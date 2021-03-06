﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMech.Web
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="webmech")]
	public partial class WebMechDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSurface(Surface instance);
    partial void UpdateSurface(Surface instance);
    partial void DeleteSurface(Surface instance);
    partial void InsertSample(Sample instance);
    partial void UpdateSample(Sample instance);
    partial void DeleteSample(Sample instance);
    partial void InsertPoint(Point instance);
    partial void UpdatePoint(Point instance);
    partial void DeletePoint(Point instance);
    partial void InsertParameter(Parameter instance);
    partial void UpdateParameter(Parameter instance);
    partial void DeleteParameter(Parameter instance);
    partial void InsertStatistic(Statistic instance);
    partial void UpdateStatistic(Statistic instance);
    partial void DeleteStatistic(Statistic instance);
    #endregion
		
		public WebMechDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["webmechConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WebMechDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebMechDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebMechDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebMechDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Surface> Surfaces
		{
			get
			{
				return this.GetTable<Surface>();
			}
		}
		
		public System.Data.Linq.Table<Sample> Samples
		{
			get
			{
				return this.GetTable<Sample>();
			}
		}
		
		public System.Data.Linq.Table<Point> Points
		{
			get
			{
				return this.GetTable<Point>();
			}
		}
		
		public System.Data.Linq.Table<Parameter> Parameters
		{
			get
			{
				return this.GetTable<Parameter>();
			}
		}
		
		public System.Data.Linq.Table<Statistic> Statistics
		{
			get
			{
				return this.GetTable<Statistic>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Surface")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Surface : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _surface_id;
		
		private string _name;
		
		private System.DateTime _creation_date;
		
		private System.DateTime _modification_date;
		
		private EntitySet<Sample> _Samples;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsurface_idChanging(decimal value);
    partial void Onsurface_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Oncreation_dateChanging(System.DateTime value);
    partial void Oncreation_dateChanged();
    partial void Onmodification_dateChanging(System.DateTime value);
    partial void Onmodification_dateChanged();
    #endregion
		
		public Surface()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surface_id", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public decimal surface_id
		{
			get
			{
				return this._surface_id;
			}
			set
			{
				if ((this._surface_id != value))
				{
					this.Onsurface_idChanging(value);
					this.SendPropertyChanging();
					this._surface_id = value;
					this.SendPropertyChanged("surface_id");
					this.Onsurface_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creation_date", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.DateTime creation_date
		{
			get
			{
				return this._creation_date;
			}
			set
			{
				if ((this._creation_date != value))
				{
					this.Oncreation_dateChanging(value);
					this.SendPropertyChanging();
					this._creation_date = value;
					this.SendPropertyChanged("creation_date");
					this.Oncreation_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modification_date", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.DateTime modification_date
		{
			get
			{
				return this._modification_date;
			}
			set
			{
				if ((this._modification_date != value))
				{
					this.Onmodification_dateChanging(value);
					this.SendPropertyChanging();
					this._modification_date = value;
					this.SendPropertyChanged("modification_date");
					this.Onmodification_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Surface_Sample", Storage="_Samples", ThisKey="surface_id", OtherKey="surface_id")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5, EmitDefaultValue=false)]
		public EntitySet<Sample> Samples
		{
			get
			{
				if ((this.serializing 
							&& (this._Samples.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Samples;
			}
			set
			{
				this._Samples.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Samples(Sample entity)
		{
			this.SendPropertyChanging();
			entity.Surface = this;
		}
		
		private void detach_Samples(Sample entity)
		{
			this.SendPropertyChanging();
			entity.Surface = null;
		}
		
		private void Initialize()
		{
			this._Samples = new EntitySet<Sample>(new Action<Sample>(this.attach_Samples), new Action<Sample>(this.detach_Samples));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sample")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Sample : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _sample_id;
		
		private decimal _surface_id;
		
		private System.DateTime _sample_date;
		
		private System.DateTime _upload_date;
		
		private System.DateTime _modification_date;
		
		private string _filename;
		
		private EntitySet<Point> _Points;
		
		private EntitySet<Parameter> _Parameters;
		
		private EntityRef<Statistic> _Statistic;
		
		private EntityRef<Surface> _Surface;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsample_idChanging(decimal value);
    partial void Onsample_idChanged();
    partial void Onsurface_idChanging(decimal value);
    partial void Onsurface_idChanged();
    partial void Onsample_dateChanging(System.DateTime value);
    partial void Onsample_dateChanged();
    partial void Onupload_dateChanging(System.DateTime value);
    partial void Onupload_dateChanged();
    partial void Onmodification_dateChanging(System.DateTime value);
    partial void Onmodification_dateChanged();
    partial void OnfilenameChanging(string value);
    partial void OnfilenameChanged();
    #endregion
		
		public Sample()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_id", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public decimal sample_id
		{
			get
			{
				return this._sample_id;
			}
			set
			{
				if ((this._sample_id != value))
				{
					this.Onsample_idChanging(value);
					this.SendPropertyChanging();
					this._sample_id = value;
					this.SendPropertyChanged("sample_id");
					this.Onsample_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surface_id", DbType="Decimal(18,0) NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public decimal surface_id
		{
			get
			{
				return this._surface_id;
			}
			set
			{
				if ((this._surface_id != value))
				{
					if (this._Surface.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsurface_idChanging(value);
					this.SendPropertyChanging();
					this._surface_id = value;
					this.SendPropertyChanged("surface_id");
					this.Onsurface_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_date", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public System.DateTime sample_date
		{
			get
			{
				return this._sample_date;
			}
			set
			{
				if ((this._sample_date != value))
				{
					this.Onsample_dateChanging(value);
					this.SendPropertyChanging();
					this._sample_date = value;
					this.SendPropertyChanged("sample_date");
					this.Onsample_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_upload_date", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public System.DateTime upload_date
		{
			get
			{
				return this._upload_date;
			}
			set
			{
				if ((this._upload_date != value))
				{
					this.Onupload_dateChanging(value);
					this.SendPropertyChanging();
					this._upload_date = value;
					this.SendPropertyChanged("upload_date");
					this.Onupload_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modification_date", DbType="DateTime NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public System.DateTime modification_date
		{
			get
			{
				return this._modification_date;
			}
			set
			{
				if ((this._modification_date != value))
				{
					this.Onmodification_dateChanging(value);
					this.SendPropertyChanging();
					this._modification_date = value;
					this.SendPropertyChanged("modification_date");
					this.Onmodification_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_filename", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public string filename
		{
			get
			{
				return this._filename;
			}
			set
			{
				if ((this._filename != value))
				{
					this.OnfilenameChanging(value);
					this.SendPropertyChanging();
					this._filename = value;
					this.SendPropertyChanged("filename");
					this.OnfilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sample_Point", Storage="_Points", ThisKey="sample_id", OtherKey="sample_id")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7, EmitDefaultValue=false)]
		public EntitySet<Point> Points
		{
			get
			{
				if ((this.serializing 
							&& (this._Points.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Points;
			}
			set
			{
				this._Points.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sample_Parameter", Storage="_Parameters", ThisKey="sample_id", OtherKey="sample_id")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8, EmitDefaultValue=false)]
		public EntitySet<Parameter> Parameters
		{
			get
			{
				if ((this.serializing 
							&& (this._Parameters.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Parameters;
			}
			set
			{
				this._Parameters.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sample_Statistic", Storage="_Statistic", ThisKey="sample_id", OtherKey="sample_id", IsUnique=true, IsForeignKey=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9, EmitDefaultValue=false)]
		public Statistic Statistic
		{
			get
			{
				if ((this.serializing 
							&& (this._Statistic.HasLoadedOrAssignedValue == false)))
				{
					return null;
				}
				return this._Statistic.Entity;
			}
			set
			{
				Statistic previousValue = this._Statistic.Entity;
				if (((previousValue != value) 
							|| (this._Statistic.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Statistic.Entity = null;
						previousValue.Sample = null;
					}
					this._Statistic.Entity = value;
					if ((value != null))
					{
						value.Sample = this;
					}
					this.SendPropertyChanged("Statistic");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Surface_Sample", Storage="_Surface", ThisKey="surface_id", OtherKey="surface_id", IsForeignKey=true)]
		public Surface Surface
		{
			get
			{
				return this._Surface.Entity;
			}
			set
			{
				Surface previousValue = this._Surface.Entity;
				if (((previousValue != value) 
							|| (this._Surface.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Surface.Entity = null;
						previousValue.Samples.Remove(this);
					}
					this._Surface.Entity = value;
					if ((value != null))
					{
						value.Samples.Add(this);
						this._surface_id = value.surface_id;
					}
					else
					{
						this._surface_id = default(decimal);
					}
					this.SendPropertyChanged("Surface");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Points(Point entity)
		{
			this.SendPropertyChanging();
			entity.Sample = this;
		}
		
		private void detach_Points(Point entity)
		{
			this.SendPropertyChanging();
			entity.Sample = null;
		}
		
		private void attach_Parameters(Parameter entity)
		{
			this.SendPropertyChanging();
			entity.Sample = this;
		}
		
		private void detach_Parameters(Parameter entity)
		{
			this.SendPropertyChanging();
			entity.Sample = null;
		}
		
		private void Initialize()
		{
			this._Points = new EntitySet<Point>(new Action<Point>(this.attach_Points), new Action<Point>(this.detach_Points));
			this._Parameters = new EntitySet<Parameter>(new Action<Parameter>(this.attach_Parameters), new Action<Parameter>(this.detach_Parameters));
			this._Statistic = default(EntityRef<Statistic>);
			this._Surface = default(EntityRef<Surface>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Point")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Point : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _sample_id;
		
		private decimal _order;
		
		private double _x;
		
		private double _y;
		
		private double _z;
		
		private EntityRef<Sample> _Sample;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsample_idChanging(decimal value);
    partial void Onsample_idChanged();
    partial void OnorderChanging(decimal value);
    partial void OnorderChanged();
    partial void OnxChanging(double value);
    partial void OnxChanged();
    partial void OnyChanging(double value);
    partial void OnyChanged();
    partial void OnzChanging(double value);
    partial void OnzChanged();
    #endregion
		
		public Point()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public decimal sample_id
		{
			get
			{
				return this._sample_id;
			}
			set
			{
				if ((this._sample_id != value))
				{
					if (this._Sample.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsample_idChanging(value);
					this.SendPropertyChanging();
					this._sample_id = value;
					this.SendPropertyChanged("sample_id");
					this.Onsample_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[order]", Storage="_order", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public decimal order
		{
			get
			{
				return this._order;
			}
			set
			{
				if ((this._order != value))
				{
					this.OnorderChanging(value);
					this.SendPropertyChanging();
					this._order = value;
					this.SendPropertyChanged("order");
					this.OnorderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public double x
		{
			get
			{
				return this._x;
			}
			set
			{
				if ((this._x != value))
				{
					this.OnxChanging(value);
					this.SendPropertyChanging();
					this._x = value;
					this.SendPropertyChanged("x");
					this.OnxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public double y
		{
			get
			{
				return this._y;
			}
			set
			{
				if ((this._y != value))
				{
					this.OnyChanging(value);
					this.SendPropertyChanging();
					this._y = value;
					this.SendPropertyChanged("y");
					this.OnyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_z", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public double z
		{
			get
			{
				return this._z;
			}
			set
			{
				if ((this._z != value))
				{
					this.OnzChanging(value);
					this.SendPropertyChanging();
					this._z = value;
					this.SendPropertyChanged("z");
					this.OnzChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sample_Point", Storage="_Sample", ThisKey="sample_id", OtherKey="sample_id", IsForeignKey=true)]
		public Sample Sample
		{
			get
			{
				return this._Sample.Entity;
			}
			set
			{
				Sample previousValue = this._Sample.Entity;
				if (((previousValue != value) 
							|| (this._Sample.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sample.Entity = null;
						previousValue.Points.Remove(this);
					}
					this._Sample.Entity = value;
					if ((value != null))
					{
						value.Points.Add(this);
						this._sample_id = value.sample_id;
					}
					else
					{
						this._sample_id = default(decimal);
					}
					this.SendPropertyChanged("Sample");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Sample = default(EntityRef<Sample>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Parameter")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Parameter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _sample_id;
		
		private decimal _order;
		
		private string _name;
		
		private double _value;
		
		private EntityRef<Sample> _Sample;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsample_idChanging(decimal value);
    partial void Onsample_idChanged();
    partial void OnorderChanging(decimal value);
    partial void OnorderChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnvalueChanging(double value);
    partial void OnvalueChanged();
    #endregion
		
		public Parameter()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public decimal sample_id
		{
			get
			{
				return this._sample_id;
			}
			set
			{
				if ((this._sample_id != value))
				{
					if (this._Sample.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsample_idChanging(value);
					this.SendPropertyChanging();
					this._sample_id = value;
					this.SendPropertyChanged("sample_id");
					this.Onsample_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[order]", Storage="_order", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public decimal order
		{
			get
			{
				return this._order;
			}
			set
			{
				if ((this._order != value))
				{
					this.OnorderChanging(value);
					this.SendPropertyChanging();
					this._order = value;
					this.SendPropertyChanged("order");
					this.OnorderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public double value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sample_Parameter", Storage="_Sample", ThisKey="sample_id", OtherKey="sample_id", IsForeignKey=true)]
		public Sample Sample
		{
			get
			{
				return this._Sample.Entity;
			}
			set
			{
				Sample previousValue = this._Sample.Entity;
				if (((previousValue != value) 
							|| (this._Sample.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sample.Entity = null;
						previousValue.Parameters.Remove(this);
					}
					this._Sample.Entity = value;
					if ((value != null))
					{
						value.Parameters.Add(this);
						this._sample_id = value.sample_id;
					}
					else
					{
						this._sample_id = default(decimal);
					}
					this.SendPropertyChanged("Sample");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Sample = default(EntityRef<Sample>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Statistic")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Statistic : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _sample_id;
		
		private double _x_min;
		
		private double _x_max;
		
		private double _y_min;
		
		private double _y_max;
		
		private double _z_min;
		
		private double _z_max;
		
		private double _z_mean;
		
		private EntityRef<Sample> _Sample;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onsample_idChanging(decimal value);
    partial void Onsample_idChanged();
    partial void Onx_minChanging(double value);
    partial void Onx_minChanged();
    partial void Onx_maxChanging(double value);
    partial void Onx_maxChanged();
    partial void Ony_minChanging(double value);
    partial void Ony_minChanged();
    partial void Ony_maxChanging(double value);
    partial void Ony_maxChanged();
    partial void Onz_minChanging(double value);
    partial void Onz_minChanged();
    partial void Onz_maxChanging(double value);
    partial void Onz_maxChanged();
    partial void Onz_meanChanging(double value);
    partial void Onz_meanChanged();
    #endregion
		
		public Statistic()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sample_id", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public decimal sample_id
		{
			get
			{
				return this._sample_id;
			}
			set
			{
				if ((this._sample_id != value))
				{
					if (this._Sample.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onsample_idChanging(value);
					this.SendPropertyChanging();
					this._sample_id = value;
					this.SendPropertyChanged("sample_id");
					this.Onsample_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x_min", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
		public double x_min
		{
			get
			{
				return this._x_min;
			}
			set
			{
				if ((this._x_min != value))
				{
					this.Onx_minChanging(value);
					this.SendPropertyChanging();
					this._x_min = value;
					this.SendPropertyChanged("x_min");
					this.Onx_minChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_x_max", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public double x_max
		{
			get
			{
				return this._x_max;
			}
			set
			{
				if ((this._x_max != value))
				{
					this.Onx_maxChanging(value);
					this.SendPropertyChanging();
					this._x_max = value;
					this.SendPropertyChanged("x_max");
					this.Onx_maxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y_min", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
		public double y_min
		{
			get
			{
				return this._y_min;
			}
			set
			{
				if ((this._y_min != value))
				{
					this.Ony_minChanging(value);
					this.SendPropertyChanging();
					this._y_min = value;
					this.SendPropertyChanged("y_min");
					this.Ony_minChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_y_max", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
		public double y_max
		{
			get
			{
				return this._y_max;
			}
			set
			{
				if ((this._y_max != value))
				{
					this.Ony_maxChanging(value);
					this.SendPropertyChanging();
					this._y_max = value;
					this.SendPropertyChanged("y_max");
					this.Ony_maxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_z_min", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
		public double z_min
		{
			get
			{
				return this._z_min;
			}
			set
			{
				if ((this._z_min != value))
				{
					this.Onz_minChanging(value);
					this.SendPropertyChanging();
					this._z_min = value;
					this.SendPropertyChanged("z_min");
					this.Onz_minChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_z_max", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
		public double z_max
		{
			get
			{
				return this._z_max;
			}
			set
			{
				if ((this._z_max != value))
				{
					this.Onz_maxChanging(value);
					this.SendPropertyChanging();
					this._z_max = value;
					this.SendPropertyChanged("z_max");
					this.Onz_maxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_z_mean", DbType="Float NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
		public double z_mean
		{
			get
			{
				return this._z_mean;
			}
			set
			{
				if ((this._z_mean != value))
				{
					this.Onz_meanChanging(value);
					this.SendPropertyChanging();
					this._z_mean = value;
					this.SendPropertyChanged("z_mean");
					this.Onz_meanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sample_Statistic", Storage="_Sample", ThisKey="sample_id", OtherKey="sample_id", IsForeignKey=true)]
		public Sample Sample
		{
			get
			{
				return this._Sample.Entity;
			}
			set
			{
				Sample previousValue = this._Sample.Entity;
				if (((previousValue != value) 
							|| (this._Sample.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sample.Entity = null;
						previousValue.Statistic = null;
					}
					this._Sample.Entity = value;
					if ((value != null))
					{
						value.Statistic = this;
						this._sample_id = value.sample_id;
					}
					else
					{
						this._sample_id = default(decimal);
					}
					this.SendPropertyChanged("Sample");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Sample = default(EntityRef<Sample>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
