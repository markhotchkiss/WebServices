using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;

namespace ISC.RandomValueGenerator
{
    /// <summary>
    /// Summary description for Generate
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Generate : System.Web.Services.WebService
    {
        Random _r = new Random();
        [WebMethod]
        public MeterModel Random()
        {
            var meterModel = new MeterModel
            {
                Meter01 = _r.Next(0, 100),
                Meter02 = _r.Next(0, 100),
                Meter03 = _r.Next(0, 100),
                Meter04 = _r.Next(0, 100),
                Meter05 = _r.Next(0, 100),
                Meter06 = _r.Next(0, 100),
                Meter07 = _r.Next(0, 100),
                Meter08 = _r.Next(0, 100),
                Meter09 = _r.Next(0, 100),
                Meter10 = _r.Next(0, 100),
                Meter11 = _r.Next(0, 100),
                Meter12 = _r.Next(0, 100),
                Meter13 = _r.Next(0, 100),
                Meter14 = _r.Next(0, 100),
                Meter15 = _r.Next(0, 100),
                Meter16 = _r.Next(0, 100),
                Meter17 = _r.Next(0, 100),
                Meter18 = _r.Next(0, 100),
                Meter19 = _r.Next(0, 100),
                Meter20 = _r.Next(0, 100),
                Meter21 = _r.Next(0, 100),
                Meter22 = _r.Next(0, 100),
                Meter23 = _r.Next(0, 100),
                Meter24 = _r.Next(0, 100),
                Meter25 = _r.Next(0, 100),
                Meter26 = _r.Next(0, 100),
                Meter27 = _r.Next(0, 100),
                Meter28 = _r.Next(0, 100),
                Meter29 = _r.Next(0, 100),
                Meter30 = _r.Next(0, 100)
            };

            return meterModel;
        }
    }
}
