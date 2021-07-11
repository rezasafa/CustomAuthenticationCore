using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using Sepehr4Core.MyModels.Accounting;
using Sepehr4Core.MyModels.Merchs;
using Sepehr4Core.MyModels.PublicModel;
using Sepehr4Core.MyModels.Reports;

namespace Sepehr4Core.Models
{
 

    public class DocumentIndexSearchModel
    {
        public string Doc_No { get; set; }
        public string ID { get; set; }
        public string AzDoc_Date { get; set; }
        public string TaDoc_Date { get; set; }
        public string AzDoc_DateL { get; set; }
        public string TaDoc_DateL { get; set; }
        public string Doc_Desc { get; set; }
        public string Doc_DescL { get; set; }
        public string Notes { get; set; }
        public string Attach { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil1 { get; set; }
        public string Tafsil2 { get; set; }
        public string Tafsil3 { get; set; }
        public string Doc_Type { get; set; }
        public string Artickle_Descr { get; set; }
        public decimal AzDebit { get; set; }
        public decimal TaDebit { get; set; }
        public decimal AzCredit { get; set; }
        public decimal TaCredit { get; set; }
        public string Flag { get; set; }
        public string Controler { get; set; }
        public string Confirm { get; set; }
        public string Register { get; set; }

        //public void xx()
        //{
        //    Journal x = new Journal();
        //    x.Debit
        //}
    }

    public enum Op
    {
        Equals,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Contains,
        StartsWith,
        EndsWith
    }

    public class Filter
    {
        public string PropertyName { get; set; }
        public Op Operation { get; set; }
        public object Value { get; set; }
    }

    public static class ExpressionBuilder
    {
        private static MethodInfo containsMethod = typeof(string).GetMethod("Contains");
        private static MethodInfo startsWithMethod =
        typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
        private static MethodInfo endsWithMethod =
        typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });


