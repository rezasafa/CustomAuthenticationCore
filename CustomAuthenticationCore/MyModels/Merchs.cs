using Sepehr4Core.MyModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepehr4Core.MyModels.Merchs
{
    public class Merchs
    {
        [Key]
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }

        [Display(Name = "نام کالا")]
        public string Merch_Name { get; set; }

        [Display(Name = "نام لاتین")]
        public string LMerch_Name { get; set; }

        [Display(Name = "شماره فنی")]
        public string Technical_No { get; set; }

        [Display(Name = "شماره تامین کننده")]
        public string Supplier_No { get; set; }

        [Display(Name = "شماره فنی تغییر کرده به")]
        public string Technical_No_ChangedTo { get; set; }

        [Display(Name = "شماره تامین کننده تغییر کرده به")]
        public string Supplier_No_ChangedTo { get; set; }

        [Display(Name = "شماره فنی تغییر یافته از")]
        public string Technical_No_ChangedFrom { get; set; }

        [Display(Name = "شماره تامین کننده تغییر یافته از")]
        public string Supplier_No_ChangedFrom { get; set; }

        [Display(Name = "بارکد")]
        public string Barcode_No { get; set; }

        [Display(Name = "نوع کالا محصول")]
        public bool Merch_Type1 { get; set; }

        [Display(Name = "نوع کالا مواد")]
        public bool Merch_Type2 { get; set; }

        [Display(Name = "نوع کالا در جزیان ساخت")]
        public bool Merch_Type3 { get; set; }

        [Display(Name = "نوع کالا ملزومات")]
        public bool Merch_Type4 { get; set; }

        [Display(Name = "نوع کالا قطعات یدکی")]
        public bool Merch_Type5 { get; set; }

        [Display(Name = "خدمات")]
        public bool Merch_Type6 { get; set; }

        [Display(Name = "ابزار آلات")]
        public bool Merch_Type7 { get; set; }

        [Display(Name = "اموال")]
        public bool Merch_Type8 { get; set; }

        [Display(Name = "ضایعات")]
        public bool Merch_Type9 { get; set; }

        [Display(Name = "بسته بندی")]
        public bool Merch_Type10 { get; set; }

        [Display(Name = "کالای سرمایه ای")]
        public bool Merch_Sarmayeh { get; set; }

        [Display(Name = "کالای مصرفی")]
        public bool Merch_Masrafi { get; set; }

        [Display(Name = "تاریخ مصرفی")]
        public bool Merch_Expirable { get; set; }

        [Display(Name = "واحد شمارش خرده")]
        public string MinorUnit { get; set; }

        [Display(Name = "واحد شمارش عمده")]
        public string MajorUnit { get; set; }

        [Display(Name = "تسبت واحد عمده به خرده")]
        public int Major_Minor_Rate { get; set; }

        [Display(Name = "عمده به خرده رابطه دارد")]
        public bool Major_Minor_Related { get; set; }

        [Display(Name = "وزن")]
        public int Weight { get; set; }

        [Display(Name = "نوع بسته بندی")]
        public string Packing { get; set; }

        [Display(Name = "زمان تامین کالا")]
        public int LeadTime { get; set; }

        [Display(Name = "ذخیره احتیاطی")]
        public int SafetyStock { get; set; }

        [Display(Name = "تعداد  حداقل")]
        public int Min_Qty { get; set; }

        [Display(Name = "تعداد  حداکثر")]
        public int Max_Qty { get; set; }

        [Display(Name = "تعدا عادی")]
        public int Normal_Qty { get; set; }

        [Display(Name = "ذخیره احتیاطی")]
        public int Safety_Stock { get; set; }

        [Display(Name = "حداقل سفارش")]
        public int Batch_Qty { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price { get; set; }

        [Display(Name = "قیمت فروش نمایندگی")]
        public decimal Sales_Price_DealerNet { get; set; }

        [Display(Name = "قیمت خرید")]
        public decimal Purchase_Price { get; set; }

        [Display(Name = "قیمت خرید نمایندگی")]
        public decimal Purchase_Price_DealerNet { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price1 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price2 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price3 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price4 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price5 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price6 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price7 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price8 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price9 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price10 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price11 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price12 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price13 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price14 { get; set; }

        [Display(Name = "قیمت فروش")]
        public decimal Sales_Price15 { get; set; }

        [Display(Name = "آخرین قیمت خرید")]
        public decimal Last_Purchase_Price { get; set; }

        [Display(Name = "تاریخ آخرین قیمت خرید")]
        public string Last_Purchase_Date { get; set; }

        [Display(Name = "قیمت مصرف کننده")]
        public decimal Consumer_Price { get; set; }

        [Display(Name = "تعداد روز تسویه کالا")]
        public int Days_Settle { get; set; }

        [Display(Name = "درصد مالیات بر ارزش افزوده کالا")]
        public int VAT_Prcnt { get; set; }

        [Display(Name = "درصد عوارض کالا")]
        public int Toll_Prcnt { get; set; }

        [Display(Name = "محل در انبار")]
        public string Location { get; set; }

        [Display(Name = "آخرین کالا")]
        public bool Last_Merch { get; set; }

        [Display(Name = "قیمت تمام شده")]
        public decimal CostBasis { get; set; }

        [Display(Name = "تاریخ محاسبه قیمت تمام شده")]
        public string CostBasis_Date { get; set; }

        public bool Calc_Discount_Purchase { get; set; }
        public bool Calc_Discount_Sales { get; set; }
        public bool Calc_Discount_Person { get; set; }

        public int Discount_Purchase { get; set; }
        public int Discount_Sales { get; set; }
        public int Discount_Sales_DealerNet { get; set; }


        [Display(Name = "زمان استاندارد تولید")]
        public int Product_Time_Std { get; set; }

        [Display(Name = "زمان واقعی تولید")]
        public int Product_Time_Real { get; set; }

        [Display(Name = "بهای تمام شده تولید - استاندارد")]
        public decimal CostBasis_Std { get; set; }

        [Display(Name = "بهای تمام شده تولید - واقعی")]
        public decimal CostBasis_Real { get; set; }

        [Display(Name = "فعال")]
        public bool Active { get; set; }

        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }

        [Display(Name = "شماره حساب تفصیلی")]
        public string Tafsil_No1 { get; set; }

        [Display(Name = "شرح کالا")]
        public string Merch_Descr { get; set; }

        [Display(Name = "پرمصرف")]
        public bool FastMoving { get; set; }

        [Display(Name = "متوسط مصرف")]
        public bool NormalMoving { get; set; }

        [Display(Name = "کم مصرف")]
        public bool SlowMoving { get; set; }

        [Display(Name = "راکد")]
        public bool NoMoving { get; set; }

        [Display(Name = "موجودی کادکس ماه 1")]
        public int Qty1_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 2")]
        public int Qty2_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 3")]
        public int Qty3_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 4")]
        public int Qty4_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 5")]
        public int Qty5_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 6")]
        public int Qty6_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 7")]
        public int Qty7_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 8")]
        public int Qty8_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 9")]
        public int Qty9_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 10")]
        public int Qty10_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 11")]
        public int Qty11_Card { get; set; }

        [Display(Name = "موجودی کادکس ماه 12")]
        public int Qty12_Card { get; set; }

        [Display(Name = "موجودی عینی ماه 1")]
        public int Qty1 { get; set; }

        [Display(Name = "موجودی عینی ماه 2")]
        public int Qty2 { get; set; }

        [Display(Name = "موجودی عینی ماه 3")]
        public int Qty3 { get; set; }

        [Display(Name = "موجودی عینی ماه 4")]
        public int Qty4 { get; set; }

        [Display(Name = "موجودی عینی ماه 5")]
        public int Qty5 { get; set; }

        [Display(Name = "موجودی عینی ماه 6")]
        public int Qty6 { get; set; }

        [Display(Name = "موجودی عینی ماه 7")]
        public int Qty7 { get; set; }

        [Display(Name = "موجودی عینی ماه 8")]
        public int Qty8 { get; set; }

        [Display(Name = "موجودی عینی ماه 9")]
        public int Qty9 { get; set; }

        [Display(Name = "موجودی عینی ماه 10")]
        public int Qty10 { get; set; }

        [Display(Name = "موجودی عینی ماه 11")]
        public int Qty11 { get; set; }

        [Display(Name = "موجودی عینی ماه 12")]
        public int Qty12 { get; set; }

        [Display(Name = "موجودی عینی ماه 1 شمارش دوم")]
        public int Qty1_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 2 شمارش دوم")]
        public int Qty2_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 3 شمارش دوم")]
        public int Qty3_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 4 شمارش دوم")]
        public int Qty4_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 5 شمارش دوم")]
        public int Qty5_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 6 شمارش دوم")]
        public int Qty6_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 7 شمارش دوم")]
        public int Qty7_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 8 شمارش دوم")]
        public int Qty8_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 9 شمارش دوم")]
        public int Qty9_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 10 شمارش دوم")]
        public int Qty10_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 11 شمارش دوم")]
        public int Qty11_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 12 شمارش دوم")]
        public int Qty12_2 { get; set; }

        [Display(Name = "موجودی عینی ماه 1 شمارش سوم")]
        public int Qty1_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 2 شمارش سوم")]
        public int Qty2_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 3 شمارش سوم")]
        public int Qty3_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 4 شمارش سوم")]
        public int Qty4_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 5 شمارش سوم")]
        public int Qty5_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 6 شمارش سوم")]
        public int Qty6_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 7 شمارش سوم")]
        public int Qty7_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 8 شمارش سوم")]
        public int Qty8_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 9 شمارش سوم")]
        public int Qty9_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 10 شمارش سوم")]
        public int Qty10_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 11 شمارش سوم")]
        public int Qty11_3 { get; set; }

        [Display(Name = "موجودی عینی ماه 12 شمارش سوم")]
        public int Qty12_3 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // public virtual List<Merch_Tafsil> Merch_Tafsils { get; set; }
        // public virtual List<Merch_MemberG> Merch_MemberGs { get; set; }
        // public virtual List<Merch_LBL> Merch_LBLs { get; set; }
        // public virtual List<Merchs_Yearly_Monthly> Merchs_Yearly_Monthlies { get; set; }
        // public virtual List<Orders_Details> Orders_Details { get; set; }
        // public virtual List<BOM> BOMs { get; set; }
        // public virtual List<Proforma_Details> Proforma_Details { get; set; }
        // public virtual List<Purchase_Orders_Details> Purchase_Orders_Details { get; set; }
        // public virtual List<Sales_Details> Sales_Details { get; set; }
        // public virtual List<tmp_Delv_Details> Tmp_Delv_Details { get; set; }
        // public virtual List<Store_Details_BOM> Store_Details_BOMs { get; set; }
        // public virtual List<Store_Details> Store_Details { get; set; }
        // public virtual List<Store_Details_Master_BOM> Store_Details_Master_BOMs { get; set; }
        // public virtual List<Store_Details_Serials> Store_Details_Serials { get; set; }
        // public virtual List<StoreOutOrder_Details> StoreOutOrder_Details { get; set; }
    }
    public class Merch_Tafsil
    {
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }

        public string G_No { get; set; }
        // public virtual Tafsil_Group Tafsil_Group { get; set; }

        public string No_Tafsil { get; set; }
    }
    public class Merch_Descr
    {
        [Key]
        [Display(Name = "ردیف")]
        public int Row { get; set; }

        [Display(Name = "شرح")]
        public string Descr { get; set; }
    }
    public class MerchDiscount
    {
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }
        [Display(Name = "شماره حساب")]
        public string Acc_No { get; set; }
        [Display(Name = "کد تفصیلی")]
        public string Tafsil_No { get; set; }
        [Display(Name = "تخفیف خرید")]
        public int Discount_Purchase { get; set; }
        [Display(Name = "تخفیف فروش")]
        public int Discount_Sales { get; set; }
        [Display(Name = "تخفیف فروش نمایندگی")]
        public int Discount_Sales_DealerNet { get; set; }
        [Display(Name = "تخفیف نقدی")]
        public int Discount_Sales_Cash { get; set; }
        [Display(Name = "تخفیف ویژه")]
        public int Discount_Sales_Special { get; set; }
        [Key]
        public int ID { get; set; }
    }
    public class Merch_MemberG
    {
        [Display(Name = "ردیف")]
        public int Row { get; set; }

        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }

        [Key]
        [Display(Name = "گروه")]
        public string MG_No { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

    }
    public class Merch_LBL
    {
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }

        [Display(Name = "تعداد حداقل")]
        public int LBL_Qty { get; set; }

        public string Date_Print { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

    }
    public class Merchs_SalesPriceName
    {
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price1 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price2 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price3 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price4 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price5 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price6 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price7 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price8 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price9 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price10 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price11 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price12 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price13 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price14 { get; set; }
        [Display(Name = "نام قیمت فروش")]
        public string Sales_Price15 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    public class Merchs_Yearly_Monthly
    {
        [Display(Name = "کد کالا")]
        public string Merch_Code { get; set; }
        // public virtual Merchs Merchs { get; set; }

        [Display(Name = "نوع سند")]
        public int SDoc_Type { get; set; }

        [Display(Name = "تاریخ سند")]
        public string SDoc_Date { get; set; }

        [Display(Name = "تعداد")]
        public int MQty { get; set; }

        [Display(Name = "تعداد")]
        public int Qty { get; set; }

        [Display(Name = "قیمت")]
        public decimal Total { get; set; }

        [Display(Name = "بهای تمام شده")]
        public decimal TotalCB { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
    //derakht mahsool
    public class BOM
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
        [Display(Name = " موجودی بعد از اعمال ضریب مصرف")]
        public int Inv_Qty { get; set; }
        [Display(Name = "موجودی ست")]
        public int Inv_Set { get; set; }
        [Display(Name = "موجودی قایل تولید")]
        public int Inv_Pallate { get; set; }
        [Display(Name = "حداکثر اختلاف موجودی ست با موجودی")]
        public int Inv_Max { get; set; }
        [Display(Name = "تعداد کسری برای ست کردن")]
        public int Inv_Diff { get; set; }
        [Display(Name = "تعداد سفارش")]
        public int Order_Qty { get; set; }
        [Display(Name = "تعداد سند سفارش")]
        public string Order_No { get; set; }
        [Display(Name = "سطح سفارش کالا")]
        public int Order_No_Lvl { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
}
