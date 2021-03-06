﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement.SCAO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AccessControl")]
	public partial class SCAOContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertEMP(EMP instance);
    partial void UpdateEMP(EMP instance);
    partial void DeleteEMP(EMP instance);
    partial void InsertEVENTS(EVENTS instance);
    partial void UpdateEVENTS(EVENTS instance);
    partial void DeleteEVENTS(EVENTS instance);
    #endregion
		
		public SCAOContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AccessControlConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SCAOContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SCAOContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SCAOContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SCAOContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EMP> EMP
		{
			get
			{
				return this.GetTable<EMP>();
			}
		}
		
		public System.Data.Linq.Table<EVENTS> EVENTS
		{
			get
			{
				return this.GetTable<EVENTS>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMP")]
	public partial class EMP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _LASTNAME;
		
		private string _FIRSTNAME;
		
		private string _MIDNAME;
		
		private string _SSNO;
		
		private System.Nullable<System.DateTime> _LASTCHANGED;
		
		private short _VISITOR;
		
		private short _ALLOWEDVISITORS;
		
		private System.Nullable<int> _ASSET_GROUPID;
		
		private int _LNL_DBID;
		
		private System.Nullable<short> _GUARD;
		
		private int _SEGMENTID;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnLASTNAMEChanging(string value);
    partial void OnLASTNAMEChanged();
    partial void OnFIRSTNAMEChanging(string value);
    partial void OnFIRSTNAMEChanged();
    partial void OnMIDNAMEChanging(string value);
    partial void OnMIDNAMEChanged();
    partial void OnSSNOChanging(string value);
    partial void OnSSNOChanged();
    partial void OnLASTCHANGEDChanging(System.Nullable<System.DateTime> value);
    partial void OnLASTCHANGEDChanged();
    partial void OnVISITORChanging(short value);
    partial void OnVISITORChanged();
    partial void OnALLOWEDVISITORSChanging(short value);
    partial void OnALLOWEDVISITORSChanged();
    partial void OnASSET_GROUPIDChanging(System.Nullable<int> value);
    partial void OnASSET_GROUPIDChanged();
    partial void OnLNL_DBIDChanging(int value);
    partial void OnLNL_DBIDChanged();
    partial void OnGUARDChanging(System.Nullable<short> value);
    partial void OnGUARDChanged();
    partial void OnSEGMENTIDChanging(int value);
    partial void OnSEGMENTIDChanged();
    #endregion
		
		public EMP()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LASTNAME", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string LASTNAME
		{
			get
			{
				return this._LASTNAME;
			}
			set
			{
				if ((this._LASTNAME != value))
				{
					this.OnLASTNAMEChanging(value);
					this.SendPropertyChanging();
					this._LASTNAME = value;
					this.SendPropertyChanged("LASTNAME");
					this.OnLASTNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIRSTNAME", DbType="NVarChar(64)")]
		public string FIRSTNAME
		{
			get
			{
				return this._FIRSTNAME;
			}
			set
			{
				if ((this._FIRSTNAME != value))
				{
					this.OnFIRSTNAMEChanging(value);
					this.SendPropertyChanging();
					this._FIRSTNAME = value;
					this.SendPropertyChanged("FIRSTNAME");
					this.OnFIRSTNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MIDNAME", DbType="NVarChar(64)")]
		public string MIDNAME
		{
			get
			{
				return this._MIDNAME;
			}
			set
			{
				if ((this._MIDNAME != value))
				{
					this.OnMIDNAMEChanging(value);
					this.SendPropertyChanging();
					this._MIDNAME = value;
					this.SendPropertyChanged("MIDNAME");
					this.OnMIDNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSNO", DbType="NVarChar(13)")]
		public string SSNO
		{
			get
			{
				return this._SSNO;
			}
			set
			{
				if ((this._SSNO != value))
				{
					this.OnSSNOChanging(value);
					this.SendPropertyChanging();
					this._SSNO = value;
					this.SendPropertyChanged("SSNO");
					this.OnSSNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LASTCHANGED", DbType="DateTime")]
		public System.Nullable<System.DateTime> LASTCHANGED
		{
			get
			{
				return this._LASTCHANGED;
			}
			set
			{
				if ((this._LASTCHANGED != value))
				{
					this.OnLASTCHANGEDChanging(value);
					this.SendPropertyChanging();
					this._LASTCHANGED = value;
					this.SendPropertyChanged("LASTCHANGED");
					this.OnLASTCHANGEDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VISITOR", DbType="SmallInt NOT NULL")]
		public short VISITOR
		{
			get
			{
				return this._VISITOR;
			}
			set
			{
				if ((this._VISITOR != value))
				{
					this.OnVISITORChanging(value);
					this.SendPropertyChanging();
					this._VISITOR = value;
					this.SendPropertyChanged("VISITOR");
					this.OnVISITORChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALLOWEDVISITORS", DbType="SmallInt NOT NULL")]
		public short ALLOWEDVISITORS
		{
			get
			{
				return this._ALLOWEDVISITORS;
			}
			set
			{
				if ((this._ALLOWEDVISITORS != value))
				{
					this.OnALLOWEDVISITORSChanging(value);
					this.SendPropertyChanging();
					this._ALLOWEDVISITORS = value;
					this.SendPropertyChanged("ALLOWEDVISITORS");
					this.OnALLOWEDVISITORSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ASSET_GROUPID", DbType="Int")]
		public System.Nullable<int> ASSET_GROUPID
		{
			get
			{
				return this._ASSET_GROUPID;
			}
			set
			{
				if ((this._ASSET_GROUPID != value))
				{
					this.OnASSET_GROUPIDChanging(value);
					this.SendPropertyChanging();
					this._ASSET_GROUPID = value;
					this.SendPropertyChanged("ASSET_GROUPID");
					this.OnASSET_GROUPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LNL_DBID", DbType="Int NOT NULL")]
		public int LNL_DBID
		{
			get
			{
				return this._LNL_DBID;
			}
			set
			{
				if ((this._LNL_DBID != value))
				{
					this.OnLNL_DBIDChanging(value);
					this.SendPropertyChanging();
					this._LNL_DBID = value;
					this.SendPropertyChanged("LNL_DBID");
					this.OnLNL_DBIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GUARD", DbType="SmallInt")]
		public System.Nullable<short> GUARD
		{
			get
			{
				return this._GUARD;
			}
			set
			{
				if ((this._GUARD != value))
				{
					this.OnGUARDChanging(value);
					this.SendPropertyChanging();
					this._GUARD = value;
					this.SendPropertyChanged("GUARD");
					this.OnGUARDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SEGMENTID", DbType="Int NOT NULL")]
		public int SEGMENTID
		{
			get
			{
				return this._SEGMENTID;
			}
			set
			{
				if ((this._SEGMENTID != value))
				{
					this.OnSEGMENTIDChanging(value);
					this.SendPropertyChanging();
					this._SEGMENTID = value;
					this.SendPropertyChanged("SEGMENTID");
					this.OnSEGMENTIDChanged();
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EVENTS")]
	public partial class EVENTS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SERIALNUM;
		
		private System.Nullable<System.DateTime> _EVENTIME;
		
		private System.Nullable<short> _DEVID;
		
		private System.Nullable<short> _INPUTDEVID;
		
		private System.Nullable<short> _EVENTTYPE;
		
		private System.Nullable<short> _EVENTID;
		
		private System.Nullable<short> _EVENTDATA;
		
		private System.Nullable<long> _CARDNUM;
		
		private short _MACHINE;
		
		private System.Nullable<int> _EMPID;
		
		private System.Nullable<short> _INPUTARG;
		
		private System.Nullable<int> _TRIGGER_EVENT;
		
		private System.Nullable<short> _FUNCLIST;
		
		private System.Nullable<int> _ASSETID;
		
		private System.Nullable<int> _EVENT_PARAMID;
		
		private System.Nullable<int> _CALLED_STATION;
		
		private System.Nullable<int> _TRANSMITTERID;
		
		private System.Nullable<int> _TRANSMITTER_INPUTID;
		
		private System.Nullable<int> _ISSUECODE;
		
		private System.Nullable<int> _WRKSTATIONID;
		
		private string _EVENT_TEXT;
		
		private System.Nullable<int> _RECEIVERID;
		
		private System.Nullable<int> _LINENUM;
		
		private System.Nullable<int> _AREAID;
		
		private System.Nullable<int> _USERID;
		
		private string _EVENTCODE;
		
		private System.Nullable<int> _LNL_DBID;
		
		private System.Nullable<int> _SEGMENTID;
		
		private System.Nullable<int> _AREAAPBID;
		
		private System.Nullable<int> _ALARMMASKGROUPID;
		
		private System.Nullable<System.DateTime> _EVENT_TIME_UTC;
		
		private string _CARD_EXTENDED_ID;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSERIALNUMChanging(int value);
    partial void OnSERIALNUMChanged();
    partial void OnEVENTIMEChanging(System.Nullable<System.DateTime> value);
    partial void OnEVENTIMEChanged();
    partial void OnDEVIDChanging(System.Nullable<short> value);
    partial void OnDEVIDChanged();
    partial void OnINPUTDEVIDChanging(System.Nullable<short> value);
    partial void OnINPUTDEVIDChanged();
    partial void OnEVENTTYPEChanging(System.Nullable<short> value);
    partial void OnEVENTTYPEChanged();
    partial void OnEVENTIDChanging(System.Nullable<short> value);
    partial void OnEVENTIDChanged();
    partial void OnEVENTDATAChanging(System.Nullable<short> value);
    partial void OnEVENTDATAChanged();
    partial void OnCARDNUMChanging(System.Nullable<long> value);
    partial void OnCARDNUMChanged();
    partial void OnMACHINEChanging(short value);
    partial void OnMACHINEChanged();
    partial void OnEMPIDChanging(System.Nullable<int> value);
    partial void OnEMPIDChanged();
    partial void OnINPUTARGChanging(System.Nullable<short> value);
    partial void OnINPUTARGChanged();
    partial void OnTRIGGER_EVENTChanging(System.Nullable<int> value);
    partial void OnTRIGGER_EVENTChanged();
    partial void OnFUNCLISTChanging(System.Nullable<short> value);
    partial void OnFUNCLISTChanged();
    partial void OnASSETIDChanging(System.Nullable<int> value);
    partial void OnASSETIDChanged();
    partial void OnEVENT_PARAMIDChanging(System.Nullable<int> value);
    partial void OnEVENT_PARAMIDChanged();
    partial void OnCALLED_STATIONChanging(System.Nullable<int> value);
    partial void OnCALLED_STATIONChanged();
    partial void OnTRANSMITTERIDChanging(System.Nullable<int> value);
    partial void OnTRANSMITTERIDChanged();
    partial void OnTRANSMITTER_INPUTIDChanging(System.Nullable<int> value);
    partial void OnTRANSMITTER_INPUTIDChanged();
    partial void OnISSUECODEChanging(System.Nullable<int> value);
    partial void OnISSUECODEChanged();
    partial void OnWRKSTATIONIDChanging(System.Nullable<int> value);
    partial void OnWRKSTATIONIDChanged();
    partial void OnEVENT_TEXTChanging(string value);
    partial void OnEVENT_TEXTChanged();
    partial void OnRECEIVERIDChanging(System.Nullable<int> value);
    partial void OnRECEIVERIDChanged();
    partial void OnLINENUMChanging(System.Nullable<int> value);
    partial void OnLINENUMChanged();
    partial void OnAREAIDChanging(System.Nullable<int> value);
    partial void OnAREAIDChanged();
    partial void OnUSERIDChanging(System.Nullable<int> value);
    partial void OnUSERIDChanged();
    partial void OnEVENTCODEChanging(string value);
    partial void OnEVENTCODEChanged();
    partial void OnLNL_DBIDChanging(System.Nullable<int> value);
    partial void OnLNL_DBIDChanged();
    partial void OnSEGMENTIDChanging(System.Nullable<int> value);
    partial void OnSEGMENTIDChanged();
    partial void OnAREAAPBIDChanging(System.Nullable<int> value);
    partial void OnAREAAPBIDChanged();
    partial void OnALARMMASKGROUPIDChanging(System.Nullable<int> value);
    partial void OnALARMMASKGROUPIDChanged();
    partial void OnEVENT_TIME_UTCChanging(System.Nullable<System.DateTime> value);
    partial void OnEVENT_TIME_UTCChanged();
    partial void OnCARD_EXTENDED_IDChanging(string value);
    partial void OnCARD_EXTENDED_IDChanged();
    #endregion
		
		public EVENTS()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SERIALNUM", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SERIALNUM
		{
			get
			{
				return this._SERIALNUM;
			}
			set
			{
				if ((this._SERIALNUM != value))
				{
					this.OnSERIALNUMChanging(value);
					this.SendPropertyChanging();
					this._SERIALNUM = value;
					this.SendPropertyChanged("SERIALNUM");
					this.OnSERIALNUMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENTIME", DbType="DateTime")]
		public System.Nullable<System.DateTime> EVENTIME
		{
			get
			{
				return this._EVENTIME;
			}
			set
			{
				if ((this._EVENTIME != value))
				{
					this.OnEVENTIMEChanging(value);
					this.SendPropertyChanging();
					this._EVENTIME = value;
					this.SendPropertyChanged("EVENTIME");
					this.OnEVENTIMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DEVID", DbType="SmallInt")]
		public System.Nullable<short> DEVID
		{
			get
			{
				return this._DEVID;
			}
			set
			{
				if ((this._DEVID != value))
				{
					this.OnDEVIDChanging(value);
					this.SendPropertyChanging();
					this._DEVID = value;
					this.SendPropertyChanged("DEVID");
					this.OnDEVIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INPUTDEVID", DbType="SmallInt")]
		public System.Nullable<short> INPUTDEVID
		{
			get
			{
				return this._INPUTDEVID;
			}
			set
			{
				if ((this._INPUTDEVID != value))
				{
					this.OnINPUTDEVIDChanging(value);
					this.SendPropertyChanging();
					this._INPUTDEVID = value;
					this.SendPropertyChanged("INPUTDEVID");
					this.OnINPUTDEVIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENTTYPE", DbType="SmallInt")]
		public System.Nullable<short> EVENTTYPE
		{
			get
			{
				return this._EVENTTYPE;
			}
			set
			{
				if ((this._EVENTTYPE != value))
				{
					this.OnEVENTTYPEChanging(value);
					this.SendPropertyChanging();
					this._EVENTTYPE = value;
					this.SendPropertyChanged("EVENTTYPE");
					this.OnEVENTTYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENTID", DbType="SmallInt")]
		public System.Nullable<short> EVENTID
		{
			get
			{
				return this._EVENTID;
			}
			set
			{
				if ((this._EVENTID != value))
				{
					this.OnEVENTIDChanging(value);
					this.SendPropertyChanging();
					this._EVENTID = value;
					this.SendPropertyChanged("EVENTID");
					this.OnEVENTIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENTDATA", DbType="SmallInt")]
		public System.Nullable<short> EVENTDATA
		{
			get
			{
				return this._EVENTDATA;
			}
			set
			{
				if ((this._EVENTDATA != value))
				{
					this.OnEVENTDATAChanging(value);
					this.SendPropertyChanging();
					this._EVENTDATA = value;
					this.SendPropertyChanged("EVENTDATA");
					this.OnEVENTDATAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARDNUM", DbType="BigInt")]
		public System.Nullable<long> CARDNUM
		{
			get
			{
				return this._CARDNUM;
			}
			set
			{
				if ((this._CARDNUM != value))
				{
					this.OnCARDNUMChanging(value);
					this.SendPropertyChanging();
					this._CARDNUM = value;
					this.SendPropertyChanged("CARDNUM");
					this.OnCARDNUMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MACHINE", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short MACHINE
		{
			get
			{
				return this._MACHINE;
			}
			set
			{
				if ((this._MACHINE != value))
				{
					this.OnMACHINEChanging(value);
					this.SendPropertyChanging();
					this._MACHINE = value;
					this.SendPropertyChanged("MACHINE");
					this.OnMACHINEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMPID", DbType="Int")]
		public System.Nullable<int> EMPID
		{
			get
			{
				return this._EMPID;
			}
			set
			{
				if ((this._EMPID != value))
				{
					this.OnEMPIDChanging(value);
					this.SendPropertyChanging();
					this._EMPID = value;
					this.SendPropertyChanged("EMPID");
					this.OnEMPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_INPUTARG", DbType="SmallInt")]
		public System.Nullable<short> INPUTARG
		{
			get
			{
				return this._INPUTARG;
			}
			set
			{
				if ((this._INPUTARG != value))
				{
					this.OnINPUTARGChanging(value);
					this.SendPropertyChanging();
					this._INPUTARG = value;
					this.SendPropertyChanged("INPUTARG");
					this.OnINPUTARGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRIGGER_EVENT", DbType="Int")]
		public System.Nullable<int> TRIGGER_EVENT
		{
			get
			{
				return this._TRIGGER_EVENT;
			}
			set
			{
				if ((this._TRIGGER_EVENT != value))
				{
					this.OnTRIGGER_EVENTChanging(value);
					this.SendPropertyChanging();
					this._TRIGGER_EVENT = value;
					this.SendPropertyChanged("TRIGGER_EVENT");
					this.OnTRIGGER_EVENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FUNCLIST", DbType="SmallInt")]
		public System.Nullable<short> FUNCLIST
		{
			get
			{
				return this._FUNCLIST;
			}
			set
			{
				if ((this._FUNCLIST != value))
				{
					this.OnFUNCLISTChanging(value);
					this.SendPropertyChanging();
					this._FUNCLIST = value;
					this.SendPropertyChanged("FUNCLIST");
					this.OnFUNCLISTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ASSETID", DbType="Int")]
		public System.Nullable<int> ASSETID
		{
			get
			{
				return this._ASSETID;
			}
			set
			{
				if ((this._ASSETID != value))
				{
					this.OnASSETIDChanging(value);
					this.SendPropertyChanging();
					this._ASSETID = value;
					this.SendPropertyChanged("ASSETID");
					this.OnASSETIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENT_PARAMID", DbType="Int")]
		public System.Nullable<int> EVENT_PARAMID
		{
			get
			{
				return this._EVENT_PARAMID;
			}
			set
			{
				if ((this._EVENT_PARAMID != value))
				{
					this.OnEVENT_PARAMIDChanging(value);
					this.SendPropertyChanging();
					this._EVENT_PARAMID = value;
					this.SendPropertyChanged("EVENT_PARAMID");
					this.OnEVENT_PARAMIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CALLED_STATION", DbType="Int")]
		public System.Nullable<int> CALLED_STATION
		{
			get
			{
				return this._CALLED_STATION;
			}
			set
			{
				if ((this._CALLED_STATION != value))
				{
					this.OnCALLED_STATIONChanging(value);
					this.SendPropertyChanging();
					this._CALLED_STATION = value;
					this.SendPropertyChanged("CALLED_STATION");
					this.OnCALLED_STATIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANSMITTERID", DbType="Int")]
		public System.Nullable<int> TRANSMITTERID
		{
			get
			{
				return this._TRANSMITTERID;
			}
			set
			{
				if ((this._TRANSMITTERID != value))
				{
					this.OnTRANSMITTERIDChanging(value);
					this.SendPropertyChanging();
					this._TRANSMITTERID = value;
					this.SendPropertyChanged("TRANSMITTERID");
					this.OnTRANSMITTERIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TRANSMITTER_INPUTID", DbType="Int")]
		public System.Nullable<int> TRANSMITTER_INPUTID
		{
			get
			{
				return this._TRANSMITTER_INPUTID;
			}
			set
			{
				if ((this._TRANSMITTER_INPUTID != value))
				{
					this.OnTRANSMITTER_INPUTIDChanging(value);
					this.SendPropertyChanging();
					this._TRANSMITTER_INPUTID = value;
					this.SendPropertyChanged("TRANSMITTER_INPUTID");
					this.OnTRANSMITTER_INPUTIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISSUECODE", DbType="Int")]
		public System.Nullable<int> ISSUECODE
		{
			get
			{
				return this._ISSUECODE;
			}
			set
			{
				if ((this._ISSUECODE != value))
				{
					this.OnISSUECODEChanging(value);
					this.SendPropertyChanging();
					this._ISSUECODE = value;
					this.SendPropertyChanged("ISSUECODE");
					this.OnISSUECODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WRKSTATIONID", DbType="Int")]
		public System.Nullable<int> WRKSTATIONID
		{
			get
			{
				return this._WRKSTATIONID;
			}
			set
			{
				if ((this._WRKSTATIONID != value))
				{
					this.OnWRKSTATIONIDChanging(value);
					this.SendPropertyChanging();
					this._WRKSTATIONID = value;
					this.SendPropertyChanged("WRKSTATIONID");
					this.OnWRKSTATIONIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENT_TEXT", DbType="NVarChar(2000)")]
		public string EVENT_TEXT
		{
			get
			{
				return this._EVENT_TEXT;
			}
			set
			{
				if ((this._EVENT_TEXT != value))
				{
					this.OnEVENT_TEXTChanging(value);
					this.SendPropertyChanging();
					this._EVENT_TEXT = value;
					this.SendPropertyChanged("EVENT_TEXT");
					this.OnEVENT_TEXTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RECEIVERID", DbType="Int")]
		public System.Nullable<int> RECEIVERID
		{
			get
			{
				return this._RECEIVERID;
			}
			set
			{
				if ((this._RECEIVERID != value))
				{
					this.OnRECEIVERIDChanging(value);
					this.SendPropertyChanging();
					this._RECEIVERID = value;
					this.SendPropertyChanged("RECEIVERID");
					this.OnRECEIVERIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LINENUM", DbType="Int")]
		public System.Nullable<int> LINENUM
		{
			get
			{
				return this._LINENUM;
			}
			set
			{
				if ((this._LINENUM != value))
				{
					this.OnLINENUMChanging(value);
					this.SendPropertyChanging();
					this._LINENUM = value;
					this.SendPropertyChanged("LINENUM");
					this.OnLINENUMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AREAID", DbType="Int")]
		public System.Nullable<int> AREAID
		{
			get
			{
				return this._AREAID;
			}
			set
			{
				if ((this._AREAID != value))
				{
					this.OnAREAIDChanging(value);
					this.SendPropertyChanging();
					this._AREAID = value;
					this.SendPropertyChanged("AREAID");
					this.OnAREAIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERID", DbType="Int")]
		public System.Nullable<int> USERID
		{
			get
			{
				return this._USERID;
			}
			set
			{
				if ((this._USERID != value))
				{
					this.OnUSERIDChanging(value);
					this.SendPropertyChanging();
					this._USERID = value;
					this.SendPropertyChanged("USERID");
					this.OnUSERIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENTCODE", DbType="NVarChar(10)")]
		public string EVENTCODE
		{
			get
			{
				return this._EVENTCODE;
			}
			set
			{
				if ((this._EVENTCODE != value))
				{
					this.OnEVENTCODEChanging(value);
					this.SendPropertyChanging();
					this._EVENTCODE = value;
					this.SendPropertyChanged("EVENTCODE");
					this.OnEVENTCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LNL_DBID", DbType="Int")]
		public System.Nullable<int> LNL_DBID
		{
			get
			{
				return this._LNL_DBID;
			}
			set
			{
				if ((this._LNL_DBID != value))
				{
					this.OnLNL_DBIDChanging(value);
					this.SendPropertyChanging();
					this._LNL_DBID = value;
					this.SendPropertyChanged("LNL_DBID");
					this.OnLNL_DBIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SEGMENTID", DbType="Int")]
		public System.Nullable<int> SEGMENTID
		{
			get
			{
				return this._SEGMENTID;
			}
			set
			{
				if ((this._SEGMENTID != value))
				{
					this.OnSEGMENTIDChanging(value);
					this.SendPropertyChanging();
					this._SEGMENTID = value;
					this.SendPropertyChanged("SEGMENTID");
					this.OnSEGMENTIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AREAAPBID", DbType="Int")]
		public System.Nullable<int> AREAAPBID
		{
			get
			{
				return this._AREAAPBID;
			}
			set
			{
				if ((this._AREAAPBID != value))
				{
					this.OnAREAAPBIDChanging(value);
					this.SendPropertyChanging();
					this._AREAAPBID = value;
					this.SendPropertyChanged("AREAAPBID");
					this.OnAREAAPBIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALARMMASKGROUPID", DbType="Int")]
		public System.Nullable<int> ALARMMASKGROUPID
		{
			get
			{
				return this._ALARMMASKGROUPID;
			}
			set
			{
				if ((this._ALARMMASKGROUPID != value))
				{
					this.OnALARMMASKGROUPIDChanging(value);
					this.SendPropertyChanging();
					this._ALARMMASKGROUPID = value;
					this.SendPropertyChanged("ALARMMASKGROUPID");
					this.OnALARMMASKGROUPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EVENT_TIME_UTC", DbType="DateTime")]
		public System.Nullable<System.DateTime> EVENT_TIME_UTC
		{
			get
			{
				return this._EVENT_TIME_UTC;
			}
			set
			{
				if ((this._EVENT_TIME_UTC != value))
				{
					this.OnEVENT_TIME_UTCChanging(value);
					this.SendPropertyChanging();
					this._EVENT_TIME_UTC = value;
					this.SendPropertyChanged("EVENT_TIME_UTC");
					this.OnEVENT_TIME_UTCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CARD_EXTENDED_ID", DbType="NVarChar(64)")]
		public string CARD_EXTENDED_ID
		{
			get
			{
				return this._CARD_EXTENDED_ID;
			}
			set
			{
				if ((this._CARD_EXTENDED_ID != value))
				{
					this.OnCARD_EXTENDED_IDChanging(value);
					this.SendPropertyChanging();
					this._CARD_EXTENDED_ID = value;
					this.SendPropertyChanged("CARD_EXTENDED_ID");
					this.OnCARD_EXTENDED_IDChanged();
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
	}
}
#pragma warning restore 1591
