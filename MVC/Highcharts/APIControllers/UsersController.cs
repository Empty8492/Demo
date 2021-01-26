using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Highcharts.Models;
using Newtonsoft.Json;
using System.Collections;
using System.Text.RegularExpressions;

namespace Highcharts.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            Users users1 = new Users();
            List<highchartsmodel> highchartsmodels = new List<highchartsmodel>();
            highchartsmodel highchartsmodel = new highchartsmodel();
            List<Users> users = SQLcmd.SQLcmdData();

            foreach (var item in users)
            {
                highchartsmodel highchartsmodel1 = new highchartsmodel() {
                    data = new List<int>()
                };
                highchartsmodel1.name = item.Name.ToString();
                highchartsmodel1.data.Add(item.January);
                highchartsmodel1.data.Add(item.February);
                highchartsmodel1.data.Add(item.March);
                highchartsmodels.Add(highchartsmodel1);
            }

            String hingeString = Newtonsoft.Json.JsonConvert.SerializeObject(highchartsmodels);
            return hingeString;
        }
        [HttpGet("GetMonthDatagetByCountryId")]
        /// <summary>
        /// 根据国家ID查询数据
        /// </summary>
        /// <param name="id">国家ID</param>
        /// <returns>国家所有月份的值</returns>
        public string GetMonthDatagetByCountryId(int id)
            {
            Users users1 = new Users();
            List<highchartsmodel> highchartsmodels = new List<highchartsmodel>();
            highchartsmodel highchartsmodel = new highchartsmodel();
            List<Users> users = SQLcmd.SQLcmdData(id);
            String hingeString = Newtonsoft.Json.JsonConvert.SerializeObject(users);
            return hingeString;
        }
            [HttpPost]
        public int Post()
        {
           int January =int.Parse( Request.Form["January"].ToString());
           int February =int.Parse( Request.Form["February"].ToString());
           int March =int.Parse( Request.Form["March"].ToString());
           string Name = Request.Form["Name"].ToString();
            return SQLcmd.SQLinsertData(January,February,March,Name);
        }
        [HttpPut]
        public int Put()
        {
            int XJanuary = int.Parse(Request.Form["January"].ToString());
            int XFebruary = int.Parse(Request.Form["February"].ToString());
            int XMarch = int.Parse(Request.Form["March"].ToString());
            int ID =int.Parse(Request.Form["Id"]);
            return SQLcmd.SQLUpdateData(XJanuary, XFebruary, XMarch, ID);
        }
        [HttpDelete]
        public int Delete()
        {
            int ID = int.Parse(Request.Form["Id"]);
            return SQLcmd.SQLDeleteData(ID);
        }
        //public static bool IsNumber(string s)
        //{
        //    const string pattern = @"\d^]";
        //    Regex rx = new Regex(pattern);
        //    return rx.IsMatch(s);
        //}
        //// GET api/<UsersController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<UsersController>


        // PUT api/<UsersController>/5


        // DELETE api/<UsersController>/5

    }
}
