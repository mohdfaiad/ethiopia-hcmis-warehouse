
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
	public abstract class _LogPrint : SqlClientEntity
	{
		public _LogPrint()
		{
			this.QuerySource = "LogPrint";
			this.MappingName = "LogPrint";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogPrintLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_LogPrintLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter Type
			{
				get
				{
					return new SqlParameter("@Type", SqlDbType.NVarChar, 100);
				}
			}
			
			public static SqlParameter Printer
			{
				get
				{
					return new SqlParameter("@Printer", SqlDbType.NVarChar, 100);
				}
			}
			
			public static SqlParameter Value
			{
				get
				{
					return new SqlParameter("@Value", SqlDbType.Image, 2147483647);
				}
			}
			
			public static SqlParameter PrintedDate
			{
				get
				{
					return new SqlParameter("@PrintedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter IsPrinted
			{
				get
				{
					return new SqlParameter("@IsPrinted", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter PrintedBy
			{
				get
				{
					return new SqlParameter("@PrintedBy", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Reference
			{
				get
				{
					return new SqlParameter("@Reference", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string Type = "Type";
            public const string Printer = "Printer";
            public const string Value = "Value";
            public const string PrintedDate = "PrintedDate";
            public const string IsPrinted = "IsPrinted";
            public const string PrintedBy = "PrintedBy";
            public const string Reference = "Reference";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _LogPrint.PropertyNames.ID;
					ht[Type] = _LogPrint.PropertyNames.Type;
					ht[Printer] = _LogPrint.PropertyNames.Printer;
					ht[Value] = _LogPrint.PropertyNames.Value;
					ht[PrintedDate] = _LogPrint.PropertyNames.PrintedDate;
					ht[IsPrinted] = _LogPrint.PropertyNames.IsPrinted;
					ht[PrintedBy] = _LogPrint.PropertyNames.PrintedBy;
					ht[Reference] = _LogPrint.PropertyNames.Reference;

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
            public const string Type = "Type";
            public const string Printer = "Printer";
            public const string Value = "Value";
            public const string PrintedDate = "PrintedDate";
            public const string IsPrinted = "IsPrinted";
            public const string PrintedBy = "PrintedBy";
            public const string Reference = "Reference";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _LogPrint.ColumnNames.ID;
					ht[Type] = _LogPrint.ColumnNames.Type;
					ht[Printer] = _LogPrint.ColumnNames.Printer;
					ht[Value] = _LogPrint.ColumnNames.Value;
					ht[PrintedDate] = _LogPrint.ColumnNames.PrintedDate;
					ht[IsPrinted] = _LogPrint.ColumnNames.IsPrinted;
					ht[PrintedBy] = _LogPrint.ColumnNames.PrintedBy;
					ht[Reference] = _LogPrint.ColumnNames.Reference;

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
            public const string Type = "s_Type";
            public const string Printer = "s_Printer";
            public const string PrintedDate = "s_PrintedDate";
            public const string IsPrinted = "s_IsPrinted";
            public const string PrintedBy = "s_PrintedBy";
            public const string Reference = "s_Reference";

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

		public virtual string Type
	    {
			get
	        {
				return base.Getstring(ColumnNames.Type);
			}
			set
	        {
				base.Setstring(ColumnNames.Type, value);
			}
		}

		public virtual string Printer
	    {
			get
	        {
				return base.Getstring(ColumnNames.Printer);
			}
			set
	        {
				base.Setstring(ColumnNames.Printer, value);
			}
		}

		public virtual byte[] Value
	    {
			get
	        {
				return base.GetByteArray(ColumnNames.Value);
			}
			set
	        {
				base.SetByteArray(ColumnNames.Value, value);
			}
		}

		public virtual DateTime PrintedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.PrintedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.PrintedDate, value);
			}
		}

		public virtual bool IsPrinted
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsPrinted);
			}
			set
	        {
				base.Setbool(ColumnNames.IsPrinted, value);
			}
		}

		public virtual int PrintedBy
	    {
			get
	        {
				return base.Getint(ColumnNames.PrintedBy);
			}
			set
	        {
				base.Setint(ColumnNames.PrintedBy, value);
			}
		}

		public virtual int Reference
	    {
			get
	        {
				return base.Getint(ColumnNames.Reference);
			}
			set
	        {
				base.Setint(ColumnNames.Reference, value);
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

		public virtual string s_Type
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Type) ? string.Empty : base.GetstringAsString(ColumnNames.Type);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Type);
				else
					this.Type = base.SetstringAsString(ColumnNames.Type, value);
			}
		}

		public virtual string s_Printer
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Printer) ? string.Empty : base.GetstringAsString(ColumnNames.Printer);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Printer);
				else
					this.Printer = base.SetstringAsString(ColumnNames.Printer, value);
			}
		}

		public virtual string s_PrintedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PrintedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.PrintedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PrintedDate);
				else
					this.PrintedDate = base.SetDateTimeAsString(ColumnNames.PrintedDate, value);
			}
		}

		public virtual string s_IsPrinted
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsPrinted) ? string.Empty : base.GetboolAsString(ColumnNames.IsPrinted);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsPrinted);
				else
					this.IsPrinted = base.SetboolAsString(ColumnNames.IsPrinted, value);
			}
		}

		public virtual string s_PrintedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PrintedBy) ? string.Empty : base.GetintAsString(ColumnNames.PrintedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PrintedBy);
				else
					this.PrintedBy = base.SetintAsString(ColumnNames.PrintedBy, value);
			}
		}

		public virtual string s_Reference
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Reference) ? string.Empty : base.GetintAsString(ColumnNames.Reference);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Reference);
				else
					this.Reference = base.SetintAsString(ColumnNames.Reference, value);
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

				public WhereParameter Type
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Type, Parameters.Type);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Printer
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Printer, Parameters.Printer);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Value
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Value, Parameters.Value);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PrintedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PrintedDate, Parameters.PrintedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsPrinted
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsPrinted, Parameters.IsPrinted);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PrintedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PrintedBy, Parameters.PrintedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Reference
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Reference, Parameters.Reference);
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

			public WhereParameter Type
		    {
				get
		        {
					if(_Type_W == null)
	        	    {
						_Type_W = TearOff.Type;
					}
					return _Type_W;
				}
			}

			public WhereParameter Printer
		    {
				get
		        {
					if(_Printer_W == null)
	        	    {
						_Printer_W = TearOff.Printer;
					}
					return _Printer_W;
				}
			}

			public WhereParameter Value
		    {
				get
		        {
					if(_Value_W == null)
	        	    {
						_Value_W = TearOff.Value;
					}
					return _Value_W;
				}
			}

			public WhereParameter PrintedDate
		    {
				get
		        {
					if(_PrintedDate_W == null)
	        	    {
						_PrintedDate_W = TearOff.PrintedDate;
					}
					return _PrintedDate_W;
				}
			}

			public WhereParameter IsPrinted
		    {
				get
		        {
					if(_IsPrinted_W == null)
	        	    {
						_IsPrinted_W = TearOff.IsPrinted;
					}
					return _IsPrinted_W;
				}
			}

			public WhereParameter PrintedBy
		    {
				get
		        {
					if(_PrintedBy_W == null)
	        	    {
						_PrintedBy_W = TearOff.PrintedBy;
					}
					return _PrintedBy_W;
				}
			}

			public WhereParameter Reference
		    {
				get
		        {
					if(_Reference_W == null)
	        	    {
						_Reference_W = TearOff.Reference;
					}
					return _Reference_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _Type_W = null;
			private WhereParameter _Printer_W = null;
			private WhereParameter _Value_W = null;
			private WhereParameter _PrintedDate_W = null;
			private WhereParameter _IsPrinted_W = null;
			private WhereParameter _PrintedBy_W = null;
			private WhereParameter _Reference_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_Type_W = null;
				_Printer_W = null;
				_Value_W = null;
				_PrintedDate_W = null;
				_IsPrinted_W = null;
				_PrintedBy_W = null;
				_Reference_W = null;

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

				public AggregateParameter Type
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Type, Parameters.Type);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Printer
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Printer, Parameters.Printer);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Value
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Value, Parameters.Value);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PrintedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PrintedDate, Parameters.PrintedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsPrinted
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsPrinted, Parameters.IsPrinted);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PrintedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PrintedBy, Parameters.PrintedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Reference
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Reference, Parameters.Reference);
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

			public AggregateParameter Type
		    {
				get
		        {
					if(_Type_W == null)
	        	    {
						_Type_W = TearOff.Type;
					}
					return _Type_W;
				}
			}

			public AggregateParameter Printer
		    {
				get
		        {
					if(_Printer_W == null)
	        	    {
						_Printer_W = TearOff.Printer;
					}
					return _Printer_W;
				}
			}

			public AggregateParameter Value
		    {
				get
		        {
					if(_Value_W == null)
	        	    {
						_Value_W = TearOff.Value;
					}
					return _Value_W;
				}
			}

			public AggregateParameter PrintedDate
		    {
				get
		        {
					if(_PrintedDate_W == null)
	        	    {
						_PrintedDate_W = TearOff.PrintedDate;
					}
					return _PrintedDate_W;
				}
			}

			public AggregateParameter IsPrinted
		    {
				get
		        {
					if(_IsPrinted_W == null)
	        	    {
						_IsPrinted_W = TearOff.IsPrinted;
					}
					return _IsPrinted_W;
				}
			}

			public AggregateParameter PrintedBy
		    {
				get
		        {
					if(_PrintedBy_W == null)
	        	    {
						_PrintedBy_W = TearOff.PrintedBy;
					}
					return _PrintedBy_W;
				}
			}

			public AggregateParameter Reference
		    {
				get
		        {
					if(_Reference_W == null)
	        	    {
						_Reference_W = TearOff.Reference;
					}
					return _Reference_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _Type_W = null;
			private AggregateParameter _Printer_W = null;
			private AggregateParameter _Value_W = null;
			private AggregateParameter _PrintedDate_W = null;
			private AggregateParameter _IsPrinted_W = null;
			private AggregateParameter _PrintedBy_W = null;
			private AggregateParameter _Reference_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_Type_W = null;
				_Printer_W = null;
				_Value_W = null;
				_PrintedDate_W = null;
				_IsPrinted_W = null;
				_PrintedBy_W = null;
				_Reference_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogPrintInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogPrintUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_LogPrintDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.Type);
			p.SourceColumn = ColumnNames.Type;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Printer);
			p.SourceColumn = ColumnNames.Printer;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Value);
			p.SourceColumn = ColumnNames.Value;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PrintedDate);
			p.SourceColumn = ColumnNames.PrintedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsPrinted);
			p.SourceColumn = ColumnNames.IsPrinted;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PrintedBy);
			p.SourceColumn = ColumnNames.PrintedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Reference);
			p.SourceColumn = ColumnNames.Reference;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
