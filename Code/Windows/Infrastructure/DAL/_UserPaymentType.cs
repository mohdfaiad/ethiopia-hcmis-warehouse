
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
	public abstract class _UserPaymentType : SqlClientEntity
	{
		public _UserPaymentType()
		{
			this.QuerySource = "UserPaymentType";
			this.MappingName = "UserPaymentType";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserPaymentTypeLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserPaymentTypeLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PaymentTypeID
			{
				get
				{
					return new SqlParameter("@PaymentTypeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CanAccess
			{
				get
				{
					return new SqlParameter("@CanAccess", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter IsDefault
			{
				get
				{
					return new SqlParameter("@IsDefault", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string UserID = "UserID";
            public const string PaymentTypeID = "PaymentTypeID";
            public const string CanAccess = "CanAccess";
            public const string IsDefault = "IsDefault";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _UserPaymentType.PropertyNames.ID;
					ht[UserID] = _UserPaymentType.PropertyNames.UserID;
					ht[PaymentTypeID] = _UserPaymentType.PropertyNames.PaymentTypeID;
					ht[CanAccess] = _UserPaymentType.PropertyNames.CanAccess;
					ht[IsDefault] = _UserPaymentType.PropertyNames.IsDefault;

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
            public const string UserID = "UserID";
            public const string PaymentTypeID = "PaymentTypeID";
            public const string CanAccess = "CanAccess";
            public const string IsDefault = "IsDefault";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _UserPaymentType.ColumnNames.ID;
					ht[UserID] = _UserPaymentType.ColumnNames.UserID;
					ht[PaymentTypeID] = _UserPaymentType.ColumnNames.PaymentTypeID;
					ht[CanAccess] = _UserPaymentType.ColumnNames.CanAccess;
					ht[IsDefault] = _UserPaymentType.ColumnNames.IsDefault;

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
            public const string UserID = "s_UserID";
            public const string PaymentTypeID = "s_PaymentTypeID";
            public const string CanAccess = "s_CanAccess";
            public const string IsDefault = "s_IsDefault";

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

		public virtual int UserID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserID);
			}
			set
	        {
				base.Setint(ColumnNames.UserID, value);
			}
		}

		public virtual int PaymentTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.PaymentTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.PaymentTypeID, value);
			}
		}

		public virtual bool CanAccess
	    {
			get
	        {
				return base.Getbool(ColumnNames.CanAccess);
			}
			set
	        {
				base.Setbool(ColumnNames.CanAccess, value);
			}
		}

		public virtual bool IsDefault
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsDefault);
			}
			set
	        {
				base.Setbool(ColumnNames.IsDefault, value);
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

		public virtual string s_UserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserID) ? string.Empty : base.GetintAsString(ColumnNames.UserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserID);
				else
					this.UserID = base.SetintAsString(ColumnNames.UserID, value);
			}
		}

		public virtual string s_PaymentTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PaymentTypeID) ? string.Empty : base.GetintAsString(ColumnNames.PaymentTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PaymentTypeID);
				else
					this.PaymentTypeID = base.SetintAsString(ColumnNames.PaymentTypeID, value);
			}
		}

		public virtual string s_CanAccess
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CanAccess) ? string.Empty : base.GetboolAsString(ColumnNames.CanAccess);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CanAccess);
				else
					this.CanAccess = base.SetboolAsString(ColumnNames.CanAccess, value);
			}
		}

		public virtual string s_IsDefault
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsDefault) ? string.Empty : base.GetboolAsString(ColumnNames.IsDefault);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsDefault);
				else
					this.IsDefault = base.SetboolAsString(ColumnNames.IsDefault, value);
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

				public WhereParameter UserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PaymentTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PaymentTypeID, Parameters.PaymentTypeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CanAccess
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CanAccess, Parameters.CanAccess);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsDefault
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsDefault, Parameters.IsDefault);
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

			public WhereParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public WhereParameter PaymentTypeID
		    {
				get
		        {
					if(_PaymentTypeID_W == null)
	        	    {
						_PaymentTypeID_W = TearOff.PaymentTypeID;
					}
					return _PaymentTypeID_W;
				}
			}

			public WhereParameter CanAccess
		    {
				get
		        {
					if(_CanAccess_W == null)
	        	    {
						_CanAccess_W = TearOff.CanAccess;
					}
					return _CanAccess_W;
				}
			}

			public WhereParameter IsDefault
		    {
				get
		        {
					if(_IsDefault_W == null)
	        	    {
						_IsDefault_W = TearOff.IsDefault;
					}
					return _IsDefault_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _PaymentTypeID_W = null;
			private WhereParameter _CanAccess_W = null;
			private WhereParameter _IsDefault_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_UserID_W = null;
				_PaymentTypeID_W = null;
				_CanAccess_W = null;
				_IsDefault_W = null;

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

				public AggregateParameter UserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PaymentTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PaymentTypeID, Parameters.PaymentTypeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CanAccess
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CanAccess, Parameters.CanAccess);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsDefault
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsDefault, Parameters.IsDefault);
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

			public AggregateParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public AggregateParameter PaymentTypeID
		    {
				get
		        {
					if(_PaymentTypeID_W == null)
	        	    {
						_PaymentTypeID_W = TearOff.PaymentTypeID;
					}
					return _PaymentTypeID_W;
				}
			}

			public AggregateParameter CanAccess
		    {
				get
		        {
					if(_CanAccess_W == null)
	        	    {
						_CanAccess_W = TearOff.CanAccess;
					}
					return _CanAccess_W;
				}
			}

			public AggregateParameter IsDefault
		    {
				get
		        {
					if(_IsDefault_W == null)
	        	    {
						_IsDefault_W = TearOff.IsDefault;
					}
					return _IsDefault_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _PaymentTypeID_W = null;
			private AggregateParameter _CanAccess_W = null;
			private AggregateParameter _IsDefault_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_UserID_W = null;
				_PaymentTypeID_W = null;
				_CanAccess_W = null;
				_IsDefault_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserPaymentTypeInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserPaymentTypeUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserPaymentTypeDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PaymentTypeID);
			p.SourceColumn = ColumnNames.PaymentTypeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CanAccess);
			p.SourceColumn = ColumnNames.CanAccess;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsDefault);
			p.SourceColumn = ColumnNames.IsDefault;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}