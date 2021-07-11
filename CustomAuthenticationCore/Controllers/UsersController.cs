using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sepehr4Core.Models;
using Microsoft.Data.SqlClient;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Sepehr4Core.Classes;
using Sepehr4Core.MyModels.PublicModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sepehr4Core.Controllers
{
    public class UsersController : Controller
    {
        private readonly IConfiguration configuration;
        private string scon = "";
        public UsersController(IConfiguration _configuration) 
        {
            configuration = _configuration;
            scon = configuration.GetConnectionString("FinYear");
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            Console.WriteLine("Connection String" + scon);
            return View();
        }
        
        [HttpPost]
        public IActionResult LogIn(LoginViewModel form)
        {
            
            if (!ModelState.IsValid)
                return View(form);
            try
            {
                if (CheckLogin(form))
                {
                    var _userManager = new UserManager();
                    //authenticate
                    _userManager.SignIn(this.HttpContext, form);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(form);
                }   
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("summary", ex.Message);
                return View(form);
            }
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            var _userManager = new UserManager();
            //authenticate
            _userManager.SignOut(this.HttpContext);
            return Redirect("/");
        }

        private bool CheckLogin(LoginViewModel user)
        {
            var conv = new Classes.ENCODES();
            var ro = new BusinessLayer.Options();
            var fo = new BusinessLayer.FinacialPeriodOperation();
            var ua = new BusinessLayer.UsersAccount();
            
            user.Company = fo.Get_CompanyName(scon, user.Company);

            var accsys = new BusinessLayer.AccountSystem();
            var myapplogin = new myAppLogin();
            var myapp = new myApp();

            myapp.company = user.Company;
            myapp.year = user.Year;
            myapplogin.myapp = myapp;
            myapplogin.Username = user.UserName;
            myapplogin.Password = user.Password;

            var ret = ua.Login(scon, user.Company, user.Year,user.UserName,user.Password);
            if (ret.Rows.Count > 0) 
            {
                var rslt = "";
                
                rslt = conv.ConvetToUTF8("{data:" + conv.DataTableTOJson(ro.InitOption(scon, user.Company, user.Year)) + "}");
                dynamic dyn_Init = JsonConvert.DeserializeObject(rslt); 
                var lInit_Option = new List<Init>();

                foreach (var obj in dyn_Init.data)
                {
                    lInit_Option.Add(new Init()
                    {
                        Co_Name = (obj.Co_Name != null) ? obj.Co_Name.ToString() : "",
                        Co_Address = (obj.Co_Address != null) ? obj.Co_Address.ToString() : "",
                        Start_Date = (obj.Start_Date != null) ? obj.Start_Date.ToString() : "",
                        End_Date = (obj.End_Date != null) ? obj.End_Date.ToString() : "",
                        ATafsil1_Visible = Boolean.Parse(obj.ATafsil1_Visible.ToString()),
                        ATafsil2_Visible = Boolean.Parse(obj.ATafsil1_Visible.ToString()),
                        ATafsil3_Visible = Boolean.Parse(obj.ATafsil1_Visible.ToString())
                    });
                }

                rslt = conv.ConvetToUTF8("{data:" + conv.DataTableTOJson(accsys.Get_InitAcc(scon, user.Company, user.Year)) + "}");
                dynamic dyn_InitAcc = JsonConvert.DeserializeObject(rslt);
                var lInit_Acc = new List<InitAcc>();

                foreach (var obj in dyn_InitAcc.data)
                {
                    lInit_Acc.Add(new InitAcc()
                    {
                        Acc_Levels = int.Parse(obj.Acc_Levels.ToString()),
                        GL_Level = int.Parse(obj.GL_Level.ToString()),
                        Acc_Level1_Name = (obj.Acc_Level1_Name != null) ? obj.Acc_Level1_Name.ToString() : "",
                        Acc_Level1_Len = int.Parse(obj.Acc_Level1_Len.ToString()),
                        Acc_Level2_Name = (obj.Acc_Level2_Name != null) ? obj.Acc_Level2_Name.ToString() : "",
                        Acc_Level2_Len = int.Parse(obj.Acc_Level2_Len.ToString()),
                        Acc_Level3_Name = (obj.Acc_Level3_Name != null) ? obj.Acc_Level3_Name.ToString() : "",
                        Acc_Level3_Len = int.Parse(obj.Acc_Level3_Len.ToString()),
                        Acc_Level4_Name = (obj.Acc_Level4_Name != null) ? obj.Acc_Level4_Name.ToString() : "",
                        Acc_Level4_Len = int.Parse(obj.Acc_Level4_Len.ToString()),
                        Acc_Level5_Name = (obj.Acc_Level5_Name != null) ? obj.Acc_Level5_Name.ToString() : "",
                        Acc_Level5_Len = int.Parse(obj.Acc_Level5_Len.ToString()),
                        Acc_Level6_Name = (obj.Acc_Level6_Name != null) ? obj.Acc_Level6_Name.ToString() : "",
                        Acc_Level6_Len = int.Parse(obj.Acc_Level6_Len.ToString()),
                        Acc_Level7_Name = (obj.Acc_Level7_Name != null) ? obj.Acc_Level7_Name.ToString() : "",
                        Acc_Level7_Len = int.Parse(obj.Acc_Level7_Len.ToString()),
                        Acc_Level8_Name = (obj.Acc_Level8_Name != null) ? obj.Acc_Level8_Name.ToString() : "",
                        Acc_Level8_Len = int.Parse(obj.Acc_Level8_Len.ToString()),
                        Acc_Level9_Name = (obj.Acc_Level9_Name != null) ? obj.Acc_Level9_Name.ToString() : "",
                        Acc_Level9_Len = int.Parse(obj.Acc_Level9_Len.ToString()),
                        Tafsil_Len = int.Parse(obj.Tafsil_Len.ToString()),
                        GTafsil_Len = int.Parse(obj.GTafsil_Len.ToString())
                    });
                }
                
                HttpContext.Response.Cookies.Append("company", user.Company);
                HttpContext.Response.Cookies.Append("year", user.Year);
                HttpContext.Response.Cookies.Append("scon",scon);

                HttpContext.Response.Cookies.Append("TypePrint","");
                HttpContext.Response.Cookies.Append("Conditions","");

                HttpContext.Response.Cookies.Append("Co_Name", lInit_Option[0].Co_Name);
                HttpContext.Response.Cookies.Append("Co_Address", lInit_Option[0].Co_Address);
                HttpContext.Response.Cookies.Append("Start_Date", lInit_Option[0].Start_Date);
                HttpContext.Response.Cookies.Append("End_Date", lInit_Option[0].End_Date);
                HttpContext.Response.Cookies.Append("ATafsil1_Visible", lInit_Option[0].ATafsil1_Visible.ToString());
                HttpContext.Response.Cookies.Append("ATafsil2_Visible", lInit_Option[0].ATafsil2_Visible.ToString());
                HttpContext.Response.Cookies.Append("ATafsil3_Visible", lInit_Option[0].ATafsil3_Visible.ToString());

                HttpContext.Response.Cookies.Append("Acc_Levels", lInit_Acc[0].Acc_Levels.ToString());
                HttpContext.Response.Cookies.Append("GL_Level", lInit_Acc[0].GL_Level.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level1_Name", lInit_Acc[0].Acc_Level1_Name);
                HttpContext.Response.Cookies.Append("Acc_Level2_Name", lInit_Acc[0].Acc_Level2_Name);
                HttpContext.Response.Cookies.Append("Acc_Level3_Name", lInit_Acc[0].Acc_Level3_Name);
                HttpContext.Response.Cookies.Append("Acc_Level4_Name", lInit_Acc[0].Acc_Level4_Name);
                HttpContext.Response.Cookies.Append("Acc_Level5_Name", lInit_Acc[0].Acc_Level5_Name);
                HttpContext.Response.Cookies.Append("Acc_Level6_Name", lInit_Acc[0].Acc_Level6_Name);
                HttpContext.Response.Cookies.Append("Acc_Level7_Name", lInit_Acc[0].Acc_Level7_Name);
                HttpContext.Response.Cookies.Append("Acc_Level8_Name", lInit_Acc[0].Acc_Level8_Name);
                HttpContext.Response.Cookies.Append("Acc_Level9_Name", lInit_Acc[0].Acc_Level9_Name);
                HttpContext.Response.Cookies.Append("Acc_Level1_Len", lInit_Acc[0].Acc_Level1_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level2_Len", lInit_Acc[0].Acc_Level2_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level3_Len", lInit_Acc[0].Acc_Level3_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level4_Len", lInit_Acc[0].Acc_Level4_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level5_Len", lInit_Acc[0].Acc_Level5_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level6_Len", lInit_Acc[0].Acc_Level6_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level7_Len", lInit_Acc[0].Acc_Level7_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level8_Len", lInit_Acc[0].Acc_Level8_Len.ToString());
                HttpContext.Response.Cookies.Append("Acc_Level9_Len", lInit_Acc[0].Acc_Level9_Len.ToString());
                HttpContext.Response.Cookies.Append("Tafsil_Len", lInit_Acc[0].Tafsil_Len.ToString());
                HttpContext.Response.Cookies.Append("GTafsil_Len", lInit_Acc[0].GTafsil_Len.ToString());

                return true;
            }

            return false;
        }
    }
}