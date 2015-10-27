
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.2.0.7)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _ReceivePallet : SqlClientEntity
	{
		public _ReceivePallet()
		{
			this.QuerySource = "ReceivePallet";
			this.MappingName = "ReceivePallet";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivePalletLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivePalletLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReceiveID
			{
				get
				{
					return new SqlParameter("@ReceiveID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PalletID
			{
				get
				{
					return new SqlParameter("@PalletID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReceivedQuantity
			{
				get
				{
					return new SqlParameter("@ReceivedQuantity", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter Balance
			{
				get
				{
					return new SqlParameter("@Balance", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter ReservedStock
			{
				get
				{
					return new SqlParameter("@ReservedStock", SqlDbType.Decimal, 0);
				}
			}
			
			public static SqlParameter ReserveOrderID
			{
				get
				{
					return new SqlParameter("@ReserveOrderID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter BoxSize
			{
				get
				{
					return new SqlParameter("@BoxSize", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PalletLocationID
			{
				get
				{
					return new SqlParameter("@PalletLocationID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsOriginalReceive
			{
				get
				{
					return new SqlParameter("@IsOriginalReceive", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string ReceiveID = "ReceiveID";
            public const string PalletID = "PalletID";
            public const string ReceivedQuantity = "ReceivedQuantity";
            public const string Balance = "Balance";
            public const string ReservedStock = "ReservedStock";
            public const string ReserveOrderID = "ReserveOrderID";
            public const string BoxSize = "BoxSize";
            public const string PalletLocationID = "PalletLocationID";
            public const string IsOriginalReceive = "IsOriginalReceive";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ReceivePallet.PropertyNames.ID;
					ht[ReceiveID] = _ReceivePallet.PropertyNames.ReceiveID;
					ht[PalletID] = _ReceivePallet.PropertyNames.PalletID;
					ht[ReceivedQuantity] = _ReceivePallet.PropertyNames.ReceivedQuantity;
					ht[Balance] = _ReceivePallet.PropertyNames.Balance;
					ht[ReservedStock] = _ReceivePallet.PropertyNames.ReservedStock;
					ht[ReserveOrderID] = _ReceivePallet.PropertyNames.ReserveOrderID;
					ht[BoxSize] = _ReceivePallet.PropertyNames.BoxSize;
					ht[PalletLocationID] = _ReceivePallet.PropertyNames.PalletLocationID;
					ht[IsOriginalReceive] = _ReceivePallet.PropertyNames.IsOriginalReceive;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string ReceiveID = "ReceiveID";
            public const string PalletID = "PalletID";
            public const string ReceivedQuantity = "ReceivedQuantity";
            public const string Balance = "Balance";
            public const string ReservedStock = "ReservedStock";
            public const string ReserveOrderID = "ReserveOrderID";
            public const string BoxSize = "BoxSize";
            public const string PalletLocationID = "PalletLocationID";
            public const string IsOriginalReceive = "IsOriginalReceive";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ReceivePallet.ColumnNames.ID;
					ht[ReceiveID] = _ReceivePallet.ColumnNames.ReceiveID;
					ht[PalletID] = _ReceivePallet.ColumnNames.PalletID;
					ht[ReceivedQuantity] = _ReceivePallet.ColumnNames.ReceivedQuantity;
					ht[Balance] = _ReceivePallet.ColumnNames.Balance;
					ht[ReservedStock] = _ReceivePallet.ColumnNames.ReservedStock;
					ht[ReserveOrderID] = _ReceivePallet.ColumnNames.ReserveOrderID;
					ht[BoxSize] = _ReceivePallet.ColumnNames.BoxSize;
					ht[PalletLocationID] = _ReceivePallet.ColumnNames.PalletLocationID;
					ht[IsOriginalReceive] = _ReceivePallet.ColumnNames.IsOriginalReceive;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string ReceiveID = "s_ReceiveID";
            public const string PalletID = "s_PalletID";
            public const string ReceivedQuantity = "s_ReceivedQuantity";
            public const string Balance = "s_Balance";
            public const string ReservedStock = "s_ReservedStock";
            public const string ReserveOrderID = "s_ReserveOrderID";
            public const string BoxSize = "s_BoxSize";
            public const string PalletLocationID = "s_PalletLocationID";
            public const string IsOriginalReceive = "s_IsOriginalReceive";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual int ReceiveID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReceiveID);
			}
			set
	        {
				base.Setint(ColumnNames.ReceiveID, value);
			}
		}

		public virtual int PalletID
	    {
			get
	        {
				return base.Getint(ColumnNames.PalletID);
			}
			set
	        {
				base.Setint(ColumnNames.PalletID, value);
			}
		}

		public virtual decimal ReceivedQuantity
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.ReceivedQuantity);
			}
			set
	        {
				base.Setdecimal(ColumnNames.ReceivedQuantity, value);
			}
		}

		public virtual decimal Balance
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.Balance);
			}
			set
	        {
				base.Setdecimal(ColumnNames.Balance, value);
			}
		}

		public virtual decimal ReservedStock
	    {
			get
	        {
				return base.Getdecimal(ColumnNames.ReservedStock);
			}
			set
	        {
				base.Setdecimal(ColumnNames.ReservedStock, value);
			}
		}

		public virtual int ReserveOrderID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReserveOrderID);
			}
			set
	        {
				base.Setint(ColumnNames.ReserveOrderID, value);
			}
		}

		public virtual int BoxSize
	    {
			get
	        {
				return base.Getint(ColumnNames.BoxSize);
			}
			set
	        {
				base.Setint(ColumnNames.BoxSize, value);
			}
		}

		public virtual int PalletLocationID
	    {
			get
	        {
				return base.Getint(ColumnNames.PalletLocationID);
			}
			set
	        {
				base.Setint(ColumnNames.PalletLocationID, value);
			}
		}

		public virtual bool IsOriginalReceive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsOriginalReceive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsOriginalReceive, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_ReceiveID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceiveID) ? string.Empty : base.GetintAsString(ColumnNames.ReceiveID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceiveID);
				else
					this.ReceiveID = base.SetintAsString(ColumnNames.ReceiveID, value);
			}
		}

		public virtual string s_PalletID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PalletID) ? string.Empty : base.GetintAsString(ColumnNames.PalletID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PalletID);
				else
					this.PalletID = base.SetintAsString(ColumnNames.PalletID, value);
			}
		}

		public virtual string s_ReceivedQuantity
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceivedQuantity) ? string.Empty : base.GetdecimalAsString(ColumnNames.ReceivedQuantity);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceivedQuantity);
				else
					this.ReceivedQuantity = base.SetdecimalAsString(ColumnNames.ReceivedQuantity, value);
			}
		}

		public virtual string s_Balance
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Balance) ? string.Empty : base.GetdecimalAsString(ColumnNames.Balance);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Balance);
				else
					this.Balance = base.SetdecimalAsString(ColumnNames.Balance, value);
			}
		}

		public virtual string s_ReservedStock
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReservedStock) ? string.Empty : base.GetdecimalAsString(ColumnNames.ReservedStock);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReservedStock);
				else
					this.ReservedStock = base.SetdecimalAsString(ColumnNames.ReservedStock, value);
			}
		}

		public virtual string s_ReserveOrderID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReserveOrderID) ? string.Empty : base.GetintAsString(ColumnNames.ReserveOrderID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReserveOrderID);
				else
					this.ReserveOrderID = base.SetintAsString(ColumnNames.ReserveOrderID, value);
			}
		}

		public virtual string s_BoxSize
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.BoxSize) ? string.Empty : base.GetintAsString(ColumnNames.BoxSize);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.BoxSize);
				else
					this.BoxSize = base.SetintAsString(ColumnNames.BoxSize, value);
			}
		}

		public virtual string s_PalletLocationID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PalletLocationID) ? string.Empty : base.GetintAsString(ColumnNames.PalletLocationID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PalletLocationID);
				else
					this.PalletLocationID = base.SetintAsString(ColumnNames.PalletLocationID, value);
			}
		}

		public virtual string s_IsOriginalReceive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsOriginalReceive) ? string.Empty : base.GetboolAsString(ColumnNames.IsOriginalReceive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsOriginalReceive);
				else
					this.IsOriginalReceive = base.SetboolAsString(ColumnNames.IsOriginalReceive, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReceiveID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceiveID, Parameters.ReceiveID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PalletID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PalletID, Parameters.PalletID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReceivedQuantity
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceivedQuantity, Parameters.ReceivedQuantity);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Balance
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Balance, Parameters.Balance);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReservedStock
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReservedStock, Parameters.ReservedStock);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReserveOrderID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReserveOrderID, Parameters.ReserveOrderID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter BoxSize
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.BoxSize, Parameters.BoxSize);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PalletLocationID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PalletLocationID, Parameters.PalletLocationID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsOriginalReceive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsOriginalReceive, Parameters.IsOriginalReceive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter ReceiveID
		    {
				get
		        {
					if(_ReceiveID_W == null)
	        	    {
						_ReceiveID_W = TearOff.ReceiveID;
					}
					return _ReceiveID_W;
				}
			}

			public WhereParameter PalletID
		    {
				get
		        {
					if(_PalletID_W == null)
	        	    {
						_PalletID_W = TearOff.PalletID;
					}
					return _PalletID_W;
				}
			}

			public WhereParameter ReceivedQuantity
		    {
				get
		        {
					if(_ReceivedQuantity_W == null)
	        	    {
						_ReceivedQuantity_W = TearOff.ReceivedQuantity;
					}
					return _ReceivedQuantity_W;
				}
			}

			public WhereParameter Balance
		    {
				get
		        {
					if(_Balance_W == null)
	        	    {
						_Balance_W = TearOff.Balance;
					}
					return _Balance_W;
				}
			}

			public WhereParameter ReservedStock
		    {
				get
		        {
					if(_ReservedStock_W == null)
	        	    {
						_ReservedStock_W = TearOff.ReservedStock;
					}
					return _ReservedStock_W;
				}
			}

			public WhereParameter ReserveOrderID
		    {
				get
		        {
					if(_ReserveOrderID_W == null)
	        	    {
						_ReserveOrderID_W = TearOff.ReserveOrderID;
					}
					return _ReserveOrderID_W;
				}
			}

			public WhereParameter BoxSize
		    {
				get
		        {
					if(_BoxSize_W == null)
	        	    {
						_BoxSize_W = TearOff.BoxSize;
					}
					return _BoxSize_W;
				}
			}

			public WhereParameter PalletLocationID
		    {
				get
		        {
					if(_PalletLocationID_W == null)
	        	    {
						_PalletLocationID_W = TearOff.PalletLocationID;
					}
					return _PalletLocationID_W;
				}
			}

			public WhereParameter IsOriginalReceive
		    {
				get
		        {
					if(_IsOriginalReceive_W == null)
	        	    {
						_IsOriginalReceive_W = TearOff.IsOriginalReceive;
					}
					return _IsOriginalReceive_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _ReceiveID_W = null;
			private WhereParameter _PalletID_W = null;
			private WhereParameter _ReceivedQuantity_W = null;
			private WhereParameter _Balance_W = null;
			private WhereParameter _ReservedStock_W = null;
			private WhereParameter _ReserveOrderID_W = null;
			private WhereParameter _BoxSize_W = null;
			private WhereParameter _PalletLocationID_W = null;
			private WhereParameter _IsOriginalReceive_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_ReceiveID_W = null;
				_PalletID_W = null;
				_ReceivedQuantity_W = null;
				_Balance_W = null;
				_ReservedStock_W = null;
				_ReserveOrderID_W = null;
				_BoxSize_W = null;
				_PalletLocationID_W = null;
				_IsOriginalReceive_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReceiveID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceiveID, Parameters.ReceiveID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PalletID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PalletID, Parameters.PalletID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReceivedQuantity
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceivedQuantity, Parameters.ReceivedQuantity);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Balance
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Balance, Parameters.Balance);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReservedStock
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReservedStock, Parameters.ReservedStock);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReserveOrderID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReserveOrderID, Parameters.ReserveOrderID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter BoxSize
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.BoxSize, Parameters.BoxSize);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PalletLocationID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PalletLocationID, Parameters.PalletLocationID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsOriginalReceive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsOriginalReceive, Parameters.IsOriginalReceive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter ReceiveID
		    {
				get
		        {
					if(_ReceiveID_W == null)
	        	    {
						_ReceiveID_W = TearOff.ReceiveID;
					}
					return _ReceiveID_W;
				}
			}

			public AggregateParameter PalletID
		    {
				get
		        {
					if(_PalletID_W == null)
	        	    {
						_PalletID_W = TearOff.PalletID;
					}
					return _PalletID_W;
				}
			}

			public AggregateParameter ReceivedQuantity
		    {
				get
		        {
					if(_ReceivedQuantity_W == null)
	        	    {
						_ReceivedQuantity_W = TearOff.ReceivedQuantity;
					}
					return _ReceivedQuantity_W;
				}
			}

			public AggregateParameter Balance
		    {
				get
		        {
					if(_Balance_W == null)
	        	    {
						_Balance_W = TearOff.Balance;
					}
					return _Balance_W;
				}
			}

			public AggregateParameter ReservedStock
		    {
				get
		        {
					if(_ReservedStock_W == null)
	        	    {
						_ReservedStock_W = TearOff.ReservedStock;
					}
					return _ReservedStock_W;
				}
			}

			public AggregateParameter ReserveOrderID
		    {
				get
		        {
					if(_ReserveOrderID_W == null)
	        	    {
						_ReserveOrderID_W = TearOff.ReserveOrderID;
					}
					return _ReserveOrderID_W;
				}
			}

			public AggregateParameter BoxSize
		    {
				get
		        {
					if(_BoxSize_W == null)
	        	    {
						_BoxSize_W = TearOff.BoxSize;
					}
					return _BoxSize_W;
				}
			}

			public AggregateParameter PalletLocationID
		    {
				get
		        {
					if(_PalletLocationID_W == null)
	        	    {
						_PalletLocationID_W = TearOff.PalletLocationID;
					}
					return _PalletLocationID_W;
				}
			}

			public AggregateParameter IsOriginalReceive
		    {
				get
		        {
					if(_IsOriginalReceive_W == null)
	        	    {
						_IsOriginalReceive_W = TearOff.IsOriginalReceive;
					}
					return _IsOriginalReceive_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _ReceiveID_W = null;
			private AggregateParameter _PalletID_W = null;
			private AggregateParameter _ReceivedQuantity_W = null;
			private AggregateParameter _Balance_W = null;
			private AggregateParameter _ReservedStock_W = null;
			private AggregateParameter _ReserveOrderID_W = null;
			private AggregateParameter _BoxSize_W = null;
			private AggregateParameter _PalletLocationID_W = null;
			private AggregateParameter _IsOriginalReceive_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_ReceiveID_W = null;
				_PalletID_W = null;
				_ReceivedQuantity_W = null;
				_Balance_W = null;
				_ReservedStock_W = null;
				_ReserveOrderID_W = null;
				_BoxSize_W = null;
				_PalletLocationID_W = null;
				_IsOriginalReceive_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivePalletInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivePalletUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivePalletDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReceiveID);
			p.SourceColumn = ColumnNames.ReceiveID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PalletID);
			p.SourceColumn = ColumnNames.PalletID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReceivedQuantity);
			p.SourceColumn = ColumnNames.ReceivedQuantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Balance);
			p.SourceColumn = ColumnNames.Balance;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReservedStock);
			p.SourceColumn = ColumnNames.ReservedStock;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReserveOrderID);
			p.SourceColumn = ColumnNames.ReserveOrderID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.BoxSize);
			p.SourceColumn = ColumnNames.BoxSize;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PalletLocationID);
			p.SourceColumn = ColumnNames.PalletLocationID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsOriginalReceive);
			p.SourceColumn = ColumnNames.IsOriginalReceive;
			p.SourceVersion = DataRowVersion.Current;

         
			return cmd;
		}
	}
}