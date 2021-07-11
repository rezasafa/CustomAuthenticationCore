using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Sepehr4Core.Classes;
using Sepehr4Core.BusinessLayer;
using Sepehr4Core.MyModels;
using Sepehr4Core.Models;
using ClosedXML;
using ClosedXML.Excel;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace Sepehr4Core.ws
{
    
    //[Route("api/[controller]/[action]/{id}")]
    [Route("/api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class mywsController : ControllerBase
    {
        //return Ok(result)//;//
        private readonly IConfiguration configuration;
        string scon = "";
        ENCODES MakeJson;
        public mywsController(IConfiguration _configuration)
        {
            var makeJson = new ENCODES();
            MakeJson = makeJson;
            configuration = _configuration;
            scon = configuration.GetConnectionString("FinYear");
        }

        #region PublicInfo

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Get_Company()
        {
            var fo = new FinacialPeriodOperation();
            var result = fo.Get_Company(scon);
            return Ok(MakeJson.DataTableTOJson(result));
        }
        
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Get_CompanyID(string CompanyName)
        {
            var fo = new FinacialPeriodOperation();
            var result = fo.Get_CompanyID(scon, CompanyName);
            return Ok(result);
        }
        
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Get_FinYear(string FinCompany)
        {
            var fo = new FinacialPeriodOperation();
            var result = fo.Get_FinYear(scon, FinCompany);
            return Ok(MakeJson.DataTableTOJson(result)); 
        }

        [HttpGet]
        public ActionResult InitOption(myApp m)
        {
            var o = new Options();
            var result = o.InitOption(scon, m.company, m.year);
            return Ok(MakeJson.DataTableTOJson(result));
        }

        [HttpPost]
        public ActionResult Get_CompanyInfo(myApp m)
        {
            var c = new BusinessLayer.Company();
            var result = c.Get_CompanyInfo(scon, m.company, m.year);
            return Ok(MakeJson.DataTableTOJson(result));
        }
        
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(myAppLogin myapplogin)
        {
            var ua = new UsersAccount();
            var result = ua.Login(scon, myapplogin.myapp.company, myapplogin.myapp.year, myapplogin.Username, myapplogin.Password);
            return Ok(MakeJson.DataTableTOJson(result));
        }

        #endregion

        
    }
}
