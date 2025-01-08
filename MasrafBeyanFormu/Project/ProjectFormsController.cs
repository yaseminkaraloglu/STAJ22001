using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;

namespace MasrafBeyanFormu.Project
{
    [Route("apps/MasrafBeyanFormu/latest/api/project/forms/[action]")]
    [Route("apps/MasrafBeyanFormu/{v:int:min(1)}/api/project/forms/[action]")]
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