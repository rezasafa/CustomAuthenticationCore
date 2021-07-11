using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sepehr4Core.BusinessLayer
{
    public class AccountSystem
    {
        public DataTable Get_InitAcc(string scon,string co, string y)
        {
            string query = "SELECT Acc_Levels,GL_Level, " +
                " Acc_Level1_Name,Acc_Level1_Len, " +
                " Acc_Level2_Name,Acc_Level2_Len, " +
                " Acc_Level3_Name,Acc_Level3_Len, " +
                " Acc_Level4_Name,Acc_Level4_Len, " +
                " Acc_Level5_Name,Acc_Level5_Len, " +
                " Acc_Level6_Name,Acc_Level6_Len, " +
                " Acc_Level7_Name,Acc_Level7_Len, " +
                " Acc_Level8_Name,Acc_Level8_Len, " +
                " Acc_Level9_Name,Acc_Level9_Len, " +
                " GAcc_Level1_Len,TAcc_Level1_Len, " +
                " GAcc_Level2_Len,TAcc_Level2_Len, " +
                " GAcc_Level3_Len,TAcc_Level3_Len, " +
                " GAcc_Level4_Len,TAcc_Level4_Len, " +
                " GAcc_Level5_Len,TAcc_Level5_Len, " +
                " GAcc_Level6_Len,TAcc_Level6_Len, " +
                " GAcc_Level7_Len,TAcc_Level7_Len, " +
                " GAcc_Level8_Len,TAcc_Level8_Len, " +
                " GAcc_Level9_Len,TAcc_Level9_Len, " +
                " Tafsil_Len,GTafsil_Len " +
                " FROM InitAcc";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Account(string scon,string co, string y, string Wheres)
        {
            string query = "SELECT * FROM Accounts " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Tafsil(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT * FROM Tafsil " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Acc_Tafsil(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT Acc_No,G_No,No_Tafsil FROM Acc_Tafsil " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Get_New_Doc_No(string scon,string co , string y)
        {
            string query = "" +
                " SELECT dbo.fn_Get_New_Doc_No() ";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public DataTable Get_Doc_Type(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT * FROM Doc_Type " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Documents(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT * FROM Documents " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Journal(string scon, string co, string y, string Wheres)
        {
            string query = " SELECT J.[Row] " +
                            "    ,J.[Doc_No] " +
                            "    ,J.[Acc_No] " +
                            "    ,A.[Acc_Name] " +
                            "    ,J.[Tafsil1] " +
                            "    ,J.[Tafsil2] " +
                            "    ,J.[Tafsil3] " +
                            "    ,J.[Descr] " +
                            "    ,J.[Debit] " +
                            "    ,J.[Credit] " +
                            "    ,J.[Sales_Doc_No] " +
                            "    ,J.[SDoc_No] " +
                            "    ,J.[PDoc_No] " +
                            "    ,J.[RDoc_No] " +
                            "    ,J.[Sub_Type] " +
                            "    ,J.[Control] " +
                            "    ,J.[Settle] " +
                            "    ,J.[Currency_Price] " +
                            "    ,J.[Currency_Type] " +
                            "    ,J.[Currency_Symbol] " +
                            "    ,J.[Currency_Rate] " +
                            "    ,J.[DescrL] " +
                            "    ,J.[Company_Code] " +
                            "    ,J.[Flag] " +
                            "    ,J.[Hidden] " +
                            "    ,J.[Qty] " +
                            "    ,J.[Price] " +
                            "    ,J.[Follow_Date] " +
                            "    ,J.[Follow_No] " +
                            "    ,J.[Follow_Descr] " +
                            "    ,J.[ID_Link] " +
                            "    ,J.[ID] " +
                            " FROM[dbo].[Journal] J " +
                            " LEFT JOIN Accounts A ON J.Acc_No = A.Acc_No " +
                            " " + Wheres +
                            " ORDER BY J.[Row]";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_TafsilName(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT Tafsil_Name FROM Tafsil " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_AccName(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT Acc_Name FROM Accounts " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_AccNo(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT Acc_No FROM Accounts " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        
        public DataTable Get_DocList(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT D.Doc_No, DT.Doc_Type_Name, D.Doc_Date, D.Doc_Desc, D.Controler, D.Confirm, D.Register, D.ID FROM Doc_Type AS DT INNER JOIN Documents AS D ON DT.Doc_Type = D.Doc_type " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Del_Journal(string scon, string co, string y, string Wheres,
            string user_log,string from_log,string status_log,string desc_log)
        {
            var query = " DELETE FROM Journal " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Delete_Document(string scon, string co, string y, string Wheres,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var query = " DELETE FROM Documents " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public DataTable Get_CurrencyType(string scon, string co, string y, string Wheres)
        {
            string query = " SELECT * FROM Currency_Table " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Tafsil_Group(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT * FROM Tafsil_Group " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Get_NewTafsilGroup(string scon, string co, string y)
        {
            var dt = new DataTable();
            var query = "";
            query = "" +
                " SELECT [dbo].[get_NewTafsilGroup]()";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public DataTable Get_DocDesc(string scon, string co, string y, string Wheres)
        {
            var query = " SELECT [Row] ,[Descr]  FROM [Doc_Descr] " + Wheres + " ORDER BY [Descr]";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_MerchDesc(string scon, string co, string y, string Wheres)
        {
            var query = " SELECT [Row] ,[Descr]  FROM [Merch_Descr] " + Wheres + " ORDER BY [Descr]";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_DocumentsManager(string scon, string co, string y, string Wheres)
        {
            string query = " EXEC sp_GetDocList @Wheres = '" + Wheres + "' ";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_DocumentsManager_Sum(string scon, string co, string y, string Wheres)
        {
            string query = " EXEC sp_GetSumDocList @Wheres = '" + Wheres + "' ";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Get_TurnOverAcc(string scon,string co, string y, string Acc_No)
        {
            var dt = new DataTable();
            var query = " SELECT ISNULL([SumDebit],0) [SumDebit] , ISNULL([SumCredit],0) [SumCredit] , ISNULL([Rem],0) [Rem] FROM [dbo].[get_TurnOver]('" + Acc_No + "') ";

            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            dt = db.GetRecords(db.Get_ConnectionString(), query);

            string str = "{\"SumDebit\":\"" + dt.Rows[0][0].ToString() + "\",\"SumCredit\":\"" + dt.Rows[0][1].ToString() + "\",\"Rem\":\"" + dt.Rows[0][2].ToString() + "\"}";
            return str.ToLower();
        }

        public string Get_CheckTurnOverAcc(string scon,string co, string y, string Acc_No)
        {
            var dt = new DataTable();
            var query = " SELECT DBO.[CheckTurnOverAcc]('" + Acc_No + "') [Checked] ";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            string str = "{\"Checked\":" + dt.Rows[0][0].ToString() + "}";
            return str.ToLower();
        }

        public string Delete_Account(string scon,string co, string y, string Acc_No)
        {
            var dt = new DataTable();
            var query = "" +
                " IF NOT EXISTS( " +
                " 				SELECT  " +
                " 					* " +
                " 				FROM Documents D " +
                " 					LEFT JOIN Journal J ON D.Doc_No = J.Doc_No " +
                " 				WHERE (1=1) " +
                " 						AND J.Acc_No LIKE '" + Acc_No + "%' " +
                " 						AND D.Controler = 1 " +
                " 				) " +
                " 				BEGIN " +
                " 					DELETE " +
                " 					from Accounts  " +
                " 					WHERE Acc_No LIKE'" + Acc_No + "%' " +
                " 				END " +
                " SELECT @@ROWCOUNT  ";

            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            dt= db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public string Get_CheckNextLevelAcc(string scon,string co, string y, string Acc_No)
        {
            var dt = new DataTable();
            var query = " SELECT DBO.[CheckNextLevelAcc]('" + Acc_No + "') [Checked] ";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            string str = "{\"Checked\":\"" + dt.Rows[0][0].ToString() + "\"}";
            return str;
        }

        public string Insert_AccTafsil(string scon, string co, string y, string Acc_No, string G_No, string No_Tafsil, 
            string user_log,string from_log,string status_log,string desc_log)
        {
            var dt = new DataTable();
            string query = "" +
                " INSERT INTO  [dbo].[Acc_Tafsil] ([Acc_No],[G_No],[No_Tafsil]) " +
                "     VALUES " +
                "     (N'" + Acc_No + "',N'" + G_No + "'," + No_Tafsil + ") ";

            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Delete_AccTafsil(string scon, string co, string y, string Acc_No, string G_No, string No_Tafsil,
             string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            string query = "" +
                " DELETE FROM [dbo].[Acc_Tafsil] " +
                " WHERE  " +
                "     [Acc_No] = N'" + Acc_No + "' AND " +
                "     [G_No] = N'" + G_No + "' AND " +
                "     [No_Tafsil] = " + No_Tafsil + " ";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Get_Acc_No_Level(string scon, string co, string y, string Acc_No)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " SELECT [dbo].[fn_get_Level_Acc_No]('" + Acc_No + "')";

            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public string Delete_Tafsil_TurnOver(string scon, string co, string y, string Tafsil_No, string open_close_close,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            var occ = "";
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            
            if (bool.Parse(open_close_close) == true)
                occ = "      "; //AND D.Doc_Type IN(2,3,4)
            else
                occ = "     AND D.Doc_Type NOT IN(2,3,4) ";

            var query = " DELETE " +
                " J " +
                " FROM Journal J " +
                " LEFT JOIN Documents D ON J.Doc_No = D.Doc_No " +
                " WHERE (1 = 1) " +
                "       AND (J.Tafsil1 = N'" + Tafsil_No + "' OR J.Tafsil2 = N'" + Tafsil_No + "' OR J.Tafsil3 = N'" + Tafsil_No + "')" +
                occ;

            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
            //return dt.Rows[0][0].ToString();
        }

        public DataTable Get_Doc_Nos(string scon, string co, string y, string docno)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC dbo.sp_getDoc_Nos @CurrentDoc_No = '" + docno + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Journal_Rem(string scon, string co, string y, string docno)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "SELECT SUM(Debit) AS [SumDebit],SUM(Credit) AS [SumCredit],(SUM(Debit) - SUM(Credit)) AS [Rem] FROM Journal WHERE Doc_No = '" + docno + "'";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Import_Document(string scon, string co, string y, string Doc_No, string Doc_Date, string Doc_Desc,
            string Controler, string Confirm, string Register, string Doc_type, string Sub_type, string timeCreate,
            string timeUpdate, string UserCreate, string UserUpdate, string Notes, string Attach, string Doc_DateL,
            string Doc_DescL, string Company_Code, string Flag, string ID_Link, string ID, string Insert,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var id = "";
            var dt = new DataTable();
            var query = "";

            if (Insert == "true")
            {
                Doc_No = Get_New_Doc_No(scon, co, y);
                //insert
                query = "";
                query = " INSERT INTO Documents (Doc_No,Doc_Date,Doc_Desc,Controler,Confirm,Register,Doc_type,Sub_type,UserUpdate,Notes,Attach,Doc_DateL,Doc_DescL,Company_Code,Flag,ID_Link) " +
                    " VALUES (" +
                        "N'" + Doc_No + "'," +
                        "N'" + Doc_Date + "'," +
                        "N'" + Doc_Desc + "'," +
                        "N'" + Controler + "'," +
                        "N'" + Confirm + "'," +
                        "N'" + Register + "'," +
                        "" + Doc_type + "," +
                        "" + Sub_type + "," +
                        "N''," +
                        "N'" + Notes + "'," +
                        "N'" + Attach + "'," +
                        "N'" + Doc_DateL + "'," +
                        "N'" + Doc_DescL + "'," +
                        "N'" + Company_Code + "'," +
                        "N'" + Flag + "'," +
                        "" + ID +
                    ")";
                var Result = db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
                if (Result == "OK")
                {
                    dt = db.GetRecords(db.Get_ConnectionString(), " SELECT ID FROM Documents WHERE Doc_No = N'" + Doc_No + "'");
                    id = dt.Rows[0][0].ToString();
                    string str = "{\"result\":\"" + Result + "\",\"doc_no\":\"" + Doc_No + "\",\"id\":" + id + "}";
                    return str;
                }
                else
                {
                    string str = "{\"result\":\"" + Result + "\",\"doc_no\":\"0\",\"id\":0}";
                    return str;
                }
            }
            else
            {
                //update
                //" Doc_No    = N'" + Doc_No + "'," +
                query = "";
                query = " UPDATE Documents SET " +

                        " Doc_Date  = N'" + Doc_Date + "'," +
                        " Doc_Desc  = N'" + Doc_Desc + "'," +
                        " Controler = N'" + Controler + "'," +
                        " Confirm   = N'" + Confirm + "'," +
                        " Register  = N'" + Register + "'," +
                        " Doc_type  =   " + Doc_type + "," +
                        " Sub_type  =   " + Doc_type + "," +
                        " Notes     = N'" + Notes + "'," +
                        " Attach    = N'" + Attach + "'," +
                        " Doc_DateL = N'" + Doc_DateL + "'," +
                        " Doc_DescL = N'" + Doc_DescL + "'," +
                        " Company_Code = N'" + Company_Code + "'," +
                        " ID_Link   =   " + ID + "," +
                        " Flag      = N'" + Flag + "' WHERE ID_Link = " + ID + "";
                var Result = db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
                return Result;
            }
        }

        public string Import_Journal(string scon, string co, string y, string Row, string Doc_No, string Acc_No,
            string Tafsil1, string Tafsil2, string Tafsil3, string Descr, string Debit, string Credit, string Sales_Doc_No,
            string SDoc_No, string PDoc_No, string RDoc_No, string Sub_Type, string Control, string Settle,
            string Currency_Price, string Currency_Type, string Currency_Symbol, string Currency_Rate, string DescrL,
            string Company_Code, string Flag, string Hidden, string Qty, string Price, string Follow_Date,
            string Follow_No, string Follow_Descr, string ID_Link, string ID, string Insert,
            string user_log, string from_log, string status_log, string desc_log)
        {

            if (Tafsil1 == "")
                Tafsil1 = "null";
            else
                Tafsil1 = "N'" + Tafsil1 + "'";

            if (Tafsil2 == "")
                Tafsil2 = "null";
            else
                Tafsil2 = "N'" + Tafsil2 + "'";

            if (Tafsil3 == "")
                Tafsil3 = "null";
            else
                Tafsil3 = "N'" + Tafsil3 + "'";

            var query = "";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;

            if (Insert == "false")
            {
                //update
                query = "";
                query = " UPDATE Journal SET " +
                    " Acc_No = N'" + Acc_No + "'" +
                    ",Tafsil1 = " + Tafsil1 + "" +
                    ",Tafsil2 = " + Tafsil2 + "" +
                    ",Tafsil3 = " + Tafsil3 + "" +
                    ",Descr = N'" + Descr + "'" +
                    ",Debit = " + Debit + "" +
                    ",Credit = " + Credit + "" +
                    ",Sales_Doc_No = N'" + Sales_Doc_No + "'" +
                    ",SDoc_No = N'" + SDoc_No + "'" +
                    ",PDoc_No = N'" + PDoc_No + "'" +
                    ",RDoc_No = N'" + RDoc_No + "'" +
                    ",Sub_Type = " + Sub_Type + "" +
                    ",Control = N'" + Control + "'" +
                    ",Settle = N'" + Settle + "'" +
                    ",Currency_Price = " + Currency_Price + "" +
                    ",Currency_Type = N'" + Currency_Type + "'" +
                    ",Currency_Symbol = N'" + Currency_Symbol + "'" +
                    ",Currency_Rate = " + Currency_Rate + "" +
                    ",DescrL = N'" + DescrL + "'" +
                    ",Company_Code = N'" + Company_Code + "'" +
                    ",Flag = N'" + Flag + "' " +
                    ",Hidden = N'" + Hidden + "'" +
                    ",Qty = " + Qty + "" +
                    ",Price = " + Price + "" +
                    ",Follow_Date = N'" + Follow_Date + "'" +
                    ",Follow_No = N'" + Follow_No + "'" +
                    ",Follow_Descr = N'" + Follow_Descr + "'" +
                    ",ID_Link = " + ID_Link + "" +
                    " WHERE (ID_Link = " + ID + ")  ";
                //Doc_No = N'" + Doc_No + "' AND 
                var Result = db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
                return Result;
            }
            else
            {
                //query = " SELECT * FROM Journal WHERE (Doc_No =N'" + Doc_No + "' AND Row = " + Row + ") ";
                //var dt = new DataTable();
                //dt = db.GetRecords(db.Get_ConnectionString(), query);
                //if (dt.Rows.Count > 0)
                //{
                //    query = " UPDATE Journal SET [Row] = [Row] + 1  WHERE (Doc_No = N'" + Doc_No + "' AND [Row] >= " + Row + ") ";
                //    db.DoCommand(db.Get_ConnectionString(), query);
                //}
                var dt = db.GetRecords(db.Get_ConnectionString(), " SELECT ISNULL(MAX([ROW]),0)+1 FROM Journal WHERE Doc_No = N'" + Doc_No + "'");
                Row = dt.Rows[0][0].ToString();
                //insert
                query = "";
                query = " INSERT INTO Journal (Row,Doc_No,Acc_No,Tafsil1,Tafsil2,Tafsil3,Descr,Debit,Credit,"+
                    "Sales_Doc_No,SDoc_No,PDoc_No,RDoc_No,Sub_Type,Control,Settle,Currency_Price,Currency_Type,"+
                    "Currency_Symbol,Currency_Rate,DescrL,Company_Code,Flag,Hidden,Qty,Price,Follow_Date,"+
                    "Follow_No,Follow_Descr,ID_Link) " +
                    " VALUES (" +
                    "" + Row + "," +
                    "N'" + Doc_No + "'," +
                    "N'" + Acc_No + "'," +
                    "" + Tafsil1 + "," +
                    "" + Tafsil2 + "," +
                    "" + Tafsil3 + "," +
                    "N'" + Descr + "'," +
                    "" + Debit + "," +
                    "" + Credit + "," +
                    "N'" + Sales_Doc_No+ "',"+
                    "N'" + SDoc_No + "',"+
                    "N'" + PDoc_No + "'," +
                    "N'" + RDoc_No + "'," +
                    "" + Sub_Type + ","+
                    "N'" + Control + "'," +
                    "N'"  + Settle + "',"+
                    ""  + Currency_Price + ","+ 
                    "N'" + Currency_Type + "',"+
                    "N'" + Currency_Symbol + "',"+
                    "" + Currency_Rate + ","+
                    "N'" + DescrL+ "',"+
                    "N'" + Company_Code+ "',"+
                    "N'" + Flag + "'," +
                    "N'" + Hidden + "',"+ 
                    "" + Qty + ","+
                    "" + Price + ","+
                    "N'" + Follow_Date+ "'," +
                    "N'" + Follow_No + "',"+
                    "N'" + Follow_Descr + "'," +
                    "" + ID +""+
                    ")";
                var Result = db.DoCommand(db.Get_ConnectionString(), query
                    , user_log, from_log, status_log, desc_log);
                if (Result == "OK")
                {
                    Sort_Row(scon, co, y, Doc_No, "row"
                        , user_log, from_log, status_log, desc_log);
                    return "OK";
                }
                else
                {
                    return Result;
                }
            }
        }

        public DataTable Search_Documents(string scon, string co, string y,
            string Doc_No, string ID, string AzDoc_Date, string TaDoc_Date, string AzDoc_DateL, string TaDoc_DateL,
            string Doc_Desc, string Doc_DescL, string Notes, string Attach, string Acc_No, string Acc_Name,
            string Tafsil1, string TafsilName1, string Tafsil2, string TafsilName2, string Tafsil3, string TafsilName3,
            string DocType, string Artickle_Descr, string AzDebit, string TaDebit, string AzCredit, string TaCredit,
            string Controler, string Confirm, string Register, string Flag
            )
        {
            var wheres = "";
            if (Doc_No != "")
                wheres += "  AND D.Doc_No LIKE N'%" + Doc_No + "%' ";
            if (ID != "")
                wheres += "  AND D.ID LIKE N'%" + ID + "%' ";

            if (AzDoc_Date != "" && TaDoc_Date != "") 
                wheres += "  AND D.Doc_Date BETWEEN N'" + AzDoc_Date + "' AND N'" + TaDoc_Date + "' ";
            if (AzDoc_Date != "" && TaDoc_Date == "")
                wheres += "  AND D.Doc_Date LIKE N'%" + AzDoc_Date + "%' ";
            if (AzDoc_Date == "" && TaDoc_Date != "")
                wheres += "  AND D.Doc_Date LIKE N'%" + TaDoc_Date + "%' ";

            if (AzDoc_DateL != "" && TaDoc_DateL != "")
                wheres += "  AND D.Doc_DateL BETWEEN N'" + AzDoc_DateL + "' AND N'" + TaDoc_DateL + "' ";
            if (AzDoc_DateL != "" && TaDoc_DateL == "")
                wheres += "  AND D.Doc_DateL LIKE N'%" + AzDoc_DateL + "%' ";
            if (AzDoc_DateL == "" && TaDoc_DateL != "")
                wheres += "  AND D.Doc_DateL LIKE N'%" + TaDoc_DateL + "%' ";

            if (Doc_Desc != "")
                wheres += "  AND D.Doc_Desc LIKE N'%" + Doc_Desc + "%' ";
            if (Doc_DescL != "")
                wheres += "  AND D.Doc_DescL LIKE N'%" + Doc_DescL + "%' ";
            if (Notes != "")
                wheres += "  AND D.Notes LIKE N'%" + Notes + "%' ";
            if (Attach != "")
                wheres += "  AND D.Attach LIKE N'%" + Attach + "%' ";

            if (Acc_No != "")
                wheres += "  AND J.Acc_No LIKE N'%" + Acc_No + "%' ";
            //if (Acc_Name != "" && Acc_Name != "-1")
            //    wheres += "  AND A.Acc_Name LIKE N'%" + Acc_Name +"%'";

            if (Tafsil1 != "")
                wheres += "  AND J.Tafsil1 LIKE N'%" + Tafsil1 + "%'";
            if (Tafsil2 != "")
                wheres += "  AND J.Tafsil2 LIKE N'%" + Tafsil2 + "%'";
            if (Tafsil3 != "")
                wheres += "  AND J.Tafsil3 LIKE N'%" + Tafsil3 + "%'";

            //if (TafsilName1 != "" && TafsilName1 != "-1")
            //    wheres += "  AND T1.Tafsil_Name LIKE N'%" + TafsilName1 + "%'";
            //if (TafsilName2 != "" && TafsilName2 != "-1")
            //    wheres += "  AND T2.Tafsil_Name LIKE N'%" + TafsilName2 + "%'";
            //if (TafsilName3 != "" && TafsilName3 != "-1")
            //    wheres += "  AND T3.Tafsil_Name LIKE N'%" + TafsilName3 + "%'";

            if (DocType != "" && DocType != "-1")
                wheres += "  AND D.Doc_Type = " + DocType +  " ";

            if (Artickle_Descr != "")
                wheres += "  AND J.Descr LIKE N'%" + Artickle_Descr + "%' ";

            if (AzDebit != "" && TaDebit != "")
                wheres += "  AND J.Debit BETWEEN " + AzDebit + " AND " + TaDebit + " ";
            if (AzDebit != "" && TaDebit == "")
                wheres += "  AND J.Debit LIKE '%" + AzDebit + "%' ";
            if (AzDebit == "" && TaDebit != "")
                wheres += "  AND J.Debit LIKE '%" + TaDebit + "%' ";

            if (AzCredit != "" && TaCredit != "")
                wheres += "  AND J.Credit BETWEEN " + AzCredit + " AND " + TaCredit + " ";
            if (AzCredit != "" && TaCredit == "")
                wheres += "  AND J.Credit LIKE '%" + AzCredit + "%' ";
            if (AzCredit == "" && TaCredit != "")
                wheres += "  AND J.Credit LIKE '%" + TaCredit + "%' ";

            if (bool.Parse(Controler))
                wheres += "  AND D.Controler = 1 ";
            if (bool.Parse(Confirm))
                wheres += "  AND D.Confirm = 1 ";
            if (bool.Parse(Register))
                wheres += "  AND D.Register = 1 ";
            if (bool.Parse(Flag))
                wheres += "  AND D.Flag = 1 ";

            var query = "" +
            " SELECT " +
            "        D.Controler, " +
            "        D.Confirm, " +
            "        D.Register, " +
            "        D.Doc_No, " +
            "        D.Doc_Date, " +
            "        D.ID, " +
            "        ISNULL(D.Doc_Desc,'') Doc_Desc, " +
            "        ISNULL(SUM(J.Debit),0) SumDebit, " +
            "        ISNULL(SUM(J.Credit),0) SumCredit, " +
            "        D.Flag, " +
            "        ISNULL(D.[Attach],'') [Attach] " +
            " FROM Documents D   " +
            " LEFT JOIN Journal  J  ON D.Doc_No  = J.Doc_No " +
            " LEFT JOIN Accounts A  ON J.Acc_No  = A.Acc_No " +
            " LEFT JOIN Tafsil   T1 ON J.Tafsil1 = T1.Tafsil_No " +
            " LEFT JOIN Tafsil   T2 ON J.Tafsil2 = T2.Tafsil_No " +
            " LEFT JOIN Tafsil   T3 ON J.Tafsil3 = T3.Tafsil_No " +
            " WHERE (1=1) " +
            "  " + wheres +
            " GROUP BY " +
            "        D.Controler, " +
            "        D.Confirm, " +
            "        D.Register, " +
            "        D.Doc_No, " +
            "        D.Doc_Date, " +
            "        D.ID, " +
            "        D.Doc_Desc, " +
            "        D.Flag, " +
            "        D.[Attach] " +
            " ORDER BY " +
            "       Doc_No ";
            
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Insert_Document(string scon, string co, string y,
            string Doc_Date, string Doc_Desc, string Doc_type, string Notes, string Attach,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var Doc_No = "";
            var id = "";
            var dt = new DataTable();
            var query = "";
            Doc_No = Get_New_Doc_No(scon, co, y);

            //insert
            query = "";
            query = " INSERT INTO Documents (Doc_No,Doc_Date,Doc_Desc,Controler,Confirm,Register,Doc_type,Sub_type,UserUpdate,Notes,Attach,Doc_DateL,Doc_DescL,Company_Code,Flag,ID_Link) " +
                " VALUES (" +
                    "N'" + Doc_No + "'," +
                    "N'" + Doc_Date + "'," +
                    "N'" + Doc_Desc + "'," +
                    "0," +
                    "0," +
                    "0," +
                    "" + Doc_type + "," +
                    "0," +
                    "N''," +
                    "N'" + Notes + "'," +
                    "N'" + Attach + "'," +
                    "N''," +
                    "N''," +
                    "N''," +
                    "0," +
                    "0" +
                ")";

            var Result = db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
            if (Result == "OK")
            {
                dt = db.GetRecords(db.Get_ConnectionString(), " SELECT ID FROM Documents WHERE Doc_No = N'" + Doc_No + "'");
                id = dt.Rows[0][0].ToString();
                string str = "{\"result\":\"" + Result + "\",\"doc_no\":\"" + Doc_No + "\",\"id\":" + id + "}";
                return str;
            }
            else
            {
                string str = "{\"result\":\"" + Result + "\",\"doc_no\":\"0\",\"id\":0}";
                return str;
            }


        }

        public string Insert_DocumentSample(string scon, string co, string y, 
            string Doc_No, string DocSampleName,
            string user_log,string from_log,string status_log,string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC  [dbo].[sp_Add_DocSample] " +
                "       @Doc_Nos     = N'" + Doc_No + "', " +
                "       @Name_Sample = N'" + DocSampleName + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Insert_DocumentSampleToJournal(string scon, string co, string y, 
            string Doc_No, string Doc_No_Sample,
            string user_log,string from_log,string status_log,string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC	[dbo].[sp_AddSampleToJournal] " +
                "       @Doc_No_Sample = '" + Doc_No_Sample + "', " +
                "       @Doc_No        = '" + Doc_No + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Transfer_DocumentNo(string scon, string co, string y,
            string Doc_No, string New_Doc_No,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC	[dbo].[sp_Transfer_Document] " +
                "       @Doc_No     = '" + Doc_No + "'," +
                "       @New_Doc_No = '" + New_Doc_No + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Copy_DocumentNo(string scon, string co, string y,
             string Doc_No, string New_Doc_No,
             string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC	[dbo].[sp_Copy_Document] " +
                "       @Doc_No     = '" + Doc_No + "'," +
                "       @New_Doc_No = '" + New_Doc_No + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Merge_DocumentNo(string scon, string co, string y,
                     string Doc_No_Source, string Doc_No_Destination,
                     string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC	[dbo].[sp_Merge_Document] " +
                "       @Doc_No_Source      = '" + Doc_No_Source + "'," +
                "       @Doc_No_Destination = '" + Doc_No_Destination + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Sort_DocumentNo(string scon, string co, string y, string ORDER_BY,
            string user_log, string from_log, string status_log, string desc_log)
        {
            //ORDER_by = doc_date or id
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC	[dbo].[sp_Sort_Document] " +
                "       @ORDER_BY        = '" + ORDER_BY + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Insert_DocumentNo(string scon, string co, string y, string Doc_No,
            string user_log,string  from_log, string status_log,string desc_log)
        {
            //insert document from document management
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " EXEC	[dbo].[sp_Insert_Document] " +
                "       @Doc_No        = '" + Doc_No + "'";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public DataTable Get_Doument_Sample(string scon, string co, string y)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " SELECT * FROM Documents_Sample ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Update_Document(string scon, string co, string y,
            string Doc_No, string Doc_Date, string Doc_Desc, string Controler, string Confirm, string Register,
            string Doc_type, string Notes, string Attach, string Flag,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var dt = new DataTable();
            var query = "";
            var ctrl = 0;
            var conf = 0;
            var reg = 0;
            var flg = 0;
            if (Flag == "true")
            {
                flg = 1;
            }
            if (Register == "true")
            {
                reg = 1;
            }
            if (Confirm == "true")
            {
                conf = 1;
            }
            else
            {
                reg = 0;
            }
            if (Controler == "true")
            {
                ctrl = 1;
            }
            else
            {
                conf = 0;
                reg = 0;
            }

            //update
            query = "";
            query = " UPDATE Documents SET " +
                    " Doc_No    = N'" + Doc_No + "'," +
                    " Doc_Date  = N'" + Doc_Date + "'," +
                    " Doc_Desc  = N'" + Doc_Desc + "'," +
                    " Controler = " + ctrl + "," +
                    " Confirm   = " + conf + "," +
                    " Register  = " + reg + "," +
                    " Doc_type  = " + Doc_type + "," +
                    " Notes     = N'" + Notes + "'," +
                    " Attach    = N'" + Attach + "'," +
                    " Flag      = " + flg + " WHERE Doc_No = N'" + Doc_No + "'";

            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }


        public string Save_Journal(string scon, string co, string y,
            string docno, string row, string accno, string t1, string t2, string t3,
            string desc, string deb, string cre, string cont, string flag, string Insert,
            string user_log, string from_log, string status_log, string desc_log)
        {
            if (flag == "false")
                flag = "0";
            else
                flag = "1";
            if (cont == "false")
                cont = "0";
            else
                cont = "1";

            if (t1 == "")
                t1 = "null";
            else
                t1 = "'" + t1 + "'";

            if (t2 == "")
                t2 = "null";
            else
                t2 = "'" + t2 + "'";

            if (t3 == "")
                t3 = "null";
            else
                t3 = "'" + t3 + "'";

            var query = "";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;

            if (Insert == "false")
            {
                //update
                query = "";
                query = " UPDATE Journal SET Acc_No = N'" + accno + "'" +
                    ",Tafsil1 = " + t1 + ",Tafsil2 = " + t2 + ",Tafsil3 = " + t3 + "" +
                    ",Descr = N'" + desc + "',Debit = " + deb + ",Credit = " + cre + " " +
                    ",Control = " + cont + ",Flag = " + flag + " " +
                    " WHERE (Doc_No = N'" + docno + "' AND Row = " + row + ")  ";
                
                return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
            }
            else
            {
                //query = " SELECT * FROM Journal WHERE (Doc_No =N'" + docno + "' AND Row = " + row + ") ";
                //var dt = new DataTable();
                //dt = db.GetRecords(db.Get_ConnectionString(), query);
                //if (dt.Rows.Count > 0)
                //{
                //    query = " UPDATE Journal SET [Row] = [Row] + 1  WHERE (Doc_No = N'" + docno + "' AND [Row] >= " + row + ") ";
                //    db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
                //}
                //insert
                query = "";
                query = " INSERT INTO Journal (Row,Doc_No,Acc_No,Tafsil1,Tafsil2,Tafsil3,Descr,Debit,Credit,Control,Flag) " +
                    " VALUES (" +
                    "" + row + "," +
                    "N'" + docno + "'," +
                    "N'" + accno + "'," +
                    "" + t1 + "," +
                    "" + t2 + "," +
                    "" + t3 + "," +
                    "N'" + desc + "'," +
                    "" + deb + "," +
                    "" + cre + "," +
                    "" + cont + "," +
                    "" + flag + "" +
                    ")";
                var Result = db.DoCommand(db.Get_ConnectionString(), query
                    , user_log, from_log, status_log, desc_log);
                if (Result == "OK")
                {
                    Sort_Row(scon, co, y, docno, "row"
                        , user_log, from_log, status_log, desc_log);
                    return "OK";
                }
                else
                {
                    return Result;
                }
            }
        }

        public string Sort_Row(string scon, string co, string y,
            string docno, string type,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var sort = "";
            var query = "";

            //if (type == "row") sort = " ORDER BY Row ";
            //if (type == "debcre") sort = " ORDER BY Debit ";
            //if (type == "desc") sort = " ORDER BY Descr ";
            if (type == "row") sort = " [Row] ";
            if (type == "debcre") sort = "[Debit],[Credit] ";
            if (type == "desc") sort = " [Descr] ";

            query = " SELECT * FROM Journal WHERE (Doc_No IN(" + docno + ")) ";// + sort;
            dt = db.GetRecords(db.Get_ConnectionString(), query);

            if (dt.Rows.Count > 0)
            {
                var res = "";
                query = "" +
                    "EXEC	[dbo].[sp_Sort_ROW] " +
                    "       @Doc_No =  N'" + docno + "', " +
                    "       @SortType = N'" + sort + "' ";
                res = db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
                if (res != "OK")
                {
                    return res;
                }
                //for (int i = 1; i <= dt.Rows.Count; i++)
                //{
                //    query = "UPDATE Journal SET Row = " + i + " WHERE Doc_No= N'" + docno + "' AND Row = " + dt.Rows[i - 1]["Row"].ToString();
                //    res = db.DoCommand(db.Get_ConnectionString(), query);
                //    if (res != "OK")
                //    {
                //        return res;
                //    }
                //}
                return res;
            }
            else
            {
                return "OK";
            }

        }

        public DataTable Get_Sarfasl_Acc(string scon, string co, string y, string Acc_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " SELECT  [dbo].[get_Sarfasl_Acc]('" + Acc_No + "') AS [ReturnVal] ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        
        public DataTable Get_Artickle_Info(string scon, string co, string y, string docno, string row)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " SELECT                                  " +
                            "	 ISNULL([Sarfasl],'') [Sarfasl],      " +
                            "	 ISNULL([Acc_Name],'') [Acc_Name],    " +
                            "	 ISNULL([Tafsil1],'') [Tafsil1],      " +
                            "	 ISNULL([Tafsil2],'') [Tafsil2],      " +
                            "	 ISNULL([Tafsil3],'') [Tafsil3]       " +
                            " FROM dbo.get_Artickle_Info ('" + docno + "'," + row + ")  ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        
        public string CheckRowNumber(string scon, string co, string y, string docno, string row)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " SELECT * FROM Journal WHERE (Doc_No = N'" + docno + "' AND Row = " + row + ") ";
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            if (dt.Rows.Count > 0)
            {
                //find
                return "true";
            }
            else
            {
                //not find
                return "false";
            }
        }

        public string Get_DocumentsManager_Update(string scon, string co, string y, 
            string Wheres, string Cols,
            string user_log,string from_log,string status_log,string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC [dbo].[sp_GetUpdateDocList] @Wheres = '" + Wheres + "' ,@Cols = ' " + Cols + " ' ";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Insert_TafsilGroup(string scon, string co, string y, string G_No, string G_Name, string People, string Cos,
            string Cashes, string Banks, string CostCenters, string ProfitCenters, string Merchs, string Personal,
            string Visitors, string Others,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " INSERT INTO Tafsil_Group (G_No,G_Name,People,[Cos],Cashes,Banks,CostCenters,ProfitCenters,Merchs,Personal,Visitors,Others) " +
                " VALUES (" +
                "N'" + G_No + "'," +
                "N'" + G_Name + "'," +
                "'" + People + "'," +
                "'" + Cos + "'," +
                "'" + Cashes + "'," +
                "'" + Banks + "'," +
                "'" + CostCenters + "'," +
                "'" + ProfitCenters + "'," +
                "'" + Merchs + "'," +
                "'" + Personal + "'," +
                "'" + Visitors + "'," +
                "'" + Others + "'" +
                ")";

            return db.DoCommand(db.Get_ConnectionString(), query,
                user_log, from_log, status_log, desc_log);
        }

        public string Update_TafsilGroup(string scon, string co, string y, string Old_G_No, string G_No, string G_Name, string People, string Cos,
            string Cashes, string Banks, string CostCenters, string ProfitCenters, string Merchs, string Personal,
            string Visitors, string Others,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " UPDATE Tafsil_Group SET " +
                " G_No = N'" + G_No + "'," +
                " G_Name = N'" + G_Name + "'," +
                " People = '" + People + "'," +
                " [Cos] = '" + Cos + "'," +
                " Cashes = '" + Cashes + "'," +
                " Banks = '" + Banks + "'," +
                " CostCenters = '" + CostCenters + "'," +
                " ProfitCenters = '" + ProfitCenters + "'," +
                " Merchs = '" + Merchs + "'," +
                " Personal = '" + Personal + "'," +
                " Visitors = '" + Visitors + "'," +
                " Others = '" + Others + "'" +
                " WHERE G_No = N'" + Old_G_No + "'";

            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Insert_Tafsil(string scon, string co, string y,
            string G_No, string Tafsil_No, string Tafsil_Name, string LTafsil_Name,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " INSERT INTO [dbo].[Tafsil] " +
                "           ([G_No] " +
                "           ,[Tafsil_No] " +
                "           ,[Tafsil_Name] " +
                "           ,[LTafsil_Name] ) " +
                "     VALUES " +
                "           ('" + G_No + "'" +
                "           ,N'" + Tafsil_No + "'" +
                "           ,N'" + Tafsil_Name + "'" +
                "           ,N'" + LTafsil_Name + "')";

            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Update_Tafsil(string scon, string co, string y,
            string G_No, string Old_Tafsil_No, string Tafsil_No, string Tafsil_Name, string LTafsil_Name,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " UPDATE Tafsil  SET " +
                "            [G_No] = '" + G_No + "'" +
                "           ,[Tafsil_No] = N'" + Tafsil_No + "'" +
                "           ,[Tafsil_Name] = N'" + Tafsil_Name + "'" +
                "           ,[LTafsil_Name] = N'" + LTafsil_Name + "'" +
                " WHERE Tafsil_No = N'" + Old_Tafsil_No + "'";

            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Change_Tafsil_Code(string scon, string co, string y,
            string Old_Tafsil_No, string New_Tafsil_No, string G_No, string replaces,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "";
            var r = false;
            r = bool.Parse(replaces);
            if(r == true)
            {
                query = "" +
                " UPDATE Journal SET Tafsil1 = '" + New_Tafsil_No + "' WHERE Tafsil1 = '" + Old_Tafsil_No + "' " +
                " UPDATE Journal SET Tafsil2 = '" + New_Tafsil_No + "' WHERE Tafsil2 = '" + Old_Tafsil_No + "' " +
                " UPDATE Journal SET Tafsil3 = '" + New_Tafsil_No + "' WHERE Tafsil3 = '" + Old_Tafsil_No + "' " +
                " DELETE FROM Tafsil WHERE Tafsil_No = N'" + Old_Tafsil_No + "' ";
            }
            else
            {
                query = " UPDATE Tafsil  SET " +
                        "             [G_No] = '" + G_No + "'" +
                        "            ,[Tafsil_No] = N'" + New_Tafsil_No + "'" +
                        " WHERE Tafsil_No = N'" + Old_Tafsil_No + "'";
            }
            
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Update_Tafsil_Info(string scon, string co, string y, string Tafsil_No
            , string Title, string First_Name, string Last_Name, string Job_Title, string Company, string Economic_Code, string National_Code
            , string National_ID, string Info, string State, string City, string Town, string Region, string post_Address, string post_Address2, string LState
            , string LCity, string LTown, string Lpost_Address, string Postal_Code, string Postal_Code2, string Email, string Tel_No1, string Tel_No2
            , string Tel_No3, string Tel_No4, string Fax_No, string Password, string Mobile_no, string MaxCredit, string Orf_Month, string Discount_Prcnt
            , string DealerNet, string Sales_Price_No, string Visitor, string Visitor_Prcnt, string Transporter, string Freight_Charge
            , string County, string Tehran, string Bazar, string Shoosh, string Active, string Acc_Currency, string Currency_Type, string Followup
            , string Rem_Debit, string Rem_Credit, string Rem_Debit_All, string Rem_Credit_All, string RemAcc, string NotMatureRecvDocs
            , string ReturnedRecvDocs, string TotalSales, string RemCredit, string BankCard_No, string Sheba_No
            , string Purchase_Sys, string Sales_Sys
            , string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " UPDATE Tafsil  SET " +
                "            [Title] = N'" + Title + "'" +
                "           ,[First_Name] = N'" + First_Name + "'" +
                "           ,[Last_Name] = N'" + Last_Name + "'" +
                "           ,[Job_Title] = N'" + Job_Title + "'" +
                "           ,[Company] = N'" + Company + "'" +
                "           ,[Economic_Code] = N'" + Economic_Code + "'" +
                "           ,[National_Code] = N'" + National_Code + "'" +
                "           ,[Info] = N'" + Info + "'" +
                "           ,[State] = N'" + State + "'" +
                "           ,[City] = N'" + City + "'" +
                "           ,[Town] = N'" + Town + "'" +
                "           ,[Region] = N'" + Region + "'" +
                "           ,[post_Address] = N'" + post_Address + "'" +
                "           ,[post_Address2] = N'" + post_Address2 + "'" +
                "           ,[LState] = N'" + LState + "'" +
                "           ,[LCity] = N'" + LCity + "'" +
                "           ,[LTown] = N'" + LTown + "'" +
                "           ,[Lpost_Address] = N'" + Lpost_Address + "'" +
                "           ,[Postal_Code] = N'" + Postal_Code + "'" +
                "           ,[Postal_Code2] = N'" + Postal_Code2 + "'" +
                "           ,[Email] = N'" + Email + "'" +
                "           ,[Tel_No1] = N'" + Tel_No1 + "'" +
                "           ,[Tel_No2] = N'" + Tel_No2 + "'" +
                "           ,[Tel_No3] = N'" + Tel_No3 + "'" +
                "           ,[Tel_No4] = N'" + Tel_No4 + "'" +
                "           ,[Fax_No]  = N'" + Fax_No + "'" +
                "           ,[Password]  = N'" + Password + "'" +
                "           ,[Mobile_no] = N'" + Mobile_no + "'" +
                "           ,[MaxCredit] =  " + MaxCredit + "" +
                "           ,[Orf_Month] =  " + Orf_Month + "" +
                "           ,[Discount_Prcnt] = " + Discount_Prcnt + "" +
                "           ,[DealerNet] = '" + DealerNet + "'" +
                "           ,[Sales_Price_No] = " + Sales_Price_No + "" +
                "           ,[Visitor] = '" + Visitor + "'" +
                "           ,[Visitor_Prcnt] = " + Visitor_Prcnt + "" +
                "           ,[Transporter] = N'" + Transporter + "'" +
                "           ,[Freight_Charge] = " + Freight_Charge + "" +
                "           ,[County] = '" + County + "'" +
                "           ,[Tehran] = '" + Tehran + "'" +
                "           ,[Bazar]  = '" + Bazar + "'" +
                "           ,[Shoosh] = '" + Shoosh + "'" +
                "           ,[Active] = '" + Active + "'" +
                "           ,[Acc_Currency] = '" + Acc_Currency + "'" +
                "           ,[Currency_Type] = N'" + Currency_Type + "'" +
                "           ,[Followup] = N'" + Followup + "'" +
                "           ,[Rem_Debit]      = '" + Rem_Debit + "'" +
                "           ,[Rem_Credit]     = '" + Rem_Credit + "'" +
                "           ,[Rem_Debit_All]  = '" + Rem_Debit_All + "'" +
                "           ,[Rem_Credit_All] = '" + Rem_Credit_All + "'" +
                "           ,[RemAcc] = " + RemAcc + "" +
                "           ,[NotMatureRecvDocs] = " + NotMatureRecvDocs + "" +
                "           ,[ReturnedRecvDocs] = " + ReturnedRecvDocs + "" +
                "           ,[TotalSales] = " + TotalSales + "" +
                "           ,[RemCredit] = " + RemCredit + "" +
                "           ,[BankCard_No] = N'" + BankCard_No + "'" +
                "           ,[Sheba_No] = N'" + Sheba_No + "'" +
                "           ,[Purchase_Sys] = '" + Purchase_Sys + "'" +
                "           ,[Sales_Sys] = '" + Sales_Sys + "'" +
                " WHERE Tafsil_No = N'" + Tafsil_No + "'";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Insert_Account(string scon, string co, string y, string Acc_No, string Acc_Name, string LAcc_Name, string Notes, string CurrentLevel)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC [dbo].[InsertAccount] @Acc_No = N'" + Acc_No + "',@Acc_Name = N'" + Acc_Name + "',@LAcc_Name = N'" + LAcc_Name + "',@Notes = N'" + Notes + "',@Level = " + CurrentLevel + "  ";

            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public string Update_Accounts(string scon, string co, string y, string old_AccNo,
            string Acc_No, string Acc_Name, string LAcc_Name, string Cash, string POS, string Sales, string ReturnSales, string Purchase, string ReturnPurchase, string Revenue, string Expense,
            string Bank, string InBank, string Other_Revenue, string Other_Expense, string Sales_Discount, string Purchase_Discount, string Purchase_Variance, string Consume_Variance,
            string Customer, string Visitor, string Receivable_Acc, string Receivable_Return_Acc, string Payable_Acc, string Product_Acc, string Raw_Acc, string InProgress_Acc,
            string Supplies_Acc, string Parts_Acc, string Tools_Acc, string Asset_Acc, string Pert_Acc, string Packing_Acc, string Deposit_Other_Acc, string Open_Acc,
            string Close_Acc, string Loss_Profit, string Cost_Basis, string Cost_BasisP, string CostsProduct,
            string Tolls, string Tolls_Cost, string VAT, string VATP, string Profit_Ghesti, string Last_Acc, string Rem_Debit, string Rem_Credit, string Rem_Debit_All, string Rem_Credit_All,
            string Balance, string LoseProfit, string Other, string Active, string Acc_Store, string Acc_Sales, string Acc_PayRecv, string Acc_PayRoll, string Acc_Currency,
            string Followup, string Currency_Type, string Notes,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "UPDATE [dbo].[Accounts]" +
                    "   SET [Acc_No] = N'" + Acc_No + "' " +
                    "      ,[Acc_Name] = N'" + Acc_Name + "' " +
                    "      ,[LAcc_Name] = N'" + LAcc_Name + "'" +
                    "      ,[Cash] = '" + Cash + "'" +
                    "      ,[POS] = '" + POS + "'" +
                    "      ,[Sales] = '" + Sales + "'" +
                    "      ,[ReturnSales] = '" + ReturnSales + "'" +
                    "      ,[Purchase] = '" + Purchase + "'" +
                    "      ,[ReturnPurchase] = '" + ReturnPurchase + "'" +
                    "      ,[Revenue] = '" + Revenue + "'" +
                    "      ,[Expense] = '" + Expense + "'" +
                    "      ,[Bank] = '" + Bank + "'" +
                    "      ,[InBank] = '" + InBank + "'" +
                    "      ,[Other_Revenue] = '" + Other_Revenue + "'" +
                    "      ,[Other_Expense] = '" + Other_Expense + "'" +
                    "      ,[Sales_Discount] = '" + Sales_Discount + "'" +
                    "      ,[Purchase_Discount] = '" + Purchase_Discount + "'" +
                    "      ,[Purchase_Variance] = '" + Purchase_Variance + "'" +
                    "      ,[Consume_Variance] = '" + Consume_Variance + "'" +
                    "      ,[Customer] = '" + Customer + "'" +
                    "      ,[Visitor] = '" + Visitor + "'" +
                    "      ,[Receivable_Acc] = '" + Receivable_Acc + "'" +
                    "      ,[Receivable_Return_Acc] = '" + Receivable_Return_Acc + "'" +
                    "      ,[Payable_Acc] = '" + Payable_Acc + "'" +
                    "      ,[Product_Acc] = '" + Product_Acc + "'" +
                    "      ,[Raw_Acc] = '" + Raw_Acc + "'" +
                    "      ,[InProgress_Acc] = '" + InProgress_Acc + "'" +
                    "      ,[Supplies_Acc] = '" + Supplies_Acc + "'" +
                    "      ,[Parts_Acc] = '" + Parts_Acc + "'" +
                    "      ,[Tools_Acc] = '" + Tools_Acc + "'" +
                    "      ,[Asset_Acc] = '" + Asset_Acc + "'" +
                    "      ,[Pert_Acc] = '" + Pert_Acc + "'" +
                    "      ,[Packing_Acc] = '" + Packing_Acc + "'" +
                    "      ,[Deposit_Other_Acc] = '" + Deposit_Other_Acc + "'" +
                    "      ,[Open_Acc] = '" + Open_Acc + "'" +
                    "      ,[Close_Acc] = '" + Close_Acc + "'" +
                    "      ,[Loss_Profit] = '" + Loss_Profit + "'" +
                    "      ,[Cost_Basis] = '" + Cost_Basis + "'" +
                    "      ,[Cost_BasisP] = '" + Cost_BasisP + "'" +
                    "      ,[CostsProduct] = '" + CostsProduct + "'" +
                    "      ,[Tolls] = '" + Tolls + "'" +
                    "      ,[Tolls_Cost] = '" + Tolls_Cost + "'" +
                    "      ,[VAT] = '" + VAT + "'" +
                    "      ,[VATP] = '" + VATP + "'" +
                    "      ,[Profit_Ghesti] = '" + Profit_Ghesti + "'" +
                    "      ,[Last_Acc] = '" + Last_Acc + "'" +
                    "      ,[Rem_Debit] = '" + Rem_Debit + "'" +
                    "      ,[Rem_Credit] = '" + Rem_Credit + "'" +
                    "      ,[Rem_Debit_All] = '" + Rem_Debit_All + "'" +
                    "      ,[Rem_Credit_All] = '" + Rem_Credit_All + "'" +
                    "      ,[Balance] = '" + Balance + "'" +
                    "      ,[LoseProfit] = '" + LoseProfit + "'" +
                    "      ,[Other] = '" + Other + "'" +
                    "      ,[Followup] = N'" + Followup + "'" +
                    "      ,[Active] = '" + Active + "'" +
                    "      ,[Acc_Store] = '" + Acc_Store + "'" +
                    "      ,[Acc_Sales] = '" + Acc_Sales + "'" +
                    "      ,[Acc_PayRecv] = '" + Acc_PayRecv + "'" +
                    "      ,[Acc_PayRoll] = '" + Acc_PayRoll + "'" +
                    "      ,[Acc_Currency] = '" + Acc_Currency + "'" +
                    "      ,[Currency_Type] = N'" + Currency_Type + "'" +
                    "      ,[Notes] = N'" + Notes + "'" +
                    " WHERE Acc_No = N'" + old_AccNo + "'";
            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public DataTable Get_AccountInLevel(string scon, string co, string y, string AccNo, string Level)
        {
            string query = "" +
                " EXEC	[dbo].[getAccountsLevels] " +
                "    @AccNo = '" + AccNo + "', " +
                "    @Level = " + Level;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Get_NewAccount(string scon, string co, string y, string Acc_No, string CurrentLevel)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " SELECT [dbo].[get_NewAccount](" + CurrentLevel + ",'" + Acc_No + "') ";

            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public string Delete_Tafsil_Group(string scon, string co, string y, string G_No,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " DELETE FROM Tafsil_Group " +
                " WHERE G_No = N'" + G_No + "'";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Get_NewTafsil(string scon, string co, string y, string G_No)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " SELECT [dbo].[get_NewTafsil]('" + G_No + "')";

            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }

        public string Get_CheckTurnOverGNO(string scon, string co, string y, string G_No)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " SELECT DBO.[CheckTurnOverGNO]('" + G_No + "') [Checked] ";

            dt = db.GetRecords(db.Get_ConnectionString(), query);
            string str = "{\"Checked\":" + dt.Rows[0][0].ToString() + "}";
            return str;
        }

        public string Delete_Tafsil(string scon, string co, string y, string Tafsil_No,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " DELETE FROM Tafsil " +
                " WHERE Tafsil_No = N'" + Tafsil_No + "'";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Get_CheckTurnOverTafsil(string scon, string co, string y, string Tafsil_No)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "";
            query = " SELECT DBO.[CheckTurnOverTafsil]('" + Tafsil_No + "') [Checked] ";
            
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            string str = "{\"Checked\":" + dt.Rows[0][0].ToString() + "}";
            return str;
        }

        public string Insert_DocDescr(string scon, string co, string y, string Descr,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " INSERT INTO [dbo].[Doc_Descr] " +
                "           ([Descr]) " +
                "     VALUES " +
                "           (N'" + Descr + "')";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Insert_MerchDescr(string scon, string co, string y, string Descr,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " INSERT INTO [dbo].[Merch_Descr] " +
                "           ([Descr]) " +
                "     VALUES " +
                "           (N'" + Descr + "')";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Update_DocDescr(string scon, string co, string y, string Row, string Descr,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " UPDATE [dbo].[Doc_Descr] SET " +
                "           [Descr] = N'" + Descr + "'" +
                "     WHERE " +
                "           [Row] = " + Row + "";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Update_MerchDescr(string scon, string co, string y, string Row, string Descr,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " UPDATE [dbo].[Merch_Descr] SET " +
                "           [Descr] = N'" + Descr + "'" +
                "     WHERE " +
                "           [Row] = " + Row + "";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Delete_DocDescr(string scon, string co, string y, string Row,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " DELETE FROM  [dbo].[Doc_Descr] " +
                "     WHERE " +
                "           [Row] = " + Row + "";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public string Delete_MerchDescr(string scon, string co, string y, string Row,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " DELETE FROM  [dbo].[Merch_Descr] " +
                "     WHERE " +
                "           [Row] = " + Row + "";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }


        public string Set_un_Flag(string scon, string co, string y,
            string ID, string Flag,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " UPDATE Journal Set " +
                "       [Flag]     = " + Flag + " " +
                " WHERE ID = " + ID + " ";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Set_un_Settle(string scon, string co, string y,
            string ID, string Settle,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " UPDATE Journal Set " +
                "       [Settle]     = " + Settle + " " +
                " WHERE ID = " + ID + " ";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Set_un_Hidden(string scon, string co, string y,
            string ID, string Hidden,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " UPDATE Journal Set " +
                "       [Hidden]     = " + Hidden + " " +
                " WHERE ID = " + ID + " ";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public string Set_un_Follow(string scon, string co, string y,
            string ID, string Follow_Date, string Follow_No, string Follow_Descr,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var db = new mydb(); //Follow_Date,Follow_No,Follow_Descr
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = "" +
                " UPDATE Journal Set " +
                "       [Follow_Date]  = '" + Follow_Date + "' ," +
                "       [Follow_No]    = '" + Follow_No + "' ," +
                "       [Follow_Descr] = '" + Follow_Descr + "' " +
                " WHERE ID = " + ID + " ";
            return db.DoCommand(db.Get_ConnectionString(), query, user_log, from_log, status_log, desc_log);
        }

        public DataTable Get_JournalsAcc(string scon, string co, string y, string Conditions, string Acc_No, string CTRL, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC  DBO.sp_JournalsAcc @Conditions = '" + Conditions + "',@ACC_NO = '" + Acc_No + "' ,@CTRL = '" + CTRL + "',@TAFSIL_NO = '" + Tafsil_No + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsAccRem(string scon, string co, string y, string Conditions, string Acc_No, string CTRL, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC  DBO.sp_JournalsAcc_Rem @Conditions = '" + Conditions + "',@ACC_NO = '" + Acc_No + "' ,@CTRL = '" + CTRL + "',@TAFSIL_NO = '" + Tafsil_No + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Acc_Nos(string scon, string co, string y, string Level,string Acc_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC [dbo].[sp_getAcc_Nos] @Level = " + Level + " , @Acc_No = N'" + Acc_No + "'";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
                
        public DataTable Get_Tafsil_Nos(string scon, string co, string y, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC [dbo].[sp_getTafsil_Nos] @Tafsil_No = '" + Tafsil_No + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsTafsil(string scon, string co, string y, string Conditions, string Acc_No, string LenAcc_No, string CTRL, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC  DBO.sp_JournalsTafsil @Conditions = '" + Conditions + "',@Acc_No = '" + Acc_No + "' ,@LenACC_NO = '" + LenAcc_No + "' ,@CTRL = '" + CTRL + "',@TAFSIL_NO = '" + Tafsil_No + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsTafsil_Acc(string scon, string co, string y, string Tafsil_No,string Acc_Len)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC	[dbo].[sp_JournalsTafsil_Acc] @Tafsil_No = N'" + Tafsil_No + "',@Acc_Len = " + Acc_Len;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsTafsil_Tafsil1(string scon, string co, string y, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC	[dbo].[sp_JournalsTafsil_Tafsil1] @Tafsil_No = N'" + Tafsil_No + "'";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsTafsil_Tafsil2(string scon, string co, string y, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC	[dbo].[sp_JournalsTafsil_Tafsil2] @Tafsil_No = N'" + Tafsil_No + "'";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsTafsil_Tafsil3(string scon, string co, string y, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC	[dbo].[sp_JournalsTafsil_Tafsil3] @Tafsil_No = N'" + Tafsil_No + "'";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalsTafsilRem(string scon, string co, string y, string Conditions, string Acc_No, string LenAcc_No, string CTRL, string Tafsil_No)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC  DBO.sp_JournalsTafsil_Rem @Conditions = '" + Conditions + "',@Acc_No = '" + Acc_No + "' ,@LenACC_NO = '" + LenAcc_No + "' ,@CTRL = '" + CTRL + "',@TAFSIL_NO = '" + Tafsil_No + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_DividendTafsil(string scon, string co,string y, string Conditions,string startAcc,string endAcc,string Len)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC   [dbo].[sp_Dividend_Tafsil] "+ 
                           "        @Conditions = '" + Conditions + "'," +
                           "        @Az_Acc = '" + startAcc + "' ," +
                           "        @Ta_Acc = '" + endAcc + "' , " +
                           "        @Len = '" + Len + "'";

            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_DocListManagerErorr(string scon,string co, string y)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
                "SELECT  " +
                "	Controler, " +
                "	Confirm, " +
                "	Register, " +
                "	Doc_No, " +
                "	Doc_Date, " +
                "	ID, " +
                "	Doc_Desc, " +
                "	[SUM_Debit], " +
                "	[SUM_Credit], " +
                "	[REM], " +
                "	Flag, " +
                "	[Attach], " +
                "	[Last_Acc], " +
                "	[Tafsil1], " +
                "	[Tafsil2], " +
                "	[Tafsil3], " +
                "	[Desc], " +
                "	[DebitCredit] " +
                "FROM  fn_DocListManager() " +
                "	ORDER BY  " +
                "		Doc_No ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_DocListManagerError(string scon, string co, string y, string Doc_Nos,string CheckType)
        {
            var type = "";
            var err = "";
            switch (CheckType)
            {
                case "ctrl":
                    type = " 	Controler = 1  ";
                    err = " 	AND Controler = 0  ";
                    break;
                case "conf":
                    type = " 	Confirm = 1  ";
                    err = "  AND Controler = 1	AND Confirm = 0  ";
                    break;
                case "rgst":
                    type = " 	Register = 1  ";
                    err = "  AND Controler = 1	AND Confirm = 1  AND Register = 0  ";
                    break;
                case "unctrl":
                    type = " 	Controler = 0  ";
                    err = " 	AND Controler = 1  ";
                    break;
                case "unconf":
                    type = " 	Confirm = 0  ";
                    err = "  AND Controler = 1	AND Confirm = 1  ";
                    break;
                case "unrgst":
                    type = " 	Register = 0  ";
                    err = "  AND Controler = 1	AND Confirm = 1  AND Register = 1  ";
                    break;
            }
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
                " UPDATE Documents SET  " +
                type +
                " WHERE Doc_No IN ( " +
                " 					SELECT Doc_No  " +
                " 					FROM fn_DocListManager() " +
                " 					WHERE (1 = 1)  " +
                " 						AND Doc_No IN (" + Doc_Nos + ")  " +
                err +
                " 						AND REM = 0  " +
                " 						AND Last_Acc= '' " +
                " 						AND Tafsil1 = '' " +
                " 						AND Tafsil2 = '' " +
                " 						AND Tafsil3 = '' " +
                " 						AND [Desc] = '' " +
                " 						AND [DebitCredit] = '' " +
                " 					) " +
                " SELECT * " +
                " FROM fn_DocListManager() " +
                " WHERE (1 = 1) " +
                " 	    AND Doc_No IN (" + Doc_Nos + ")  " + err;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_DocsListManagerError(string scon, string co, string y, string Condition)
        {
            //" EXEC sp_DocsCheckControl @Condition = ' WHERE D.DOC_NO IN(''00001'',''00002'')';";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
                " EXEC sp_DocsCheckControl @Condition = ' WHERE D.Doc_No IN (" + Condition + ") ';";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_DocListManager(string scon, string co, string y,string Conditions)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
                " SELECT " +
                " 	D.Controler, " +
                " 	D.Confirm, " +
                " 	D.Register, " +
                " 	D.Doc_No, " +
                " 	D.Doc_Date, " +
                " 	D.ID, " +
                " 	ISNULL(D.Doc_Desc,'') Doc_Desc, " +
                " 	SUM(ISNULL(J.Debit,0)) [SUM_Debit], " +
                " 	SUM(ISNULL(J.Credit,0)) [SUM_Credit], " +
                " 	D.Flag, " +
                " 	ISNULL(D.[Attach],'')[Attach] " +
                " FROM Documents D " +
                " 	LEFT JOIN Journal J ON D.Doc_No = J.Doc_No " +
                " WHERE (1 = 1) " + Conditions + 
                " GROUP BY  " +
                " 	D.Controler, " +
                " 	D.Confirm, " +
                " 	D.Register, " +
                " 	D.Doc_No, " +
                " 	D.Doc_Date, " +
                " 	D.ID, " +
                " 	D.Doc_Desc, " +
                " 	D.Flag, " +
                " 	D.[Attach] " +
                " ORDER BY  " +
                "   D.Doc_No ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_BalanceSheet(string scon, string co, string y, string Level, string Hiarchical, string AccLevel, 
            string CurrentLevel, string azDate, string taDate, string azDoc, string taDoc,
            string azAcc,string taAcc)
        {
            bool SelseleMarateb = bool.Parse(Hiarchical);
            int iLevel = Int32.Parse(Level);
            int iAccLevel = Int32.Parse(AccLevel);
            int iCurrentLevel = Int32.Parse(CurrentLevel);
            string az = "";
            string ta = "";
            string DD = "";//Date Doc
            string condition = "";
            string sm = "=";

            if (!String.IsNullOrEmpty(azAcc) || !String.IsNullOrEmpty(taAcc))
            {
                if(azAcc != "" && taAcc != "")
                {
                    condition += " AND bs.Acc_No BETWEEN '" + azAcc + "' AND '" + taAcc + "' ";
                }
                if (azAcc != "" && taAcc == "")
                {
                    condition += " AND bs.Acc_No = '" + azAcc + "'";
                }
                if (azAcc == "" && taAcc != "")
                {
                    condition += " AND bs.Acc_No = '" + taAcc + "'";
                }
            }

            if (SelseleMarateb == true) { sm = "<="; }

            if (azDate != "")
            {
                az = azDate;
                ta = taDate;
                DD = "Date";
            }
            else
            {
                az = azDoc;
                ta = taDoc;
                DD = "Doc";
            }

            if (iLevel - 1 != 0) 
            {
                Level = (iLevel - 1).ToString();
            }

            if(iCurrentLevel > 9)
            {
                switch (iCurrentLevel)
                {
                    case 10:
                        condition += " AND Len(bs.Acc_No) " + sm + " (SELECT (GTafsil_Len + Tafsil_Len)*1 AS [LenTafsil]  FROM InitAcc) AND TafsilNo <= '1' ";
                        break;
                    case 11:
                        if (SelseleMarateb)
                        {
                            condition += " AND Len(bs.Acc_No) " + sm + " (SELECT (GTafsil_Len + Tafsil_Len)*2 AS [LenTafsil]  FROM InitAcc) AND TafsilNo <= '2' ";
                        }
                        else
                        {
                            condition += " AND Len(bs.Acc_No) BETWEEN (SELECT (GTafsil_Len + Tafsil_Len)*1 AS [LenTafsil]  FROM InitAcc) AND (SELECT (GTafsil_Len + Tafsil_Len)*2 AS [LenTafsil]  FROM InitAcc) AND TafsilNo <= '2' ";
                        }
                        break;
                    case 12:
                        if (SelseleMarateb)
                        {
                            condition += " AND Len(bs.Acc_No) " + sm + " (SELECT (GTafsil_Len + Tafsil_Len)*3 AS [LenTafsil]  FROM InitAcc) AND TafsilNo <= '3' ";
                        }
                        else
                        {
                            condition += " AND Len(bs.Acc_No) BETWEEN (SELECT (GTafsil_Len + Tafsil_Len)*1 AS [LenTafsil]  FROM InitAcc) AND (SELECT (GTafsil_Len + Tafsil_Len)*3 AS [LenTafsil]  FROM InitAcc) AND TafsilNo <= '3' ";
                        }
                        break;
                }
            }
            else
            {
                condition += " AND Len(bs.Acc_No) " + sm + "  (SELECT GAcc_Level" + Level + "_Len FROM InitAcc) ";
            }

            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
            " SELECT  " +
            "     bs.Acc_No  AS [Acc_No], " +
            "     AccNo      AS [AccNo], " +
            "     bs.Acc_Name AS [Acc_Name], " +
            "     Tafsil , " +
            "     TafsilNo ,  " +
            "     FirstRemDebit  AS [FirstRemDebit],  " +
            "     FirstRemCredit AS [FirstRemCredit], " +
            "     SumDebit       AS [SumDebit],  " +
            "     SumCredit      AS [SumCredit], " +
            "     RemDebit       AS [RemDebit],  " +
            "     RemCredit      AS [RemCredit], " +
            "     FirstRemDebit+SumDebit   AS [FirstRemDebitSumDebit],  " +
            "     FirstRemCredit+SumCredit AS [FirstRemCreditSumCredit],  " +
            "     RemDebitFinal  AS [RemDebitFinal],  " +
            "     RemCreditFinal AS [RemCreditFinal], " +
            "     SumQty         AS [SumQty]  " +
            " FROM fn_BalanceSheet_" + DD + "(N'" + az +"',N'" + ta + "') BS " +
            "     INNER JOIN Accounts A ON bs.AccNo = A.Acc_No  " +
            " WHERE (1=1) " +
            "     " + condition + " " +
            " ORDER BY bs.Acc_No ";

            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_JournalBook(string scon,string co,string y,string Condition)
        {
            // Documents D - Journals J - Tafsil T1,T2,T3
            
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
            " EXEC sp_Get_Journal @WHERE = '" + Condition + "' ";

            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_JournalBook_Main(string scon,string co,string y,string Condition)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " " +
            " DECLARE @GLEN AS INT = (SELECT GAcc_Level1_Len FROM InitAcc) " +
            " SELECT  " +
            "     V1.Doc_No, " +
            "     V1.Doc_Date, " +
            "     Left(V1.Acc_No,@GLEN) AS Acc_No, " +
            "     A.Acc_Name, " +
            "     SUM(V1.Debit) SumDebit, " +
            "     SUM(V1.Credit)SumCredit " +
            " FROM ( " +
            "     SELECT " +
            "         D.Doc_No, " +
            "         D.Doc_Date, " +
            "         J.Acc_No, " +
            "         J.Debit,  " +
            "         J.Credit  " +
            "     FROM Journal J  " +
            "         LEFT JOIN Documents D ON J.Doc_No = D.Doc_No " +
            "     WHERE (1 = 1) " +
            "         AND D.Controler = 1  " +
            "         AND D.Confirm = 1 " +
            "         AND D.Register = 1 " +
            " ) AS V1 " +
            "     LEFT JOIN Accounts A ON Left(V1.Acc_No,@GLEN) = A.Acc_No " +
            " GROUP BY " +
            "     V1.Doc_No, " +
            "     V1.Doc_Date, " +
            "     Left(V1.Acc_No,@GLEN), " +
            "     A.Acc_Name " +
            " ORDER BY  " +
            "     V1.Doc_No, " +
            "     V1.Doc_Date, " +
            "     Left(V1.Acc_No,@GLEN) ";

            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Get_Create_DocumentDaily(string scon,string co,string y,string DocType,string Tafsil,string DebitCredit)
        {
            // RETURN VALUE  = 1  YANI DOROSTE
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " " +
            " DECLARE    @return_value INT " +
            " EXEC       @return_value = [dbo].[sp_Create_Document_Daily] " +
            "            @DocType = " + DocType + ", " +
            "            @Tafsil = " + Tafsil + ", " +
            "            @DebitCredit = " + DebitCredit + " " +
            " SELECT	'Return Value' = @return_value ";

            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }
        public DataTable Get_Doc_Nos_Daily(string scon, string co, string y, string docno)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC dbo.sp_getDoc_Nos_Daily @CurrentDoc_No = '" + docno + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_Documents_Daily(string scon, string co, string y, string Wheres)
        {
            string query = "SELECT * FROM Documents_Daily " + Wheres;
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_Journal_Daily(string scon, string co, string y, string Wheres)
        {
            string query = " SELECT J.[Row] " +
                            "       ,J.[Doc_No] " +
                            "       ,J.[Acc_No] " +
                            " 	    ,A.[Acc_Name] " +
                            "       ,J.[Tafsil1] " +
                            "       ,J.[Tafsil2] " +
                            "       ,J.[Tafsil3] " +
                            "       ,J.[Descr] " +
                            "       ,J.[Debit] " +
                            "       ,J.[Credit] " +
                            "       ,J.[Sales_Doc_No] " +
                            "       ,J.[SDoc_No] " +
                            "       ,J.[PDoc_No] " +
                            "       ,J.[RDoc_No] " +
                            "       ,J.[Sub_Type] " +
                            "       ,J.[Control] " +
                            "       ,J.[Settle] " +
                            "       ,J.[Currency_Price] " +
                            "       ,J.[Currency_Type] " +
                            "       ,J.[Currency_Symbol] " +
                            "       ,J.[Currency_Rate] " +
                            "       ,J.[DescrL] " +
                            "       ,J.[Flag] " +
                            "       ,J.[Hidden] " +
                            "       ,J.[Qty] " +
                            "       ,J.[Price] " +
                            "       ,J.[Follow_Date] " +
                            "       ,J.[Follow_No] " +
                            "       ,J.[Follow_Descr] " +
                            "       ,J.[ID] " +
                            " FROM [Journal_Daily] J " +
                            " 	LEFT JOIN Accounts A ON J.Acc_No = A.Acc_No " +
                            " " + Wheres +
                            " ORDER BY J.[Row]";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            return db.GetRecords(db.Get_ConnectionString(), query);
        }
        public DataTable Get_Artickle_Info_Daily(string scon, string co, string y, string docno, string row)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " SELECT                                  " +
                            "	 ISNULL([Sarfasl],'') [Sarfasl],      " +
                            "	 ISNULL([Acc_Name],'') [Acc_Name],    " +
                            "	 ISNULL([Tafsil1],'') [Tafsil1],      " +
                            "	 ISNULL([Tafsil2],'') [Tafsil2],      " +
                            "	 ISNULL([Tafsil3],'') [Tafsil3]       " +
                            " FROM dbo.fn_get_Artickle_Info_Daily ('" + docno + "'," + row + ")  ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_CompareAccount(string scon,string co,string y,string type,string Acc_Nos)
        {
            var x = "";
            switch (type)
            {
                case "Monthly":
                    x = " [dbo].[sp_Compare_Account_Monthly] ";
                    break;
                case "Session":
                    x = " [dbo].[sp_Compare_Account_Session] ";
                    break;
                case "4Month":
                    x = " [dbo].[sp_Compare_Account_4Month] ";
                    break;
                case "6Month":
                    x = " [dbo].[sp_Compare_Account_6Month] ";
                    break;
                case "Year":
                    x = " [dbo].[sp_Compare_Account_Year] ";
                    break;
            }
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC " + x +
                           " @Acc_Nos = N'" + Acc_Nos + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_AccPeopleList(string scon,string co,string y,string Wheres)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " SELECT " +
                           "     P.Acc_No, " +
                           "     A.Acc_Name, " +
                           "     P.Title, " +
                           "     P.First_Name, " +
                           "     P.Last_Name," +
                           "     P.ID " +
                           " FROM People P " +
                           "     LEFT JOIN Accounts A ON P.Acc_No = A.Acc_No " +
                           " WHERE (1 = 1) " + Wheres +
                           " ORDER BY " +
                           "      P.Acc_No ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_People(string scon,string co,string y,string ID)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " SELECT " +
                            " 	   [Acc_No] " +
                            "       ,ISNULL([Title],'')[Title] " +
                            "       ,ISNULL([First_Name],'')[First_Name] " +
                            "       ,ISNULL([Last_Name],'')[Last_Name] " +
                            "       ,ISNULL([Job_Title],'')[Job_Title] " +
                            "       ,ISNULL([Company],'')[Company] " +
                            "       ,ISNULL([Info],'')[Info] " +
                            "       ,ISNULL([Economic_Code],'')[Economic_Code] " +
                            "       ,ISNULL([National_Code],'')[National_Code] " +
                            "       ,ISNULL([National_ID],'')[National_ID] " +
                            "       ,ISNULL([State],'')[State] " +
                            "       ,ISNULL([City],'')[City] " +
                            "       ,ISNULL([Town],'')[Town] " +
                            "       ,ISNULL([Region],'')[Region] " +
                            "       ,ISNULL([post_Address1],'')[post_Address1] " +
                            "       ,ISNULL([post_Address2],'')[post_Address2] " +
                            "       ,ISNULL([Postal_Code],'')[Postal_Code] " +
                            "       ,ISNULL([Email],'')[Email] " +
                            "       ,ISNULL([Tel_No1],'')[Tel_No1] " +
                            "       ,ISNULL([Tel_No2],'')[Tel_No2] " +
                            "       ,ISNULL([Tel_No3],'')[Tel_No3] " +
                            "       ,ISNULL([Tel_No4],'')[Tel_No4] " +
                            "       ,ISNULL([Fax_No],'')[Fax_No] " +
                            "       ,ISNULL([Mobile_no],'')[Mobile_no] " +
                            "       ,[MaxCredit] " +
                            "       ,[Discount_Prcnt] " +
                            "       ,[DealerNet] " +
                            "       ,[Sales_Price_No] " +
                            "       ,ISNULL([Transporter],'')[Transporter] " +
                            "       ,[Freight_Charge] " +
                            "       ,[County] " +
                            "       ,[Tehran] " +
                            "       ,[Bazar] " +
                            "       ,[Active] " +
                            "       ,[ID] " +
                            "   FROM [People]  " +
                            " WHERE (1 = 1) AND ID = " + ID + " " +
                           " ORDER BY " +
                           "      Acc_No ";
            return db.GetRecords(db.Get_ConnectionString(), query);
            
        }

        public string Insert_PepoleList(string scon, string co, string y,
            string Acc_No, string Title, string First_Name, string Last_Name, string Job_Title, string Company,
            string Info, string Economic_Code, string National_Code, string National_ID, string State, string City,
            string Town, string Region, string post_Address1, string post_Address2, string Postal_Code, string Email,
            string Tel_No1, string Tel_No2, string Tel_No3, string Tel_No4, string Fax_No, string Mobile_no,
            string MaxCredit, string Discount_Prcnt, string DealerNet, string Sales_Price_No, string Transporter,
            string Freight_Charge, string County, string Tehran, string Bazar, string Active,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "";
            //check record vojood dare ya na
            query = " SELECT COUNT([Acc_No]) AS COUNTS FROM [dbo].[People] WHERE Acc_No = N'" + Acc_No + "' ";
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            if (dt.Rows[0][0].ToString() == "0")
            {
                string result = "";
                query = "" +
                    "  INSERT INTO [dbo].[People] " +
                    "            ([Acc_No] " +
                    "            ,[Title] " +
                    "            ,[First_Name] " +
                    "            ,[Last_Name] " +
                    "            ,[Job_Title] " +
                    "            ,[Company] " +
                    "            ,[Info] " +
                    "            ,[Economic_Code] " +
                    "            ,[National_Code] " +
                    "            ,[National_ID] " +
                    "            ,[State] " +
                    "            ,[City] " +
                    "            ,[Town] " +
                    "            ,[Region] " +
                    "            ,[post_Address1] " +
                    "            ,[post_Address2] " +
                    "            ,[Postal_Code] " +
                    "            ,[Email] " +
                    "            ,[Tel_No1] " +
                    "            ,[Tel_No2] " +
                    "            ,[Tel_No3] " +
                    "            ,[Tel_No4] " +
                    "            ,[Fax_No] " +
                    "            ,[Mobile_no] " +
                    "            ,[MaxCredit] " +
                    "            ,[Discount_Prcnt] " +
                    "            ,[DealerNet] " +
                    "            ,[Sales_Price_No] " +
                    "            ,[Transporter] " +
                    "            ,[Freight_Charge] " +
                    "            ,[County] " +
                    "            ,[Tehran] " +
                    "            ,[Bazar] " +
                    "            ,[Active]) " +
                    "      VALUES " +
                    "            (N'" + Acc_No + "' " +
                    "            ,N'" + Title + "' " +
                    "            ,N'" + First_Name + "' " +
                    "            ,N'" + Last_Name + "' " +
                    "            ,N'" + Job_Title + "' " +
                    "            ,N'" + Company + "' " +
                    "            ,N'" + Info + "' " +
                    "            ,N'" + Economic_Code + "' " +
                    "            ,N'" + National_Code + "' " +
                    "            ,N'" + National_ID + "' " +
                    "            ,N'" + State + "' " +
                    "            ,N'" + City + "' " +
                    "            ,N'" + Town + "' " +
                    "            ,N'" + Region + "' " +
                    "            ,N'" + post_Address1 + "' " +
                    "            ,N'" + post_Address2 + "' " +
                    "            ,N'" + Postal_Code + "' " +
                    "            ,N'" + Email + "' " +
                    "            ,N'" + Tel_No1 + "' " +
                    "            ,N'" + Tel_No2 + "' " +
                    "            ,N'" + Tel_No3 + "' " +
                    "            ,N'" + Tel_No4 + "' " +
                    "            ,N'" + Fax_No + "' " +
                    "            ,N'" + Mobile_no + "' " +
                    "            ,  " + MaxCredit + " " +
                    "            ,  " + Discount_Prcnt + " " +
                    "            ,N'" + DealerNet + "' " +
                    "            ,  " + Sales_Price_No + "" +
                    "            ,N'" + Transporter + "' " +
                    "            ,  " + Freight_Charge + " " +
                    "            ,N'" + County + "'" +
                    "            ,N'" + Tehran + "'" +
                    "            ,N'" + Bazar + "'" +
                    "            ,N'" + Active + "') ";
                result = db.DoCommand(db.Get_ConnectionString(), query
                    , user_log, from_log, status_log, desc_log);
                if (result == "OK")
                {
                    query = " SELECT TOP 1 ID FROM [dbo].[People] WHERE Acc_No = N'" + Acc_No + "'";
                    dt = db.GetRecords(db.Get_ConnectionString(), query);
                    return "OK_" + dt.Rows[0][0].ToString();
                }
                else
                {
                    return result;
                }
            }
            else
            {
                return "EXISTS";
            }
        }

        public string Update_PeopleList(string scon, string co, string y,
            string Acc_No, string Title, string First_Name, string Last_Name, string Job_Title, string Company,
            string Info, string Economic_Code, string National_Code, string National_ID, string State, string City,
            string Town, string Region, string post_Address1, string post_Address2, string Postal_Code, string Email,
            string Tel_No1, string Tel_No2, string Tel_No3, string Tel_No4, string Fax_No, string Mobile_no,
            string MaxCredit, string Discount_Prcnt, string DealerNet, string Sales_Price_No, string Transporter,
            string Freight_Charge, string County, string Tehran, string Bazar, string Active, string ID,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
            " UPDATE [dbo].[People] " +
            "   SET [Acc_No] = N'" + Acc_No + "'" +
            "      ,[Title] = N'" + Title + "'" +
            "      ,[First_Name] = N'" + First_Name + "' " +
            "      ,[Last_Name] = N'" + Last_Name + "' " +
            "      ,[Job_Title] = N'" + Job_Title + "' " +
            "      ,[Company] = N'" + Company + "' " +
            "      ,[Info] = N'" + Info + "' " +
            "      ,[Economic_Code] = N'" + Economic_Code + "' " +
            "      ,[National_Code] = N'" + National_Code + "' " +
            "      ,[National_ID] = N'" + National_ID + "' " +
            "      ,[State] = N'" + State + "' " +
            "      ,[City] = N'" + City + "' " +
            "      ,[Town] = N'" + Town + "' " +
            "      ,[Region] = N'" + Region + "' " +
            "      ,[post_Address1] = N'" + post_Address1 + "' " +
            "      ,[post_Address2] = N'" + post_Address2 + "' " +
            "      ,[Postal_Code] = N'" + Postal_Code + "' " +
            "      ,[Email] = N'" + Email + "' " +
            "      ,[Tel_No1] = N'" + Tel_No1 + "' " +
            "      ,[Tel_No2] = N'" + Tel_No2 + "' " +
            "      ,[Tel_No3] = N'" + Tel_No3 + "' " +
            "      ,[Tel_No4] = N'" + Tel_No4 + "' " +
            "      ,[Fax_No] = N'" + Fax_No + "' " +
            "      ,[Mobile_no] = N'" + Mobile_no + "' " +
            "      ,[MaxCredit] = " + MaxCredit + " " +
            "      ,[Discount_Prcnt] = " + Discount_Prcnt + " " +
            "      ,[DealerNet] = N'" + DealerNet + "' " +
            "      ,[Sales_Price_No] = " + Sales_Price_No + " " +
            "      ,[Transporter] = N'" + Transporter + "' " +
            "      ,[Freight_Charge] = " + Freight_Charge + " " +
            "      ,[County] = N'" + County + "' " +
            "      ,[Tehran] = N'" + Tehran + "' " +
            "      ,[Bazar] = N'" + Bazar + "' " +
            "      ,[Active] = N'" + Active + "' " +
            " WHERE (1 = 1) AND ID = " + ID;
            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);

        }

        public string Delete_PeopleList(string scon, string co, string y, string ID,
            string user_log, string from_log, string status_log, string desc_log)
        {
            var dt = new DataTable();
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = "" +
                " DELETE FROM  [dbo].[People] " +
                "     WHERE " +
                "           [ID] = " + ID + "";

            return db.DoCommand(db.Get_ConnectionString(), query
                , user_log, from_log, status_log, desc_log);
        }

        public DataTable Get_People_Nos(string scon, string co, string y, string id)
        {
            var db = new mydb();

            db.Company = co;
            db.Year = y;
            db.scon = scon;
            string query = " EXEC dbo.sp_getPeoples @ID = " + id + " ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Cost_Benefit(string scon, string co, string y, string StartDate, string EndDate)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC  [dbo].[sp_Cost_Benefit] " +
                        "           @StartDate = '" + StartDate + "'," +
                        "           @EndDate   = '" + EndDate + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public DataTable Get_Balance(string scon, string co, string y, string StartDate, string EndDate)
        {
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            var query = " EXEC  [dbo].[sp_Balance] " +
                        "           @StartDate = '" + StartDate + "'," +
                        "           @EndDate   = '" + EndDate + "' ";
            return db.GetRecords(db.Get_ConnectionString(), query);
        }

        public string Get_Len_Doc_No(string scon, string co, string y)
        {
            var dt = new DataTable();
            var query = "";
            query = "" +
                " SELECT [dbo].[fn_Get_Len_Doc_No]()";
            var db = new mydb();
            db.Company = co;
            db.Year = y;
            db.scon = scon;
            dt = db.GetRecords(db.Get_ConnectionString(), query);
            return dt.Rows[0][0].ToString();
        }
    }
}

