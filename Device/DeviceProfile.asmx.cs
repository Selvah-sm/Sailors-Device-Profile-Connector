using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Device
{
    /// <summary>
    /// Summary description for DeviceProfile
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeviceProfile : System.Web.Services.WebService
    {
       
        [WebMethod]
        public string DeviceConnector(string action)
        {
            Device.DeviceConnector.jinp = action;
            Device.DeviceConnector dc = new Device.DeviceConnector();
            dc.openPort();
            string resp = dc.sendData();
            dc.closePort();
            return resp;
        }
        
    }
}
