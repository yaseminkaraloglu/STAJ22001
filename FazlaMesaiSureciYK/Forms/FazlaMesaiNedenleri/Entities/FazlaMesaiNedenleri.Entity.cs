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

namespace FazlaMesaiSureciYK.Entities {
    
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleri")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleriEntity : FormEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriEntity> {
        
        private E_FazlaMesaiSureciYK_FazlaMesaiNedenleriVREntity _VersionEntity;
        
        private RDEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDMLEntity> _RD;
        
        private RDCEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCMLEntity> _RDC;
        
        private GridEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniMLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity> _E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni;
        
        public E_FazlaMesaiSureciYK_FazlaMesaiNedenleriEntity() {
            this.VersionEntity = new E_FazlaMesaiSureciYK_FazlaMesaiNedenleriVREntity();
            this.RD = new RDEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCMLEntity>();
            this.E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni = new GridEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniMLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity>();
            this.E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni.MLEntityEnabled = true;
            this.E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni.SLEntityEnabled = false;
        }
        
        public E_FazlaMesaiSureciYK_FazlaMesaiNedenleriVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public GridEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniMLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity> E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni {
            get {
                return this._E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni;
            }
            set {
                this._E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni = value;
            }
        }
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeni")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniEntity : GridEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniMLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity> {
        
        private Bimser.Framework.Domain.DataField<System.Nullable<decimal>> _DGID;
        
        public E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniEntity() {
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
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniMLEntity : GridMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _MesaiNedeni;
        
        [ColumnOptionsAttribute(Name="MesaiNedeni", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> MesaiNedeni {
            get {
                return this._MesaiNedeni;
            }
            set {
                this._MesaiNedeni = value;
            }
        }
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSL")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLEntity : GridSLEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity : GridSLMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleri_dgFazlaMesaiNedeniSLMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleriVR")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleriVREntity : VersionEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriVREntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDC")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCEntity : RDCEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCMLEntity : RDCMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRD")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDEntity : RDEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDMLEntity : RDMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiNedenleriRDMLEntity> {
    }
}




