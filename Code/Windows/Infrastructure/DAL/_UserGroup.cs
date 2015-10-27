
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
	public abstract class _UserGroup : SqlClientEntity
	{
		public _UserGroup()
		{
			this.QuerySource = "UserGroup";
			this.MappingName = "UserGroup";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserGroupLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int UserGroupID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.UserGroupID, UserGroupID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_UserGroupLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter UserGroupID
			{
				get
				{
					return new SqlParameter("@UserGroupID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter GroupID
			{
				get
				{
					return new SqlParameter("@GroupID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsActive
			{
				get
				{
					return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string UserGroupID = "UserGroupID";
            public const string UserID = "UserID";
            public const string GroupID = "GroupID";
            public const string IsActive = "IsActive";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserGroupID] = _UserGroup.PropertyNames.UserGroupID;
					ht[UserID] = _UserGroup.PropertyNames.UserID;
					ht[GroupID] = _UserGroup.PropertyNames.GroupID;
					ht[IsActive] = _UserGroup.PropertyNames.IsActive;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string UserGroupID = "UserGroupID";
            public const string UserID = "UserID";
            public const string GroupID = "GroupID";
            public const string IsActive = "IsActive";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[UserGroupID] = _UserGroup.ColumnNames.UserGroupID;
					ht[UserID] = _UserGroup.ColumnNames.UserID;
					ht[GroupID] = _UserGroup.ColumnNames.GroupID;
					ht[IsActive] = _UserGroup.ColumnNames.IsActive;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string UserGroupID = "s_UserGroupID";
            public const string UserID = "s_UserID";
            public const string GroupID = "s_GroupID";
            public const string IsActive = "s_IsActive";

		}
		#endregion		
		
		#region Properties
	
		public virtual int UserGroupID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserGroupID);
			}
			set
	        {
				base.Setint(ColumnNames.UserGroupID, value);
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

		public virtual int GroupID
	    {
			get
	        {
				return base.Getint(ColumnNames.GroupID);
			}
			set
	        {
				base.Setint(ColumnNames.GroupID, value);
			}
		}

		public virtual bool IsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsActive, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_UserGroupID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserGroupID) ? string.Empty : base.GetintAsString(ColumnNames.UserGroupID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserGroupID);
				else
					this.UserGroupID = base.SetintAsString(ColumnNames.UserGroupID, value);
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

		public virtual string s_GroupID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.GroupID) ? string.Empty : base.GetintAsString(ColumnNames.GroupID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.GroupID);
				else
					this.GroupID = base.SetintAsString(ColumnNames.GroupID, value);
			}
		}

		public virtual string s_IsActive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsActive) ? string.Empty : base.GetboolAsString(ColumnNames.IsActive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsActive);
				else
					this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
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
				
				
				public WhereParameter UserGroupID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserGroupID, Parameters.UserGroupID);
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

				public WhereParameter GroupID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.GroupID, Parameters.GroupID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter UserGroupID
		    {
				get
		        {
					if(_UserGroupID_W == null)
	        	    {
						_UserGroupID_W = TearOff.UserGroupID;
					}
					return _UserGroupID_W;
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

			public WhereParameter GroupID
		    {
				get
		        {
					if(_GroupID_W == null)
	        	    {
						_GroupID_W = TearOff.GroupID;
					}
					return _GroupID_W;
				}
			}

			public WhereParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			private WhereParameter _UserGroupID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _GroupID_W = null;
			private WhereParameter _IsActive_W = null;

			public void WhereClauseReset()
			{
				_UserGroupID_W = null;
				_UserID_W = null;
				_GroupID_W = null;
				_IsActive_W = null;

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
				
				
				public AggregateParameter UserGroupID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserGroupID, Parameters.UserGroupID);
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

				public AggregateParameter GroupID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.GroupID, Parameters.GroupID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter UserGroupID
		    {
				get
		        {
					if(_UserGroupID_W == null)
	        	    {
						_UserGroupID_W = TearOff.UserGroupID;
					}
					return _UserGroupID_W;
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

			public AggregateParameter GroupID
		    {
				get
		        {
					if(_GroupID_W == null)
	        	    {
						_GroupID_W = TearOff.GroupID;
					}
					return _GroupID_W;
				}
			}

			public AggregateParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			private AggregateParameter _UserGroupID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _GroupID_W = null;
			private AggregateParameter _IsActive_W = null;

			public void AggregateClauseReset()
			{
				_UserGroupID_W = null;
				_UserID_W = null;
				_GroupID_W = null;
				_IsActive_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserGroupInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.UserGroupID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserGroupUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_UserGroupDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.UserGroupID);
			p.SourceColumn = ColumnNames.UserGroupID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.UserGroupID);
			p.SourceColumn = ColumnNames.UserGroupID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.GroupID);
			p.SourceColumn = ColumnNames.GroupID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsActive);
			p.SourceColumn = ColumnNames.IsActive;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}