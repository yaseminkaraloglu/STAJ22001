using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace Seyahat.Forms
{
    [Route("apps/Seyahat/latest/api/Sehirler/[action]")]
    [Route("apps/Seyahat/{v:int:min(1)}/api/Sehirler/[action]")]
    [Route("api/Sehirler/[action]")]
    [Produces("application/json")]
    public class SehirlerController : BaseFormController<Sehirler>
    {
        public SehirlerController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Sehirler API Controller is ok";            
        }
    }
}