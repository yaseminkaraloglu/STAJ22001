using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace MasrafBeyanFormu.Flows
{
    [WorkflowIdentifier("4f95e788-d390-4132-9ec8-0ed5bca88825")]
    public partial class Flow1 : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowPosition _amir;
		private FlowPosition _akisBaslatan;
		private FlowPosition _departmanYonetici;
		private FlowAssign _assignment1;
		private FlowAssign _assignment2;
		private FlowCompare _karsilastirma;
		private FlowMail _redBilgilendirme;
		private FlowMail _revizyonBilgilendirme;
		private FlowMail _redBilgi;
		private FlowMail _surecBittiBilgi;
		private FlowDepartment _akisDepartman;
		private Variable _toplamTutar;
		private FlowNode _nodeIn1;
		private FlowNode _nodeIn2;
		private FlowNode _nodeOut1;
		private FlowNode _nodeOut2;
		private FlowGroup _iK;
		private FlowGroup _muhasebegrup;
		private FlowDocument _document1;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition Amir => _amir ??= new FlowPosition("Amir", _workflowData, this);
		private FlowPosition AkisBaslatan => _akisBaslatan ??= new FlowPosition("AkisBaslatan", _workflowData, this);
		private FlowPosition DepartmanYonetici => _departmanYonetici ??= new FlowPosition("DepartmanYonetici", _workflowData, this);
		private FlowAssign Assignment1 => _assignment1 ??= new FlowAssign("Assignment1", _workflowData, this);
		private FlowAssign Assignment2 => _assignment2 ??= new FlowAssign("Assignment2", _workflowData, this);
		private FlowCompare Karsilastirma => _karsilastirma ??= new FlowCompare("Karsilastirma", _workflowData, this);
		private FlowMail RedBilgilendirme => _redBilgilendirme ??= new FlowMail("RedBilgilendirme", _workflowData, this);
		private FlowMail RevizyonBilgilendirme => _revizyonBilgilendirme ??= new FlowMail("RevizyonBilgilendirme", _workflowData, this);
		private FlowMail RedBilgi => _redBilgi ??= new FlowMail("RedBilgi", _workflowData, this);
		private FlowMail SurecBittiBilgi => _surecBittiBilgi ??= new FlowMail("SurecBittiBilgi", _workflowData, this);
		private FlowDepartment AkisDepartman => _akisDepartman ??= new FlowDepartment("AkisDepartman", _workflowData, this);
		private Variable ToplamTutar => _toplamTutar ??= new Variable("ToplamTutar", _workflowData, this);
		private FlowNode NodeIn1 => _nodeIn1 ??= new FlowNode("NodeIn1", _workflowData, this);
		private FlowNode NodeIn2 => _nodeIn2 ??= new FlowNode("NodeIn2", _workflowData, this);
		private FlowNode NodeOut1 => _nodeOut1 ??= new FlowNode("NodeOut1", _workflowData, this);
		private FlowNode NodeOut2 => _nodeOut2 ??= new FlowNode("NodeOut2", _workflowData, this);
		private FlowGroup IK => _iK ??= new FlowGroup("IK", _workflowData, this);
		private FlowGroup Muhasebegrup => _muhasebegrup ??= new FlowGroup("Muhasebegrup", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);


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