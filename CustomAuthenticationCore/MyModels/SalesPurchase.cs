using Sepehr4Core.MyModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepehr4Core.MyModels.SalesPurchase
{
    
    //sefaresh pishfactor
    public class Orders_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }

        [Display(Name = "شماره سند")]
        public string Order_No { get; set; }
        // public virtual Orders_Doc Orders_Doc { get; set; }

        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }

        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }

        [Display(Name = "قیمت")]
        public decimal Price { get; set; }

        [Display(Name = "تعدا خرده")]
        public int Qty { get; set; }

        [Display(Name = "تعداد عمده")]
        public int MQty { get; set; }

        [Display(Name = "تعداد موجود در انبار")]
        public int Qty_Inv { get; set; }

        [Display(Name = "تعداد عنده انبار")]
        public int MQty_Inv { get; set; }

        [Display(Name = "جمع")]
        public decimal Total { get; set; }

        [Display(Name = "درصد تخفیف")]
        public int Discount { get; set; }

        [Display (Name = "مبلغ تخفیف")]
        public decimal Discount_Price { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    public class Orders_Doc
    {
        [Key]
        [Display (Name = "شماره سند")]
        public string Order_No { get; set; }

        [Display(Name = "تاریخ سند")]
        public string Order_Date { get; set; }

        [Display(Name = "شرح سند")]
        public string Order_Desc { get; set; }

        [Display(Name = "شماره پیش فاکتور")]
        public string PreFactor_No { get; set; }

        [Display(Name = "کد مرکز")]
        public string Center_No { get; set; }

        [Display(Name = "عامل فروش")]
        public string Sales_Person_No { get; set; }

        [Display(Name = "تاریخ اعتبار" )]
        public string Expire_Date { get; set; }

        [Display(Name = "شرایط سفارش" )]
        public string Order_Condition { get; set; }

        [Display(Name = "تتاریخ تحویل")]
        public string Order_Dlv_Date { get; set; }

        [Display(Name = "محل تحویل")]
        public string Order_Dlv_Place { get; set; }

        [Display(Name = "مدت اعتبار")]
        public string Order_Expire { get; set; }

        [Display(Name = "پایه مفتول مس")]
        public decimal Copper_Base { get; set; }

        [Display(Name = "نوع بسته بندی")]
        public string Packing { get; set; }

        [Display(Name = "حسابهای بانکی" )]
        public string BankAccounts { get; set; }

        [Display(Name = "اقدام کننده")]
        public string Followup_Person { get; set; }

        [Display(Name = "نام مشتری")]
        public string Customer_Name { get; set; }

        [Display(Name = "کد مشتری")]
        public string Acc_No { get; set; }

        [Display(Name = "کد تفصیلی 1" )]
        public string Tafsil_No1 { get; set; }

        [Display(Name = "کد تفصیلی 2")]
        public string Tafsil_No2 { get; set; }

        [Display(Name = "کد تفصیلی 3")]
        public string Tafsil_No3 { get; set; }

        [Display(Name = "شماره فاکتور")]
        public string Factor_No { get; set; }

        [Display(Name = "شماره سند انبار")]
        public string SDoc_No { get; set; }

        [Display(Name = "شماره سند انبار خرید")]
        public string SDoc_NoP { get; set; }

        [Display(Name = "کد انبار")]
        public string Store_No { get; set; }

        [Display(Name = "درصد تخفیف")]
        public int Discount_Prcnt { get; set; }

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

        [Display(Name = "ثبت فروش")]
        public bool SalesMan { get; set; }

        [Display(Name = "ثبت انبارداری")]
        public bool Store_Keeper_Register { get; set; }

        [Display(Name = "ثبت")]
        public bool Register { get; set; }

        [Display(Name = "تسویه")]
        public bool Settle { get; set; }

        [Display(Name = "تاریخ تسویه")]
        public string Settle_Date { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public string timeCreate { get; set; }

        [Display(Name = "تاریخ آخرین تغییر")]
        public string timeUpdate { get; set; }

        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }

        public bool Order_Cancel { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        // public virtual List<Orders_Details>Orders_Details { get; set; }
    }
    // markaz
    public class Center
    {
        public string center_code { get; set; }
        public string center_name { get; set; }
        public decimal center_debit { get; set; }
        public decimal center_credit { get; set; }
        public decimal center_tolid { get; set; }
        public decimal center_sale { get; set; }
        public decimal center_mali { get; set; }
        public decimal center_atabar { get; set; }
        public string center_dollar { get; set; }
        public string center_no_dollar { get; set; }
        public string center_attach { get; set; }
        public string taf1 { get; set; }
        public string moein1 { get; set; }
        public string taf2 { get; set; }
        public string moein2 { get; set; }
        public string center_group { get; set; }
        public string center_tabag { get; set; }
        public int company { get; set; }

    }
    
    //factor latin internatuional
    public class Proforma
    {
        [Key]
        [Display(Name = "شماره سند")]
        public string Proforma_No { get; set; }
        [Display(Name = "تاریخ سند")]
        public string Proforma_Date { get; set; }
        [Display(Name = "شرح سند")]
        public string Proforma_Desc { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        [Display(Name = "پست الکترونیک")]
        public string Email { get; set; }
        [Display(Name = "سایت")]
        public string WebSite { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        [Display(Name = "تعداد بسته ها")]
        public int Package_Qty { get; set; }
        public string Total_Amount_Desc { get; set; }
        public decimal Total_Amount { get; set; }
        public int Gross_Weight { get; set; }
        public int Net_Weight { get; set; }
        public string TermsPayment { get; set; }
        public string Validity { get; set; }
        public string Delivery { get; set; }
        public string Bank { get; set; }
        public string CountryOrigin { get; set; }
        public string Signature { get; set; }
        public string Currency_Rate { get; set; }
        public string Currency_Type { get; set; }
        public string timeCreate { get; set; }
        public string timeUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // public virtual List<Proforma_Details> Proforma_Details { get; set; }
    }
    public class Proforma_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره سند")]
        public string Proforma_No { get; set; }
        // public virtual Proforma Proforma { get; set; }
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        [Display(Name = "تعداد خرده")]
        public int Qty { get; set; }
        [Display(Name = "تعداد عمده")]
        public int MQty { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //ghardad shivename
    public class Protocols
    {
        [Key]
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        public string Protocol_Name { get; set; }
        public string Acc_No_Bed { get; set; }
        public string Tafsil_No1_Bed { get; set; }
        public string Tafsil_No2_Bed { get; set; }
        public string Tafsil_No3_Bed { get; set; }
        public bool Tafsil_No1_Bed_Customer { get; set; }
        public bool Tafsil_No2_Bed_Customer { get; set; }
        public bool Tafsil_No3_Bed_Customer { get; set; }
        public bool Tafsil_No1_Bed_Store { get; set; }
        public bool Tafsil_No2_Bed_Store { get; set; }
        public bool Tafsil_No3_Bed_Store { get; set; }
        public bool Tafsil_No1_Bed_Merchs { get; set; }
        public bool Tafsil_No2_Bed_Merchs { get; set; }
        public bool Tafsil_No3_Bed_Merchs { get; set; }
        public string Acc_No_Bes { get; set; }
        public string Tafsil_No1_Bes { get; set; }
        public string Tafsil_No2_Bes { get; set; }
        public string Tafsil_No3_Bes { get; set; }
        public bool Tafsil_No1_Bes_Customer { get; set; }
        public bool Tafsil_No2_Bes_Customer { get; set; }
        public bool Tafsil_No3_Bes_Customer { get; set; }
        public bool Tafsil_No1_Bes_Store { get; set; }
        public bool Tafsil_No2_Bes_Store { get; set; }
        public bool Tafsil_No3_Bes_Store { get; set; }
        public bool Tafsil_No1_Bes_Merchs { get; set; }
        public bool Tafsil_No2_Bes_Merchs { get; set; }
        public bool Tafsil_No3_Bes_Merchs { get; set; }
        public string Acc_No_Hosn { get; set; }
        public string Tafsil_No1_Hosn { get; set; }
        public string Tafsil_No2_Hosn { get; set; }
        public string Tafsil_No3_Hosn { get; set; }
        public bool Tafsil_No1_Hosn_Customer { get; set; }
        public bool Tafsil_No2_Hosn_Customer { get; set; }
        public bool Tafsil_No3_Hosn_Customer { get; set; }
        public bool Tafsil_No1_Hosn_Store { get; set; }
        public bool Tafsil_No2_Hosn_Store { get; set; }
        public bool Tafsil_No3_Hosn_Store { get; set; }
        public bool Tafsil_No1_Hosn_Merchs { get; set; }
        public bool Tafsil_No2_Hosn_Merchs { get; set; }
        public bool Tafsil_No3_Hosn_Merchs { get; set; }
        public string Acc_No_Sales_Parts { get; set; }
        public string Tafsil_No1_Sales_Parts { get; set; }
        public string Tafsil_No2_Sales_Parts { get; set; }
        public string Tafsil_No3_Sales_Parts { get; set; }
        public bool Tafsil_No1_Sales_Parts_Customer { get; set; }
        public bool Tafsil_No2_Sales_Parts_Customer { get; set; }
        public bool Tafsil_No3_Sales_Parts_Customer { get; set; }
        public bool Tafsil_No1_Sales_Parts_Store { get; set; }
        public bool Tafsil_No2_Sales_Parts_Store { get; set; }
        public bool Tafsil_No3_Sales_Parts_Store { get; set; }
        public bool Tafsil_No1_Sales_Parts_Merchs { get; set; }
        public bool Tafsil_No2_Sales_Parts_Merchs { get; set; }
        public bool Tafsil_No3_Sales_Parts_Merchs { get; set; }
        public string Acc_No_Sales_PartsTabadol { get; set; }
        public string Tafsil_No1_Sales_PartsTabadol { get; set; }
        public string Tafsil_No2_Sales_PartsTabadol { get; set; }
        public string Tafsil_No3_Sales_PartsTabadol { get; set; }
        public bool Tafsil_No1_Sales_PartsTabadol_Customer { get; set; }
        public bool Tafsil_No2_Sales_PartsTabadol_Customer { get; set; }
        public bool Tafsil_No3_Sales_PartsTabadol_Customer { get; set; }
        public bool Tafsil_No1_Sales_PartsTabadol_Store { get; set; }
        public bool Tafsil_No2_Sales_PartsTabadol_Store { get; set; }
        public bool Tafsil_No3_Sales_PartsTabadol_Store { get; set; }
        public bool Tafsil_No1_Sales_PartsTabadol_Merchs { get; set; }
        public bool Tafsil_No2_Sales_PartsTabadol_Merchs { get; set; }
        public bool Tafsil_No3_Sales_PartsTabadol_Merchs { get; set; }
        public string Acc_No_Sales_Ojrat { get; set; }
        public string Tafsil_No1_Sales_Ojrat { get; set; }
        public string Tafsil_No2_Sales_Ojrat { get; set; }
        public string Tafsil_No3_Sales_Ojrat { get; set; }
        public bool Tafsil_No1_Sales_Ojrat_Customer { get; set; }
        public bool Tafsil_No2_Sales_Ojrat_Customer { get; set; }
        public bool Tafsil_No3_Sales_Ojrat_Customer { get; set; }
        public bool Tafsil_No1_Sales_Ojrat_Store { get; set; }
        public bool Tafsil_No2_Sales_Ojrat_Store { get; set; }
        public bool Tafsil_No3_Sales_Ojrat_Store { get; set; }
        public bool Tafsil_No1_Sales_Ojrat_Merchs { get; set; }
        public bool Tafsil_No2_Sales_Ojrat_Merchs { get; set; }
        public bool Tafsil_No3_Sales_Ojrat_Merchs { get; set; }
        public string Acc_No_Toll { get; set; }
        public string Tafsil_No1_Toll { get; set; }
        public string Tafsil_No2_Toll { get; set; }
        public string Tafsil_No3_Toll { get; set; }
        public bool Tafsil_No1_Toll_Customer { get; set; }
        public bool Tafsil_No2_Toll_Customer { get; set; }
        public bool Tafsil_No3_Toll_Customer { get; set; }
        public bool Tafsil_No1_Toll_Store { get; set; }
        public bool Tafsil_No2_Toll_Store { get; set; }
        public bool Tafsil_No3_Toll_Store { get; set; }
        public bool Tafsil_No1_Toll_Merchs { get; set; }
        public bool Tafsil_No2_Toll_Merchs { get; set; }
        public bool Tafsil_No3_Toll_Merchs { get; set; }
        public string Acc_No_VAT { get; set; }
        public string Tafsil_No1_VAT { get; set; }
        public string Tafsil_No2_VAT { get; set; }
        public string Tafsil_No3_VAT { get; set; }
        public bool Tafsil_No1_VAT_Customer { get; set; }
        public bool Tafsil_No2_VAT_Customer { get; set; }
        public bool Tafsil_No3_VAT_Customer { get; set; }
        public bool Tafsil_No1_VAT_Store { get; set; }
        public bool Tafsil_No2_VAT_Store { get; set; }
        public bool Tafsil_No3_VAT_Store { get; set; }
        public bool Tafsil_No1_VAT_Merchs { get; set; }
        public bool Tafsil_No2_VAT_Merchs { get; set; }
        public bool Tafsil_No3_VAT_Merchs { get; set; }
        public string Acc_No_VAT_Bes { get; set; }
        public string Tafsil_No1_VAT_Bes { get; set; }
        public string Tafsil_No2_VAT_Bes { get; set; }
        public string Tafsil_No3_VAT_Bes { get; set; }
        public bool Tafsil_No1_VAT_Bes_Customer { get; set; }
        public bool Tafsil_No2_VAT_Bes_Customer { get; set; }
        public bool Tafsil_No3_VAT_Bes_Customer { get; set; }
        public bool Tafsil_No1_VAT_Bes_Store { get; set; }
        public bool Tafsil_No2_VAT_Bes_Store { get; set; }
        public bool Tafsil_No3_VAT_Bes_Store { get; set; }
        public bool Tafsil_No1_VAT_Bes_Merchs { get; set; }
        public bool Tafsil_No2_VAT_Bes_Merchs { get; set; }
        public bool Tafsil_No3_VAT_Bes_Merchs { get; set; }
        // public virtual List<Protocols_Details> Protocols_Details { get; set; }
        // public virtual List<Sales_Details> Sales_Details { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    public class Protocols_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره حساب")]
        public string Merch_Code { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        // public virtual Protocols Protocols { get; set; }
        [Display(Name = "تیراژ قطعه")]
        public int Tiraj { get; set; }
        [Display(Name = "قیمت قطعات مستقیم")]
        public decimal Price_Parts { get; set; }
        [Display(Name = "قیمت قطعات تبادلی")]
        public decimal Price_Parts_Tabadol { get; set; }
        [Display(Name = "اجرت مونتاژ")]
        public decimal Price_Ojrat { get; set; }
        public int Hosn_Rate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //sefaresh kharid (pishfactor kharid)
    public class Purchase_Orders
    {
        [Key]
        [Display(Name = "شماره سند")]
        public string Order_No { get; set; }
        [Display(Name = "تاریخ سند")]
        public string Order_Date { get; set; }
        [Display(Name = "شرح سند")]
        public string Order_Desc { get; set; }
        [Display(Name = "شماره پیش فاکتور")]
        public string PreFactor_No { get; set; }
        [Display(Name = "کد مرکز")]
        public string Center_No { get; set; }
        [Display(Name = "عامل فروش")]
        public string Sales_Person_No { get; set; }
        [Display(Name = "تاریخ اعتبار")]
        public string Expire_Date { get; set; }
        [Display(Name = "شرایط سفارش")]
        public string Order_Condition { get; set; }
        [Display(Name = "تاریخ تحویل")]
        public string Order_Dlv_Date { get; set; }
        [Display(Name = "محل تحویل")]
        public string Order_Dlv_Place { get; set; }
        [Display(Name = "مدت اعتبار")]
        public string Order_Expire { get; set; }
        [Display(Name = "پایه مفتول مس")]
        public decimal Copper_Base { get; set; }
        [Display(Name = "نوع بسته بندی")]
        public string Packing { get; set; }
        [Display(Name = "حساب های بانکی")]
        public string BankAccounts { get; set; }
        [Display(Name = "اقدام کننده")]
        public string Followup_Person { get; set; }
        [Display(Name = "نام مشتری")]
        public string Customer_Name { get; set; }
        [Display(Name = "کد مشتری")]
        public string Acc_No { get; set; }
        [Display(Name = "کد تفصیلی 1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "کد تفصیلی 2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "کد تفصیلی 3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "شماره فاکتور")]
        public string Factor_No { get; set; }
        [Display(Name = "شماره سند انبار")]
        public string SDoc_No { get; set; }
        [Display(Name = "شماره سند انبار خرید")]
        public string SDoc_NoP { get; set; }
        [Display(Name = "کد انبار")]
        public string Store_No { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Discount_Prcnt { get; set; }
        [Display(Name = "تخفیف")]
        public decimal Discount { get; set; }
        [Display(Name = "اضافه سایر")]
        public decimal Extra_Charge { get; set; }
        [Display(Name ="سایر کسر")]
        public decimal Extra_Costs { get; set; }
        [Display(Name = "تجمیع عوارض")]
        public decimal Toll { get; set; }
        [Display(Name = "مالیات بر ارزش افزوده")]
        public decimal VAT { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        [Display(Name = "تعداد بسته ها")]
        public int Package_Qty { get; set; }
        [Display(Name = "نقدی")]
        public bool Cash { get; set; }
        [Display(Name = "اعتباری")]
        public bool Credit { get; set; }
        [Display(Name = "مبلغ نقدی")]
        public decimal Cash_Value { get; set; }
        [Display(Name = "تهران")]
        public bool County { get; set; }
        [Display(Name = "ثبت فروش")]
        public bool SalesMan { get; set; }
        [Display(Name = "ثبت انبار داری")]
        public bool Store_Keeper_Register { get; set; }
        [Display(Name = "ثبت")]
        public bool Register { get; set; }
        [Display(Name = "تسویه")]
        public bool Settle { get; set; }
        [Display(Name = "تاریخ تسویه")]
        public bool Settle_Date { get; set; }
        public string timeCreate { get; set; }
        public string timeUpdate { get; set; }
        public string UserCreate { get; set; }
        public string Order_Cancel { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        // public virtual List<Purchase_Orders_Details>Purchase_Orders_Details { get; set; }
    }
    public class Purchase_Orders_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره سند")]
        public string Order_No { get; set; }
        // public virtual Purchase_Orders Purchase_Orders { get; set; }
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "واحد درخواست کننده")]
        public string Unit { get; set; }
        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        [Display(Name = "تعداد خرده درخواستی")]
        public int Qty_Req { get; set; }
        [Display(Name = "تعداد عمده درخواستی")]
        public int MQty_Req { get; set; }
        [Display(Name = "تعداد خرده")]
        public int Qty { get; set; }
        [Display(Name = "تعداد عمده")]
        public int MQty { get; set; }
        [Display(Name = "تعداد موجود در انبار")]
        public int Qty_Inv { get; set; }
        [Display(Name = "تعداد عمده انبار")]
        public int MQty_Inv { get; set; }
        [Display(Name = "جمع ریال")]
        public decimal Total { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Discount { get; set; }
        [Display(Name = "مبلغ تخفیف")]
        public decimal Discount_Price { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //marakez foroosh
    public class Sales_Center
    {
        [Key]
        public string Center_No { get; set; }
        public string Center_Name { get; set; }
        public string Acc_No_Purchase { get; set; }
        public string Tafsil_No1_Purchase { get; set; }
        public string Tafsil_No2_Purchase { get; set; }
        public string Tafsil_No3_Purchase { get; set; }
        public bool Tafsil_No1_Purchase_Customer { get; set; }
        public bool Tafsil_No2_Purchase_Customer { get; set; }
        public bool Tafsil_No3_Purchase_Customer { get; set; }
        public bool Tafsil_No1_Purchase_Store { get; set; }
        public bool Tafsil_No2_Purchase_Store { get; set; }
        public bool Tafsil_No3_Purchase_Store { get; set; }
        public bool Tafsil_No1_Purchase_Merchs { get; set; }
        public bool Tafsil_No2_Purchase_Merchs { get; set; }
        public bool Tafsil_No3_Purchase_Merchs { get; set; }
        public string Acc_No_Sales { get; set; }
        public string Tafsil_No1_Sales { get; set; }
        public string Tafsil_No2_Sales { get; set; }
        public string Tafsil_No3_Sales { get; set; }
        public bool Tafsil_No1_Sales_Customer { get; set; }
        public bool Tafsil_No2_Sales_Customer { get; set; }
        public bool Tafsil_No3_Sales_Customer { get; set; }
        public bool Tafsil_No1_Sales_Store { get; set; }
        public bool Tafsil_No2_Sales_Store { get; set; }
        public bool Tafsil_No3_Sales_Store { get; set; }
        public bool Tafsil_No1_Sales_Merchs { get; set; }
        public bool Tafsil_No2_Sales_Merchs { get; set; }
        public bool Tafsil_No3_Sales_Merchs { get; set; }
        public string Acc_No_RPurchase { get; set; }
        public string Tafsil_No1_RPurchase { get; set; }
        public string Tafsil_No2_RPurchase { get; set; }
        public string Tafsil_No3_RPurchase { get; set; }
        public bool Tafsil_No1_RPurchase_Customer { get; set; }
        public bool Tafsil_No2_RPurchase_Customer { get; set; }
        public bool Tafsil_No3_RPurchase_Customer { get; set; }
        public bool Tafsil_No1_RPurchase_Store { get; set; }
        public bool Tafsil_No2_RPurchase_Store { get; set; }
        public bool Tafsil_No3_RPurchase_Store { get; set; }
        public bool Tafsil_No1_RPurchase_Merchs { get; set; }
        public bool Tafsil_No2_RPurchase_Merchs { get; set; }
        public bool Tafsil_No3_RPurchase_Merchs { get; set; }
        public string Acc_No_RSales { get; set; }
        public string Tafsil_No1_RSales { get; set; }
        public string Tafsil_No2_RSales { get; set; }
        public string Tafsil_No3_RSales { get; set; }
        public bool Tafsil_No1_RSales_Customer { get; set; }
        public bool Tafsil_No2_RSales_Customer { get; set; }
        public bool Tafsil_No3_RSales_Customer { get; set; }
        public bool Tafsil_No1_RSales_Store { get; set; }
        public bool Tafsil_No2_RSales_Store { get; set; }
        public bool Tafsil_No3_RSales_Store { get; set; }
        public bool Tafsil_No1_RSales_Merchs { get; set; }
        public bool Tafsil_No2_RSales_Merchs { get; set; }
        public bool Tafsil_No3_RSales_Merchs { get; set; }
        public string Acc_No_PDiscount { get; set; }
        public string Tafsil_No1_PDiscount { get; set; }
        public string Tafsil_No2_PDiscount { get; set; }
        public string Tafsil_No3_PDiscount { get; set; }
        public bool Tafsil_No1_PDiscount_Customer { get; set; }
        public bool Tafsil_No2_PDiscount_Customer { get; set; }
        public bool Tafsil_No3_PDiscount_Customer { get; set; }
        public bool Tafsil_No1_PDiscount_Store { get; set; }
        public bool Tafsil_No2_PDiscount_Store { get; set; }
        public bool Tafsil_No3_PDiscount_Store { get; set; }
        public bool Tafsil_No1_PDiscount_Merchs { get; set; }
        public bool Tafsil_No2_PDiscount_Merchs { get; set; }
        public bool Tafsil_No3_PDiscount_Merchs { get; set; }
        public string Acc_No_SDiscount { get; set; }
        public string Tafsil_No1_SDiscount { get; set; }
        public string Tafsil_No2_SDiscount { get; set; }
        public string Tafsil_No3_SDiscount { get; set; }
        public bool Tafsil_No1_SDiscount_Customer { get; set; }
        public bool Tafsil_No2_SDiscount_Customer { get; set; }
        public bool Tafsil_No3_SDiscount_Customer { get; set; }
        public bool Tafsil_No1_SDiscount_Store { get; set; }
        public bool Tafsil_No2_SDiscount_Store { get; set; }
        public bool Tafsil_No3_SDiscount_Store { get; set; }
        public bool Tafsil_No1_SDiscount_Merchs { get; set; }
        public bool Tafsil_No2_SDiscount_Merchs { get; set; }
        public bool Tafsil_No3_SDiscount_Merchs { get; set; }
        public string Acc_No_OtherCosts { get; set; }
        public string Tafsil_No1_OtherCosts { get; set; }
        public string Tafsil_No2_OtherCosts { get; set; }
        public string Tafsil_No3_OtherCosts { get; set; }
        public bool Tafsil_No1_OtherCosts_Customer { get; set; }
        public bool Tafsil_No2_OtherCosts_Customer { get; set; }
        public bool Tafsil_No3_OtherCosts_Customer { get; set; }
        public bool Tafsil_No1_OtherCosts_Store { get; set; }
        public bool Tafsil_No2_OtherCosts_Store { get; set; }
        public bool Tafsil_No3_OtherCosts_Store { get; set; }
        public bool Tafsil_No1_OtherCosts_Merchs { get; set; }
        public bool Tafsil_No2_OtherCosts_Merchs { get; set; }
        public bool Tafsil_No3_OtherCosts_Merchs { get; set; }
        public string Acc_No_OtherIncome { get; set; }
        public string Tafsil_No1_OtherIncome { get; set; }
        public string Tafsil_No2_OtherIncome { get; set; }
        public string Tafsil_No3_OtherIncome { get; set; }
        public bool Tafsil_No1_OtherIncome_Customer { get; set; }
        public bool Tafsil_No2_OtherIncome_Customer { get; set; }
        public bool Tafsil_No3_OtherIncome_Customer { get; set; }
        public bool Tafsil_No1_OtherIncome_Store { get; set; }
        public bool Tafsil_No2_OtherIncome_Store { get; set; }
        public bool Tafsil_No3_OtherIncome_Store { get; set; }
        public bool Tafsil_No1_OtherIncome_Merchs { get; set; }
        public bool Tafsil_No2_OtherIncome_Merchs { get; set; }
        public bool Tafsil_No3_OtherIncome_Merchs { get; set; }
        public string Acc_No_Toll { get; set; }
        public string Tafsil_No1_Toll { get; set; }
        public string Tafsil_No2_Toll { get; set; }
        public string Tafsil_No3_Toll { get; set; }
        public bool Tafsil_No1_Toll_Customer { get; set; }
        public bool Tafsil_No2_Toll_Customer { get; set; }
        public bool Tafsil_No3_Toll_Customer { get; set; }
        public bool Tafsil_No1_Toll_Store { get; set; }
        public bool Tafsil_No2_Toll_Store { get; set; }
        public bool Tafsil_No3_Toll_Store { get; set; }
        public bool Tafsil_No1_Toll_Merchs { get; set; }
        public bool Tafsil_No2_Toll_Merchs { get; set; }
        public bool Tafsil_No3_Toll_Merchs { get; set; }
        public string Acc_No_VAT { get; set; }
        public string Tafsil_No1_VAT { get; set; }
        public string Tafsil_No2_VAT { get; set; }
        public string Tafsil_No3_VAT { get; set; }
        public bool Tafsil_No1_VAT_Customer { get; set; }
        public bool Tafsil_No2_VAT_Customer { get; set; }
        public bool Tafsil_No3_VAT_Customer { get; set; }
        public bool Tafsil_No1_VAT_Store { get; set; }
        public bool Tafsil_No2_VAT_Store { get; set; }
        public bool Tafsil_No3_VAT_Store { get; set; }
        public bool Tafsil_No1_VAT_Merchs { get; set; }
        public bool Tafsil_No2_VAT_Merchs { get; set; }
        public bool Tafsil_No3_VAT_Merchs { get; set; }
        public string Acc_No_VATP { get; set; }
        public string Tafsil_No1_VATP { get; set; }
        public string Tafsil_No2_VATP { get; set; }
        public string Tafsil_No3_VATP { get; set; }
        public bool Tafsil_No1_VATP_Customer { get; set; }
        public bool Tafsil_No2_VATP_Customer { get; set; }
        public bool Tafsil_No3_VATP_Customer { get; set; }
        public bool Tafsil_No1_VATP_Store { get; set; }
        public bool Tafsil_No2_VATP_Store { get; set; }
        public bool Tafsil_No3_VATP_Store { get; set; }
        public bool Tafsil_No1_VATP_Merchs { get; set; }
        public bool Tafsil_No2_VATP_Merchs { get; set; }
        public bool Tafsil_No3_VATP_Merchs { get; set; }
        public string Acc_No_CB { get; set; }
        public string Tafsil_No1_CB { get; set; }
        public string Tafsil_No2_CB { get; set; }
        public string Tafsil_No3_CB { get; set; }
        public bool Tafsil_No1_CostBasis_Customer { get; set; }
        public bool Tafsil_No2_CostBasis_Customer { get; set; }
        public bool Tafsil_No3_CostBasis_Customer { get; set; }
        public bool Tafsil_No1_CostBasis_Store { get; set; }
        public bool Tafsil_No2_CostBasis_Store { get; set; }
        public bool Tafsil_No3_CostBasis_Store { get; set; }
        public bool Tafsil_No1_CostBasis_Merchs { get; set; }
        public bool Tafsil_No2_CostBasis_Merchs { get; set; }
        public bool Tafsil_No3_CostBasis_Merchs { get; set; }
        public string Acc_No_Com { get; set; }
        public string Tafsil_No1_Com { get; set; }
        public string Tafsil_No2_Com { get; set; }
        public string Tafsil_No3_Com { get; set; }
        public bool Tafsil_No1_Com_Customer { get; set; }
        public bool Tafsil_No2_Com_Customer { get; set; }
        public bool Tafsil_No3_Com_Customer { get; set; }
        public bool Tafsil_No1_Com_Store { get; set; }
        public bool Tafsil_No2_Com_Store { get; set; }
        public bool Tafsil_No3_Com_Store { get; set; }
        public bool Tafsil_No1_Com_Merchs { get; set; }
        public bool Tafsil_No2_Com_Merchs { get; set; }
        public bool Tafsil_No3_Com_Merchs { get; set; }
        public string Acc_No_OrfCom { get; set; }
        public string Tafsil_No1_OrfCom { get; set; }
        public string Tafsil_No2_OrfCom { get; set; }
        public string Tafsil_No3_OrfCom { get; set; }
        public bool Tafsil_No1_OrfCom_Customer { get; set; }
        public bool Tafsil_No2_OrfCom_Customer { get; set; }
        public bool Tafsil_No3_OrfCom_Customer { get; set; }
        public bool Tafsil_No1_OrfCom_Store { get; set; }
        public bool Tafsil_No2_OrfCom_Store { get; set; }
        public bool Tafsil_No3_OrfCom_Store { get; set; }
        public bool Tafsil_No1_OrfCom_Merchs { get; set; }
        public bool Tafsil_No2_OrfCom_Merchs { get; set; }
        public bool Tafsil_No3_OrfCom_Merchs { get; set; }
        public string Acc_No_Ins { get; set; }
        public string Tafsil_No1_Ins { get; set; }
        public string Tafsil_No2_Ins { get; set; }
        public string Tafsil_No3_Ins { get; set; }
        public bool Tafsil_No1_Ins_Customer { get; set; }
        public bool Tafsil_No2_Ins_Customer { get; set; }
        public bool Tafsil_No3_Ins_Customer { get; set; }
        public bool Tafsil_No1_Ins_Store { get; set; }
        public bool Tafsil_No2_Ins_Store { get; set; }
        public bool Tafsil_No3_Ins_Store { get; set; }
        public bool Tafsil_No1_Ins_Merchs { get; set; }
        public bool Tafsil_No2_Ins_Merchs { get; set; }
        public bool Tafsil_No3_Ins_Merchs { get; set; }
        public string Acc_No_GoodWork { get; set; }
        public string Tafsil_No1_GoodWork { get; set; }
        public string Tafsil_No2_GoodWork { get; set; }
        public string Tafsil_No3_GoodWork { get; set; }
        public bool Tafsil_No1_GoodWork_Customer { get; set; }
        public bool Tafsil_No2_GoodWork_Customer { get; set; }
        public bool Tafsil_No3_GoodWork_Customer { get; set; }
        public bool Tafsil_No1_GoodWork_Store { get; set; }
        public bool Tafsil_No2_GoodWork_Store { get; set; }
        public bool Tafsil_No3_GoodWork_Store { get; set; }
        public bool Tafsil_No1_GoodWork_Merchs { get; set; }
        public bool Tafsil_No2_GoodWork_Merchs { get; set; }
        public bool Tafsil_No3_GoodWork_Merchs { get; set; }
        public string Acc_No_TaxTaklifi { get; set; }
        public string Tafsil_No1_TaxTaklifi { get; set; }
        public string Tafsil_No2_TaxTaklifi { get; set; }
        public string Tafsil_No3_TaxTaklifi { get; set; }
        public bool Tafsil_No1_TaxTaklifi_Customer { get; set; }
        public bool Tafsil_No2_TaxTaklifi_Customer { get; set; }
        public bool Tafsil_No3_TaxTaklifi_Customer { get; set; }
        public bool Tafsil_No1_TaxTaklifi_Store { get; set; }
        public bool Tafsil_No2_TaxTaklifi_Store { get; set; }
        public bool Tafsil_No3_TaxTaklifi_Store { get; set; }
        public bool Tafsil_No1_TaxTaklifi_Merchs { get; set; }
        public bool Tafsil_No2_TaxTaklifi_Merchs { get; set; }
        public bool Tafsil_No3_TaxTaklifi_Merchs { get; set; }
        public string Acc_No_PishPardakht { get; set; }
        public string Tafsil_No1_PishPardakht { get; set; }
        public string Tafsil_No2_PishPardakht { get; set; }
        public string Tafsil_No3_PishPardakht { get; set; }
        public bool Tafsil_No1_PishPardakht_Customer { get; set; }
        public bool Tafsil_No2_PishPardakht_Customer { get; set; }
        public bool Tafsil_No3_PishPardakht_Customer { get; set; }
        public bool Tafsil_No1_PishPardakht_Store { get; set; }
        public bool Tafsil_No2_PishPardakht_Store { get; set; }
        public bool Tafsil_No3_PishPardakht_Store { get; set; }
        public bool Tafsil_No1_PishPardakht_Merchs { get; set; }
        public bool Tafsil_No2_PishPardakht_Merchs { get; set; }
        public bool Tafsil_No3_PishPardakht_Merchs { get; set; }
        public string Acc_No_VATO { get; set; }
        public string Tafsil_No1_VATO { get; set; }
        public string Tafsil_No2_VATO { get; set; }
        public string Tafsil_No3_VATO { get; set; }
        public bool Tafsil_No1_VATO_Customer { get; set; }
        public bool Tafsil_No2_VATO_Customer { get; set; }
        public bool Tafsil_No3_VATO_Customer { get; set; }
        public bool Tafsil_No1_VATO_Store { get; set; }
        public bool Tafsil_No2_VATO_Store { get; set; }
        public bool Tafsil_No3_VATO_Store { get; set; }
        public bool Tafsil_No1_VATO_Merchs { get; set; }
        public bool Tafsil_No2_VATO_Merchs { get; set; }
        public bool Tafsil_No3_VATO_Merchs { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //amel foroosh
    public class Sales_Person
    {
        [Key]
        [Display(Name = "کد عامل")]
        public string Sales_Person_No { get; set; }
        [Display(Name = "نام عامل")]
        public string Sales_Person_Name { get; set; }
        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "کد تفصیلی 1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "کد تفصیلی 2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "کد تفصیلی 3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "درصد ویزیتوری")]
        public int Visitor_Prcnt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        // public virtual List<Sales_Person_FC> Sales_Person_FCs { get; set; }

    }
    // keraye haml hazine 
    public class Sales_Person_FC
    {
        [Display(Name = "کد عامل")]
        public string Sales_Person_No { get; set; }
        // public virtual Sales_Person Sales_Person { get; set; }
        [Display(Name = "منطقه")]
        public string Region { get; set; }
        [Display(Name = "هزینه حمل و نقل")]
        public string Freight_Charge { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //sanad foroosh
    public class Sales_Docs
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
        [Display(Name = "مد تفصیلی3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "شماره فاکتور")]
        public string Factor_No { get; set; }
        [Display(Name = "کد مرکز")]
        public string Center_No { get; set; }
        [Display(Name = "عامل فروش")]
        public string Sales_Person_No { get; set; }
        [Display(Name = "درصد تخفیف")]
        public int Discount_Prcnt { get; set; }
        [Display(Name = "تخفیف")]
        public decimal Discount { get; set; }
        [Display(Name = "اضافه سایر")]
        public decimal Extra_Charge { get; set; }
        [Display(Name = "کسر سایر")]
        public decimal Extra_Costs { get; set; }
        [Display(Name = "تجمیع عوارض")]
        public decimal Toll { get; set; }
        [Display(Name = "مالیات برارزش افزوده")]
        public decimal VAT { get; set; }
        [Display(Name = "روز تسویه")]
        public int Days_Settle { get; set; }
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        [Display(Name = "تعداد بسته ها")]
        public int Package_Qty { get; set; }
        [Display(Name = "نقدی")]
        public bool Cash { get; set; }
        [Display(Name = "اعتباری")]
        public bool Credit { get; set; }
        [Display(Name = "مبلغ نقدی")]
        public decimal Cash_Value { get; set; }
        [Display(Name = "مبلغ نقدی")]
        public decimal POS_Value { get; set; }
        [Display(Name = "حساب پایانه فروش")]
        public string Acc_No_Pos { get; set; }
        [Display(Name = "حساب تفصیلی پایانه فروش")]
        public string Tafsil_No_Pos { get; set; }
        [Display(Name = "شهرستان")]
        public bool County { get; set; }
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
        [Display(Name = "شماره درخواست خرید/کالا")]
        public string Purchase_No { get; set; }
        // public virtual Purchase_Orders Purchase_Orders { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        // public virtual Protocols Protocols { get; set; }
        [Display(Name = "شماره رسید موقت")]
        public string tmp_delv_No { get; set; }
        [Display(Name = "شماره رسید دایم")]
        public string prm_delv_No { get; set; }
        [Display(Name = "شماره تایید QC")]
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
        // public virtual List<Sales_Details> Sales_Details { get; set; }
    }
    public class Sales_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        // public virtual Sales_Docs Sales_Docs { get; set; }
        [Display(Name = "شماره سریال سند عطف")]
        public int ID_Ref { get; set; }
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "تفصیلی1")]
        public string Tafsil_No1 { get; set; }
        [Display(Name = "تفصیلی2")]
        public string Tafsil_No2 { get; set; }
        [Display(Name = "تفصیلی3")]
        public string Tafsil_No3 { get; set; }
        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        [Display(Name = "قیمت تمام شده")]
        public int Cost_Basis { get; set; }
        [Display(Name = "تعداد خرد موقت")]
        public int PreQty { get; set; }
        [Display(Name = "تعداد خرده")]
        public int Qty { get; set; }
        [Display(Name = "تعدا عمده")]
        public int MQty { get; set; }
        [Display(Name = "جمع ریال")]
        public decimal Total { get; set; }
        [Display(Name = "جمع")]
        public decimal TotalCB { get; set; }
        [Display(Name = "قیمت واقعی")]
        public decimal Price_Real { get; set; }
        [Display(Name = "قیمت برآوردی")]
        public decimal Price_Estimate { get; set; }
        [Display(Name = "قیمت استاندارد")]
        public decimal Price_Standard { get; set; }
        [Display(Name = "قیمت اصلاحی")]
        public decimal Price_Reviced { get; set; }
        [Display(Name = "جمع ریال واقعی")]
        public decimal Total_Real { get; set; }
        [Display(Name = "جمع برآوردی")]
        public decimal Total_Estimate { get; set; }
        [Display(Name = "جمع استاندارد")]
        public decimal Total_Standard { get; set; }
        [Display(Name = "جمع اصلاحی")]
        public decimal Total_Reviced { get; set; }
        [Display(Name = "موجودی ریالی")]
        public decimal Totals { get; set; }
        [Display(Name = "حسابداری انبار - عادی")]
        public bool Acc_Normal { get; set; }
        [Display(Name = "حسابداری انبار - واقعی")]
        public bool Acc_Real { get; set; }
        [Display(Name = "حسابداری انبار - برآوردی")]
        public bool Acc_Estimate { get; set; }
        [Display(Name = "حسابداری انبار - استاندارد")]
        public bool Acc_Standard { get; set; }
        [Display(Name = "حسابداری انبار - اصلاحی")]
        public bool Acc_Revised { get; set; }
        [Display(Name = "تاریخ عادی")]
        public string Acc_Normal_Date { get; set; }
        [Display(Name = "تاریخ واقعی")]
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
        [Display(Name = "شماره ارسالی/شماره دم")]
        public string Ersal_No { get; set; }
        [Display(Name ="شماره درخواست خرید/کالا")]
        public string Purchase_No { get; set; }
        // public virtual Purchase_Orders Purchase_Orders { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        // public virtual Protocols Protocols { get; set; }
        [Display(Name = "شماره بارنامه")]
        public string Trans_No { get; set; }
        [Display(Name = "شماره تبادل")]
        public string Tmp_Dlv_No { get; set; }
        [Display(Name = "تاریخ تبادل")]
        public string Tmp_Dlv_Date { get; set; }
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
        [Display(Name = "وصعیت سند")]
        public string Doc_Status { get; set; }
        [Display(Name = "نوع سند")]
        public string Doc_Type { get; set; }
        [Display(Name = "کد ظروف")]
        public string Plate_No { get; set; }
        [Display(Name = "سریال ظروف")]
        public string Plate_Serial { get; set; }
        public bool Confirm { get; set; }
        public bool Return { get; set; }
        public int ID_Link { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //zoroof konrol serial - roghan fale kharidim mikhahim khoordesh konim to tedadi zoroof
    public class Plates
    {
        [Key]
        [Display(Name = "کد ظرف")]
        public string Plate_No { get; set; }
        [Display(Name = "نام ظرف")]
        public string Plate_Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //delivery asnabd tahvil movaghat
    public class tmp_Delv_Docs
    {
        [Display(Name = "کد انبار")]
        public string Store_No { get; set; }
        [Key]
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        [Display(Name = "تاریخ سند")]
        public string SDoc_Date { get; set; }
        [Display(Name = "شرح سند")]
        public string SDoc_Desc { get; set; }
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
        [Display(Name = "توضیحات")]
        public string Notes { get; set; }
        [Display(Name = "تعدا بسته ها")]
        public int Package_Qty { get; set; }
        [Display(Name = "ثبت")]
        public bool Register { get; set; }
        [Display(Name = "شماره بارنامه")]
        public string Trans_No { get; set; }
        public string timeCreate { get; set; }
        public string timeUpdate { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        [Display(Name = "شماره درخواست خرید/کالا")]
        public string Purchase_No { get; set; }
        [Display(Name = "شماره قرارداد")]
        public string Protocol_No { get; set; }
        [Display(Name = "شماره رسید موقت")]
        public string tmp_delv_No { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        // public virtual List<tmp_Delv_Details> Tmp_Delv_Details { get; set; }
    }
    public class tmp_Delv_Details
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }
        [Display(Name = "شماره سند")]
        public string SDoc_No { get; set; }
        // public virtual tmp_Delv_Docs Tmp_Delv_Docs { get; set; }
        [Display(Name = "کد کالا")]
        public string Merch_No { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شرح ردیف")]
        public string Descr { get; set; }
        [Display(Name = "قیمت")]
        public decimal Price { get; set; }
        [Display(Name = "قیمت تمام شده کالا")]
        public decimal Cost_Basis { get; set; }
        [Display(Name = "تعداد خرده")]
        public int Qty { get; set; }
        [Display(Name = "تعداد عمده")]
        public int MQty { get; set; }
        [Display(Name = "کد فرعی")]
        public string Sub_Code { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    
}
