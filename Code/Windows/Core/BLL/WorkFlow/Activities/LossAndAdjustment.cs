
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
    /// <summary>
    /// Class that encapsulates logic about Loss and Adjustment
    /// </summary>
    public class LossAndAdjustment : _LossAndAdjustment
    {
        /// <summary>
        /// Gets list of Adjustments performed by a reference number, store id, and date
        /// Date is Ethiopian date
        /// </summary>
        /// <param name="refNo"></param>
        /// <param name="storeId"></param>
        /// <param name="adjDate"></param>
        /// <returns></returns>
        public DataTable GetDocumentByRefNo(string refNo, int storeId, string adjDate)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGetDocumentByRefNo(refNo, storeId, adjDate));
            return this.DataTable;
        }


        /// <summary>
        /// Loads the by item ID.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        public void LoadByItemID(int itemID)
        {
            this.FlushData();
            this.Where.ItemID.Value = itemID;
            this.Query.Load();
        }

        

        /// <summary>
        /// Gets all loss and adjustment transactions by a store
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public DataTable GetAllTransaction(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGetAllTransaction(storeId));
            return this.DataTable;
        }

    

        /// <summary>
        /// Get list of loss and adjustment transactions by reason of loss and adjustment
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="reasonId"></param>
        /// <returns></returns>
        public DataTable GetTransactionByReason(int storeId, int reasonId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGetTransactionByReason(storeId, reasonId));
            return this.DataTable;
        }

       


        public void GetLossAdjustmentsForLastRRFPeriod(int itemID, int storeID, DateTime startDate, DateTime endDate)
        {
            string query =
                HCMIS.Repository.Queries.LossAndAdjustment.SelectGetLossAdjustmentsForLastRRFPeriod(itemID, storeID, startDate, endDate);

            this.FlushData();
            this.LoadFromRawSql(query);
        }

      
        /// <summary>
        /// Get Loss and Adjustement Transactions by Date Range
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataTable GetTransactionByDateRange(int storeId, DateTime dt1, DateTime dt2)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGetTransactionByDateRange(storeId, dt1, dt2));
            return this.DataTable;
        }

       

        /// <summary>
        /// Gets list of Adjustment in logical store
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public DataTable GetDistinctAdjustmentDocments(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGetDistinctAdjustmentDocments(storeId));
            DataTable dtbl = this.DataTable;
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectDistinctYearGetDistinctAdjustmentDocments());
            while (!this.EOF)//The following is added for the benefit of tree control and having parents there.
            {
                DataRowView drv = dtbl.DefaultView.AddNew();
                drv["RefNo"] = drv["ID"] = (this.DataRow["Year"].ToString());
                this.MoveNext();
            }
            return dtbl;
        }

       


        /// <summary>
        /// Gets total Adjusted Quantity 
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="storeId"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public Int64 GetAdjustedQuantityTillMonth(int itemId, int storeId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);
            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            this.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGetAdjustedQuantityTillMonth(itemId, storeId, dt1, dt2));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }



        /// <summary>
        /// Get the lost quanitity till a given month
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="storeId"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public Int64 GetLossesQuantityTillMonth(int itemId, int storeId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);

            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            string query = HCMIS.Repository.Queries.LossAndAdjustment.SelectGetLossesQuantityTillMonth(itemId, storeId, dt1, dt2);
            this.LoadFromRawSql(query);
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

     


        /// <summary>
        /// Utility that generates reference number f
        /// </summary>
        public void GenerateRefNo()
        {
            LossAndAdjustment d = new LossAndAdjustment();
            d.LoadFromRawSql(HCMIS.Repository.Queries.LossAndAdjustment.SelectGenerateRefNo());
            int newRefNo = 0;
            if (!d.IsColumnNull("NewRefNo"))
                newRefNo = d.Getint("NewRefNo");
            this.RefNo = (++newRefNo).ToString();
        }
    }
}
