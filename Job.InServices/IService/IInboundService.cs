using Job.InServices.ProxyToJobWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.InServices.IService
{
    public interface IInboundService
    {
        IList<MusicType> GetMusicTypes();
        IList<MusicType> GetMusicTypesAuthenticated();

    }
}
