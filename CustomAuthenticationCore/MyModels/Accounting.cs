using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepehr4Core.MyModels.Accounting
{
    public class Accounts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Required(ErrorMessage = "شماره حساب الزامی است")]
        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }

        [Required(ErrorMessage = "نام حساب الزامی است")]
        [Display(Name = "نام حساب")]
        public string Acc_Name { get; set; }

        [Display(Name = "نام لاتین حساب")]
        public string LAcc_Name { get; set; }

        [Display(Name = "حساب نقدی")]
        public bool Cash { get; set; }

        [Display(Name = "حساب پايانه فروش")]
        public bool POS { get; set; }

        [Display(Name = "حساب فروش")]
        public bool Sales { get; set; }

        [Display(Name = "حساب برگشت از فروش")]
        public bool ReturnSales { get; set; }

        [Display(Name = "حساب خرید")]
        public bool Purchase { get; set; }

        [Display(Name = "حساب برگشت از خرید")]
        public bool ReturnPurchase { get; set; }

        [Display(Name = "حساب درآمد")]
        public bool Revenue { get; set; }

        [Display(Name = "حساب هزینه")]
        public bool Expense { get; set; }

        [Display(Name = "حساب بانک")]
        public bool Bank { get; set; }

        [Display(Name = "حساب اسناد بانک")]
        public bool InBank { get; set; }

        [Display(Name = "حساب سایر درآمد")]
        public bool Other_Revenue { get; set; }

        [Display(Name = "حساب سایر هزینه")]
        public bool Other_Expense { get; set; }

        [Display(Name = "حساب تخفیف فروش")]
        public bool Sales_Discount { get; set; }

        [Display(Name = "حساب تخفیف خرید")]
        public bool Purchase_Discount { get; set; }

        [Display(Name = "انحراف بهاي خريد")]
        public bool Purchase_Variance { get; set; }

        [Display(Name = "انحراف بهاي مصرف")]
        public bool Consume_Variance { get; set; }

        [Display(Name = "حساب اشخاص تجاری")]
        public bool Customer { get; set; }

        [Display(Name = "ويزيتور")]
        public bool Visitor { get; set; }

        [Display(Name = "حساب اسناد دریافتنی")]
        public bool Receivable_Acc { get; set; }

        [Display(Name = "حساب اسناد دریافتنی برگشتي")]
        public bool Receivable_Return_Acc { get; set; }

        [Display(Name = "حساب اسناد پرداختنی")]
        public bool Payable_Acc { get; set; }

        [Display(Name = "موجودی کالا محصول")]
        public bool Product_Acc { get; set; }

        [Display(Name = "موجودی کالا مواد")]
        public bool Raw_Acc { get; set; }

        [Display(Name = "موجودی کالا درجريان ساخت")]
        public bool InProgress_Acc { get; set; }

        [Display(Name = "موجودی کالا ملزومات")]
        public bool Supplies_Acc { get; set; }

        [Display(Name = "موجودی کالا قطعات يدكي")]
        public bool Parts_Acc { get; set; }

        [Display(Name = "موجودی کالا ابزار")]
        public bool Tools_Acc { get; set; }

        [Display(Name = "موجودی کالا اموال")]
        public bool Asset_Acc { get; set; }

        [Display(Name = "موجودی ضايعات")]
        public bool Pert_Acc { get; set; }

        [Display(Name = "موجودي بسته بندي")]
        public bool Packing_Acc { get; set; }

        [Display(Name = "موجودي كالاي اماني ديگران نزد ما")]
        public bool Deposit_Other_Acc { get; set; }

        [Display(Name = "حساب افتتاحیه")]
        public bool Open_Acc { get; set; }

        [Display(Name = "حساب اختتامیه")]
        public bool Close_Acc { get; set; }

        [Display(Name = "حساب سود و زيان")]
        public bool Loss_Profit { get; set; }

        [Display(Name = "قیمت تمام شده کالای فروخته شده")]
        public bool Cost_Basis { get; set; }

        [Display(Name = "قیمت تمام شده کالای ساخته شده")]
        public bool Cost_BasisP { get; set; }

        [Display(Name = "هزينه مستقيم / سربار جذب شده")]
        public bool CostsProduct { get; set; }

        [Display(Name = "تجميع عوارض")]
        public bool Tolls { get; set; }

        [Display(Name = "هزينه تجميع عوارض")]
        public bool Tolls_Cost { get; set; }

        [Display(Name = "ماليات ارزش افزوده")]
        public bool VAT { get; set; }

        [Display(Name = "ماليات بر ارزش افزوده خريد")]
        public bool VATP { get; set; }

        [Display(Name = "سود تحقق نيافته اقساطي")]
        public bool Profit_Ghesti { get; set; }

        [Display(Name = "آخرین حساب")]
        public bool Last_Acc { get; set; }

        [Display(Name = "مانده بدهکار")]
        public bool Rem_Debit { get; set; }

        [Display(Name = "مانده بستانکار")]
        public bool Rem_Credit { get; set; }

        [Display(Name = "مانده همواره بدهکار")]
        public bool Rem_Debit_All { get; set; }

        [Display(Name = "مانده همواره بستانکار")]
        public bool Rem_Credit_All { get; set; }

        [Display(Name = "ترازنامه اي")]
        public bool Balance { get; set; }

        [Display(Name = "سود و زياني")]
        public bool LoseProfit { get; set; }

        [Display(Name = "انتظامي")]
        public bool Other { get; set; }

        [Display(Name = "پيگيري")]
        public string Followup { get; set; }

        [Display(Name = "فعال")]
        public bool Active { get; set; }

        [Display(Name = "حساب انبار")]
        public bool Acc_Store { get; set; }

        [Display(Name = "حساب فروش")]
        public bool Acc_Sales { get; set; }

        [Display(Name = "حساب خزانه")]
        public bool Acc_PayRecv { get; set; }

        [Display(Name = "حساب حقوق و دستمزد")]
        public bool Acc_PayRoll { get; set; }

        [Display(Name = "حساب ارزي")]
        public bool Acc_Currency { get; set; }

        [Display(Name = "نوع ارز")]
        public string Currency_Type { get; set; }

        [Display(Name = "شرح حساب")]
        public string Notes { get; set; }

        public virtual List<Acc_Tafsil> LAcc_Tafsil { get; set; }
        public virtual List<Journal> LJournal { get; set; }
    }

    public class Doc_Type
    {
        [Key]
        public int doc_Type { get; set; }

        [Display(Name = "نوع سند")]
        [Required(ErrorMessage = "نام نوع سند الزامی است")]
        public string Doc_Type_Name { get; set; }

        public virtual List<Documents> LDocuments { get; set; }
    }

    public class Tafsil_Group
    {
        [Display(Name = "کد گروه تفصیلی")]
        [Required(ErrorMessage = "کد گروه تفصیلی الزامی است")]
        [Key]
        public string G_No { get; set; }

        [Display(Name = "نام گروه تفصیلی")]
        [Required(ErrorMessage = "نام گروه تفصیلی الزامی است")]
        public string G_Name { get; set; }

        [Display(Name = "اشخاص")]
        public bool People { get; set; }

        [Display(Name = "شرکتها")]
        public bool Cos { get; set; }

        [Display(Name = "صندوق / تنخواه گردانها")]
        public bool Cashes { get; set; }

        [Display(Name = "بانکها")]
        public bool Banks { get; set; }

        [Display(Name = "مراكز هزينه")]
        public bool CostCenters { get; set; }

        [Display(Name = "مراكز درآمد")]
        public bool ProfitCenters { get; set; }

        [Display(Name = "كالاها")]
        public bool Merchs { get; set; }

        [Display(Name = "كاركنان")]
        public bool Personal { get; set; }

        [Display(Name = "ويزيتور")]
        public bool Visitors { get; set; }

        [Display(Name = "ساير")]
        public bool Others { get; set; }

        public virtual List<Tafsil> lTafsil { get; set; }
        //public virtual List<Merch_Tafsil> Merch_Tafsils { get; set; }
    }

    public class Tafsil
    {
        [Display(Name = "کد گروه تفصیلی")]
        public string G_No { get; set; }
        public virtual Tafsil_Group tafsil_Group { get; set; }

        [Display(Name = "کد تفصیلی")]
        [Required(ErrorMessage = "کد تفصیلی الزامی است")]
        [Key]
        public string Tafsil_No { get; set; }

        [Display(Name = "نام تفصیلی")]
        [Required(ErrorMessage = "نام تفصیلی الزامی است")]
        public string Tafsil_Name { get; set; }

        [Display(Name = "نام لاتین تفصیلی")]
        public string LTafsil_Name { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "نام")]
        public string First_Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Last_Name { get; set; }

        [Display(Name = "سمت")]
        public string Job_Title { get; set; }

        [Display(Name = "شرکت")]
        public string Company { get; set; }

        [Display(Name = "شماره اقتصادي")]
        public string Economic_Code { get; set; }

        [Display(Name = "كد ملي")]
        public string National_Code { get; set; }

        [Display(Name = "شناسه ملي")]
        public string National_ID { get; set; }

        [Display(Name = "مشخصات")]
        public string Info { get; set; }

        [Display(Name = "استان")]
        public string State { get; set; }

        [Display(Name = "شهر")]
        public string City { get; set; }

        [Display(Name = "شهر منطقه")]
        public string Town { get; set; }

        [Display(Name = "منظقه")]
        public string Region { get; set; }

        [Display(Name = "آدرس پستی 1")]
        public string post_Address { get; set; }

        [Display(Name = "آدرس پستی 2")]
        public string post_Address2 { get; set; }

        [Display(Name = "استان")]
        public string LState { get; set; }

        [Display(Name = "شهر")]
        public string LCity { get; set; }

        [Display(Name = "شهر منطقه")]
        public string LTown { get; set; }

        [Display(Name = "آدرس پستی 1")]
        public string Lpost_Address { get; set; }

        [Display(Name = "کد پستی")]
        public string Postal_Code { get; set; }

        [Display(Name = "کد پستی 2")]
        public string Postal_Code2 { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "شماره تلفن 1")]
        public string Tel_No1 { get; set; }

        [Display(Name = "شماره تلفن 2")]
        public string Tel_No2 { get; set; }

        [Display(Name = "شماره تلفن 3")]
        public string Tel_No3 { get; set; }

        [Display(Name = "شماره تلفن 4")]
        public string Tel_No4 { get; set; }

        [Display(Name = "شماره فکس")]
        public string Fax_No { get; set; }

        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [Display(Name = "شماره موبایل")]
        public string Mobile_no { get; set; }

        [Display(Name = "حداکثر اعتبار")]
        public decimal MaxCredit { get; set; }

        [Display(Name = "تعداد ماه عرف")]
        public int Orf_Month { get; set; }

        [Display(Name = "درصد تخفیف")]
        public Single Discount_Prcnt { get; set; }

        [Display(Name = "نمایندگی")]
        public bool DealerNet { get; set; }

        [Display(Name = "")]
        public int Sales_Price_No { get; set; }

        [Display(Name = "ويزيتور")]
        public bool Visitor { get; set; }

        [Display(Name = "درصد ويزيتوري")]
        public Single Visitor_Prcnt { get; set; }

        [Display(Name = "باربری")]
        public string Transporter { get; set; }

        [Display(Name = "هزينه حمل")]
        public decimal Freight_Charge { get; set; }

        [Display(Name = "شهرستان")]
        public bool County { get; set; }

        [Display(Name = "تهران")]
        public bool Tehran { get; set; }

        [Display(Name = "بازار")]
        public bool Bazar { get; set; }

        [Display(Name = "شوش")]
        public bool Shoosh { get; set; }

        [Display(Name = "فعال")]
        public bool Active { get; set; }

        [Display(Name = "حساب ارزي")]
        public bool Acc_Currency { get; set; }

        [Display(Name = "نوع ارز")]
        public string Currency_Type { get; set; }

        [Display(Name = "پيگيري")]
        public string Followup { get; set; }

        [Display(Name = "مانده بدهکار")]
        public bool Rem_Debit { get; set; }

        [Display(Name = "مانده بستانکار")]
        public bool Rem_Credit { get; set; }

        [Display(Name = "مانده همواره بدهکار")]
        public bool Rem_Debit_All { get; set; }

        [Display(Name = "مانده همواره بستانکار")]
        public bool Rem_Credit_All { get; set; }

        [Display(Name = "مانده حساب دفتري")]
        public decimal RemAcc { get; set; }

        [Display(Name = "اسناد دريافتني سررسيد نشده")]
        public decimal NotMatureRecvDocs { get; set; }

        [Display(Name = "چكهاي برگشتي")]
        public decimal ReturnedRecvDocs { get; set; }

        [Display(Name = "جمع فروش")]
        public decimal TotalSales { get; set; }

        [Display(Name = "مانده اعتبار")]
        public decimal RemCredit { get; set; }

        [Display(Name = "شماره كارت بانكي")]
        public string BankCard_No { get; set; }

        [Display(Name = "شماره شبا")]
        public string Sheba_No { get; set; }

        [Display(Name = "سیستم خرید")]
        public bool Purchase_Sys { get; set; }

        [Display(Name = "سیستم فروش")]
        public bool Sales_Sys { get; set; }

    }

    public class Documents
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "عطف")]
        public int ID { get; set; }

        [Key]
        [Display(Name = "شماره سند")]
        [Required(ErrorMessage = "شماره سند الزامی است")]
        public string Doc_No { get; set; }

        [Display(Name = "تاریخ سند")]
        public string Doc_Date { get; set; }

        [Display(Name = "شرح سند")]
        public string Doc_Desc { get; set; }

        [Display(Name = "کنترل")]
        public bool Controler { get; set; }

        [Display(Name = "تایید")]
        public bool Confirm { get; set; }

        [Display(Name = "ثبت قطعی")]
        public bool Register { get; set; }

        public int doc_Type { get; set; }
        public virtual Doc_Type doc_type { get; set; }
        public int Sub_type { get; set; }

        //public string timeCreate { get; set; }
        //public string timeUpdate { get; set; }
        //public string UserCreate { get; set; }
        //public string UserUpdate { get; set; }

        [Display(Name = "توضیحات")]
        public string Notes { get; set; }

        [Display(Name = "پیوست")]
        public string Attach { get; set; }

        [Display(Name = "تاریخ میلادی")]
        public string Doc_DateL { get; set; }

        [Display(Name = "شرح لاتین سند")]
        public string Doc_DescL { get; set; }

        public string Company_Code { get; set; }

        [Display(Name = "پرچم")]
        public bool Flag { get; set; }

        public int ID_Link { get; set; }

        public virtual List<Journal> LJournals { get; set; }
    }

    public class Journal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Display(Name = "ردیف")]
        public int Row { get; set; }

        [Display(Name = "شماره سند")]
        public string Doc_No { get; set; }
        public virtual Documents documents { get; set; }

        [Display(Name = "حساب")]
        public string Acc_No { get; set; }
        public virtual Accounts accounts { get; set; }

        [Display(Name = "تفصیل 1")]
        public string Tafsil1 { get; set; }

        [Display(Name = "تفصیل 2")]
        public string Tafsil2 { get; set; }

        [Display(Name = "تفصیل 3")]
        public string Tafsil3 { get; set; }

        [Display(Name = "شرح")]
        public string Descr { get; set; }

        [Display(Name = "بدهکار")]
        public decimal Debit { get; set; }

        [Display(Name = "بستانکار")]
        public decimal Credit { get; set; }

        public string Sales_Doc_No { get; set; }
        public string SDoc_No { get; set; }
        public string PDoc_No { get; set; }
        public string RDoc_No { get; set; }
        public int Sub_Type { get; set; }

        [Display(Name = "تایید")]
        public bool Control { get; set; }

        public bool Settle { get; set; }
        public decimal Currency_Price { get; set; }
        public string Currency_Type { get; set; }
        public string Currency_Symbol { get; set; }
        public int Currency_Rate { get; set; }

        [Display(Name = "شرح لاتین")]
        public string DescrL { get; set; }
        public string Company_Code { get; set; }

        [Display(Name = "پرچم")]
        public bool Flag { get; set; }

        [Display(Name = "پنهان")]
        public bool Hidden { get; set; }

        [Display(Name = "تعداد")]
        public int Qty { get; set; }

        [Display(Name = "قیمت")]
        public decimal Price { get; set; }

        [Display(Name = "تاريخ پيگيري")]
        public string Follow_Date { get; set; }

        [Display(Name = "كد پيگيري")]
        public string Follow_No { get; set; }

        [Display(Name = "شرح پيگيري")]
        public string Follow_Descr { get; set; }


        public int ID_Link { get; set; }
    }

    public class Doc_Descr
    {
        [Key]
        [Display(Name = "ردیف")]
        public int Row { get; set; }

        [Display(Name = "شرح")]
        public string Descr { get; set; }
    }

    public class Acc_Tafsil
    {
        [Key]
        public int ID { get; set; }

        public string Acc_No { get; set; }
        public virtual Accounts Accounts { get; set; }

        public string G_No { get; set; }
        public virtual Tafsil_Group Tafsil_Group { get; set; }

        public string No_Tafsil { get; set; }
    }

    public class Journal_Acc
    {
        [Display(Name = "ردیف")]
        public Int64 row { get; set; }
        [Display(Name = "سند")]
        public string Doc_No { get; set; }
        [Display(Name = "تاریخ")]
        public string Doc_Date { get; set; }
        [Display(Name = "شرح")]
        public string Artickle_Descr { get; set; }
        [Display(Name = "بدهکار")]
        public decimal Debit { get; set; }
        [Display(Name = "بستانکار")]
        public decimal Credit { get; set; }
        [Display(Name = "مانده")]
        public decimal Rem { get; set; }
        [Display(Name = "پرچم")]
        public bool Flag { get; set; }

        [Display(Name = "تسویه")]
        public bool Settle { get; set; }

        [Display(Name = "تشخیص")]
        public string RemType { get; set; }

        [Display(Name = "شناسه")]
        public long ID { get; set; }
    }

    public class Journal_Tafsil
    {
        [Display(Name = "سرفصل")]
        public string Acc_No { get; set; }
        [Display(Name = "ردیف")]
        public Int64 row { get; set; }
        [Display(Name = "سند")]
        public string Doc_No { get; set; }
        [Display(Name = "تاریخ")]
        public string Doc_Date { get; set; }
        [Display(Name = "شرح")]
        public string Artickle_Descr { get; set; }

        [Display(Name = "بدهکار")]
        public decimal Debit { get; set; }
        [Display(Name = "بستانکار")]
        public decimal Credit { get; set; }
        [Display(Name = "مانده")]
        public decimal Rem { get; set; }

        [Display(Name = "پرچم")]
        public bool Flag { get; set; }
        [Display(Name = "تسویه")]
        public bool Settle { get; set; }
        [Display(Name = "تاریخ پیگیری")]
        public string Follow_Date { get; set; }
        [Display(Name = "تشخیص")]
        public string RemType { get; set; }

        [Display(Name = "شناسه")]
        public long ID { get; set; }
    }

    public class Journal_Book
    {
        [Display(Name = "سند")]
        public string Doc_No { get; set; }
        [Display(Name = "تاریخ")]
        public string Doc_Date { get; set; }
        [Display(Name = "حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "نام حساب")]
        public string Acc_Name { get; set; }
        [Display(Name = "تفصیل 1")]
        public string Tafsil1 { get; set; }
        [Display(Name = "نام تفصیل 1")]
        public string Tafsil_Name1 { get; set; }
        [Display(Name = "تفصیل 2")]
        public string Tafsil2 { get; set; }
        [Display(Name = "نام تفصیل 2")]
        public string Tafsil_Name2 { get; set; }
        [Display(Name = "تفصیل 3")]
        public string Tafsil3 { get; set; }
        [Display(Name = "نام تفصیل 3")]
        public string Tafsil_Name3 { get; set; }
        [Display(Name = "شرح")]
        public string Descr { get; set; }
        [Display(Name = "بدهکار")]
        public decimal Debit { get; set; }
        [Display(Name = "بستانکار")]
        public decimal Credit { get; set; }
        [Display(Name = "شماره پیگیری")]
        public string PeygiriNum { get; set; }
        [Display(Name = "تاریخ پیگیری")]
        public string PeygiriDate { get; set; }
        [Display(Name = "شرح پیگیری")]
        public string PeygiriDescr { get; set; }
        [Display(Name = "دریافت")]
        public string DocReceipt { get; set; }
        [Display(Name = "پرداخت")]
        public string DocPayment { get; set; }
        [Display(Name = "سند انبار")]
        public string DocStore { get; set; }
        [Display(Name = "سند خرید فروش")]
        public string DocBuySale { get; set; }
    }

    public class BalanceSheet
    {
        [Display(Name = "حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "حساب")]
        public string AccNo { get; set; }
        [Display(Name = "نام حساب")]
        public string Acc_Name { get; set; }
        public string Tafsil { get; set; }
        public string TafsilNo { get; set; }
        [Display(Name = "بدهکار اول دوره")]
        public decimal FirstRemDebit { get; set; }
        [Display(Name = "بستانکار اول دوره")]
        public decimal FirstRemCredit { get; set; }
        [Display(Name = "جمع بدهکار طی دوره")]
        public decimal SumDebit { get; set; }
        [Display(Name = "جمع بسانکار طی دوره")]
        public decimal SumCredit { get; set; }
        [Display(Name = "مانده بدهکار طی دوره")]
        public decimal RemDebit { get; set; }
        [Display(Name = "مانده بستانکار طی دوره")]
        public decimal RemCredit { get; set; }
        [Display(Name = "جمع بدهکار")]
        public decimal FirstRemDebitSumDebit { get; set; }
        [Display(Name = "جمع بستانکار")]
        public decimal FirstRemCreditSumCredit { get; set; }
        [Display(Name = "مانده بدهکار")]
        public decimal RemDebitFinal { get; set; }
        [Display(Name = "مانده بستانکار")]
        public decimal RemCreditFinal { get; set; }
        public decimal SumQty { get; set; }
    }

    public class People
    {
        [Key]
        [Display(Name = "شناسه")]
        public int ID { get; set; }

        [Display(Name = "حساب")]
        public string Acc_No { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "نام")]
        public string First_Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Last_Name { get; set; }

        [Display(Name = "سمت")]
        public string Job_Title { get; set; }

        [Display(Name = "شرکت /موسسه")]
        public string Company { get; set; }

        [Display(Name = "اطلاعات")]
        public string Info { get; set; }

        [Display(Name = "کد اقتصادی")]
        public string Economic_Code { get; set; }

        [Display(Name = "کد ملی / شماره ثبت")]
        public string National_Code { get; set; }

        [Display(Name = "شناسه ملی")]
        public string National_ID { get; set; }

        [Display(Name = "استان")]
        public string State { get; set; }

        [Display(Name = "شهر")]
        public string City { get; set; }

        [Display(Name = "Town")]
        public string Town { get; set; }

        [Display(Name = "منطقه")]
        public string Region { get; set; }

        [Display(Name = "آدرس پستی 1")]
        public string post_Address1 { get; set; }

        [Display(Name = "ادرس پستی 2")]
        public string post_Address2 { get; set; }

        [Display(Name = "کدپستی")]
        public string Postal_Code { get; set; }

        [Display(Name = "پست الکترونیک")]
        public string Email { get; set; }

        [Display(Name = "شماره تلفن 1")]
        public string Tel_No1 { get; set; }

        [Display(Name = "شماره تلفن 2")]
        public string Tel_No2 { get; set; }

        [Display(Name = "شماره تلفن 3")]
        public string Tel_No3 { get; set; }

        [Display(Name = "شماره تلفن 4")]
        public string Tel_No4 { get; set; }

        [Display(Name = "شماره فکس")]
        public string Fax_No { get; set; }

        [Display(Name = "شماره موبایل")]
        public string Mobile_no { get; set; }

        [Display(Name = "حداکثر اعتبار")]
        public decimal MaxCredit { get; set; }

        [Display(Name = "درصد تخفیف")]
        public int Discount_Prcnt { get; set; }

        [Display(Name = "نمایندگی")]
        public bool DealerNet { get; set; }

        [Display(Name = "")]
        public int Sales_Price_No { get; set; }

        [Display(Name = "باربری")]
        public string Transporter { get; set; }

        [Display(Name = "هزینه حمل")]
        public decimal Freight_Charge { get; set; }

        [Display(Name = "شهرستان")]
        public bool County { get; set; }

        [Display(Name = "تهران")]
        public bool Tehran { get; set; }

        [Display(Name = "بازار")]
        public bool Bazar { get; set; }

        [Display(Name = "فعال")]
        public bool Active { get; set; }

    }

    public class CostBenefit
    {
        public int Rows { get; set; }
        public string Desrc { get; set; }
        public decimal col1 { get; set; }
        public decimal col2 { get; set; }
        public decimal col3 { get; set; }
    }

    public class Balance
    {
        [Display(Name = "کد")]
        public string Acc_No1 { get; set; }
        [Display(Name = "شرح")]
        public string Acc_Name1 { get; set; }
        [Display(Name = "کد")]
        public string Acc_No2 { get; set; }
        [Display(Name = "شرح")]
        public string Acc_Name2 { get; set; }
        [Display(Name = "بدهکار")]
        public decimal RemDebit { get; set; }
        [Display(Name = "بستانکار")]
        public decimal RemCredit { get; set; }
    }
}
