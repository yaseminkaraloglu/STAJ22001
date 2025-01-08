using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace MasrafBeyanFormu.Forms
{
    [Route("apps/MasrafBeyanFormu/latest/api/MasrafTipleri/[action]")]
    [Route("apps/MasrafBeyanFormu/{v:int:min(1)}/api/MasrafTipleri/[action]")]
    [Route("api/MasrafTipleri/[action]")]
    [Produces("application/json")]
    public class MasrafTipleriController : BaseFormController<MasrafTipleri>
    {
        public MasrafTipleriController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "MasrafTipleri API Controller is ok";            
        }
    }
}