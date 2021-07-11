using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepehr4Core.MyModels.PublicModel
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        [Display(Name = "نام شرکت")]
        [Required(ErrorMessage = "نام شرکت الزامیست")]
        public string Name { get; set; }

    }

    public class Years
    {
        [Key]
        public string YearID { get; set; }
        [Display(Name = "سال مالی")]
        [Required(ErrorMessage = "سال مالی شرکت الزامیست")]
        public string FinYear { get; set; }
        [Display(Name = "شرح")]
        public string Description { get; set; }
        [Display(Name = "سال قبل")]
        public string LastYear { get; set; }

        public string dbAddress { get; set; }

        public int CompanyID { get; set; }
        public Company company { get; set; }
    }


    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Admin { get; set; }
        public bool Defines { get; set; }
        public bool Account { get; set; }
        public bool Store { get; set; }
        public bool Sales { get; set; }
        public bool PayRecv { get; set; }
        public bool HR { get; set; }
        public bool PayRoll { get; set; }
        public bool BackupUser { get; set; }
        public bool Acc_Doc { get; set; }
        public bool Acc_Doc_Del { get; set; }
        public bool Acc_Control { get; set; }
        public bool Acc_GLedger { get; set; }
        public bool Acc_GLedger_Sales { get; set; }
        public bool Acc_GLedger_Store { get; set; }
        public bool Acc_GLedger_PayRecv { get; set; }
        public bool Acc_GLedger_PayRoll { get; set; }
        public bool Acc_Tafsil { get; set; }
        public bool Acc_Tafsil_Sales { get; set; }
        public bool Acc_Tafsil_Store { get; set; }
        public bool Acc_Tafsil_PayRecv { get; set; }
        public bool Acc_Tafsil_PayRoll { get; set; }
        public bool Acc_Journal { get; set; }
        public bool Acc_Balance { get; set; }
        public bool Acc_ProfitCost { get; set; }
        public bool Acc_MiscReports { get; set; }
        public bool Acc_Controler { get; set; }
        public bool Acc_Confirm { get; set; }
        public bool Acc_Register { get; set; }
        public bool Acc_ChangeSys { get; set; }
        public bool Sales_PreFactor { get; set; }
        public bool Sales_Out_Order { get; set; }
        public bool Sales_Factor { get; set; }
        public bool Sales_Factor_R { get; set; }
        public bool Sales_Factor_Market { get; set; }
        public bool Sales_Factor_Del { get; set; }
        public bool Sales_Control { get; set; }
        public bool Purchase_Factor { get; set; }
        public bool Purchase_Factor_R { get; set; }
        public bool Purchase_Factor_Del { get; set; }
        public bool Purchase_Control { get; set; }
        public bool Sales_Report { get; set; }
        public bool Branch { get; set; }
        public bool Sales_Qty { get; set; }
        public bool Sales_Customer { get; set; }
        public bool SalesMan { get; set; }
        public bool CreditVeto { get; set; }
        public bool CreditCheque { get; set; }
        public bool Dlv_Docs { get; set; }
        public bool Store_In { get; set; }
        public bool Store_Out { get; set; }
        public bool Store_Doc_Del { get; set; }
        public bool Store_Purchase_Order { get; set; }
        public bool Store_Proforma { get; set; }
        public bool Store_Control { get; set; }
        public bool Store_Qty { get; set; }
        public bool Store_Inv { get; set; }
        public bool Store_InvCard { get; set; }
        public bool Store_TurnOver { get; set; }
        public bool Store_TurnOverDetails { get; set; }
        public bool Store_MerchTurnOver { get; set; }
        public bool Store_Customer { get; set; }
        public bool Store_CostBasis { get; set; }
        public bool Store_RealInv { get; set; }
        public bool Store_Keeper { get; set; }
        public bool Store_Rial { get; set; }
        public bool Store_Report { get; set; }
        public bool PayRecv_Recv_File { get; set; }
        public bool PayRecv_Recv { get; set; }
        public bool PayRecv_Pay { get; set; }
        public bool PayRecv_MngRecv { get; set; }
        public bool PayRecv_MngPay { get; set; }
        public bool PayRecv_MatRecv { get; set; }
        public bool PayRecv_MatPay { get; set; }
        public bool PayRecv_ChequeForm { get; set; }
        public bool PayRecv_ChequeBook { get; set; }
        public bool PayRecv_Forecast { get; set; }
        public bool PayRecv_Controler { get; set; }
        public bool PayRecv_Confirm { get; set; }
        public bool PayRecv_Register { get; set; }
        public bool PayRecv_Doc_Del { get; set; }
        public bool HR_personel_Define { get; set; }
        public bool HR_InOut_Define { get; set; }
        public bool HR_Monthly_Calc_WorkTime { get; set; }
        public bool HR_Monthly_WorkTime { get; set; }
        public bool HR_Card_IOs { get; set; }
        public bool HR_Shift_Define { get; set; }
        public bool HR_WorkGroup_Define { get; set; }
        public bool HR_JobsDefine { get; set; }
        public bool HR_Positions { get; set; }
        public bool HR_Service_Define { get; set; }
        public bool HR_Adv_Define { get; set; }
        public bool HR_Kosor_Define { get; set; }
        public bool HR_loan { get; set; }
        public bool HR_PrePay { get; set; }
        public bool HR_ExtraPay { get; set; }
        public bool P_PayrollForm { get; set; }
        public bool P_Loan_Reserve { get; set; }
        public bool P_Loan_Assign { get; set; }
        public bool P_PrePayDaily { get; set; }
        public bool P_ExtraPayDaily { get; set; }
        public bool P_CalcPayroll { get; set; }
        public bool Acc_Opt { get; set; }
        public bool Store_Opt { get; set; }
        public bool PayRecv_Opt { get; set; }
        public bool Sales_Opt { get; set; }
        public bool HR_Opt { get; set; }
        public bool P_Opt { get; set; }
        public bool Active { get; set; }
        public string Acc_No { get; set; }
        public string Tafsil_No1 { get; set; }
        public string Tafsil_No2 { get; set; }
        public string Tafsil_No3 { get; set; }
        public string Center_No { get; set; }
        public string Sales_Person_No { get; set; }

    }

    public class InitAcc
    {
        [Key]
        public int Acc_Levels { get; set; }
        public int GL_Level { get; set; }
        public string Acc_Level1_Name { get; set; }
        public int Acc_Level1_Len { get; set; }
        public string Acc_Level2_Name { get; set; }
        public int Acc_Level2_Len { get; set; }
        public string Acc_Level3_Name { get; set; }
        public int Acc_Level3_Len { get; set; }
        public string Acc_Level4_Name { get; set; }
        public int Acc_Level4_Len { get; set; }
        public string Acc_Level5_Name { get; set; }
        public int Acc_Level5_Len { get; set; }
        public string Acc_Level6_Name { get; set; }
        public int Acc_Level6_Len { get; set; }
        public string Acc_Level7_Name { get; set; }
        public int Acc_Level7_Len { get; set; }
        public string Acc_Level8_Name { get; set; }
        public int Acc_Level8_Len { get; set; }
        public string Acc_Level9_Name { get; set; }
        public int Acc_Level9_Len { get; set; }
        public int GAcc_Level1_Len { get; set; }
        public int TAcc_Level1_Len { get; set; }
        public int GAcc_Level2_Len { get; set; }
        public int TAcc_Level2_Len { get; set; }
        public int GAcc_Level3_Len { get; set; }
        public int TAcc_Level3_Len { get; set; }
        public int GAcc_Level4_Len { get; set; }
        public int TAcc_Level4_Len { get; set; }
        public int GAcc_Level5_Len { get; set; }
        public int TAcc_Level5_Len { get; set; }
        public int GAcc_Level6_Len { get; set; }
        public int TAcc_Level6_Len { get; set; }
        public int GAcc_Level7_Len { get; set; }
        public int TAcc_Level7_Len { get; set; }
        public int GAcc_Level8_Len { get; set; }
        public int TAcc_Level8_Len { get; set; }
        public int GAcc_Level9_Len { get; set; }
        public int TAcc_Level9_Len { get; set; }
        public int Tafsil_Len { get; set; }
        public int GTafsil_Len { get; set; }
    }

    public class Init
    {
        [Key]
        [Display(Name = "نام شخص حقيقي / حقوقي")]
        public string Co_Name { get; set; }
        [Display(Name = "Co. Name")]
        public string LCo_Name { get; set; }
        [Display(Name = "استان")]
        public string State { get; set; }
        [Display(Name = "شهرستان")]
        public string City { get; set; }
        [Display(Name = "شهر")]
        public string Town { get; set; }
        [Display(Name = "نشانی")]
        public string Co_Address { get; set; }
        [Display(Name = "State")]
        public string LState { get; set; }
        [Display(Name = "City")]
        public string LCity { get; set; }
        [Display(Name = "Town")]
        public string LTown { get; set; }
        [Display(Name = "Co. Address")]
        public string LCo_Address { get; set; }
        [Display(Name = "نشانی 2")]
        public string Co_Address2 { get; set; }
        [Display(Name = "کد پستی")]
        public string Postal_Code { get; set; }
        [Display(Name = "شماره تلفن")]
        public string Co_TelNo { get; set; }
        [Display(Name = "شماره تلفن 2")]
        public string Co_TelNo2 { get; set; }
        [Display(Name = "فکس")]
        public string Co_FaxNo { get; set; }
        [Display(Name = "پست الکترونیک")]
        public string Co_Email { get; set; }
        [Display(Name = "سایت")]
        public string Co_WebSite { get; set; }
        [Display(Name = "کد اقتصادی")]
        public string Economic_Code { get; set; }
        [Display(Name = "کد ملی/شمار ثبت")]
        public string National_Code { get; set; }
        [Display(Name = "شناسه ملی")]
        public string National_ID { get; set; }
        [Display(Name = "پیش فاکتور تاریخ اعتبار")]
        public string Expire_Date { get; set; }
        [Display(Name = "پیش فاکتر شرایط سفارش")]
        public string Order_Condition { get; set; }
        [Display(Name = "پیش فاکتر تاریخ تحویل")]
        public string Order_Dlv_Date { get; set; }
        [Display(Name = "پیش فاکتور محل تحویل")]
        public string Order_Dlv_Place { get; set; }
        [Display(Name = "پیش فاکتور مدت اعتبار")]
        public string Order_Expire { get; set; }
        [Display(Name = "پیش فاکتور پایه مفتول مس")]
        public decimal Copper_Base { get; set; }
        [Display(Name = "پیش فاکتور بسته بندی")]
        public string Packing { get; set; }
        [Display(Name = "پیش فاکتور حسابهای بانکی")]
        public string BankAccounts { get; set; }
        [Display(Name = "طول سند")]
        public int DocNoLen { get; set; }
        [Display(Name = "حداکثر تعداد سند")]
        public int MaxDocNo { get; set; }
        public int ChequeNoLen { get; set; }
        public int MaxChequeNo { get; set; }
        [Display(Name = "طول سند انبار")]
        public int SDocNoLen { get; set; }
        [Display(Name = "حداکثر تعداد سند انبار")]
        public int MaxSDocNo { get; set; }
        [Display(Name = "طول پروفرما")]
        public int ProformaNoLen { get; set; }
        [Display(Name = "طول کد پرسنلی")]
        public int PersonCodeLen { get; set; }
        [Display(Name = "حداکثر کد پرسنلی")]
        public int MaxPersonCode { get; set; }
        [Display(Name = "طول کد حکم")]
        public int HokmNoLen { get; set; }
        [Display(Name = "حداکثر کد حکم")]
        public int MaxHokmNo { get; set; }
        [Display(Name = "کد دستگاه کارت خوان ساعت")]
        public int Card_Saat { get; set; }

        public int Index { get; set; }
        [Display(Name = "تاریخ شروع دوره مالی")]
        public string Start_Date { get; set; }
        [Display(Name = "تاریخ پایان دوره مالی")]
        public string End_Date { get; set; }
        [Display(Name = "شرح سال مالی")]
        public string Year_Descr { get; set; }
        [Display(Name = "تجمیع عوارض")]
        public int Toll_prcnt { get; set; }
        [Display(Name = "مالیات ارزش افزوده")]
        public int VAT_prcnt { get; set; }
        [Display(Name = "نام مدیر عامل")]
        public string Managing_Director { get; set; }
        [Display(Name = "کد بیمه کارگاه")]
        public string Ins_Code { get; set; }
        [Display(Name = "شماره پرونده مالیات")]
        public string Tax_Code { get; set; }
        [Display(Name = "حوزه مالیاتی")]
        public string Tax_Domain { get; set; }
        [Display(Name = "سازمان بیمه تامین اجتماعی")]
        public string Ins_Name { get; set; }
        [Display(Name = "آدرس بیمه")]
        public string Ins_Address { get; set; }
        [Display(Name = "اداره دارایی")]
        public string Tax_Name { get; set; }
        [Display(Name = "ادرس اداره دارایی")]
        public string Tax_Address { get; set; }
        [Display(Name = "نام ممیز")]
        public string Tax_Person { get; set; }
        [Display(Name = "سریالی / ترتیبی")]
        public bool Factor_No_Serial { get; set; }
        [Display(Name = "طول سریال")]
        public int SerialNoLen { get; set; }
        [Display(Name = "اولین شماره فاکتور")]
        public string First_Factor_No { get; set; }
        
        public bool Factor_Legal { get; set; }
        [Display(Name = "سریالی / ترتیبی")]
        public bool PreFactor_No_Serial { get; set; }
        [Display(Name = "طول سریال")]
        public int PreSerialNoLen { get; set; }
        [Display(Name = "اولین شماره فاکتور")]
        public string First_PreFactor_No { get; set; }
        [Display(Name = "شماره فاکتور مستقل برای هر انبار")]
        public bool Factor_No_Indpnt { get; set; }
        [Display(Name = "شماره فاکتور مستقل برای هر مرکز")]
        public bool Factor_No_Indpnt_Center { get; set; }
        [Display(Name = "پیش فرض فاکتور های نقدی")]
        public bool Cash_Credit { get; set; }
        
        public bool PreFactor_Legal { get; set; }
        [Display(Name = "روش قیمت گذاری انبار ادواری / دائمی")]
        public bool CostBasisMethod { get; set; }
        [Display(Name = "انابر محوری - کالا محوری")]
        public bool Inv_Oriented { get; set; }

        public DateTime LastSyncDate { get; set; }


        public bool ATafsil1_Visible { get; set; }
        public bool ATafsil2_Visible { get; set; }
        public bool ATafsil3_Visible { get; set; }
    }

    public class Currency_Table
    {
        [Key]
        public int ID { get; set; }
        public string Currency_Type { get; set; }
        public string Currency_Symbol { get; set; }
        public decimal Currency_Rate { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Currency_Code_Tax { get; set; }
        
    }

    public class Option
    {
        public float LeftMargin { get; set; }
        public float RightMargin { get; set; }
        public float TopMargin { get; set; }
        public float BottomMargin { get; set; }
        public bool ReportDate { get; set; }
        public bool ReportDate_Today { get; set; }
        public bool ID_Print { get; set; }
        public bool LatinRep_NoRial { get; set; }
        public bool UserCreate_Print { get; set; }
        public bool Print_LastDebit { get; set; }
        public bool ATafsil1_Visible { get; set; }
        public bool ATafsil2_Visible { get; set; }
        public bool ATafsil3_Visible { get; set; }
        public bool Control_Tafsil { get; set; }
        public bool Control_Descr { get; set; }
        public bool Control_Debit_Credit { get; set; }
        public bool Control_Auto { get; set; }
        public bool Doc_Editable { get; set; }
        public bool Doc_Confirm_Editable { get; set; }
        public bool OnLineFilter { get; set; }
        public bool Doc_Store_SDoc { get; set; }
        public bool Doc_Store_Daily { get; set; }
        public bool Doc_Store_Monthly { get; set; }
        public bool Doc_Sales_SDoc { get; set; }
        public bool Doc_Sales_Daily { get; set; }
        public bool Doc_Sales_Monthly { get; set; }
        public bool Doc_Purchase_SDoc { get; set; }
        public bool Doc_Purchase_Daily { get; set; }
        public bool Doc_Purchase_Monthly { get; set; }
        public bool Doc_PayRecv_PRDoc { get; set; }
        public bool Doc_PayRecv_Daily { get; set; }
        public bool Doc_PayRecv_Monthly { get; set; }
        public bool DocA4A5 { get; set; }
        public bool MajorMinor { get; set; }
        public bool LastPurchase { get; set; }
        public bool MerchRepeat { get; set; }
        public bool Barcode_Merchs { get; set; }
        public bool Doc_Sales_Issue { get; set; }
        public bool Doc_Store_Issue { get; set; }
        public bool Inventory_Control { get; set; }
        public bool Sales_Inventory_Control { get; set; }
        public bool Cost_Basis { get; set; }
        public bool RSales_Cost_Basis { get; set; }
        public bool Credit_Visible { get; set; }
        public bool Sales_Customer_Doc { get; set; }
        public bool FishSep { get; set; }
        public string QtyFormat { get; set; }
        public string MQtyFormat { get; set; }
        public int QtyDecimals { get; set; }
        public int MQtyDecimals { get; set; }
        public bool MQtyVisible { get; set; }
        public bool MTafsil1_Visible { get; set; }
        public bool MTafsil2_Visible { get; set; }
        public bool MTafsil3_Visible { get; set; }
        public bool Serial_Visible { get; set; }
        public bool Expire_Visible { get; set; }
        public bool Plates_Visible { get; set; }
        public bool Location_Visible { get; set; }
        public bool CostBasis_Visible { get; set; }
        public bool Store_Qty_InDocDesc { get; set; }
        public bool Store_Center { get; set; }
        public bool Purchase_Discount { get; set; }
        public bool PaymanKari { get; set; }
        public bool MerchCodeMode { get; set; }
        public bool InOutA4A5 { get; set; }
        public int DaySettle { get; set; }
        public bool ChequePriceToman { get; set; }
        public int Diff_Day { get; set; }
        public int Town_Diff_Day { get; set; }
        public bool Holiday_Diff_Day { get; set; }
        public int Control_Day { get; set; }
        public bool PayableAcc { get; set; }
        public bool Return_To_Refund { get; set; }
        public bool File_AccNo { get; set; }
        public int Numeral { get; set; }
        public string TextFontName { get; set; }
        public string NumberFontName { get; set; }
        public string MerchFontName { get; set; }
        public string MonitorFontName { get; set; }
        public int TextFontSize { get; set; }
        public int NumberFontSize { get; set; }
        public int MerchFontSize { get; set; }
        public int MonitorFontSize { get; set; }
        public bool TextFontBold { get; set; }
        public bool NumberFontBold { get; set; }
        public bool MerchFontBold { get; set; }
        public bool MonitorFontBold { get; set; }
        public bool PayControl { get; set; }
        public bool RecvControl { get; set; }
        public bool InvLessMinControl { get; set; }
        public bool InvLessNormalControl { get; set; }
        public bool InvMoreMaxControl { get; set; }
        public bool BalanceSheetFirstRem { get; set; }
        public bool AllowLessMin { get; set; }
        public bool AllowLessNormal { get; set; }
        public bool AllowMoreMax { get; set; }
        public bool RoundKarkard_Khales { get; set; }
        public bool RoundPardakht_Khales { get; set; }
        public int RoundNumberPardakht_Khales { get; set; }
        public bool RoundPardakht_Khales_Ins { get; set; }
        public int RoundNumberPardakht_Khales_Ins { get; set; }
        public bool Tax_2_7_InsKargar { get; set; }
        public bool PayFish_TotalY2D { get; set; }
        public bool PayFish_DayOff { get; set; }
        public bool PayFish_SignSection { get; set; }
        public bool PrePay_Control { get; set; }
        public decimal PrePay_TopPrcnt { get; set; }
        public bool Doc_Descr_Serial_PayRecv { get; set; }
        public bool Doc_Descr_BankName { get; set; }
        public bool Doc_Descr_Serial_Store { get; set; }
        public bool Doc_Descr_Serial_SalesPurchase { get; set; }
        public bool Produce_BOM { get; set; }
        public bool Contract_BOM { get; set; }
        public string BackupPath { get; set; }
        public string BackupDailyPath { get; set; }
        public bool AutoBackup { get; set; }
        public int BackupPeriod { get; set; }
        public string SyncPath { get; set; }
        public int SyncPeriod { get; set; }
        public bool SyncMaster { get; set; }
        public string InsPath { get; set; }
        public string TaxPath { get; set; }
        [Key]
        public int ID { get; set; }
    }

    public class BackupRestoreList
    {
        [Key]
        [Display(Name = "شماره حساب")]
        public int ID { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "شرکت")]
        public string Company { get; set; }

        [Display(Name = "سال")]
        public string Year { get; set; }

        [Display(Name = "مسیر فایل پشتیبان")]
        public string Address { get; set; }

        [Display(Name = "حجم فایل")]
        public decimal Size { get; set; }

        [Display(Name = "تاریخ و زمان")]
        public DateTime dttm { get; set; }

        [Display(Name = "پشتیبانی / بازیابی")]
        public bool Backup { get; set; }

    }

    public class Log
    {
        [Display(Name = "کاربر")]
        public string Users { get; set; }
        [Display(Name = "زمان ثبت")]
        public string dttm { get; set; }
        [Display(Name = "فرم")]
        public string Form { get; set; }
        [Display(Name = "نوع تراکنش")]
        public string Status { get; set; }
        [Display(Name = "شرح")]
        public string Descr { get; set; }
        [Display(Name = "تراکنش")]
        public string Query { get; set; }
    }

    //ساختار کالا
    public class InitMerch
    {
        [Display(Name = "سطوح کالا")]
        public int Merch_levels { get; set; }
        [Display(Name = "تعداد ارقام سطح 1")]
        public int Merch_level1_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 2")]
        public int Merch_level2_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 3")]
        public int Merch_level3_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 4")]
        public int Merch_level4_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 5")]
        public int Merch_level5_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 6")]
        public int Merch_level6_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 7")]
        public int Merch_level7_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 8")]
        public int Merch_level8_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 9")]
        public int Merch_level9_Len { get; set; }
        [Display(Name = "نام سطح 1")]
        public string Merch_level1_Name { get; set; }
        [Display(Name = "نام سطح 2")]
        public string Merch_level2_Name { get; set; }
        [Display(Name = "نام سطح 3")]
        public string Merch_level3_Name { get; set; }
        [Display(Name = "نام سطح 4")]
        public string Merch_level4_Name { get; set; }
        [Display(Name = "نام سطح 5")]
        public string Merch_level5_Name { get; set; }
        [Display(Name = "نام سطح 6")]
        public string Merch_level6_Name { get; set; }
        [Display(Name = "نام سطح 7")]
        public string Merch_level7_Name { get; set; }
        [Display(Name = "نام سطح 8")]
        public string Merch_level8_Name { get; set; }
        [Display(Name = "نام سطح 9")]
        public string Merch_level9_Name { get; set; }
        public int GMerch_level1_Len { get; set; }
        public int GMerch_level2_Len { get; set; }
        public int GMerch_level3_Len { get; set; }
        public int GMerch_level4_Len { get; set; }
        public int GMerch_level5_Len { get; set; }
        public int GMerch_level6_Len { get; set; }
        public int GMerch_level7_Len { get; set; }
        public int GMerch_level8_Len { get; set; }
        public int GMerch_level9_Len { get; set; }
        [Display(Name = "سطوح گروه کالا")]
        public int MG_levels { get; set; }
        [Display(Name = "تعداد ارقام سطح 1")]
        public int MG_level1_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 2")]
        public int MG_level2_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 3")]
        public int MG_level3_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 4")]
        public int MG_level4_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 5")]
        public int MG_level5_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 6")]
        public int MG_level6_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 7")]
        public int MG_level7_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 8")]
        public int MG_level8_Len { get; set; }
        [Display(Name = "تعداد ارقام سطح 9")]
        public int MG_level9_Len { get; set; }
        [Display(Name = "نام سطح 1")]
        public string MG_level1_Name { get; set; }
        [Display(Name = "نام سطح 2")]
        public string MG_level2_Name { get; set; }
        [Display(Name = "نام سطح 3")]
        public string MG_level3_Name { get; set; }
        [Display(Name = "نام سطح 4")]
        public string MG_level4_Name { get; set; }
        [Display(Name = "نام سطح 5")]
        public string MG_level5_Name { get; set; }
        [Display(Name = "نام سطح 6")]
        public string MG_level6_Name { get; set; }
        [Display(Name = "نام سطح 7")]
        public string MG_level7_Name { get; set; }
        [Display(Name = "نام سطح 8")]
        public string MG_level8_Name { get; set; }
        [Display(Name = "نام سطح 9")]
        public string MG_level9_Name { get; set; }
        [Display(Name = "درصد پرمصرف")]
        public int FastMoving { get; set; }
        [Display(Name = "درصد متسوط مصرف")]
        public int NormalMoving { get; set; }
        [Display(Name = "درصد کم مصرف")]
        public int SlowMoving { get; set; }
        [Display(Name = "تعداد روز تامین کالا")]
        public int Master_LeadTime { get; set; }

    }
    //تعریف انبار ها
    public class InitStores
    {
        [Display(Name = "تعداد انبار")]
        public int No_Stores { get; set; }
        [Display(Name = "نام انبار")]
        public string Store1_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store2_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store3_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store4_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store5_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store6_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store7_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store8_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store9_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store10_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store11_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store12_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store13_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store14_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store15_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store16_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store17_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store18_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store19_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store20_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store21_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store22_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store23_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store24_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store25_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store26_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store27_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store28_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store29_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store30_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store31_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store32_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store33_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store34_Name { get; set; }
        [Display(Name = "نام انبار")]
        public string Store35_Name { get; set; }
    }
}
