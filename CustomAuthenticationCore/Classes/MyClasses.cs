using System;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Reflection;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Data.SqlClient;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;
using Sepehr4Core.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;

namespace Sepehr4Core.Classes
{
    public class ENCODES
    {
        public string ConvetToUTF8(string SVAL)
        {
            byte[] bytes = Encoding.Default.GetBytes(SVAL);
            return Encoding.UTF8.GetString(bytes);
        }

        public string DataTableTOJson(DataTable dt)
        {
            var x = JsonConvert.SerializeObject(dt);
            return x;
            /*
            var serializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
            */
        }

    }

    public class SystemVariable
    {
        public string SerialNo { get { return "SS1002-9104-N0339"; } } //
        public int MaxClient { get { return 1; } }
        public string RegisterName { get { return "Reza Safa"; } }
        public string RegisterCompany { get { return "Safasoftco"; } }
        public bool AccountingSystem { get { return true; } }
        public bool SalesSystem { get { return true; } }
        public bool StoreSystem { get { return false; } }
        public bool PayRecvSystem { get { return false; } }
        public bool PayRollSystem { get { return true; } }
        public bool CalcProduct_CostBasis { get { return false; } }
        public bool gbLatinSys { get { return false; } }
        public int Edition { get { return 3; } }// 1: Standard 2:Professional 3:Advanced
        public int AccEdition { get { return 3; } }// 1: Standard 2:Professional 3:Advanced
        public int StoreEdition { get { return 3; } }// 1: Standard 2:Professional 3:Advanced
        public int PayRecvEdition { get { return 3; } }// 1: Standard 2:Professional 3:Advanced
        public int PayRollEdition { get { return 3; } }// 1: Standard 2:Professional 3:Advanced
        public bool BarCodeEnable { get { return false; } }
        public bool MultiCompany { get { return true; } }
        public bool SystemTalfighi { get { return false; } }
        public int CardSaat { get { return 2; } }// 1:DoniaPardazesh 2:PalizAfzar
    }

    public class UserManager
    {
        private readonly IConfiguration configuration;
        public UserManager() { }

        public async Task SignIn(HttpContext httpContext, LoginViewModel user, bool isPersistent = false)
        {
            ClaimsIdentity identity = new ClaimsIdentity(this.GetUserClaims(user), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            await httpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, 
                principal, 
                new AuthenticationProperties
                {
                    IsPersistent = isPersistent
                });
        }

        public async Task SignOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        private IEnumerable<Claim> GetUserClaims(LoginViewModel user)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Company));
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim(ClaimTypes.GivenName, user.Year));
            claims.AddRange(this.GetUserRoleClaims(user));
            return claims;
        }

        private IEnumerable<Claim> GetUserRoleClaims(LoginViewModel user)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Company));
            claims.Add(new Claim(ClaimTypes.Role,"admin"));
            return claims;
        }
    
    }
}
