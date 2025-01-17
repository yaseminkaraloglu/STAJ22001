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
    
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormu")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuEntity : FormEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuEntity> {
        
        private Bimser.Framework.Domain.DataField<System.DateTimeOffset> _tpBaslangicSaati;
        
        private Bimser.Framework.Domain.DataField<System.DateTimeOffset> _tpBitisSaati;
        
        private Bimser.Framework.Domain.DataField<System.Nullable<bool>> _removeValue;
        
        private Bimser.Framework.Domain.DataField<System.DateTimeOffset> _dtTarih;
        
        private Bimser.Framework.Domain.DataField<string> _umTalepEden;
        
        private E_FazlaMesaiSureciYK_FazlaMesaiFormuVREntity _VersionEntity;
        
        private RDEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDMLEntity> _RD;
        
        private RDCEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCMLEntity> _RDC;
        
        private MLEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuMLEntity> _ML;
        
        private SLEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuSLMLEntity> _SL;
        
        public E_FazlaMesaiSureciYK_FazlaMesaiFormuEntity() {
            this.ML = new MLEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuMLEntity>();
            this.VersionEntity = new E_FazlaMesaiSureciYK_FazlaMesaiFormuVREntity();
            this.RD = new RDEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDMLEntity>();
            this.RDC = new RDCEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCMLEntity>();
            this.SL = new SLEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuSLMLEntity>();
        }
        
        [ColumnOptionsAttribute(Name="tpBaslangicSaati", Mandatory=true)]
        public Bimser.Framework.Domain.DataField<System.DateTimeOffset> tpBaslangicSaati {
            get {
                return this._tpBaslangicSaati;
            }
            set {
                this._tpBaslangicSaati = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="tpBitisSaati", Mandatory=true)]
        public Bimser.Framework.Domain.DataField<System.DateTimeOffset> tpBitisSaati {
            get {
                return this._tpBitisSaati;
            }
            set {
                this._tpBitisSaati = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="removeValue", Mandatory=false)]
        public Bimser.Framework.Domain.DataField<System.Nullable<bool>> removeValue {
            get {
                return this._removeValue;
            }
            set {
                this._removeValue = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="dtTarih", Mandatory=true)]
        public Bimser.Framework.Domain.DataField<System.DateTimeOffset> dtTarih {
            get {
                return this._dtTarih;
            }
            set {
                this._dtTarih = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="umTalepEden", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> umTalepEden {
            get {
                return this._umTalepEden;
            }
            set {
                this._umTalepEden = value;
            }
        }
        
        public E_FazlaMesaiSureciYK_FazlaMesaiFormuVREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
        
        public MLEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuMLEntity> ML {
            get {
                return this._ML;
            }
            set {
                this._ML = value;
            }
        }
        
        public SLEntityCollection<E_FazlaMesaiSureciYK_FazlaMesaiFormuSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuSLMLEntity> SL {
            get {
                return this._SL;
            }
            set {
                this._SL = value;
            }
        }
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuMLEntity : MLEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuMLEntity> {
        
        private Bimser.Framework.Domain.DataField<string> _umDepartman;
        
        private Bimser.Framework.Domain.DataField<string> _nbFazlaMesaiSuresi;
        
        private Bimser.Framework.Domain.DataField<string> _umUnvan;
        
        private Bimser.Framework.Domain.DataField<string> _taAciklama;
        
        [ColumnOptionsAttribute(Name="umDepartman", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> umDepartman {
            get {
                return this._umDepartman;
            }
            set {
                this._umDepartman = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="nbFazlaMesaiSuresi", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> nbFazlaMesaiSuresi {
            get {
                return this._nbFazlaMesaiSuresi;
            }
            set {
                this._nbFazlaMesaiSuresi = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="umUnvan", Mandatory=false, Size=50)]
        public Bimser.Framework.Domain.DataField<string> umUnvan {
            get {
                return this._umUnvan;
            }
            set {
                this._umUnvan = value;
            }
        }
        
        [ColumnOptionsAttribute(Name="taAciklama", Mandatory=false, Size=250)]
        public Bimser.Framework.Domain.DataField<string> taAciklama {
            get {
                return this._taAciklama;
            }
            set {
                this._taAciklama = value;
            }
        }
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuSL")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuSLEntity : SLEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuSLEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuSLMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuSLML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuSLMLEntity : SLMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuSLMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuVR")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuVREntity : VersionEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuVREntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuRDC")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCEntity : RDCEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCMLEntity : RDCMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDCMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuRD")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuRDEntity : RDEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDEntity, E_FazlaMesaiSureciYK_FazlaMesaiFormuRDMLEntity> {
    }
    
    [TableOptions(TableName="E_FazlaMesaiSureciYK_FazlaMesaiFormuRDML")]
    public class E_FazlaMesaiSureciYK_FazlaMesaiFormuRDMLEntity : RDMLEntity<E_FazlaMesaiSureciYK_FazlaMesaiFormuRDMLEntity> {
    }
}




