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
    
    
    [TableOptions(TableName="E_Seyahat_UcusFiyatStandarti")]
    public class E_Seyahat_UcusFiyatStandartiEntity : FormEntity<E_Seyahat_UcusFiyatStandartiEntity> {
        
        private Bimser.Framework.Domain.DataField<decimal> _MilUcret;
        
        private Bimser.Framework.Domain.DataField<decimal> _BagajHak;
        
        private Bimser.Framework.Domain.DataField<decimal> _BagajEkUcret;
        
        private E_Seyahat_UcusFiyatStandartiVREntity _VersionEntity;
        
        private RDEntityCollection<E_Seyahat_UcusFiyatStandartiRDEntity, E_Seyahat_UcusFiyatStandartiRDMLEntity> _RD;
        
        private RDCEntityCollection<E_Seyahat_UcusFiyatStandartiRDCEntity, E_Seyahat_UcusFiyatStandartiRDCMLEntity> _RDC;
        
        public E_Seyahat_UcusFiyatStandartiEntity() {
            this.VersionEntity = new E_Seyahat_UcusFiyatStandartiVREntity();
            this.RD = new RDEntityCollection<E_Seyahat_UcusFiyatStandartiRDEntity, E_Seyahat_UcusFiyatStandartiRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_Seyahat_UcusFiyatStandartiRDCEntity, E_Seyahat_UcusFiyatStandartiRDCMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="MilUcret", Mandatory=true)]
        public Bimser.Framework.Domain.DataField<decimal> MilUcret {
            get {
                return this._MilUcret;
            }
            set {
                this._MilUcret = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="BagajHak", Mandatory=true)]
        public Bimser.Framework.Domain.DataField<decimal> BagajHak {
            get {
                return this._BagajHak;
            }
            set {
                this._BagajHak = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="BagajEkUcret", Mandatory=true)]
        public Bimser.Framework.Domain.DataField<decimal> BagajEkUcret {
            get {
                return this._BagajEkUcret;
            }
            set {
                this._BagajEkUcret = value;
            }
        }
        
        public E_Seyahat_UcusFiyatStandartiVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_Seyahat_UcusFiyatStandartiRDEntity, E_Seyahat_UcusFiyatStandartiRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_Seyahat_UcusFiyatStandartiRDCEntity, E_Seyahat_UcusFiyatStandartiRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
    }
    
    [TableOptions(TableName="E_Seyahat_UcusFiyatStandartiVR")]
    public class E_Seyahat_UcusFiyatStandartiVREntity : VersionEntity<E_Seyahat_UcusFiyatStandartiVREntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_UcusFiyatStandartiRDC")]
    public class E_Seyahat_UcusFiyatStandartiRDCEntity : RDCEntity<E_Seyahat_UcusFiyatStandartiRDCEntity, E_Seyahat_UcusFiyatStandartiRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_UcusFiyatStandartiRDCML")]
    public class E_Seyahat_UcusFiyatStandartiRDCMLEntity : RDCMLEntity<E_Seyahat_UcusFiyatStandartiRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_UcusFiyatStandartiRD")]
    public class E_Seyahat_UcusFiyatStandartiRDEntity : RDEntity<E_Seyahat_UcusFiyatStandartiRDEntity, E_Seyahat_UcusFiyatStandartiRDMLEntity> {
    }
    
    [TableOptions(TableName="E_Seyahat_UcusFiyatStandartiRDML")]
    public class E_Seyahat_UcusFiyatStandartiRDMLEntity : RDMLEntity<E_Seyahat_UcusFiyatStandartiRDMLEntity> {
    }
}




