using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.Web.Attributes;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace yktest.Report
{
	[EnableCors]
    [DontWrapResultFilter]
    [ApiExplorerSettings(IgnoreApi = true)]
	[Route("apps/yktest/latest/api/ReportViewer")]
	[Route("api/ReportViewer")]
	[Route("apps/yktest/{v:int:min(1)}/api/ReportViewer")]
    public class ReportViewerController : BaseReportController
    {
        public ReportViewerController(IWebDocumentViewerMvcControllerService controllerService, IocManager iocManager) : base(controllerService, iocManager)
        {
        }
    }
}