﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace atak_testcase
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class atak_testcaseEntities1 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new atak_testcaseEntities1 object using the connection string found in the 'atak_testcaseEntities1' section of the application configuration file.
        /// </summary>
        public atak_testcaseEntities1() : base("name=atak_testcaseEntities1", "atak_testcaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new atak_testcaseEntities1 object.
        /// </summary>
        public atak_testcaseEntities1(string connectionString) : base(connectionString, "atak_testcaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new atak_testcaseEntities1 object.
        /// </summary>
        public atak_testcaseEntities1(EntityConnection connection) : base(connection, "atak_testcaseEntities1")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Fotograf> Fotograf
        {
            get
            {
                if ((_Fotograf == null))
                {
                    _Fotograf = base.CreateObjectSet<Fotograf>("Fotograf");
                }
                return _Fotograf;
            }
        }
        private ObjectSet<Fotograf> _Fotograf;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Haber> Haber
        {
            get
            {
                if ((_Haber == null))
                {
                    _Haber = base.CreateObjectSet<Haber>("Haber");
                }
                return _Haber;
            }
        }
        private ObjectSet<Haber> _Haber;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Kategori> Kategori
        {
            get
            {
                if ((_Kategori == null))
                {
                    _Kategori = base.CreateObjectSet<Kategori>("Kategori");
                }
                return _Kategori;
            }
        }
        private ObjectSet<Kategori> _Kategori;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Sayfa> Sayfa
        {
            get
            {
                if ((_Sayfa == null))
                {
                    _Sayfa = base.CreateObjectSet<Sayfa>("Sayfa");
                }
                return _Sayfa;
            }
        }
        private ObjectSet<Sayfa> _Sayfa;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Video> Video
        {
            get
            {
                if ((_Video == null))
                {
                    _Video = base.CreateObjectSet<Video>("Video");
                }
                return _Video;
            }
        }
        private ObjectSet<Video> _Video;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Yonetici> Yonetici
        {
            get
            {
                if ((_Yonetici == null))
                {
                    _Yonetici = base.CreateObjectSet<Yonetici>("Yonetici");
                }
                return _Yonetici;
            }
        }
        private ObjectSet<Yonetici> _Yonetici;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Ziyaretci> Ziyaretci
        {
            get
            {
                if ((_Ziyaretci == null))
                {
                    _Ziyaretci = base.CreateObjectSet<Ziyaretci>("Ziyaretci");
                }
                return _Ziyaretci;
            }
        }
        private ObjectSet<Ziyaretci> _Ziyaretci;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Fotograf EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFotograf(Fotograf fotograf)
        {
            base.AddObject("Fotograf", fotograf);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Haber EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHaber(Haber haber)
        {
            base.AddObject("Haber", haber);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Kategori EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToKategori(Kategori kategori)
        {
            base.AddObject("Kategori", kategori);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Sayfa EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSayfa(Sayfa sayfa)
        {
            base.AddObject("Sayfa", sayfa);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Video EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVideo(Video video)
        {
            base.AddObject("Video", video);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Yonetici EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToYonetici(Yonetici yonetici)
        {
            base.AddObject("Yonetici", yonetici);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Ziyaretci EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToZiyaretci(Ziyaretci ziyaretci)
        {
            base.AddObject("Ziyaretci", ziyaretci);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Fotograf")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Fotograf : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Fotograf object.
        /// </summary>
        /// <param name="fotografID">Initial value of the fotografID property.</param>
        public static Fotograf CreateFotograf(global::System.Int32 fotografID)
        {
            Fotograf fotograf = new Fotograf();
            fotograf.fotografID = fotografID;
            return fotograf;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 fotografID
        {
            get
            {
                return _fotografID;
            }
            set
            {
                if (_fotografID != value)
                {
                    OnfotografIDChanging(value);
                    ReportPropertyChanging("fotografID");
                    _fotografID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("fotografID");
                    OnfotografIDChanged();
                }
            }
        }
        private global::System.Int32 _fotografID;
        partial void OnfotografIDChanging(global::System.Int32 value);
        partial void OnfotografIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String fotografYol
        {
            get
            {
                return _fotografYol;
            }
            set
            {
                OnfotografYolChanging(value);
                ReportPropertyChanging("fotografYol");
                _fotografYol = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("fotografYol");
                OnfotografYolChanged();
            }
        }
        private global::System.String _fotografYol;
        partial void OnfotografYolChanging(global::System.String value);
        partial void OnfotografYolChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String fotografAciklama
        {
            get
            {
                return _fotografAciklama;
            }
            set
            {
                OnfotografAciklamaChanging(value);
                ReportPropertyChanging("fotografAciklama");
                _fotografAciklama = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("fotografAciklama");
                OnfotografAciklamaChanged();
            }
        }
        private global::System.String _fotografAciklama;
        partial void OnfotografAciklamaChanging(global::System.String value);
        partial void OnfotografAciklamaChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Haber")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Haber : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Haber object.
        /// </summary>
        /// <param name="haberID">Initial value of the haberID property.</param>
        public static Haber CreateHaber(global::System.Int32 haberID)
        {
            Haber haber = new Haber();
            haber.haberID = haberID;
            return haber;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 haberID
        {
            get
            {
                return _haberID;
            }
            set
            {
                if (_haberID != value)
                {
                    OnhaberIDChanging(value);
                    ReportPropertyChanging("haberID");
                    _haberID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("haberID");
                    OnhaberIDChanged();
                }
            }
        }
        private global::System.Int32 _haberID;
        partial void OnhaberIDChanging(global::System.Int32 value);
        partial void OnhaberIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String haberBaslik
        {
            get
            {
                return _haberBaslik;
            }
            set
            {
                OnhaberBaslikChanging(value);
                ReportPropertyChanging("haberBaslik");
                _haberBaslik = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("haberBaslik");
                OnhaberBaslikChanged();
            }
        }
        private global::System.String _haberBaslik;
        partial void OnhaberBaslikChanging(global::System.String value);
        partial void OnhaberBaslikChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String haberIcerik
        {
            get
            {
                return _haberIcerik;
            }
            set
            {
                OnhaberIcerikChanging(value);
                ReportPropertyChanging("haberIcerik");
                _haberIcerik = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("haberIcerik");
                OnhaberIcerikChanged();
            }
        }
        private global::System.String _haberIcerik;
        partial void OnhaberIcerikChanging(global::System.String value);
        partial void OnhaberIcerikChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> haberTarih
        {
            get
            {
                return _haberTarih;
            }
            set
            {
                OnhaberTarihChanging(value);
                ReportPropertyChanging("haberTarih");
                _haberTarih = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("haberTarih");
                OnhaberTarihChanged();
            }
        }
        private Nullable<global::System.DateTime> _haberTarih;
        partial void OnhaberTarihChanging(Nullable<global::System.DateTime> value);
        partial void OnhaberTarihChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> haberOkunmaSayisi
        {
            get
            {
                return _haberOkunmaSayisi;
            }
            set
            {
                OnhaberOkunmaSayisiChanging(value);
                ReportPropertyChanging("haberOkunmaSayisi");
                _haberOkunmaSayisi = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("haberOkunmaSayisi");
                OnhaberOkunmaSayisiChanged();
            }
        }
        private Nullable<global::System.Int32> _haberOkunmaSayisi;
        partial void OnhaberOkunmaSayisiChanging(Nullable<global::System.Int32> value);
        partial void OnhaberOkunmaSayisiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String haberTag
        {
            get
            {
                return _haberTag;
            }
            set
            {
                OnhaberTagChanging(value);
                ReportPropertyChanging("haberTag");
                _haberTag = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("haberTag");
                OnhaberTagChanged();
            }
        }
        private global::System.String _haberTag;
        partial void OnhaberTagChanging(global::System.String value);
        partial void OnhaberTagChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Kategori")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Kategori : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Kategori object.
        /// </summary>
        /// <param name="kategoriID">Initial value of the kategoriID property.</param>
        public static Kategori CreateKategori(global::System.Int32 kategoriID)
        {
            Kategori kategori = new Kategori();
            kategori.kategoriID = kategoriID;
            return kategori;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 kategoriID
        {
            get
            {
                return _kategoriID;
            }
            set
            {
                if (_kategoriID != value)
                {
                    OnkategoriIDChanging(value);
                    ReportPropertyChanging("kategoriID");
                    _kategoriID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("kategoriID");
                    OnkategoriIDChanged();
                }
            }
        }
        private global::System.Int32 _kategoriID;
        partial void OnkategoriIDChanging(global::System.Int32 value);
        partial void OnkategoriIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String kategoriAd
        {
            get
            {
                return _kategoriAd;
            }
            set
            {
                OnkategoriAdChanging(value);
                ReportPropertyChanging("kategoriAd");
                _kategoriAd = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("kategoriAd");
                OnkategoriAdChanged();
            }
        }
        private global::System.String _kategoriAd;
        partial void OnkategoriAdChanging(global::System.String value);
        partial void OnkategoriAdChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Sayfa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Sayfa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Sayfa object.
        /// </summary>
        /// <param name="sayfaID">Initial value of the sayfaID property.</param>
        public static Sayfa CreateSayfa(global::System.Int32 sayfaID)
        {
            Sayfa sayfa = new Sayfa();
            sayfa.sayfaID = sayfaID;
            return sayfa;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 sayfaID
        {
            get
            {
                return _sayfaID;
            }
            set
            {
                if (_sayfaID != value)
                {
                    OnsayfaIDChanging(value);
                    ReportPropertyChanging("sayfaID");
                    _sayfaID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("sayfaID");
                    OnsayfaIDChanged();
                }
            }
        }
        private global::System.Int32 _sayfaID;
        partial void OnsayfaIDChanging(global::System.Int32 value);
        partial void OnsayfaIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String sayfaAdi
        {
            get
            {
                return _sayfaAdi;
            }
            set
            {
                OnsayfaAdiChanging(value);
                ReportPropertyChanging("sayfaAdi");
                _sayfaAdi = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("sayfaAdi");
                OnsayfaAdiChanged();
            }
        }
        private global::System.String _sayfaAdi;
        partial void OnsayfaAdiChanging(global::System.String value);
        partial void OnsayfaAdiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> sayfaOkunma
        {
            get
            {
                return _sayfaOkunma;
            }
            set
            {
                OnsayfaOkunmaChanging(value);
                ReportPropertyChanging("sayfaOkunma");
                _sayfaOkunma = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("sayfaOkunma");
                OnsayfaOkunmaChanged();
            }
        }
        private Nullable<global::System.Int32> _sayfaOkunma;
        partial void OnsayfaOkunmaChanging(Nullable<global::System.Int32> value);
        partial void OnsayfaOkunmaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String sayfaKategori
        {
            get
            {
                return _sayfaKategori;
            }
            set
            {
                OnsayfaKategoriChanging(value);
                ReportPropertyChanging("sayfaKategori");
                _sayfaKategori = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("sayfaKategori");
                OnsayfaKategoriChanged();
            }
        }
        private global::System.String _sayfaKategori;
        partial void OnsayfaKategoriChanging(global::System.String value);
        partial void OnsayfaKategoriChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Video")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Video : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Video object.
        /// </summary>
        /// <param name="videoID">Initial value of the videoID property.</param>
        public static Video CreateVideo(global::System.Int32 videoID)
        {
            Video video = new Video();
            video.videoID = videoID;
            return video;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 videoID
        {
            get
            {
                return _videoID;
            }
            set
            {
                if (_videoID != value)
                {
                    OnvideoIDChanging(value);
                    ReportPropertyChanging("videoID");
                    _videoID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("videoID");
                    OnvideoIDChanged();
                }
            }
        }
        private global::System.Int32 _videoID;
        partial void OnvideoIDChanging(global::System.Int32 value);
        partial void OnvideoIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String videoYol
        {
            get
            {
                return _videoYol;
            }
            set
            {
                OnvideoYolChanging(value);
                ReportPropertyChanging("videoYol");
                _videoYol = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("videoYol");
                OnvideoYolChanged();
            }
        }
        private global::System.String _videoYol;
        partial void OnvideoYolChanging(global::System.String value);
        partial void OnvideoYolChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String videoAciklama
        {
            get
            {
                return _videoAciklama;
            }
            set
            {
                OnvideoAciklamaChanging(value);
                ReportPropertyChanging("videoAciklama");
                _videoAciklama = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("videoAciklama");
                OnvideoAciklamaChanged();
            }
        }
        private global::System.String _videoAciklama;
        partial void OnvideoAciklamaChanging(global::System.String value);
        partial void OnvideoAciklamaChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Yonetici")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Yonetici : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Yonetici object.
        /// </summary>
        /// <param name="yoneticiID">Initial value of the yoneticiID property.</param>
        public static Yonetici CreateYonetici(global::System.Int32 yoneticiID)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.yoneticiID = yoneticiID;
            return yonetici;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 yoneticiID
        {
            get
            {
                return _yoneticiID;
            }
            set
            {
                if (_yoneticiID != value)
                {
                    OnyoneticiIDChanging(value);
                    ReportPropertyChanging("yoneticiID");
                    _yoneticiID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("yoneticiID");
                    OnyoneticiIDChanged();
                }
            }
        }
        private global::System.Int32 _yoneticiID;
        partial void OnyoneticiIDChanging(global::System.Int32 value);
        partial void OnyoneticiIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String yoneticiAdSoyad
        {
            get
            {
                return _yoneticiAdSoyad;
            }
            set
            {
                OnyoneticiAdSoyadChanging(value);
                ReportPropertyChanging("yoneticiAdSoyad");
                _yoneticiAdSoyad = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("yoneticiAdSoyad");
                OnyoneticiAdSoyadChanged();
            }
        }
        private global::System.String _yoneticiAdSoyad;
        partial void OnyoneticiAdSoyadChanging(global::System.String value);
        partial void OnyoneticiAdSoyadChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String yoneticiEmail
        {
            get
            {
                return _yoneticiEmail;
            }
            set
            {
                OnyoneticiEmailChanging(value);
                ReportPropertyChanging("yoneticiEmail");
                _yoneticiEmail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("yoneticiEmail");
                OnyoneticiEmailChanged();
            }
        }
        private global::System.String _yoneticiEmail;
        partial void OnyoneticiEmailChanging(global::System.String value);
        partial void OnyoneticiEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String yoneticiKullaniciAd
        {
            get
            {
                return _yoneticiKullaniciAd;
            }
            set
            {
                OnyoneticiKullaniciAdChanging(value);
                ReportPropertyChanging("yoneticiKullaniciAd");
                _yoneticiKullaniciAd = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("yoneticiKullaniciAd");
                OnyoneticiKullaniciAdChanged();
            }
        }
        private global::System.String _yoneticiKullaniciAd;
        partial void OnyoneticiKullaniciAdChanging(global::System.String value);
        partial void OnyoneticiKullaniciAdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String yoneticiSifre
        {
            get
            {
                return _yoneticiSifre;
            }
            set
            {
                OnyoneticiSifreChanging(value);
                ReportPropertyChanging("yoneticiSifre");
                _yoneticiSifre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("yoneticiSifre");
                OnyoneticiSifreChanged();
            }
        }
        private global::System.String _yoneticiSifre;
        partial void OnyoneticiSifreChanging(global::System.String value);
        partial void OnyoneticiSifreChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="atak_testcaseModel", Name="Ziyaretci")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Ziyaretci : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Ziyaretci object.
        /// </summary>
        /// <param name="ziyaretciID">Initial value of the ziyaretciID property.</param>
        public static Ziyaretci CreateZiyaretci(global::System.Int32 ziyaretciID)
        {
            Ziyaretci ziyaretci = new Ziyaretci();
            ziyaretci.ziyaretciID = ziyaretciID;
            return ziyaretci;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ziyaretciID
        {
            get
            {
                return _ziyaretciID;
            }
            set
            {
                if (_ziyaretciID != value)
                {
                    OnziyaretciIDChanging(value);
                    ReportPropertyChanging("ziyaretciID");
                    _ziyaretciID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ziyaretciID");
                    OnziyaretciIDChanged();
                }
            }
        }
        private global::System.Int32 _ziyaretciID;
        partial void OnziyaretciIDChanging(global::System.Int32 value);
        partial void OnziyaretciIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ZiyaretciAdSoyad
        {
            get
            {
                return _ZiyaretciAdSoyad;
            }
            set
            {
                OnZiyaretciAdSoyadChanging(value);
                ReportPropertyChanging("ZiyaretciAdSoyad");
                _ZiyaretciAdSoyad = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ZiyaretciAdSoyad");
                OnZiyaretciAdSoyadChanged();
            }
        }
        private global::System.String _ZiyaretciAdSoyad;
        partial void OnZiyaretciAdSoyadChanging(global::System.String value);
        partial void OnZiyaretciAdSoyadChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ziyaretciEmail
        {
            get
            {
                return _ziyaretciEmail;
            }
            set
            {
                OnziyaretciEmailChanging(value);
                ReportPropertyChanging("ziyaretciEmail");
                _ziyaretciEmail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ziyaretciEmail");
                OnziyaretciEmailChanged();
            }
        }
        private global::System.String _ziyaretciEmail;
        partial void OnziyaretciEmailChanging(global::System.String value);
        partial void OnziyaretciEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ziyaretciIcerik
        {
            get
            {
                return _ziyaretciIcerik;
            }
            set
            {
                OnziyaretciIcerikChanging(value);
                ReportPropertyChanging("ziyaretciIcerik");
                _ziyaretciIcerik = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ziyaretciIcerik");
                OnziyaretciIcerikChanged();
            }
        }
        private global::System.String _ziyaretciIcerik;
        partial void OnziyaretciIcerikChanging(global::System.String value);
        partial void OnziyaretciIcerikChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> ziyaretciOnay
        {
            get
            {
                return _ziyaretciOnay;
            }
            set
            {
                OnziyaretciOnayChanging(value);
                ReportPropertyChanging("ziyaretciOnay");
                _ziyaretciOnay = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ziyaretciOnay");
                OnziyaretciOnayChanged();
            }
        }
        private Nullable<global::System.Boolean> _ziyaretciOnay;
        partial void OnziyaretciOnayChanging(Nullable<global::System.Boolean> value);
        partial void OnziyaretciOnayChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ziyaretciTarih
        {
            get
            {
                return _ziyaretciTarih;
            }
            set
            {
                OnziyaretciTarihChanging(value);
                ReportPropertyChanging("ziyaretciTarih");
                _ziyaretciTarih = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ziyaretciTarih");
                OnziyaretciTarihChanged();
            }
        }
        private Nullable<global::System.DateTime> _ziyaretciTarih;
        partial void OnziyaretciTarihChanging(Nullable<global::System.DateTime> value);
        partial void OnziyaretciTarihChanged();

        #endregion

    
    }

    #endregion

    
}
