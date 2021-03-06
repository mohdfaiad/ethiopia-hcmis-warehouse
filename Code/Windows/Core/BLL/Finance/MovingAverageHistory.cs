
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using DAL;
using System.Data;
using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// Weighted average settings
    /// </summary>
	public class MovingAverageHistory : _MovingAverageHistory
	{
        /// <summary>
        /// Gets the list for GRV pricing.
        /// </summary>
        /// <returns></returns>
        public static DataView GetListForGRVPricing()
        {
            MovingAverageHistory wal = new MovingAverageHistory();
            var query = HCMIS.Repository.Queries.MovingAverageHistory.SelectGetListForGRVPricing(ReceiptType.CONSTANTS.BEGINNING_BALANCE);
           wal.LoadFromRawSql(query);
           return wal.DefaultView;
        }

        /// <summary>
        /// Gets the moving average by receipt ID.
        /// </summary>
        /// <param name="ReceiptID">The receipt ID.</param>
        /// <returns></returns>
        public static DataTable GetMovingAverageByReceiptID(int ReceiptID)
        {
            MovingAverageHistory wal = new MovingAverageHistory();
            var query = HCMIS.Repository.Queries.MovingAverageHistory.SelectGetMovingAverageByReceiptId(ReceiptID);
            wal.LoadFromRawSql(query);
            return wal.DataTable;
        }

        /// <summary>
        /// Gets the history.
        /// </summary>
        /// <param name="itemID">The item ID.</param>
        /// <param name="activityID">The activity ID.</param>
        /// <param name="unitID">The unit ID.</param>
        /// <returns></returns>
        public DataTable GetHistory(CostElement CostElement)
        {
            var query = HCMIS.Repository.Queries.MovingAverageHistory.SelectGetHistory(CostElement.ItemID, CostElement.ItemUnitID, CostElement.ManufacturerID, CostElement.MovingAverageID);
            this.LoadFromRawSql(query);
            return this.DataTable;

        }

        public DataTable GetBeginningBalance(CostElement CostElement)
        {
            var query = HCMIS.Repository.Queries.MovingAverageHistory.SelectGetBeginningBalance(CostElement.ItemID, CostElement.ItemUnitID, CostElement.ManufacturerID, CostElement.MovingAverageID);
            this.LoadFromRawSql(query);
            return this.DataTable;

        }
	}
}
