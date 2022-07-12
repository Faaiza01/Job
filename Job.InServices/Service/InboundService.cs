using Job.InServices.IService;
using Job.InServices.ProxyToJobWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.InServices.Service
{
    public class InboundService : IInboundService
    {
        JobWebServiceSoapClient proxy;

        public InboundService()
        {
            proxy = new JobWebServiceSoapClient("JobWebServiceSoap",
                "http://webteach_net.hallam.shu.ac.uk/cmsmr2/RemoteWebService.asmx");
        }
        public IList<MusicType> GetMusicTypes()
        {
            return proxy.GetOurCatalogue();
        }
        public IList<MusicType> GetMusicTypesAuthenticated()
        {
            HeaderLogin header = new HeaderLogin();
            header.User = "mo"; header.Password = "secret";
            return proxy.GetOurCatalogueByAuthenticating(header);
        }
    }
}
