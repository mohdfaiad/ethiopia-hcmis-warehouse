﻿
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
    public abstract class _OrderType : SqlClientEntity
    {
        public _OrderType()
        {
            this.QuerySource = "OrderType";
            this.MappingName = "OrderType";

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

            return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderTypeLoadAll]", parameters);
        }

        //=================================================================
        // public Overridable Function LoadByPrimaryKey()  As Boolean
        //=================================================================
        //  Loads a single row of via the primary key
        //=================================================================
        public virtual bool LoadByPrimaryKey(int OrderTypeID)
        {
            ListDictionary parameters = new ListDictionary();
            parameters.Add(Parameters.OrderTypeID, OrderTypeID);


            return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderTypeLoadByPrimaryKey]", parameters);
        }

        #region Parameters
        protected class Parameters
        {

            public static SqlParameter OrderTypeID
            {
                get
                {
                    return new SqlParameter("@OrderTypeID", SqlDbType.Int, 0);
                }
            }

            public static SqlParameter Name
            {
                get
                {
                    return new SqlParameter("@Name", SqlDbType.NVarChar, 100);
                }
            }

            public static SqlParameter Description
            {
                get
                {
                    return new SqlParameter("@Description", SqlDbType.NVarChar, 400);
                }
            }

            public static SqlParameter IsActive
            {
                get
                {
                    return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
                }
            }

            public static SqlParameter Rowguid
            {
                get
                {
                    return new SqlParameter("@Rowguid", SqlDbType.UniqueIdentifier, 0);
                }
            }

            public static SqlParameter OrderTypeCode
            {
                get
                {
                    return new SqlParameter("@OrderTypeCode", SqlDbType.NVarChar, 5);
                }
            }

            public static SqlParameter SN
            {
                get
                {
                    return new SqlParameter("@SN", SqlDbType.Int, 0);
                }
            }

        }
        #endregion

        #region ColumnNames
        public class ColumnNames
        {
            public const string OrderTypeID = "OrderTypeID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "rowguid";
            public const string OrderTypeCode = "OrderTypeCode";
            public const string SN = "SN";

            static public string ToPropertyName(string columnName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[OrderTypeID] = _OrderType.PropertyNames.OrderTypeID;
                    ht[Name] = _OrderType.PropertyNames.Name;
                    ht[Description] = _OrderType.PropertyNames.Description;
                    ht[IsActive] = _OrderType.PropertyNames.IsActive;
                    ht[Rowguid] = _OrderType.PropertyNames.Rowguid;
                    ht[OrderTypeCode] = _OrderType.PropertyNames.OrderTypeCode;
                    ht[SN] = _OrderType.PropertyNames.SN;

                }
                return (string)ht[columnName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region PropertyNames
        public class PropertyNames
        {
            public const string OrderTypeID = "OrderTypeID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string IsActive = "IsActive";
            public const string Rowguid = "Rowguid";
            public const string OrderTypeCode = "OrderTypeCode";
            public const string SN = "SN";

            static public string ToColumnName(string propertyName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[OrderTypeID] = _OrderType.ColumnNames.OrderTypeID;
                    ht[Name] = _OrderType.ColumnNames.Name;
                    ht[Description] = _OrderType.ColumnNames.Description;
                    ht[IsActive] = _OrderType.ColumnNames.IsActive;
                    ht[Rowguid] = _OrderType.ColumnNames.Rowguid;
                    ht[OrderTypeCode] = _OrderType.ColumnNames.OrderTypeCode;
                    ht[SN] = _OrderType.ColumnNames.SN;

                }
                return (string)ht[propertyName];
            }

            static private Hashtable ht = null;
        }
        #endregion

        #region StringPropertyNames
        public class StringPropertyNames
        {
            public const string OrderTypeID = "s_OrderTypeID";
            public const string Name = "s_Name";
            public const string Description = "s_Description";
            public const string IsActive = "s_IsActive";
            public const string Rowguid = "s_Rowguid";
            public const string OrderTypeCode = "s_OrderTypeCode";
            public const string SN = "s_SN";

        }
        #endregion

        #region Properties

        public virtual int OrderTypeID
        {
            get
            {
                return base.Getint(ColumnNames.OrderTypeID);
            }
            set
            {
                base.Setint(ColumnNames.OrderTypeID, value);
            }
        }

        public virtual string Name
        {
            get
            {
                return base.Getstring(ColumnNames.Name);
            }
            set
            {
                base.Setstring(ColumnNames.Name, value);
            }
        }

        public virtual string Description
        {
            get
            {
                return base.Getstring(ColumnNames.Description);
            }
            set
            {
                base.Setstring(ColumnNames.Description, value);
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

        public virtual Guid Rowguid
        {
            get
            {
                return base.GetGuid(ColumnNames.Rowguid);
            }
            set
            {
                base.SetGuid(ColumnNames.Rowguid, value);
            }
        }

        public virtual string OrderTypeCode
        {
            get
            {
                return base.Getstring(ColumnNames.OrderTypeCode);
            }
            set
            {
                base.Setstring(ColumnNames.OrderTypeCode, value);
            }
        }

        public virtual int SN
        {
            get
            {
                return base.Getint(ColumnNames.SN);
            }
            set
            {
                base.Setint(ColumnNames.SN, value);
            }
        }


        #endregion

        #region String Properties

        public virtual string s_OrderTypeID
        {
            get
            {
                return this.IsColumnNull(ColumnNames.OrderTypeID) ? string.Empty : base.GetintAsString(ColumnNames.OrderTypeID);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.OrderTypeID);
                else
                    this.OrderTypeID = base.SetintAsString(ColumnNames.OrderTypeID, value);
            }
        }

        public virtual string s_Name
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Name);
                else
                    this.Name = base.SetstringAsString(ColumnNames.Name, value);
            }
        }

        public virtual string s_Description
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Description);
                else
                    this.Description = base.SetstringAsString(ColumnNames.Description, value);
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
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.IsActive);
                else
                    this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
            }
        }

        public virtual string s_Rowguid
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Rowguid) ? string.Empty : base.GetGuidAsString(ColumnNames.Rowguid);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Rowguid);
                else
                    this.Rowguid = base.SetGuidAsString(ColumnNames.Rowguid, value);
            }
        }

        public virtual string s_OrderTypeCode
        {
            get
            {
                return this.IsColumnNull(ColumnNames.OrderTypeCode) ? string.Empty : base.GetstringAsString(ColumnNames.OrderTypeCode);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.OrderTypeCode);
                else
                    this.OrderTypeCode = base.SetstringAsString(ColumnNames.OrderTypeCode, value);
            }
        }

        public virtual string s_SN
        {
            get
            {
                return this.IsColumnNull(ColumnNames.SN) ? string.Empty : base.GetintAsString(ColumnNames.SN);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.SN);
                else
                    this.SN = base.SetintAsString(ColumnNames.SN, value);
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
                    if (_tearOff == null)
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


                public WhereParameter OrderTypeID
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.OrderTypeID, Parameters.OrderTypeID);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Name
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Description
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
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

                public WhereParameter Rowguid
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Rowguid, Parameters.Rowguid);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter OrderTypeCode
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.OrderTypeCode, Parameters.OrderTypeCode);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter SN
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.SN, Parameters.SN);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }


                private WhereClause _clause;
            }
            #endregion

            public WhereParameter OrderTypeID
            {
                get
                {
                    if (_OrderTypeID_W == null)
                    {
                        _OrderTypeID_W = TearOff.OrderTypeID;
                    }
                    return _OrderTypeID_W;
                }
            }

            public WhereParameter Name
            {
                get
                {
                    if (_Name_W == null)
                    {
                        _Name_W = TearOff.Name;
                    }
                    return _Name_W;
                }
            }

            public WhereParameter Description
            {
                get
                {
                    if (_Description_W == null)
                    {
                        _Description_W = TearOff.Description;
                    }
                    return _Description_W;
                }
            }

            public WhereParameter IsActive
            {
                get
                {
                    if (_IsActive_W == null)
                    {
                        _IsActive_W = TearOff.IsActive;
                    }
                    return _IsActive_W;
                }
            }

            public WhereParameter Rowguid
            {
                get
                {
                    if (_Rowguid_W == null)
                    {
                        _Rowguid_W = TearOff.Rowguid;
                    }
                    return _Rowguid_W;
                }
            }

            public WhereParameter OrderTypeCode
            {
                get
                {
                    if (_OrderTypeCode_W == null)
                    {
                        _OrderTypeCode_W = TearOff.OrderTypeCode;
                    }
                    return _OrderTypeCode_W;
                }
            }

            public WhereParameter SN
            {
                get
                {
                    if (_SN_W == null)
                    {
                        _SN_W = TearOff.SN;
                    }
                    return _SN_W;
                }
            }

            private WhereParameter _OrderTypeID_W = null;
            private WhereParameter _Name_W = null;
            private WhereParameter _Description_W = null;
            private WhereParameter _IsActive_W = null;
            private WhereParameter _Rowguid_W = null;
            private WhereParameter _OrderTypeCode_W = null;
            private WhereParameter _SN_W = null;

            public void WhereClauseReset()
            {
                _OrderTypeID_W = null;
                _Name_W = null;
                _Description_W = null;
                _IsActive_W = null;
                _Rowguid_W = null;
                _OrderTypeCode_W = null;
                _SN_W = null;

                this._entity.Query.FlushWhereParameters();

            }

            private BusinessEntity _entity;
            private TearOffWhereParameter _tearOff;

        }

        public WhereClause Where
        {
            get
            {
                if (_whereClause == null)
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
                    if (_tearOff == null)
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


                public AggregateParameter OrderTypeID
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderTypeID, Parameters.OrderTypeID);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Name
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Description
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
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

                public AggregateParameter Rowguid
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Rowguid, Parameters.Rowguid);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter OrderTypeCode
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderTypeCode, Parameters.OrderTypeCode);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter SN
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.SN, Parameters.SN);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }


                private AggregateClause _clause;
            }
            #endregion

            public AggregateParameter OrderTypeID
            {
                get
                {
                    if (_OrderTypeID_W == null)
                    {
                        _OrderTypeID_W = TearOff.OrderTypeID;
                    }
                    return _OrderTypeID_W;
                }
            }

            public AggregateParameter Name
            {
                get
                {
                    if (_Name_W == null)
                    {
                        _Name_W = TearOff.Name;
                    }
                    return _Name_W;
                }
            }

            public AggregateParameter Description
            {
                get
                {
                    if (_Description_W == null)
                    {
                        _Description_W = TearOff.Description;
                    }
                    return _Description_W;
                }
            }

            public AggregateParameter IsActive
            {
                get
                {
                    if (_IsActive_W == null)
                    {
                        _IsActive_W = TearOff.IsActive;
                    }
                    return _IsActive_W;
                }
            }

            public AggregateParameter Rowguid
            {
                get
                {
                    if (_Rowguid_W == null)
                    {
                        _Rowguid_W = TearOff.Rowguid;
                    }
                    return _Rowguid_W;
                }
            }

            public AggregateParameter OrderTypeCode
            {
                get
                {
                    if (_OrderTypeCode_W == null)
                    {
                        _OrderTypeCode_W = TearOff.OrderTypeCode;
                    }
                    return _OrderTypeCode_W;
                }
            }

            public AggregateParameter SN
            {
                get
                {
                    if (_SN_W == null)
                    {
                        _SN_W = TearOff.SN;
                    }
                    return _SN_W;
                }
            }

            private AggregateParameter _OrderTypeID_W = null;
            private AggregateParameter _Name_W = null;
            private AggregateParameter _Description_W = null;
            private AggregateParameter _IsActive_W = null;
            private AggregateParameter _Rowguid_W = null;
            private AggregateParameter _OrderTypeCode_W = null;
            private AggregateParameter _SN_W = null;

            public void AggregateClauseReset()
            {
                _OrderTypeID_W = null;
                _Name_W = null;
                _Description_W = null;
                _IsActive_W = null;
                _Rowguid_W = null;
                _OrderTypeCode_W = null;
                _SN_W = null;

                this._entity.Query.FlushAggregateParameters();

            }

            private BusinessEntity _entity;
            private TearOffAggregateParameter _tearOff;

        }

        public AggregateClause Aggregate
        {
            get
            {
                if (_aggregateClause == null)
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
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderTypeInsert]";

            CreateParameters(cmd);

            SqlParameter p;
            p = cmd.Parameters[Parameters.OrderTypeID.ParameterName];
            p.Direction = ParameterDirection.Output;

            return cmd;
        }

        protected override IDbCommand GetUpdateCommand()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderTypeUpdate]";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetDeleteCommand()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderTypeDelete]";

            SqlParameter p;
            p = cmd.Parameters.Add(Parameters.OrderTypeID);
            p.SourceColumn = ColumnNames.OrderTypeID;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }

        private IDbCommand CreateParameters(SqlCommand cmd)
        {
            SqlParameter p;

            p = cmd.Parameters.Add(Parameters.OrderTypeID);
            p.SourceColumn = ColumnNames.OrderTypeID;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Name);
            p.SourceColumn = ColumnNames.Name;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Description);
            p.SourceColumn = ColumnNames.Description;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.IsActive);
            p.SourceColumn = ColumnNames.IsActive;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Rowguid);
            p.SourceColumn = ColumnNames.Rowguid;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.OrderTypeCode);
            p.SourceColumn = ColumnNames.OrderTypeCode;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.SN);
            p.SourceColumn = ColumnNames.SN;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }
    }
}


