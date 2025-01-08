using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace MasrafBeyanFormu.Forms
{
    [Route("apps/MasrafBeyanFormu/latest/api/MasrafDetayFormu/[action]")]
    [Route("apps/MasrafBeyanFormu/{v:int:min(1)}/api/MasrafDetayFormu/[action]")]
    [Route("api/MasrafDetayFormu/[action]")]
    [Produces("application/json")]
    public class MasrafDetayFormuController : BaseFormController<MasrafDetayFormu>
    {
        public MasrafDetayFormuController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "MasrafDetayFormu API Controller is ok";            
        }
    }
}