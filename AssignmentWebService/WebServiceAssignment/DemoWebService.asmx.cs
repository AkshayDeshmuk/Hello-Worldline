using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace WebServiceAssignment
{
    /// <summary>
    /// Summary description for DemoWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DemoWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        //public long[] GetCategoryWisePopulationForPinCode(string pinCode)
        //{
        //    var random = new Random();

        //    long data = random.Next(100000, 800000);
        //    long data1 = random.Next(100000, 800000);
        //    long data2 = random.Next(100000, 800000);

        //    return new long[] { data, data1, data2 };
        //}

        public PopulationInfo GetCategoryWisePopulationForPinCode(string pinCode)
        {
            var random=new Random();
            return new PopulationInfo
            {
                PinCode = pinCode,
                MaleCount = random.Next(10000,50000),
                FemaleCount = random.Next(10000, 50000),
                ChildrenCount = random.Next(10000, 50000)

            };
        }
        

    }
    public class PopulationInfo {
        public string PinCode { get; set; }       
        public long MaleCount { get; set; }       
        public long FemaleCount { get; set; }
        public long ChildrenCount { get; set; } 
    }
}
