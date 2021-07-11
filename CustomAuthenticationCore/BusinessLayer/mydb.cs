using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

namespace Sepehr4Core.BusinessLayer
{
    public class mydb
    {
        public string Company;
        public string Year;
        public string scon;

        private string GetAddress()
        {
            DataTable dt;
            dt = GetRecords(scon, " SELECT [dbAddress] FROM [FinYear] WHERE ([FinYear] = N'" + Year + "') AND [CompanyID] = (SELECT TOP 1 CompanyID FROM FinCo WHERE Name = N'" + Company + "')");
            return dt.Rows[0][0].ToString();
        }

        public string Get_ConnectionString()
        {
            if (Company == "" || Year == "")
            {
                return scon;
            }
            else
            {
                return @GetAddress();
            }
        }

        public bool GetTafsilLogin_dbMain(string SQLQuery)
        {            

            if (Company == "" || Year == "")
            {
                return CheckLogin(scon, SQLQuery);
            }
            else
            {
                string AccessProvider = @GetAddress();
                return CheckLogin(AccessProvider, SQLQuery);
            }
        }

        public bool CheckLogin(string conString, string sqlQuery)
        {
            var con = new SqlConnection();
            var com = new SqlCommand();
            var dset = new DataSet();
            var dadapter = new SqlDataAdapter();
            var dtable = new DataTable();

            con.ConnectionString = conString;
            dset.Clear();
            SqlDataReader dReader;
            bool find = false;

            dset.Clear();

            com.CommandTimeout = 0;
            com.Connection = con;
            com.CommandText = sqlQuery;
            con.Open();
            com.ExecuteNonQuery();
            dReader = com.ExecuteReader();

            while (dReader.Read())
            {
                //find
                find = true;
            }

            dReader.Close();
            con.Close();

            if (find == true)
                return true;
            else
                return false;
        }

        public DataTable GetRecords(string conString, string sqlQuery)
        {
            var con = new SqlConnection();
            var com = new SqlCommand();
            var dset = new DataSet();
            var dadapter = new SqlDataAdapter();
            var dtable = new DataTable();

            con.ConnectionString = conString;
            dset.Clear();
            com.CommandTimeout = 0;
            com.Connection = con;
            com.CommandText = sqlQuery;
            dadapter.SelectCommand = com;
            dadapter.Fill(dset);
            con.Close();
            dtable = dset.Tables[0];

            return dtable;
        }

        public string DoCommand(string conString, string sqlQuery,string user,string form,string status,string desc)
        {
            var con = new SqlConnection();
            var com = new SqlCommand();
            var dset = new DataSet();
            var dadapter = new SqlDataAdapter();
            var dtable = new DataTable();

            con.ConnectionString = conString;

            try
            {
                com.CommandTimeout = 0;
                com.Connection = con;
                com.CommandText = sqlQuery;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                //create logs
                var dblog = new mydblog();
                dblog.Company = Company;
                dblog.Year = Year;
                dblog.scon = scon;

                var q = "" +
                    " INSERT INTO [dbo].[Log]( " +
                    "       [Users],[dttm],[Form],[Status],[Descr],[Query]) " +
                    " VALUES " +
                    "       (N'" + user + "',GETDATE(),N'" + form + "',N'" + status + "',N'" + desc + "',N'" + sqlQuery.Replace("'","''") + "') ";

                dblog.DoCommand(dblog.Get_ConnectionString(), q);
                
            }
            catch (SqlException ex)
            {
                con.Close();
                return ex.Message;
            }
            return "OK";
        }

        public string DoCommand_No_Log(string conString, string sqlQuery)
        {
            var con = new SqlConnection();
            var com = new SqlCommand();
            var dset = new DataSet();
            var dadapter = new SqlDataAdapter();
            var dtable = new DataTable();

            con.ConnectionString = conString;

            try
            {
                com.CommandTimeout = 0;
                com.Connection = con;
                com.CommandText = sqlQuery;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                con.Close();
                return ex.Message;
            }
            return "OK";
        }
    }

    public class mydblog
    {
        public string Company;
        public string Year;
        public string scon;

        private string GetAddress()
        {
            DataTable dt;
            dt = GetRecords(scon, " SELECT [dbAddress] FROM [FinYearLog] WHERE ([FinYear] = N'" + Year + "') AND [CompanyID] = (SELECT TOP 1 CompanyID FROM FinCo WHERE Name = N'" + Company + "')");
            return dt.Rows[0][0].ToString();
        }

        public string Get_ConnectionString()
        {
            if (Company == "" || Year == "")
            {
                return scon;
            }
            else
            {
                return @GetAddress();
            }
        }

        public DataTable GetRecords(string conString, string sqlQuery)
        {
            var con = new SqlConnection();
            var com = new SqlCommand();
            var dset = new DataSet();
            var dadapter = new SqlDataAdapter();
            var dtable = new DataTable();

            con.ConnectionString = conString;
            dset.Clear();
            com.CommandTimeout = 0;
            com.Connection = con;
            com.CommandText = sqlQuery;
            dadapter.SelectCommand = com;
            dadapter.Fill(dset);
            con.Close();
            dtable = dset.Tables[0];

            return dtable;
        }

        public string DoCommand(string conString, string sqlQuery)
        {
            var con = new SqlConnection();
            var com = new SqlCommand();
            var dset = new DataSet();
            var dadapter = new SqlDataAdapter();
            var dtable = new DataTable();

            con.ConnectionString = conString;

            try
            {
                com.CommandTimeout = 0;
                com.Connection = con;
                com.CommandText = sqlQuery;
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                con.Close();
                return ex.Message;
            }
            return "OK";
        }
    }
}