        public static Expression<Func<T,
        bool>> GetExpression<T>(IList<Filter> filters)
        {
            if (filters.Count == 0)
                return null;

            ParameterExpression param = Expression.Parameter(typeof(T), "t");
            Expression exp = null;

            if (filters.Count == 1)
                exp = GetExpression<T>(param, filters[0]);
            else if (filters.Count == 2)
                exp = GetExpression<T>(param, filters[0], filters[1]);
            else
            {
                while (filters.Count > 0)
                {
                    var f1 = filters[0];
                    var f2 = filters[1];

                    if (exp == null)
                        exp = GetExpression<T>(param, filters[0], filters[1]);
                    else
                        exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[0], filters[1]));

                    filters.Remove(f1);
                    filters.Remove(f2);

                    if (filters.Count == 1)
                    {
                        exp = Expression.AndAlso(exp, GetExpression<T>(param, filters[0]));
                        filters.RemoveAt(0);
                    }
                }
            }

            return Expression.Lambda<Func<T, bool>>(exp, param);
        }

        private static Expression GetExpression<T>(ParameterExpression param, Filter filter)
        {
            MemberExpression member = Expression.Property(param, filter.PropertyName);
            ConstantExpression constant = Expression.Constant(filter.Value);

            switch (filter.Operation)
            {
                case Op.Equals:
                    return Expression.Equal(member, constant);

                case Op.GreaterThan:
                    return Expression.GreaterThan(member, constant);

                case Op.GreaterThanOrEqual:
                    return Expression.GreaterThanOrEqual(member, constant);

                case Op.LessThan:
                    return Expression.LessThan(member, constant);

                case Op.LessThanOrEqual:
                    return Expression.LessThanOrEqual(member, constant);

                case Op.Contains:
                    return Expression.Call(member, containsMethod, constant);

                case Op.StartsWith:
                    return Expression.Call(member, startsWithMethod, constant);

                case Op.EndsWith:
                    return Expression.Call(member, endsWithMethod, constant);
            }

            return null;
        }

        private static BinaryExpression GetExpression<T>
        (ParameterExpression param, Filter filter1, Filter filter2)
        {
            Expression bin1 = GetExpression<T>(param, filter1);
            Expression bin2 = GetExpression<T>(param, filter2);

            return Expression.AndAlso(bin1, bin2);
        }
    }

    public class DocunmentsExpressionBuilder
    {

        public static Func<Documents, bool> Build(IList<Filter> filters)
        {
            ParameterExpression param = Expression.Parameter(typeof(Documents), "t");
            Expression exp = null;

            if (filters.Count == 1)
                exp = GetExpression(param, filters[0]);
            else if (filters.Count == 2)
                exp = GetExpression(param, filters[0], filters[1]);
            else
            {
                while (filters.Count > 0)
                {
                    var f1 = filters[0];
                    var f2 = filters[1];

                    if (exp == null)
                        exp = GetExpression(param, filters[0], filters[1]);
                    else
                        exp = Expression.AndAlso(exp, GetExpression(param, filters[0], filters[1]));

                    filters.Remove(f1);
                    filters.Remove(f2);

                    if (filters.Count == 1)
                    {
                        exp = Expression.AndAlso(exp, GetExpression(param, filters[0]));
                        filters.RemoveAt(0);
                    }
                }
            }

            return Expression.Lambda<Func<Documents, bool>>(exp, param).Compile();
        }

        private static Expression GetExpression(ParameterExpression param, Filter filter)
        {
            MemberExpression member = Expression.Property(param, filter.PropertyName);
            ConstantExpression constant = Expression.Constant(filter.Value);
            return Expression.Equal(member, constant);
        }

        private static BinaryExpression GetExpression
        (ParameterExpression param, Filter filter1, Filter filter2)
        {
            Expression bin1 = GetExpression(param, filter1);
            Expression bin2 = GetExpression(param, filter2);

            return Expression.AndAlso(bin1, bin2);
        }
    }

    //public class FinYearsContext : DbContext
    //{
    //    public FinYearsContext() : base("FinYear") { }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        Database.SetInitializer<FinYearsContext>(null);
    //        base.OnModelCreating(modelBuilder);
    //    }

    //    public DbSet<Years> Years { get; set; }
    //    public DbSet<Company> Company { get; set; }
    //    public DbSet<BackupRestoreList> BackupRestoreList { get; set; }
    //}

    public class JournalAccViewModel
    {
        public List<Accounts> LAccounts { get; set; }
        public List<Tafsil> LTafsil { get; set; }
        public List<Acc_Tafsil> LAcc_Tafsil { get; set; }
        public List<Journal_Acc> LJournal_Acc { get; set; }
    }

    public class JournalTafsilViewModel
    {
        public List<Accounts> LAccounts { get; set; }
        public List<Tafsil> LTafsil { get; set; }
        public List<Acc_Tafsil> LAcc_Tafsil { get; set; }
        public List<Journal_Acc> LJournal_Acc { get; set; }
    }

    public class ReportViewModel
    {
        public List<ReportGroup> LReportGroups { get; set; }
    }

    public class ReportRepositoryViewModel
    {
        public List<ReportRepository> LReportRepositories { get; set; }
        public int GroupID { get; set; }
        public string Title { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "شرکت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Company { get; set; }

        [Display(Name = "سال مالی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Year { get; set; }
        
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }

    public class DocumentListManager
    {
        [Display(Name = "کنترل")]
        public bool Controler { get; set; }
        [Display(Name = "تایید")]
        public bool Confirm { get; set; }
        [Display(Name = "قطعی")]
        public bool Register { get; set; }
        [Display(Name = "سند")]
        public string Doc_No { get; set; }
        [Display(Name = "تاریخ")]
        public string Doc_Date { get; set; }
        [Display(Name = "عطف")]
        public int ID { get; set; }
        [Display(Name = "شرح")]
        public string Doc_Desc { get; set; }
        //[DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:0}")]
        [Display(Name = "بدهکار")]
        public decimal SUM_Debit { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}")]
        [Display(Name = "بستانکار")]
        public decimal SUM_Credit { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}")]
        [Display(Name = "مانده")]
        public decimal REM { get; set; }
        [Display(Name = "پرچم")]
        public bool Flag { get; set; }
        [Display(Name = "پیوست")]
        public string Attach { get; set; }
        [Display(Name = "آخرین حساب")]
        public string Last_Acc { get; set; }
        [Display(Name = "تفصیل 1")]
        public string Tafsil1 { get; set; }
        [Display(Name = "تفصیل 2")]
        public string Tafsil2 { get; set; }
        [Display(Name = "تفصیل 3")]
        public string Tafsil3 { get; set; }
        [Display(Name = "شرح آرتیکل")]
        public string Desc { get; set; }
        [Display(Name = "بدهکار بستانکار صفر")]
        public string DebitCredit { get; set; }
    }

    public class ImportData
    {
        public string Code_Old { get; set; }
        public string Code_New { get; set; }
        public string Error { get; set; }
    }

    public class ImportAccess
    {
        public string TableName { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
    }

    public class OrderDocsList
    {
        public int ID { get; set; }
        public string Order_No { get; set; }
        public string Order_Date { get; set; }
        public string Order_Desc { get; set; }
        public string Store_No { get; set; }
        public string Store_Name { get; set; }
        public bool Cash { get; set; }
        public bool Credit { get; set; }

    }

    #region Web API Function

    public class myApp
    {
        public string company { get; set; }
        public string year { get; set; }
    }

    public class myAppQuery
    {
        public myApp myapp { get; set; }
        public string query { get; set; }
    }

    public class myAppSearchDoc
    {
        public myApp myapp { get; set; }
        public string Doc_No { get; set; }
        public string ID { get; set; }
        public string AzDoc_Date { get; set; }
        public string TaDoc_Date { get; set; }
        public string AzDoc_DateL { get; set; }
        public string TaDoc_DateL { get; set; }
        public string Doc_Desc { get; set; }
        public string Doc_DescL { get; set; }
        public string Notes { get; set; }
        public string Attach { get; set; }
        public string Acc_No { get; set; }
        public string Acc_Name { get; set; }
        public string Tafsil1 { get; set; }
        public string TafsilName1 { get; set; }
        public string Tafsil2 { get; set; }
        public string TafsilName2 { get; set; }
        public string Tafsil3 { get; set; }
        public string TafsilName3 { get; set; }
        public string DocType { get; set; }
        public string Artickle_Descr { get; set; }
        public string AzDebit { get; set; }
        public string TaDebit { get; set; }
        public string AzCredit { get; set; }
        public string TaCredit { get; set; }
        public string Controler { get; set; }
        public string Confirm { get; set; }
        public string Register { get; set; }
        public string Flag { get; set; }
    }

    public class myAppLogin
    {
        public myApp myapp { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class myAppWhere
    {
        public myApp myapp { get; set; }
        public string Wheres { get; set; }
    }

    public class myAppAccNo
    {
        public myApp myapp { get; set; }
        public string Acc_No { get; set; }
    }

    public class myAppAccTafsil
    {
        public myApp myapp { get; set; }
        public string Acc_No { get; set; }
        public string G_No { get; set; }
        public string No_Tafsil { get; set; }
    }

    public class myAppJournal
    {
        public myApp myapp { get; set; }

        public string docno { get; set; }
        public string row { get; set; }
        public string accno { get; set; }
        public string t1 { get; set; }
        public string t2 { get; set; }
        public string t3 { get; set; }
        public string desc { get; set; }
        public string deb { get; set; }
        public string cre { get; set; }
        public string cont { get; set; }
        public string flag { get; set; }
        public string Insert { get; set; }
    }

    public class myAppSortJournal
    {
        public myApp myapp { get; set; }
        public string docno { get; set; }
        public string type { get; set; }
    }

    public class myAppDocument
    {
        public myApp myapp { get; set; }
        public string Doc_No { get; set; }
        public string Doc_Date { get; set; }
        public string Doc_Desc { get; set; }
        public string Controler { get; set; }
        public string Confirm { get; set; }
        public string Register { get; set; }
        public string Doc_type { get; set; }
        public string Notes { get; set; }
        public string Attach { get; set; }
        public string Flag { get; set; }
    }

    public class myAppTafsil
    {
        public myApp myapp { get; set; }
        public string G_No { get; set; }
        public string Old_Tafsil_No { get; set; }
        public string Tafsil_No { get; set; }
        public string Tafsil_Name { get; set; }
        public string LTafsil_Name { get; set; }
    }

    public class myAppCheckReadJournal
    {
        public myApp myapp { get; set; }
        public string docno { get; set; }
        public string row { get; set; }
    }

    public class myAppDocNo
    {
        public myApp myapp { get; set; }
        public string docno { get; set; }
    }

    public class myAppTafsilGroup
    {
        public myApp myapp { get; set; }
        public string Old_G_No { get; set; }
        public string G_No { get; set; }
        public string G_Name { get; set; }
        public string People { get; set; }
        public string Cos { get; set; }
        public string Cashes { get; set; }
        public string Banks { get; set; }
        public string CostCenters { get; set; }
        public string ProfitCenters { get; set; }
        public string Merchs { get; set; }
        public string Personal { get; set; }
        public string Visitors { get; set; }
        public string Others { get; set; }
    }

    public class myAppTafsilInfo
    {
        public myApp myapp { get; set; }
        public string Tafsil_No { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Job_Title { get; set; }
        public string Company { get; set; }
        public string Economic_Code { get; set; }
        public string National_Code { get; set; }
        public string National_ID { get; set; }
        public string Info { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public string post_Address { get; set; }
        public string post_Address2 { get; set; }
        public string LState { get; set; }
        public string LCity { get; set; }
        public string LTown { get; set; }
        public string Lpost_Address { get; set; }
        public string Postal_Code { get; set; }
        public string Postal_Code2 { get; set; }
        public string Email { get; set; }
        public string Tel_No1 { get; set; }
        public string Tel_No2 { get; set; }
        public string Tel_No3 { get; set; }
        public string Tel_No4 { get; set; }
        public string Fax_No { get; set; }
        public string Password { get; set; }
        public string Mobile_no { get; set; }
        public string MaxCredit { get; set; }
        public string Orf_Month { get; set; }
        public string Discount_Prcnt { get; set; }
        public string DealerNet { get; set; }
        public string Sales_Price_No { get; set; }
        public string Visitor { get; set; }
        public string Visitor_Prcnt { get; set; }
        public string Transporter { get; set; }
        public string Freight_Charge { get; set; }
        public string County { get; set; }
        public string Tehran { get; set; }
        public string Bazar { get; set; }
        public string Shoosh { get; set; }
        public string Active { get; set; }
        public string Acc_Currency { get; set; }
        public string Currency_Type { get; set; }
        public string Followup { get; set; }
        public string Rem_Debit { get; set; }
        public string Rem_Credit { get; set; }
        public string Rem_Debit_All { get; set; }
        public string Rem_Credit_All { get; set; }
        public string RemAcc { get; set; }
        public string NotMatureRecvDocs { get; set; }
        public string ReturnedRecvDocs { get; set; }
        public string TotalSales { get; set; }
        public string RemCredit { get; set; }
        public string BankCard_No { get; set; }
        public string Sheba_No{get;set;}
        public string Purchase_Sys { get; set; }
        public string Sales_Sys { get; set; }
    }

    public class myAppAccountUpdate
    {
        public myApp myapp { get; set; }
        public string old_AccNo { get; set; }
        public string Acc_No { get; set; }
        public string Acc_Name { get; set; }
        public string LAcc_Name { get; set; }
        public string Cash { get; set; }
        public string POS { get; set; }
        public string Sales { get; set; }
        public string ReturnSales { get; set; }
        public string Purchase { get; set; }
        public string ReturnPurchase { get; set; }
        public string Revenue { get; set; }
        public string Expense { get; set; }
        public string Bank { get; set; }
        public string InBank { get; set; }
        public string Other_Revenue { get; set; }
        public string Other_Expense { get; set; }
        public string Sales_Discount { get; set; }
        public string Purchase_Discount { get; set; }
        public string Purchase_Variance { get; set; }
        public string Consume_Variance { get; set; }
        public string Customer { get; set; }
        public string Visitor { get; set; }
        public string Receivable_Acc { get; set; }
        public string Receivable_Return_Acc { get; set; }
        public string Payable_Acc { get; set; }
        public string Product_Acc { get; set; }
        public string Raw_Acc { get; set; }
        public string InProgress_Acc { get; set; }
        public string Supplies_Acc { get; set; }
        public string Parts_Acc { get; set; }
        public string Tools_Acc { get; set; }
        public string Asset_Acc { get; set; }
        public string Pert_Acc { get; set; }
        public string Packing_Acc { get; set; }
        public string Deposit_Other_Acc { get; set; }
        public string Open_Acc { get; set; }
        public string Close_Acc { get; set; }
        public string Loss_Profit { get; set; }
        public string Cost_Basis { get; set; }
        public string Cost_BasisP { get; set; }
        public string CostsProduct { get; set; }
        public string Tolls { get; set; }
        public string Tolls_Cost { get; set; }
        public string VAT { get; set; }
        public string VATP { get; set; }
        public string Profit_Ghesti { get; set; }
        public string Last_Acc { get; set; }
        public string Rem_Debit { get; set; }
        public string Rem_Credit { get; set; }
        public string Rem_Debit_All { get; set; }
        public string Rem_Credit_All { get; set; }
        public string Balance { get; set; }
        public string LoseProfit { get; set; }
        public string Other { get; set; }
        public string Active { get; set; }
        public string Acc_Store { get; set; }
        public string Acc_Sales { get; set; }
        public string Acc_PayRecv { get; set; }
        public string Acc_PayRoll { get; set; }
        public string Acc_Currency { get; set; }
        public string Followup { get; set; }
        public string Currency_Type { get; set; }
        public string Notes { get; set; }
    }

    public class myAppAccountInsert
    {
        public myApp myapp { get; set; }
        public string Acc_No { get; set; }
        public string Acc_Name { get; set; }
        public string LAcc_Name { get; set; }
        public string Notes { get; set; }
        public string CurrentLevel { get; set; }
    }

    public class myAppAccount
    {
        public myApp myapp { get; set; }
        public string Acc_No { get; set; }
        public string Level { get; set; }
        public string CurrentLevel { get; set; }
    }

    public class myAppJournalAccTafsil
    {
        public myApp myapp { get; set; }
        public string Conditions { get; set; }
        public string Acc_No { get; set; }
        public string CTRL { get; set; }
        public string LenAcc_No { get; set; }
        public string Tafsil_No { get; set; }
    }

    public class myAppGNO
    {
        public myApp myapp { get; set; }
        public string G_NO { get; set; }
    }

    public class myAppTafsilNo
    {
        public myApp myapp { get; set; }
        public string Tafsil_No { get; set; }
    }

    public class myAppTafsilNoDelTurnOver
    {
        public myApp myapp { get; set; }
        public string Tafsil_No { get; set; }
        public string Open_Close_Doc { get; set; }
    }

    public class myAppTafsilNoAccLen
    {
        public myApp myapp { get; set; }
        public string Tafsil_No { get; set; }
        public string Acc_Len { get; set; }
    }

    public class myAppTafsilNoChangeCode
    {
        public myApp myapp { get; set; }
        public string Old_Tafsil_No { get; set; }
        public string New_Tafsil_No { get; set; }
        public string G_No { get; set; }
        public string rplc { get; set; }
    }

    public class myAppDescription
    {
        public myApp myapp { get; set; }
        public string Row { get; set; }
        public string Descr { get; set; }
    }

    public class myAppReport
    {
        public myApp myapp { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }
    }

    public class myAppDocumentsManager
    {
        public myApp myapp { get; set; }
        public string Wheres { get; set; }
        public string Cols { get; set; }
    }

    public class myAppCostDescr
    {
        public myApp myapp { get; set; }
        public string Row { get; set; }
        public string Descr { get; set; }
    }

    public class myAppLevelAcc
    {
        public myApp myapp { get; set; }
        public string Level { get; set; }
        public string Acc_No { get; set; }
    }

    public class myAppDocumentDaily
    {
        public myApp myapp { get; set; }
        public string DocType { get; set; }
        public string Tafsil { get; set; }
        public string DebitCredit { get; set; }
    }

    public class myAppCompareAcc
    {
        public myApp myapp { get; set; }
        public string accno { get; set; }
        public string type { get; set; }
    }

    public class myAppID
    {
        public myApp myapp { get; set; }
        public string ID { get; set; }
    }

    public class myAppPeopleInsertUpdate
    {
        public myApp myapp { get; set; }

        public string ID { get; set; }
        public string Acc_No { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Job_Title { get; set; }
        public string Company { get; set; }
        public string Info { get; set; }
        public string Economic_Code { get; set; }
        public string National_Code { get; set; }
        public string National_ID { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public string post_Address1 { get; set; }
        public string post_Address2 { get; set; }
        public string Postal_Code { get; set; }
        public string Email { get; set; }
        public string Tel_No1 { get; set; }
        public string Tel_No2 { get; set; }
        public string Tel_No3 { get; set; }
        public string Tel_No4 { get; set; }
        public string Fax_No { get; set; }
        public string Mobile_no { get; set; }
        public string MaxCredit { get; set; }
        public string Discount_Prcnt { get; set; }
        public string DealerNet { get; set; }
        public string Sales_Price_No { get; set; }
        public string Transporter { get; set; }
        public string Freight_Charge { get; set; }
        public string County { get; set; }
        public string Tehran { get; set; }
        public string Bazar { get; set; }
        public string Active { get; set; }

    }
    
    public class myAppDocSample
    {
        public myApp myapp { get; set; }

        public string Doc_No { get; set; }
        public string Name { get; set; }
    }
    
    public class myAppCurrency
    {
        public myApp myapp { get; set; }
        public string Currency_Type { get; set; }
        public string Currency_Symbol { get; set; }
        public string Currency_Rate { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Currency_Code_Tax { get; set; }
        public string Where { get; set; }
    }

    public class myAppPlate
    {
        public myApp myapp { get; set; }
        public string Plate_No { get; set; }
        public string Plate_Name { get; set; }
        public string Where { get; set; }
    }

    public class myAppStoreType
    {
        public myApp myapp { get; set; }
        public string SDoc_Type { get; set; }
        public string SDoc_Type_Name { get; set; }
        public string Where { get; set; }
    }

    public class myAppStoresSub
    {      
        public myApp myapp { get; set; }
        public string StoreSub_No { get; set; }
        
        public string StoreSub_Name { get; set; }
        
        public string Where { get; set; }
    }

    public class myAppStores
    {
        public myApp myapp { get; set; }

        public string Store_No { get; set; }
        public string Store_Name { get; set; }
        public string Store_Type1 { get; set; }
        public string Store_Type2 { get; set; }
        public string Store_Type3 { get; set; }
        public string Store_Type4 { get; set; }
        public string Store_Type5 { get; set; }
        public string BOM { get; set; }
        public string ShowIt { get; set; }
        public string CostBasis_Method { get; set; }
        public string InvControl { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil_No1 { get; set; }
        public string Tafsil_No2 { get; set; }
        public string Tafsil_No3 { get; set; }
        public string Acc_No_Sales { get; set; }
        public string Tafsil_No1_Sales { get; set; }
        public string Tafsil_No2_Sales { get; set; }
        public string Tafsil_No3_Sales { get; set; }
        public string Acc_No_CB { get; set; }
        public string Tafsil_No1_CB { get; set; }
        public string Tafsil_No2_CB { get; set; }
        public string Tafsil_No3_CB { get; set; }

        public string Where { get; set; }
    }

    public class myAppInitMerch
    {
        public myApp myapp { get; set; }
        public string Merch_levels { get; set; }
        public string Merch_level1_Len { get; set; }
        public string Merch_level2_Len { get; set; }
        public string Merch_level3_Len { get; set; }
        public string Merch_level4_Len { get; set; }
        public string Merch_level5_Len { get; set; }
        public string Merch_level6_Len { get; set; }
        public string Merch_level7_Len { get; set; }
        public string Merch_level8_Len { get; set; }
        public string Merch_level9_Len { get; set; }
        public string Merch_level1_Name { get; set; }
        public string Merch_level2_Name { get; set; }
        public string Merch_level3_Name { get; set; }
        public string Merch_level4_Name { get; set; }
        public string Merch_level5_Name { get; set; }
        public string Merch_level6_Name { get; set; }
        public string Merch_level7_Name { get; set; }
        public string Merch_level8_Name { get; set; }
        public string Merch_level9_Name { get; set; }
        public string GMerch_level1_Len { get; set; }
        public string GMerch_level2_Len { get; set; }
        public string GMerch_level3_Len { get; set; }
        public string GMerch_level4_Len { get; set; }
        public string GMerch_level5_Len { get; set; }
        public string GMerch_level6_Len { get; set; }
        public string GMerch_level7_Len { get; set; }
        public string GMerch_level8_Len { get; set; }
        public string GMerch_level9_Len { get; set; }
        public string MG_levels { get; set; }
        public string MG_level1_Len { get; set; }
        public string MG_level2_Len { get; set; }
        public string MG_level3_Len { get; set; }
        public string MG_level4_Len { get; set; }
        public string MG_level5_Len { get; set; }
        public string MG_level6_Len { get; set; }
        public string MG_level7_Len { get; set; }
        public string MG_level8_Len { get; set; }
        public string MG_level9_Len { get; set; }
        public string MG_level1_Name { get; set; }
        public string MG_level2_Name { get; set; }
        public string MG_level3_Name { get; set; }
        public string MG_level4_Name { get; set; }
        public string MG_level5_Name { get; set; }
        public string MG_level6_Name { get; set; }
        public string MG_level7_Name { get; set; }
        public string MG_level8_Name { get; set; }
        public string MG_level9_Name { get; set; }
        public string FastMoving { get; set; }
        public string NormalMoving { get; set; }
        public string SlowMoving { get; set; }
        public string Master_LeadTime { get; set; }

    }

    public class myAppMerch
    {
        public myApp myapp { get; set; }
        public string Merch_Code { get; set; }
        public string Merch_Name { get; set; }
        public string LMerch_Name { get; set; }
        public string Level { get; set; }
        public string CurrentLevel { get; set; }
    }

    public class myAppMerchGroup
    {
        public myApp myapp { get; set; }
        public string MG_No { get; set; }
        public string MG_Name { get; set; }
        public string Last_MG { get; set; }
        public string Wheres { get; set; }
    }

    public class myAppMerchGroup_No
    {
        public myApp myapp { get; set; }
        public string MG_No { get; set; }
        public string Level { get; set; }
        public string CurrentLevel { get; set; }
    }

    public class myAppMerchsSalesPriceName
    {
        public myApp myapp { get; set; }
        public string Sales_Price1 { get; set; }
        public string Sales_Price2 { get; set; }
        public string Sales_Price3 { get; set; }
        public string Sales_Price4 { get; set; }
        public string Sales_Price5 { get; set; }
        public string Sales_Price6 { get; set; }
        public string Sales_Price7 { get; set; }
        public string Sales_Price8 { get; set; }
        public string Sales_Price9 { get; set; }
        public string Sales_Price10 { get; set; }
        public string Sales_Price11 { get; set; }
        public string Sales_Price12 { get; set; }
        public string Sales_Price13 { get; set; }
        public string Sales_Price14 { get; set; }
        public string Sales_Price15 { get; set; }
        public int ID { get; set; }
    }

    public class myAppMerch_Update
    {
        public myApp myapp { get; set; }
        public string Merch_Code { get; set; }
        public string Merch_Name { get; set; }
        public string LMerch_Name { get; set; }
        public string Technical_No { get; set; }
        public string Supplier_No { get; set; }
        public string Merch_Type1 { get; set; }
        public string Merch_Type2 { get; set; }
        public string Merch_Type3 { get; set; }
        public string Merch_Type4 { get; set; }
        public string Merch_Type5 { get; set; }
        public string Merch_Type6 { get; set; }
        public string Merch_Type7 { get; set; }
        public string Merch_Type8 { get; set; }
        public string Merch_Type9 { get; set; }
        public string Merch_Type10 { get; set; }
        public string Merch_Sarmayeh { get; set; }
        public string Merch_Masrafi { get; set; }
        public string Merch_Expirable { get; set; }
        public string MinorUnit { get; set; }
        public string MajorUnit { get; set; }
        public string Major_Minor_Rate { get; set; }
        public string Major_Minor_Related { get; set; }
        public string Weight { get; set; }
        public string Packing { get; set; }
        public string LeadTime { get; set; }
        public string Min_Qty { get; set; }
        public string Max_Qty { get; set; }
        public string Normal_Qty { get; set; }
        public string Safety_Stock { get; set; }
        public string Sales_Price { get; set; }
        public string Sales_Price_DealerNet { get; set; }
        public string Purchase_Price { get; set; }
        public string Location { get; set; }
        public string CostBasis { get; set; }
        public string Calc_Discount_Purchase { get; set; }
        public string Calc_Discount_Sales { get; set; }
        public string Calc_Discount_Person { get; set; }
        public string Discount_Purchase { get; set; }
        public string Discount_Sales { get; set; }
        public string Discount_Sales_DealerNet { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil_No1 { get; set; }
        public string Merch_Descr { get; set; }
        public string FastMoving { get; set; }
        public string NormalMoving { get; set; }
        public string SlowMoving { get; set; }
        public string NoMoving { get; set; }
        public string Barcode_No { get; set; }
        public string Active { get; set; }
        public string Last_Merch { get; set; }
        public string Where { get; set; }
    }

    public class myAppMerchInsert
    {
        public myApp myapp { get; set; }
        public string Order_No { get; set; }
        public string Order_Date { get; set; }
        public string Order_Desc { get; set; }
        public string PreFactor_No { get; set; }
        public string Center_No { get; set; }
        public string Sales_Person_No { get; set; }
        public string Expire_Date { get; set; }
        public string Customer_Name { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil_No1 { get; set; }
        public string Tafsil_No2 { get; set; }
        public string Tafsil_No3 { get; set; }
        public string Cash { get; set; }
        public string Credit { get; set; }
        public string County { get; set; }
        public string SalesMan { get; set; }
        public string Store_Keeper_Register { get; set; }
        public string Register { get; set; }
        public string Settle { get; set; }
        public string Order_Cancel { get; set; }
    }

    public class myAppSalesPerson
    {
        public myApp myapp { get; set; }
        public string Sales_Person_No { get; set; }
        public string Sales_Person_Name { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil_No1 { get; set; }
        public string Tafsil_No2 { get; set; }
        public string Tafsil_No3 { get; set; }
        public string Visitor_Prcnt { get; set; }
        public string ID { get; set; }
        public string Region { get; set; }
        public string Freight_Charge { get; set; }
        public string Wheres { get; set; }
    }

    public class myAppSalesCenter
    {
        public myApp myapp { get; set; }
        public string Center_No { get; set; }
        public string Center_Name { get; set; }
        public string Acc_No_Purchase { get; set; }
        public string Tafsil_No1_Purchase { get; set; }
        public string Tafsil_No2_Purchase { get; set; }
        public string Tafsil_No3_Purchase { get; set; }
        public string Tafsil_No1_Purchase_Customer { get; set; }
        public string Tafsil_No2_Purchase_Customer { get; set; }
        public string Tafsil_No3_Purchase_Customer { get; set; }
        public string Tafsil_No1_Purchase_Store { get; set; }
        public string Tafsil_No2_Purchase_Store { get; set; }
        public string Tafsil_No3_Purchase_Store { get; set; }
        public string Tafsil_No1_Purchase_Merchs { get; set; }
        public string Tafsil_No2_Purchase_Merchs { get; set; }
        public string Tafsil_No3_Purchase_Merchs { get; set; }
        public string Acc_No_Sales { get; set; }
        public string Tafsil_No1_Sales { get; set; }
        public string Tafsil_No2_Sales { get; set; }
        public string Tafsil_No3_Sales { get; set; }
        public string Tafsil_No1_Sales_Customer { get; set; }
        public string Tafsil_No2_Sales_Customer { get; set; }
        public string Tafsil_No3_Sales_Customer { get; set; }
        public string Tafsil_No1_Sales_Store { get; set; }
        public string Tafsil_No2_Sales_Store { get; set; }
        public string Tafsil_No3_Sales_Store { get; set; }
        public string Tafsil_No1_Sales_Merchs { get; set; }
        public string Tafsil_No2_Sales_Merchs { get; set; }
        public string Tafsil_No3_Sales_Merchs { get; set; }
        public string Acc_No_RPurchase { get; set; }
        public string Tafsil_No1_RPurchase { get; set; }
        public string Tafsil_No2_RPurchase { get; set; }
        public string Tafsil_No3_RPurchase { get; set; }
        public string Tafsil_No1_RPurchase_Customer { get; set; }
        public string Tafsil_No2_RPurchase_Customer { get; set; }
        public string Tafsil_No3_RPurchase_Customer { get; set; }
        public string Tafsil_No1_RPurchase_Store { get; set; }
        public string Tafsil_No2_RPurchase_Store { get; set; }
        public string Tafsil_No3_RPurchase_Store { get; set; }
        public string Tafsil_No1_RPurchase_Merchs { get; set; }
        public string Tafsil_No2_RPurchase_Merchs { get; set; }
        public string Tafsil_No3_RPurchase_Merchs { get; set; }
        public string Acc_No_RSales { get; set; }
        public string Tafsil_No1_RSales { get; set; }
        public string Tafsil_No2_RSales { get; set; }
        public string Tafsil_No3_RSales { get; set; }
        public string Tafsil_No1_RSales_Customer { get; set; }
        public string Tafsil_No2_RSales_Customer { get; set; }
        public string Tafsil_No3_RSales_Customer { get; set; }
        public string Tafsil_No1_RSales_Store { get; set; }
        public string Tafsil_No2_RSales_Store { get; set; }
        public string Tafsil_No3_RSales_Store { get; set; }
        public string Tafsil_No1_RSales_Merchs { get; set; }
        public string Tafsil_No2_RSales_Merchs { get; set; }
        public string Tafsil_No3_RSales_Merchs { get; set; }
        public string Acc_No_PDiscount { get; set; }
        public string Tafsil_No1_PDiscount { get; set; }
        public string Tafsil_No2_PDiscount { get; set; }
        public string Tafsil_No3_PDiscount { get; set; }
        public string Tafsil_No1_PDiscount_Customer { get; set; }
        public string Tafsil_No2_PDiscount_Customer { get; set; }
        public string Tafsil_No3_PDiscount_Customer { get; set; }
        public string Tafsil_No1_PDiscount_Store { get; set; }
        public string Tafsil_No2_PDiscount_Store { get; set; }
        public string Tafsil_No3_PDiscount_Store { get; set; }
        public string Tafsil_No1_PDiscount_Merchs { get; set; }
        public string Tafsil_No2_PDiscount_Merchs { get; set; }
        public string Tafsil_No3_PDiscount_Merchs { get; set; }
        public string Acc_No_SDiscount { get; set; }
        public string Tafsil_No1_SDiscount { get; set; }
        public string Tafsil_No2_SDiscount { get; set; }
        public string Tafsil_No3_SDiscount { get; set; }
        public string Tafsil_No1_SDiscount_Customer { get; set; }
        public string Tafsil_No2_SDiscount_Customer { get; set; }
        public string Tafsil_No3_SDiscount_Customer { get; set; }
        public string Tafsil_No1_SDiscount_Store { get; set; }
        public string Tafsil_No2_SDiscount_Store { get; set; }
        public string Tafsil_No3_SDiscount_Store { get; set; }
        public string Tafsil_No1_SDiscount_Merchs { get; set; }
        public string Tafsil_No2_SDiscount_Merchs { get; set; }
        public string Tafsil_No3_SDiscount_Merchs { get; set; }
        public string Acc_No_OtherCosts { get; set; }
        public string Tafsil_No1_OtherCosts { get; set; }
        public string Tafsil_No2_OtherCosts { get; set; }
        public string Tafsil_No3_OtherCosts { get; set; }
        public string Tafsil_No1_OtherCosts_Customer { get; set; }
        public string Tafsil_No2_OtherCosts_Customer { get; set; }
        public string Tafsil_No3_OtherCosts_Customer { get; set; }
        public string Tafsil_No1_OtherCosts_Store { get; set; }
        public string Tafsil_No2_OtherCosts_Store { get; set; }
        public string Tafsil_No3_OtherCosts_Store { get; set; }
        public string Tafsil_No1_OtherCosts_Merchs { get; set; }
        public string Tafsil_No2_OtherCosts_Merchs { get; set; }
        public string Tafsil_No3_OtherCosts_Merchs { get; set; }
        public string Acc_No_OtherIncome { get; set; }
        public string Tafsil_No1_OtherIncome { get; set; }
        public string Tafsil_No2_OtherIncome { get; set; }
        public string Tafsil_No3_OtherIncome { get; set; }
        public string Tafsil_No1_OtherIncome_Customer { get; set; }
        public string Tafsil_No2_OtherIncome_Customer { get; set; }
        public string Tafsil_No3_OtherIncome_Customer { get; set; }
        public string Tafsil_No1_OtherIncome_Store { get; set; }
        public string Tafsil_No2_OtherIncome_Store { get; set; }
        public string Tafsil_No3_OtherIncome_Store { get; set; }
        public string Tafsil_No1_OtherIncome_Merchs { get; set; }
        public string Tafsil_No2_OtherIncome_Merchs { get; set; }
        public string Tafsil_No3_OtherIncome_Merchs { get; set; }
        public string Acc_No_Toll { get; set; }
        public string Tafsil_No1_Toll { get; set; }
        public string Tafsil_No2_Toll { get; set; }
        public string Tafsil_No3_Toll { get; set; }
        public string Tafsil_No1_Toll_Customer { get; set; }
        public string Tafsil_No2_Toll_Customer { get; set; }
        public string Tafsil_No3_Toll_Customer { get; set; }
        public string Tafsil_No1_Toll_Store { get; set; }
        public string Tafsil_No2_Toll_Store { get; set; }
        public string Tafsil_No3_Toll_Store { get; set; }
        public string Tafsil_No1_Toll_Merchs { get; set; }
        public string Tafsil_No2_Toll_Merchs { get; set; }
        public string Tafsil_No3_Toll_Merchs { get; set; }
        public string Acc_No_VAT { get; set; }
        public string Tafsil_No1_VAT { get; set; }
        public string Tafsil_No2_VAT { get; set; }
        public string Tafsil_No3_VAT { get; set; }
        public string Tafsil_No1_VAT_Customer { get; set; }
        public string Tafsil_No2_VAT_Customer { get; set; }
        public string Tafsil_No3_VAT_Customer { get; set; }
        public string Tafsil_No1_VAT_Store { get; set; }
        public string Tafsil_No2_VAT_Store { get; set; }
        public string Tafsil_No3_VAT_Store { get; set; }
        public string Tafsil_No1_VAT_Merchs { get; set; }
        public string Tafsil_No2_VAT_Merchs { get; set; }
        public string Tafsil_No3_VAT_Merchs { get; set; }
        public string Acc_No_VATP { get; set; }
        public string Tafsil_No1_VATP { get; set; }
        public string Tafsil_No2_VATP { get; set; }
        public string Tafsil_No3_VATP { get; set; }
        public string Tafsil_No1_VATP_Customer { get; set; }
        public string Tafsil_No2_VATP_Customer { get; set; }
        public string Tafsil_No3_VATP_Customer { get; set; }
        public string Tafsil_No1_VATP_Store { get; set; }
        public string Tafsil_No2_VATP_Store { get; set; }
        public string Tafsil_No3_VATP_Store { get; set; }
        public string Tafsil_No1_VATP_Merchs { get; set; }
        public string Tafsil_No2_VATP_Merchs { get; set; }
        public string Tafsil_No3_VATP_Merchs { get; set; }
        public string Acc_No_CB { get; set; }
        public string Tafsil_No1_CB { get; set; }
        public string Tafsil_No2_CB { get; set; }
        public string Tafsil_No3_CB { get; set; }
        public string Tafsil_No1_CostBasis_Customer { get; set; }
        public string Tafsil_No2_CostBasis_Customer { get; set; }
        public string Tafsil_No3_CostBasis_Customer { get; set; }
        public string Tafsil_No1_CostBasis_Store { get; set; }
        public string Tafsil_No2_CostBasis_Store { get; set; }
        public string Tafsil_No3_CostBasis_Store { get; set; }
        public string Tafsil_No1_CostBasis_Merchs { get; set; }
        public string Tafsil_No2_CostBasis_Merchs { get; set; }
        public string Tafsil_No3_CostBasis_Merchs { get; set; }
        public string Acc_No_Com { get; set; }
        public string Tafsil_No1_Com { get; set; }
        public string Tafsil_No2_Com { get; set; }
        public string Tafsil_No3_Com { get; set; }
        public string Tafsil_No1_Com_Customer { get; set; }
        public string Tafsil_No2_Com_Customer { get; set; }
        public string Tafsil_No3_Com_Customer { get; set; }
        public string Tafsil_No1_Com_Store { get; set; }
        public string Tafsil_No2_Com_Store { get; set; }
        public string Tafsil_No3_Com_Store { get; set; }
        public string Tafsil_No1_Com_Merchs { get; set; }
        public string Tafsil_No2_Com_Merchs { get; set; }
        public string Tafsil_No3_Com_Merchs { get; set; }
        public string Acc_No_OrfCom { get; set; }
        public string Tafsil_No1_OrfCom { get; set; }
        public string Tafsil_No2_OrfCom { get; set; }
        public string Tafsil_No3_OrfCom { get; set; }
        public string Tafsil_No1_OrfCom_Customer { get; set; }
        public string Tafsil_No2_OrfCom_Customer { get; set; }
        public string Tafsil_No3_OrfCom_Customer { get; set; }
        public string Tafsil_No1_OrfCom_Store { get; set; }
        public string Tafsil_No2_OrfCom_Store { get; set; }
        public string Tafsil_No3_OrfCom_Store { get; set; }
        public string Tafsil_No1_OrfCom_Merchs { get; set; }
        public string Tafsil_No2_OrfCom_Merchs { get; set; }
        public string Tafsil_No3_OrfCom_Merchs { get; set; }
        public string Acc_No_Ins { get; set; }
        public string Tafsil_No1_Ins { get; set; }
        public string Tafsil_No2_Ins { get; set; }
        public string Tafsil_No3_Ins { get; set; }
        public string Tafsil_No1_Ins_Customer { get; set; }
        public string Tafsil_No2_Ins_Customer { get; set; }
        public string Tafsil_No3_Ins_Customer { get; set; }
        public string Tafsil_No1_Ins_Store { get; set; }
        public string Tafsil_No2_Ins_Store { get; set; }
        public string Tafsil_No3_Ins_Store { get; set; }
        public string Tafsil_No1_Ins_Merchs { get; set; }
        public string Tafsil_No2_Ins_Merchs { get; set; }
        public string Tafsil_No3_Ins_Merchs { get; set; }
        public string Acc_No_GoodWork { get; set; }
        public string Tafsil_No1_GoodWork { get; set; }
        public string Tafsil_No2_GoodWork { get; set; }
        public string Tafsil_No3_GoodWork { get; set; }
        public string Tafsil_No1_GoodWork_Customer { get; set; }
        public string Tafsil_No2_GoodWork_Customer { get; set; }
        public string Tafsil_No3_GoodWork_Customer { get; set; }
        public string Tafsil_No1_GoodWork_Store { get; set; }
        public string Tafsil_No2_GoodWork_Store { get; set; }
        public string Tafsil_No3_GoodWork_Store { get; set; }
        public string Tafsil_No1_GoodWork_Merchs { get; set; }
        public string Tafsil_No2_GoodWork_Merchs { get; set; }
        public string Tafsil_No3_GoodWork_Merchs { get; set; }
        public string Acc_No_TaxTaklifi { get; set; }
        public string Tafsil_No1_TaxTaklifi { get; set; }
        public string Tafsil_No2_TaxTaklifi { get; set; }
        public string Tafsil_No3_TaxTaklifi { get; set; }
        public string Tafsil_No1_TaxTaklifi_Customer { get; set; }
        public string Tafsil_No2_TaxTaklifi_Customer { get; set; }
        public string Tafsil_No3_TaxTaklifi_Customer { get; set; }
        public string Tafsil_No1_TaxTaklifi_Store { get; set; }
        public string Tafsil_No2_TaxTaklifi_Store { get; set; }
        public string Tafsil_No3_TaxTaklifi_Store { get; set; }
        public string Tafsil_No1_TaxTaklifi_Merchs { get; set; }
        public string Tafsil_No2_TaxTaklifi_Merchs { get; set; }
        public string Tafsil_No3_TaxTaklifi_Merchs { get; set; }
        public string Acc_No_PishPardakht { get; set; }
        public string Tafsil_No1_PishPardakht { get; set; }
        public string Tafsil_No2_PishPardakht { get; set; }
        public string Tafsil_No3_PishPardakht { get; set; }
        public string Tafsil_No1_PishPardakht_Customer { get; set; }
        public string Tafsil_No2_PishPardakht_Customer { get; set; }
        public string Tafsil_No3_PishPardakht_Customer { get; set; }
        public string Tafsil_No1_PishPardakht_Store { get; set; }
        public string Tafsil_No2_PishPardakht_Store { get; set; }
        public string Tafsil_No3_PishPardakht_Store { get; set; }
        public string Tafsil_No1_PishPardakht_Merchs { get; set; }
        public string Tafsil_No2_PishPardakht_Merchs { get; set; }
        public string Tafsil_No3_PishPardakht_Merchs { get; set; }
        public string Acc_No_VATO { get; set; }
        public string Tafsil_No1_VATO { get; set; }
        public string Tafsil_No2_VATO { get; set; }
        public string Tafsil_No3_VATO { get; set; }
        public string Tafsil_No1_VATO_Customer { get; set; }
        public string Tafsil_No2_VATO_Customer { get; set; }
        public string Tafsil_No3_VATO_Customer { get; set; }
        public string Tafsil_No1_VATO_Store { get; set; }
        public string Tafsil_No2_VATO_Store { get; set; }
        public string Tafsil_No3_VATO_Store { get; set; }
        public string Tafsil_No1_VATO_Merchs { get; set; }
        public string Tafsil_No2_VATO_Merchs { get; set; }
        public string Tafsil_No3_VATO_Merchs { get; set; }
        public string ID { get; set; }
        public string Where { get; set; }
    }

    public class myAppOrderNo
    {
        public myApp myapp { get; set; }
        public string Order_No { get; set; }
    }

    public class myAppSortOrderDetails
    {
        public myApp myapp { get; set; }
        public string OrderNo { get; set; }
        public string type { get; set; }
    }

    public class myAppOrdersDoc
    {
        public myApp myapp { get; set; }
        public string Order_No { get; set; }
        public string Order_Date { get; set; }
        public string Order_Desc { get; set; }
        public string PreFactor_No { get; set; }
        public string Center_No { get; set; }
        public string Sales_Person_No { get; set; }
        public string Expire_Date { get; set; }
        public string Order_Condition { get; set; }
        public string Order_Dlv_Date { get; set; }
        public string Order_Dlv_Place { get; set; }
        public string Order_Expire { get; set; }
        public string Copper_Base { get; set; }
        public string Packing { get; set; }
        public string BankAccounts { get; set; }
        public string Followup_Person { get; set; }
        public string Customer_Name { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil_No1 { get; set; }
        public string Tafsil_No2 { get; set; }
        public string Tafsil_No3 { get; set; }
        public string Factor_No { get; set; }
        public string SDoc_No { get; set; }
        public string SDoc_NoP { get; set; }
        public string Store_No { get; set; }
        public string Discount_Prcnt { get; set; }
        public string Discount { get; set; }
        public string Extra_Charge { get; set; }
        public string Extra_Costs { get; set; }
        public string Toll { get; set; }
        public string VAT { get; set; }
        public string Notes { get; set; }
        public string Package_Qty { get; set; }
        public string Cash { get; set; }
        public string Credit { get; set; }
        public string Cash_Value { get; set; }
        public string County { get; set; }
        public string SalesMan { get; set; }
        public string Store_Keeper_Register { get; set; }
        public string Register { get; set; }
        public string Settle { get; set; }
        public string Settle_Date { get; set; }
        public string timeCreate { get; set; }
        public string timeUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public string Order_Cancel { get; set; }
        public string ID { get; set; }
        // public virtual List<Orders_Details>Orders_Details { get; set; }
    }

    public class myAppOrdersDetails
    {
        public myApp myapp { get; set; }
        public string Row { get; set; }
        public string Order_No { get; set; }
        public string Merch_Code { get; set; }
        public string Descr { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public string MQty { get; set; }
        public string Qty_Inv { get; set; }
        public string MQty_Inv { get; set; }
        public string Total { get; set; }
        public string Discount { get; set; }
        public string Discount_Price { get; set; }
        public string ID { get; set; }
        public string Where { get; set; }
        public string Insert { get; set; }
    }


    #endregion
}