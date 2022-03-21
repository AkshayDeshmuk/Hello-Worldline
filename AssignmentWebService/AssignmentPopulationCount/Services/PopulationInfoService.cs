//using AssignmentPopulationCount.Models;
using System;
using System.ServiceModel;
using System.Threading.Tasks;
using WorldlineServiceReference;


namespace AssignmentPopulationCount.Services
{
    public class PopulationInfoService : IPopulationInfoService
    {
        public readonly string serviceUrl = "https://localhost:44345/DemoWebService.asmx";
        public readonly EndpointAddress endpointAddress;
        public readonly BasicHttpBinding basicHttpBinding;

        public PopulationInfoService()
        {
            endpointAddress = new EndpointAddress(serviceUrl);

            basicHttpBinding = new BasicHttpBinding(
                endpointAddress.Uri.Scheme.ToLower() == "http" ?
                    BasicHttpSecurityMode.None :
                    BasicHttpSecurityMode.Transport)
            {
                OpenTimeout = TimeSpan.MaxValue,
                CloseTimeout = TimeSpan.MaxValue,
                ReceiveTimeout = TimeSpan.MaxValue,
                SendTimeout = TimeSpan.MaxValue
            };
        }



        public async Task<PopulationInfo> GetCategoryWisePopulationForPinCodeAsync(string pinCode)
        {

            var wsClient = new DemoWebServiceSoapClient(basicHttpBinding, endpointAddress);

            var soapResponse = await wsClient.GetCategoryWisePopulationForPinCodeAsync(pinCode);

            var result = soapResponse.Body.GetCategoryWisePopulationForPinCodeResult;

            return(result);
        }


    }
}
