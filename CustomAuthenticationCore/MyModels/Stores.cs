using Sepehr4Core.MyModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepehr4Core.MyModels.Stores
{
    //noe asnad anbar
    public class Store_Type
    {
        [Key]
        [Display(Name = "عملیات انبار")]
        public int SDoc_Type { get; set; }
        public string SDoc_Type_Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //anbarha
    public class Stores
    {
        [Key]
        [Display(Name = "کد انبار")]
        public string Store_No { get; set; }
        [Display(Name = "نام انبار")]
        public string Store_Name { get; set; }
        [Display(Name = "محصول")]
        public bool Store_Type1 { get; set; }
        [Display(Name = "مواد")]
        public bool Store_Type2 { get; set; }
        [Display(Name = "کالای جریان ساخت")]
        public bool Store_Type3 { get; set; }
        [Display(Name = "ملزومات")]
        public bool Store_Type4 { get; set; }
        [Display(Name = "قطعات یدکی")]
        public bool Store_Type5 { get; set; }
        [Display(Name = "BOM")]
        public bool BOM { get; set; }
        [Display(Name = "نمایش در منو ها")]
        public bool ShowIt { get; set; }
        [Display(Name = "نوع محاسبه")]//0 : Standard , 1: average , 2:FiFo , 3 : LiFo
        public int CostBasis_Method { get; set; }
        [Display(Name = "InvControl")]
        public bool InvControl { get; set; }
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //anbarak
    public class Stores_Sub
    {
        [Key]
        [Display(Name = "کد انبار")]
        public string StoreSub_No { get; set; }
        [Display(Name = "نام انبار")]
        public string StoreSub_Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    public class Store_Docs
    {
        [Display(Name = "کد انبار")]
        public string Store_No { get; set; }
        [Display(Name = "کد انبار")]
        public string Store_No_2 { get; set; }
        [Display(Name = "کد انبارک")]
        public string StoreSub_No { get; set; }
        [Display(Name = "کد انبارک")]
        public string StoreSub_No_2 { get; set; }
        [Display(Name = "وارده/صادره")]
        public bool inOut { get; set; }
        [Key]
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        [Display(Name = "شماره سند انتقال")]
        public string SDoc_No_2 { get; set; }
        [Display(Name = "نوع سند")]
        public int SDoc_Type { get; set; }
        [Display(Name = "تاریخ سند")]
        public string SDoc_Date { get; set; }
        [Display(Name = "شرح سند")]
        public string SDoc_Desc { get; set; }
        [Display(Name = "سند حسابداری انبار")]
        public string Doc_No { get; set; }
        [Display(Name = "سند حسابداری فروش")]
        public string Doc_No_Sales { get; set; }
        [Display(Name = "سند حسابداری انبار واقعی")]
        public string Doc_No_Real { get; set; }
        [Display(Name = "سند حسابداری انبار برآوردی")]
        public string Doc_No_Estimate { get; set; }
        [Display(Name = "سند حسابداری انبار استاندارد")]
        public string Doc_No_Standard { get; set; }
        [Display(Name = "سند حسابداری انبار اصلاحی")]
        public string Doc_No_Revised { get; set; }
        [Display(Name = "شماره رسید")]
        public string Store_Doc_No { get; set; }
        [Display(Name = "کد مشتری")]
        public string Acc_No { get; set; }
        [Display(Name = "کد تفصیلی1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "کد تفصیلی2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "کد تفصیلی3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "کد مشتری")]
        public string Acc_No_2 { get; set; }
        [Display(Name = "کد تفصیلی1")]
        public string Tafsil_No1_2 { get; set; }
        [Display(Name = "کد تفصیلی2")]
        public string Tafsil_No2_2 { get; set; }
        [Display(Name = "کد تفصیلی3")]
        public string Tafsil_No3_2 { get; set; }
        [Display(Name = "شماره فاکتور")]
        public string Factor_No { get; set; }
        [Display(Name = "کد مرکز")]
        public string Center_No { get; set; }
        [Display(Name = "عانل فروش")]
        public string Sales_Person_No { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Discount_Prcnt { get; set; }
        [Display(Name = "درصد تخفیف نقدی")]
        public int Discount_Cash_Prcnt { get; set; }
        [Display(Name = "تخفیف")]
        public decimal Discount { get; set; }
        [Display(Name = "اضافه سایر")]
        public decimal Extra_Charge { get; set; }
        [Display(Name = "کسر سایر")]
        public decimal Extra_Costs { get; set; }
        [Display(Name = "تجمیع عوارض")]
        public decimal Toll { get; set; }
        [Display(Name = "مالیات بر ارزش افزوده")]
        public decimal VAT { get; set; }
        [Display(Name = "سود تحقق نیافته اقساطی")]
        public decimal Profit_Ghesti { get; set; }
        [Display(Name = "هزینه حمل")]
        public decimal Freight_Charge { get; set; }
        [Display(Name = "نرخ کمیسیون")]
        public decimal Commission_Rate { get; set; }
        [Display(Name = "کمیسیون")]
        public decimal Commission { get; set; }
        [Display(Name = "نرخ خرید عرف کمیسیون")]
        public decimal Purchase_Com_Rate { get; set; }
        [Display(Name = "نرخ فروش عرف کمیسیون")]
        public decimal Sales_Com_Rate { get; set; }
        [Display(Name = "سهم گارانتی")]
        public decimal Guaranty_Price { get; set; }
        [Display(Name = "سهم امداد")]
        public decimal Emdad_Price { get; set; }
        [Display(Name = "سهم مشتری")]
        public decimal Customer_Price { get; set; }
        [Display(Name = "روز تسویه")]
        public decimal Days_Settle { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        [Display(Name = "تعداد بسته ها")]
        public int Package_Qty { get; set; }
        [Display(Name = "نقدی")]
        public bool Cash { get; set; }
        [Display(Name = "اعتباری")]
        public bool Credit { get; set; }
        [Display(Name = "چک مدت دار")]
        public bool Cheque_LongTerm { get; set; }
        [Display(Name = "رسید")]
        public bool Resid { get; set; }
        [Display(Name = "چک روز")]
        public bool Cheque_Day { get; set; }
        [Display(Name = "اقساطی")]
        public bool Ghesti { get; set; }
        [Display(Name = "مبلغ نقدی")]
        public decimal Cash_Value { get; set; }
        [Display(Name = "مبلغ نقدی")]
        public decimal POS_Value { get; set; }
        [Display(Name = "حساب پایانه فروش")]
        public string Acc_No_Pos { get; set; }
        [Display(Name = "کد تفصیل پایانه فروش")]
        public string Tafsil_No_Pos { get; set; }
        [Display(Name = "شهرستان")]
        public bool County { get; set; }
        [Display(Name = "تهران")]
        public bool Tehran { get; set; }
        [Display(Name = "بازار")]
        public bool Bazar { get; set; }
        [Display(Name = "شوش")]
        public bool Shoosh { get; set; }
        [Display(Name = "شماره بارنامه")]
        public string Trans_No { get; set; }
        [Display(Name = "تاریخ بارنامه")]
        public string Trans_Date { get; set; }
        [Display(Name = "نام باربری")]
        public string Trans_Name { get; set; }
        [Display(Name = "نوع و شماره ماشین")]
        public string Car_No { get; set; }
        [Display(Name = "شماره تماس")]
        public string Contact_No { get; set; }
        public string timeCreate { get; set; }
        public string timeUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        [Display(Name = "پروژه")]
        public string Project { get; set; }
        [Display(Name = "محل استفاده")]
        public string Loc_Use { get; set; }
        [Display(Name = "خرید کننده/درخواست کننده")]
        public string Purchase_Name { get; set; }
        [Display(Name = "فروشنده/تحویل دهنده")]
        public string Seller { get; set; }
        [Display(Name = "شماره سند")]
        public string Doc_No2 { get; set; }
        [Display(Name = "شماره درخواست خرید")]
        public string Purchase_No { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        [Display(Name = "شماره رسید موقت")]
        public string tmp_delv_No { get; set; }
        [Display(Name = "شماره رسید دایم")]
        public string prm_delv_No { get; set; }
        [Display(Name = "شماره تاییدیه QC")]
        public string QC_No { get; set; }
        [Display(Name = "ارسال مدارک")]
        public bool Dlv_Docs { get; set; }
        [Display(Name = "تاریخ ارسال مدارک")]
        public string Dlv_Docs_Date { get; set; }
        [Display(Name = "ثبت فروشنده")]
        public bool Salesman { get; set; }
        [Display(Name = "ثبت انبارداری")]
        public bool Store_Keeper_Register { get; set; }
        [Display(Name = "ثبت")]
        public bool Register { get; set; }
        [Display(Name = "پیش فاکتور")]
        public bool PreFactor { get; set; }
        [Display(Name = "تحویل گیرنده")]
        public string Deliver_Name { get; set; }
        [Display(Name = "تحویل دهنده")]
        public string Recive_Name { get; set; }
        [Display(Name = "مسئول انبار")]
        public string Anbar { get; set; }
        [Display(Name = "مسئول شاپ")]
        public string Shop { get; set; }
        [Display(Name = "منترل اموال")]
        public string Controler { get; set; }
        [Display(Name = "معاونت اآماد")]
        public string Amad { get; set; }
        [Display(Name = "نرخ حمل")]
        public decimal Freight_Rate { get; set; }
        [Display(Name = "باطل شده")]
        public bool SDoc_Cancel { get; set; }
        [Display(Name = "فروش کمیسیونی")]
        public bool Sales_Com { get; set; }
        [Display(Name = "فروش امانی")]
        public bool Sales_Amani { get; set; }
        public int ID_Link { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        // public virtual List<Store_Details> Store_Details { get; set; }
    }
    public class Store_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        // public virtual Store_Docs Store_Docs { get; set; } 
        [Display(Name = "شماره سریال سند عطف")]
        public int ID_Ref { get; set; }
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "تفصیل1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "تفصیل2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "تفصیل3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        [Display(Name = "قیمت تمام شده")]
        public int Cost_Basis { get; set; }
        [Display(Name = "تعداد موقت")]
        public int PreQty { get; set; }
        [Display(Name = "تعداد")]
        public int Qty { get; set; }
        [Display(Name = "تعداد عمده")]
        public int MQty { get; set; }
        [Display(Name = "جمع ریال")]
        public decimal Total { get; set; }
        [Display(Name = "جمع قیمت تمام شده")]
        public decimal TotalCB { get; set; }
        [Display(Name = "قیمت واقعی")]
        public decimal Price_Real { get; set; }
        [Display(Name = "قیمت برآوردی")]
        public decimal Price_Estimate { get; set; }
        [Display(Name = "قیمت استاندارد")]
        public decimal Price_Standard { get; set; }
        [Display(Name = "قیمت اصلاحی")]
        public decimal Privce_Revised { get; set; }
        [Display(Name = "جمع ریال واقعی")]
        public decimal Total_Real { get; set; }
        [Display(Name = "جمع ریال برآوردی")]
        public decimal Total_Estimate { get; set; }
        [Display(Name = "جمع ریال استاندارد")]
        public decimal Total_Standard { get; set; }
        [Display(Name = "جمع ریال اصلاحی")]
        public decimal Total_Revised { get; set; }
        [Display(Name = "موجودی ریالی")]
        public decimal Totals { get; set; }
        [Display(Name = "حسابداری انبار - عادی")]
        public bool Acc_Noramal { get; set; }
        [Display(Name = "حسابداری انبار - وافعی")]
        public bool Acc_Real { get; set; }
        [Display(Name = "حسابداری انبار - برآوردی")]
        public bool Acc_Estimate { get; set; }
        [Display(Name = "حسابداری انبار - استاندارد")]
        public bool Acc_Standard { get; set; }
        [Display(Name = "حسابداری انبار - اصلاحی")]
        public bool Acc_Revised { get; set; }
        [Display(Name = "تاریخ عادی")]
        public string Acc_Normal_Date { get; set; }
        [Display(Name = "تاتریخ واقعی")]
        public string Acc_Real_Date { get; set; }
        [Display(Name = "تاریخ برآوردی")]
        public string Acc_Estimate_Date { get; set; }
        [Display(Name = "تاریخ استاندارد")]
        public string Acc_Standard_Date { get; set; }
        [Display(Name = "تاریخ اصلاح")]
        public string Acc_Revised_Date { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Discount { get; set; }
        [Display(Name = "مبلغ تخفیف")]
        public decimal Discount_Price { get; set; }
        [Display(Name = "مالیات برارزش افزوده")]
        public decimal VAT_Price { get; set; }
        [Display(Name = "عوارض")]
        public decimal Toll_Price { get; set; }
        [Display(Name = "سایر اضافات")]
        public decimal Extra_Charge_Price { get; set; }
        [Display(Name = "سایر کسورات")]
        public decimal Extra_Costs_Price { get; set; }
        [Display(Name = "مالیات تکلیفی")]
        public decimal Tax_Taklifi { get; set; }
        [Display(Name = "سپرده حق بیمه")]
        public decimal Ins_Sepordeh { get; set; }
        [Display(Name = "سپرده حسن انجام کار")]
        public decimal GoodWork_Sepordeh { get; set; }
        [Display(Name = "پیش پرداخت")]
        public decimal PrePaid { get; set; }
        [Display(Name = "شماره سریال")]
        public string Serial_No { get; set; }
        [Display(Name = "تاریخ انقضا")]
        public string Expire_date { get; set; }
        [Display(Name = "قفسه انبار")]
        public string Store_Location { get; set; }
        [Display(Name = "شماره ارسال / شماره دم")]
        public string Ersal_No { get; set; }
        [Display(Name = "شماره درخواست خرید /کالا")]
        public string Purchase_No { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        [Display(Name = "شماره بارنامه")]
        public string Trans_No { get; set; }
        [Display(Name = "شماره تبادل")]
        public string Trmp_Dlv_No { get; set; }
        [Display(Name = "تاریخ تبادل")]
        public string Trmp_Dlv_Date { get; set; }
        [Display(Name = "شماره صورت وضعیت")]
        public string Status_No { get; set; }
        [Display(Name = "تاریخ صورت وضعیت")]
        public string Status_Date { get; set; }
        [Display(Name = "کد فرعی")]
        public string Sub_Code { get; set; }
        [Display(Name = "وضعیت سند")]
        public string Doc_Status { get; set; }
        [Display(Name = "نوع سند")]
        public string Doc_Type { get; set; }
        [Display(Name = "کد ظرف")]
        public string Plate_No { get; set; }
        [Display(Name = "شماره ظرف")]
        public string Plate_Serial { get; set; }
        [Display(Name = "Confirm")]
        public bool Confirm { get; set; }
        [Display(Name = "Currency_Price")]
        public decimal Currency_Price { get; set; }
        [Display(Name = "Currency_Type")]
        public string Currency_Type { get; set; }
        [Display(Name = "Currency_Symbol")]
        public string Currency_Symbol { get; set; }
        [Display(Name = "Currency_Rate")]
        public int Currency_Rate { get; set; }
        [Display(Name = "ID_Link")]
        public int ID_Link { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    public class Store_Details_BOM
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "کد محصول")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "کد مواد")]
        public string Merch_Code_Child { get; set; }
        [Display(Name = "محاسبه ست شود")]
        public bool Set_Cal { get; set; }
        [Display(Name = "ضریب مصرف")]
        public int Qty { get; set; }
        [Display(Name = "موجودی")]
        public int Inv { get; set; }
        [Display(Name = "موجودی بعد از اعمال ضریب مصرف")]
        public int Inv_Qty { get; set; }
        [Display(Name = "موجودی ست")]
        public int Inv_Set { get; set; }
        [Display(Name = "موجودی قایل تولید")]
        public int Inv_Pallate { get; set; }
        [Display(Name = "حداکثر اختلاف موجودی ست با موجودی")]
        public int Inv_Max { get; set; }
        [Display(Name = "تعدا کسری برای ست کردن")]
        public int Inv_Diff { get; set; }
        [Display(Name = "تعداد سفارش")]
        public int Order_Qty { get; set; }
        [Display(Name = "سفارش سند سفارش")]
        public string Order_No { get; set; }
        [Display(Name = "از درخت محصول اصلی استفاده شده")]
        public bool BOM { get; set; }
        public int ID_Store_Details { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //hengame tolid ghateeye x tamam mishavad ta residane ghetee jadid az ghetee jaygozin estefah mishad
    public class Store_Details_Master_BOM
    {
        [Display(Name = "کد محصول")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "زمان استاندارد تولید")]
        public int Product_Time_Std { get; set; }
        [Display(Name = "زمان واقعی تولید")]
        public int Product_Time_Real { get; set; }
        [Display(Name = "بهای تمام شده تولید -استاندارد")]
        public int CostBasis_Std { get; set; }
        [Display(Name = "بهای تمام شده تولید - واقعی")]
        public int CostBasis_Real { get; set; }
        [Display(Name = "از درخت محصول اصلی")]
        public bool BOM { get; set; }
        public int ID_Store_Details { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //kalayye ke kharej shode ba serial motefavet
    public class Store_Details_Serials
    {
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شماره سریال")]
        public string Serial_No { get; set; }
        [Display(Name = "خرید")]
        public bool Purchase { get; set; }
        [Display(Name = "وارده امانی")]
        public bool Deposit_In { get; set; }
        public int ID_Store_Details_In { get; set; }
        [Display(Name = "تاریخ ورود")]
        public string Date_In { get; set; }
        public int QC { get; set; } //0: No QC , 1: QC Ok , 2 QC Nok
        public bool WIN_MISC { get; set; }
        public bool WIN_Pixel { get; set; }
        public bool NoWIN_MISC { get; set; }
        public bool NoWIN_Pixel { get; set; }
        [Display(Name = "فروش")]
        public bool Sales { get; set; }
        [Display(Name = "ارسال امانی")]
        public bool Deposit_Out { get; set; }
        public int ID_Store_Details_Out { get; set; }
        [Display(Name = "تاریخ خروج")]
        public string Date_Out { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //darkhat khorooj kala az anbar
    public class StoreOutOrder_Docs
    {
        [Display(Name = "کد انبار")]
        public string Store_No { get; set; }
        [Display(Name = "کد انبار")]
        public string Store_No_2 { get; set; }
        [Display(Name = "وارده/صادره")]
        public bool inOut { get; set; }
        [Key]
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        [Display(Name = "شماره سند انتقال")]
        public string SDoc_No_2 { get; set; }
        [Display(Name = "نوع سند")]
        public int SDoc_Type { get; set; }
        [Display(Name = "تاریخ سند")]
        public string SDoc_Date { get; set; }
        [Display(Name = "شرح سند")]
        public string SDoc_Desc { get; set; }
        [Display(Name = "سند حسابداری")]
        public string Dco_No { get; set; }
        [Display(Name = "کد مشتری")]
        public string Acc_No { get; set; }
        [Display(Name = "کد تفصیلی1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "کد تفصیلی2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "کد تفصیلی3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "شماره فاکتور")]
        public string Factor_No { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Dsicount_Prcnt { get; set; }
        [Display(Name = "تخفیف")]
        public decimal Discount { get; set; }
        [Display(Name = "اضافه سایر")]
        public decimal Extra_Charge { get; set; }
        [Display(Name = "کسر سایر")]
        public decimal Extra_Costs { get; set; }
        [Display(Name = "تجمیع عوارض")]
        public decimal Toll { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        [Display(Name = "تعدا بسته ها")]
        public int Package_Qty { get; set; }
        [Display(Name = "نقدی")]
        public bool Cash { get; set; }
        [Display(Name = "اعتباری")]
        public bool Credit { get; set; }
        [Display(Name = "مبلغ نقدی")]
        public decimal Cash_Value { get; set; }
        [Display(Name = "شهرستان")]
        public bool County { get; set; }
        [Display(Name = "شماره بارنامه")]
        public string Trans_No { get; set; }
        [Display(Name = "تاریخ بارنامه")]
        public string Trans_Date { get; set; }
        [Display(Name = "نام باربری")]
        public string Trans_Name { get; set; }
        public string timeCreate { get; set; }
        public string timeUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        [Display(Name = "پروژه")]
        public string Project { get; set; }
        [Display(Name = "محل استفاده")]
        public string Loc_Use { get; set; }
        [Display(Name = "خرید کننده/درخواست کننده")]
        public string Purchase_Name { get; set; }
        [Display(Name = "فروشنده/تحویل دهنده")]
        public string Seller { get; set; }
        [Display(Name = "شماره سند")]
        public string Doc_No2 { get; set; }
        [Display(Name = "شماره درخواست خرید/کالا")]
        public string Purchase_No { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        [Display(Name = "شماره رسید موقت")]
        public string tmp_delv_No { get; set; }
        [Display(Name = "شماره رسید دایم")]
        public string prm_delv_No { get; set; }
        [Display(Name = "شماره تاییدیه QC")]
        public string QC_No { get; set; }
        [Display(Name = "ثبت فروشنده")]
        public bool Salesman { get; set; }
        [Display(Name = "ثبت انبارداری")]
        public bool Store_Keeper_Register { get; set; }
        [Display(Name = "ثبت")]
        public bool Register { get; set; }
        [Display(Name = "پیش فاکتور")]
        public bool Prefactor { get; set; }
        [Display(Name = "تحویل گیرنده")]
        public string Deliver_Name { get; set; }
        [Display(Name = "تحویل دهنده")]
        public string Receive_Name { get; set; }
        [Display(Name = "مسئول انبار")]
        public string Anbar { get; set; }
        [Display(Name = "مسئول شاپ")]
        public string Shop { get; set; }
        [Display(Name = "کنترل اموال")]
        public string Controler { get; set; }
        [Display(Name = "معاونت آماد")]
        public string Amad { get; set; }
        [Display(Name = "باطل شده")]
        public bool SDoc_Cancel { get; set; }
        public int ID_Link { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        // public virtual StoreOutOrder_Details StoreOutOrder_Details { get; set; }
    }
    public class StoreOutOrder_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        // public virtual StoreOutOrder_Docs StoreOutOrder_Docs { get; set; }
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "تفصیل1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "تفصیل2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "تفصیل3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        [Display(Name = "قیمت تمام شده")]
        public int Cost_Basis { get; set; }
        [Display(Name = "تعداد خرده موقت")]
        public int PreQty { get; set; }
        [Display(Name = "تعداد خرده")]
        public int Qty { get; set; }
        [Display(Name = "تعداد عمده")]
        public int MQty { get; set; }
        [Display(Name = "تعداد موجود در انبار")]
        public int Qty_Inv { get; set; }
        [Display(Name = "تعداد  عمده انبار")]
        public int MQty_Inv { get; set; }
        [Display(Name = "حمع ریال")]
        public decimal Total { get; set; }
        [Display(Name = "جمع")]
        public decimal TotalCB { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Discount { get; set; }
        [Display(Name = "شماره سریال")]
        public string Serial_No { get; set; }
        [Display(Name = "تاریخ انقضا")]
        public string Expire_date { get; set; }
        [Display(Name = "قفسه انبار")]
        public string Store_Location { get; set; }
        [Display(Name = "کد اموال")]
        public string C_Code { get; set; }
        [Display(Name = "اتاق")]
        public string Shop { get; set; }
        [Display(Name = "شماره ارسالی/ شماره دم")]
        public string Ersal_No { get; set; }
        [Display(Name = "شماره درخواست خرید/ کالا")]
        public string Purchase_No { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        [Display(Name = "شماره بارنامه")]
        public string Trans_No { get; set; }
        [Display(Name = "شماره تبادل")]
        public string Tmp_Dlv_No { get; set; }
        [Display(Name = "تاریخ تبادل")]
        public string Tmp_Dlv_No_ { get; set; }
        [Display(Name = "شماره صورت وضعیت")]
        public string Status_No { get; set; }
        [Display(Name = "تاریخ صورت وضعیت")]
        public string Status_Date { get; set; }
        [Display(Name = "کد فرعی")]
        public string Sub_Code { get; set; }
        [Display(Name = "درخواست کننده")]
        public string Request_Name { get; set; }
        [Display(Name = "کشور سازنده")]
        public string Country { get; set; }
        [Display(Name = "کاربرد")]
        public string Use { get; set; }
        [Display(Name = "وضعیت سند")]
        public string Doc_Status { get; set; }
        [Display(Name = "نوع سند")]
        public string Doc_Type { get; set; }
        [Display(Name = "کد ظرف")]
        public string Plate_No { get; set; }
        [Display(Name = "شماره ظرف")]
        public string Plate_Serial { get; set; }
        public bool Confirm { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }

}
