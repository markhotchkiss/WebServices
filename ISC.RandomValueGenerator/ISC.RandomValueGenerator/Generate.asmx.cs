using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using ISC.RandomValueGenerator.Models;

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
        private readonly Random _r = new Random();
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

        [WebMethod]
        public MeterModel Integers()
        {
            return Random();
        }

        [WebMethod]
        public BooleanModel Digitals()
        {
            var boolModel = new BooleanModel
            {
                DigitalInput01 = _r.Next(100) <= 20,
                DigitalInput02 = _r.Next(100) <= 20,
                DigitalInput03 = _r.Next(100) <= 20,
                DigitalInput04 = _r.Next(100) <= 20,
                DigitalInput05 = _r.Next(100) <= 20,
                DigitalInput06 = _r.Next(100) <= 20,
                DigitalInput07 = _r.Next(100) <= 20,
                DigitalInput08 = _r.Next(100) <= 20,
                DigitalInput09 = _r.Next(100) <= 20,
                DigitalInput10 = _r.Next(100) <= 20,
                DigitalInput11 = _r.Next(100) <= 20,
                DigitalInput12 = _r.Next(100) <= 20,
                DigitalInput13 = _r.Next(100) <= 20,
                DigitalInput14 = _r.Next(100) <= 20,
                DigitalInput15 = _r.Next(100) <= 20,
                DigitalInput16 = _r.Next(100) <= 20,
                DigitalInput17 = _r.Next(100) <= 20,
                DigitalInput18 = _r.Next(100) <= 20,
                DigitalInput19 = _r.Next(100) <= 20,
                DigitalInput20 = _r.Next(100) <= 20
            };

            return boolModel;
        }

        [WebMethod]
        public DoubleModel AreaFloats(double min, double max)
        {
            var floatModel = new DoubleModel
            {
                TemperatureInput01 = RandomDouble(min, max),
                TemperatureInput02 = RandomDouble(min, max),
                TemperatureInput03 = RandomDouble(min, max),
                TemperatureInput04 = RandomDouble(min, max),
                TemperatureInput05 = RandomDouble(min, max),
                TemperatureInput06 = RandomDouble(min, max),
                TemperatureInput07 = RandomDouble(min, max),
                TemperatureInput08 = RandomDouble(min, max),
                TemperatureInput09 = RandomDouble(min, max),
                TemperatureInput10 = RandomDouble(min, max),
                TemperatureInput11 = RandomDouble(min, max),
                TemperatureInput12 = RandomDouble(min, max),
                TemperatureInput13 = RandomDouble(min, max),
                TemperatureInput14 = RandomDouble(min, max),
                TemperatureInput15 = RandomDouble(min, max),
                TemperatureInput16 = RandomDouble(min, max),
                TemperatureInput17 = RandomDouble(min, max),
                TemperatureInput18 = RandomDouble(min, max),
                TemperatureInput19 = RandomDouble(min, max),
                TemperatureInput20 = RandomDouble(min, max)
            };

            return floatModel;
        }

        private double RandomDouble(double min, double max)
        {
            return min + (_r.NextDouble() * (max - min));
        }
    }
}
