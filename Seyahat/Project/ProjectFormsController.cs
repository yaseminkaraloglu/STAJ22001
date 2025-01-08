using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;

namespace Seyahat.Project
{
    [Route("apps/Seyahat/latest/api/project/forms/[action]")]
    [Route("apps/Seyahat/{v:int:min(1)}/api/project/forms/[action]")]
    [Route("api/project/forms/[action]")]
    [Produces("application/json")]
    public class ProjectFormsController : BaseProjectFormsController
    {
        public ProjectFormsController(IIocManager iocManager)
            : base(iocManager)
        {
        }
    }
}