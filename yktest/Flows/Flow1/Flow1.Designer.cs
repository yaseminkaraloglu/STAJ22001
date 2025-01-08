using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace yktest.Flows
{
    [WorkflowIdentifier("a8afa6b9-6a1e-4b7c-8e84-72aa5bb46cc2")]
    public partial class Flow1 : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowEnd _flowEnd2;
		private FlowPosition _position1;
		private FlowPosition _position2;
		private FlowPosition _position3;
		private FlowAssign _assignment1;
		private FlowAssign _assignment2;
		private FlowMail _notification1;
		private Variable _variable1;
		private FlowGroup _positionGroup1;
		private FlowDocument _document1;
		private FlowSetDocumentId _setDocumentId1;
		private FlowDeleteDocument _deleteDocument1;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowEnd FlowEnd2 => _flowEnd2 ??= new FlowEnd("FlowEnd2", _workflowData, this);
		private FlowPosition Position1 => _position1 ??= new FlowPosition("Position1", _workflowData, this);
		private FlowPosition Position2 => _position2 ??= new FlowPosition("Position2", _workflowData, this);
		private FlowPosition Position3 => _position3 ??= new FlowPosition("Position3", _workflowData, this);
		private FlowAssign Assignment1 => _assignment1 ??= new FlowAssign("Assignment1", _workflowData, this);
		private FlowAssign Assignment2 => _assignment2 ??= new FlowAssign("Assignment2", _workflowData, this);
		private FlowMail Notification1 => _notification1 ??= new FlowMail("Notification1", _workflowData, this);
		private Variable Variable1 => _variable1 ??= new Variable("Variable1", _workflowData, this);
		private FlowGroup PositionGroup1 => _positionGroup1 ??= new FlowGroup("PositionGroup1", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);
		private FlowSetDocumentId SetDocumentId1 => _setDocumentId1 ??= new FlowSetDocumentId("SetDocumentId1", _workflowData, this);
		private FlowDeleteDocument DeleteDocument1 => _deleteDocument1 ??= new FlowDeleteDocument("DeleteDocument1", _workflowData, this);


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