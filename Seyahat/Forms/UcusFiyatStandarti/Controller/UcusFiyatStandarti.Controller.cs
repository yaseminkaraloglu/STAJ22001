using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace Seyahat.Forms
{
    [Route("apps/Seyahat/latest/api/UcusFiyatStandarti/[action]")]
    [Route("apps/Seyahat/{v:int:min(1)}/api/UcusFiyatStandarti/[action]")]
    [Route("api/UcusFiyatStandarti/[action]")]
    [Produces("application/json")]
    public class UcusFiyatStandartiController : BaseFormController<UcusFiyatStandarti>
    {
        public UcusFiyatStandartiController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "UcusFiyatStandarti API Controller is ok";            
        }
    }
}