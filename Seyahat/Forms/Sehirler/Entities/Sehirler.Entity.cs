//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace Seyahat.Entities {
    
    
    [TableOptions(TableName="E_Seyahat_Sehirler")]
    public class E_Seyahat_SehirlerEntity : FormEntity<E_Seyahat_SehirlerEntity> {
        
        private E_Seyahat_SehirlerVREntity _VersionEntity;
        
        private RDEntityCollection<E_Seyahat_SehirlerRDEntity, E_Seyahat_SehirlerRDMLEntity> _RD;
        
        private RDCEntityCollection<E_Seyahat_SehirlerRDCEntity, E_Seyahat_SehirlerRDCMLEntity> _RDC;
        
        private GridEntityCollection<E_Seyahat_Sehirler_DGSehirlerEntity, E_Seyahat_Sehirler_DGSehirlerMLEntity, E_Seyahat_Sehirler_DGSehirlerSLEntity, E_Seyahat_Sehirler_DGSehirlerSLMLEntity> _E_Seyahat_Sehirler_DGSehirler;
        
        public E_Seyahat_SehirlerEntity() {
            this.VersionEntity = new E_Seyahat_SehirlerVREntity();
            this.RD = new RDEntityCollection<E_Seyahat_SehirlerRDEntity, E_Seyahat_SehirlerRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_Seyahat_SehirlerRDCEntity, E_Seyahat_SehirlerRDCMLEntity>();
            this.E_Seyahat_Sehirler_DGSehirler = new GridEntityCollection<E_Seyahat_Sehirler_DGSehirlerEntity, E_Seyahat_Sehirler_DGSehirlerMLEntity, E_Seyahat_Sehirler_DGSehirlerSLEntity, E_Seyahat_Sehirler_DGSehirlerSLMLEntity>();
            this.E_Seyahat_Sehirler_DGSehirler.MLEntityEnabled = true;
            this.E_Seyahat_Sehirler_DGSehirler.SLEntityEnabled = false;
        }
        
        public E_Seyahat_SehirlerVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_Seyahat_SehirlerRDEntity, E_Seyahat_SehirlerRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_Seyahat_SehirlerRDCEntity, E_Seyahat_SehirlerRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public GridEntityCollection<E_Seyahat_Sehirler_DGSehirlerEntity, E_Seyahat_Sehirler_DGSehirlerMLEntity, E_Seyahat_Sehirler_DGSehirlerSLEntity, E_Seyahat_Sehirler_DGSehirlerSLMLEntity> E_Seyahat_Sehirler_DGSehirler {
            get {
                return this._E_Seyahat_Sehirler_DGSehirler;
            }
            set {
                this._E_Seyahat_Sehirler_DGSehirler = value;
            }
        }
    }
    
    [TableOptions(TableName="E_Seyahat_Sehirler_DGSehirler")]
    public class E_Seyahat_Sehirler_DGSehirlerEntity : GridEntity<E_Seyahat_Sehirler_DGSehirlerEntity, E_Seyahat_Sehirler_DGSehirlerMLEntity, E_Seyahat_Sehirler_DGSehirlerSLEntity, E_Seyahat_Sehirler_DGSehirlerSLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _DGID;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _Enlem;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _Boylam;
        
        public E_Seyahat_Sehirler_DGSehirlerEntity() {
        }
        
        [ColumnOptionsAttribute(Name="DGID", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> DGID {
            get {
                return this._DGID;
            }
            set {
                this._DGID = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="Enlem", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> Enlem {
            get {
                return this._Enlem;
            }
            set {
                this._Enlem = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="Boylam", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<decimal>> Boylam {
            get {
                return this._Boylam;
            }
            set {
                this._Boylam = value;
            }
        }
    }
    
    [TableOptions(TableName="E_Seyahat_Sehirler_DGSehirlerML")]
    public class E_Seyahat_Sehirler_DGSehirlerMLEntity : GridMLEntity<E_Seyahat_Sehirler_DGSehirlerMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _Sehirismi;
        
        [ColumnOptionsAttribute(Name="Sehirismi", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> Sehirismi {
            get {
                return this._Sehirismi;
            }
            set {
                this._Sehirismi = value;
            }
        }
    }
    
    [TableOptions(TableName="E_Seyahat_Sehirler_DGSehirlerSL")]
    public class E_Seyahat_Sehirler_DGSehirlerSLEntity : GridSLEntity<E_Seyahat_Sehirler_DGSehirlerSLEntity, E_Seyahat_Sehirler_DGSehirlerSLMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_Sehirler_DGSehirlerSLML")]
    public class E_Seyahat_Sehirler_DGSehirlerSLMLEntity : GridSLMLEntity<E_Seyahat_Sehirler_DGSehirlerSLMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_SehirlerVR")]
    public class E_Seyahat_SehirlerVREntity : VersionEntity<E_Seyahat_SehirlerVREntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_SehirlerRDC")]
    public class E_Seyahat_SehirlerRDCEntity : RDCEntity<E_Seyahat_SehirlerRDCEntity, E_Seyahat_SehirlerRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_SehirlerRDCML")]
    public class E_Seyahat_SehirlerRDCMLEntity : RDCMLEntity<E_Seyahat_SehirlerRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_SehirlerRD")]
    public class E_Seyahat_SehirlerRDEntity : RDEntity<E_Seyahat_SehirlerRDEntity, E_Seyahat_SehirlerRDMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_SehirlerRDML")]
    public class E_Seyahat_SehirlerRDMLEntity : RDMLEntity<E_Seyahat_SehirlerRDMLEntity> {
    }
}




