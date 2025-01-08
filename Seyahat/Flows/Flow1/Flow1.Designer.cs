using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace Seyahat.Flows
{
    [WorkflowIdentifier("118bc2cd-fc16-4ef4-a38a-3e5668ff126a")]
    public partial class Flow1 : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _akisBaslangic;
		private FlowEnd _akisBitisi;
		private FlowPosition _amir;
		private FlowAssign _amirAtama;
		private FlowMail _onayBilgilendirilmesi;
		private FlowDocument _biletFormu;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart AkisBaslangic => _akisBaslangic ??= new FlowStart("AkisBaslangic", _workflowData, this);
		private FlowEnd AkisBitisi => _akisBitisi ??= new FlowEnd("AkisBitisi", _workflowData, this);
		private FlowPosition Amir => _amir ??= new FlowPosition("Amir", _workflowData, this);
		private FlowAssign AmirAtama => _amirAtama ??= new FlowAssign("AmirAtama", _workflowData, this);
		private FlowMail OnayBilgilendirilmesi => _onayBilgilendirilmesi ??= new FlowMail("OnayBilgilendirilmesi", _workflowData, this);
		private FlowDocument BiletFormu => _biletFormu ??= new FlowDocument("BiletFormu", _workflowData, this);


        #endregion

        #region [ctor]        

        public Flow1() : this(null)
        {
            
        }
        
        public Flow1(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}