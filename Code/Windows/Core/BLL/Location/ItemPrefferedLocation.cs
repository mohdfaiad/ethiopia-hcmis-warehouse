
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
namespace BLL
{
	///<summary>
	/// Handles all logics related to the Item Preferrred location
	/// Preferred location is optional and is not enforced on pick up and put away
	///</summary>
	public class ItemPrefferedLocation : _ItemPrefferedLocation
	{


        /// <summary>
        /// Checks if a pallet location is preferred location for an item.
        /// </summary>
        /// <param name="palletLocationId">The pallet location id.</param>
        /// <param name="itemId">The item id.</param>
        /// <returns>
        ///   <c>true</c> if [is prefered pallete location] [the specified pallet location id]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsPreferedPalleteLocation(int palletLocationId, int itemId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.ItemPrefferedLocation.SelectIsPreferedPalleteLocation(palletLocationId, itemId));
            return (this.RowCount > 0);
        }

	  

	    /// <summary>
        /// Load all rows in the item preferred location table for the given rack
        /// </summary>
        /// <param name="rackId">The rack id.</param>
        public void LoadByRackID(int rackId)
        {
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.ItemPrefferedLocation.SelectLoadByRackId(rackId));
        }

	  

	    /// <summary>
        /// Loads all preferred locations for an item
        /// </summary>
        /// <param name="itemId">The item id.</param>
        public void LoadByItemID(int itemId)
        { 
            this.FlushData();
            this.LoadFromRawSql(HCMIS.Repository.Queries.ItemPrefferedLocation.SelectLoadByItemId(itemId));
        }

	  

	    /// <summary>
        /// Saves item preferred location
        /// </summary>
        /// <param name="itemId">The item id.</param>
        /// <param name="palletLocation">The pallet location.</param>
        /// <param name="isFixed">if set to <c>true</c> [is fixed].</param>
        public void SaveNewItemPreferredRack(int itemId, int palletLocation, bool isFixed)
        {
            this.FlushData();

            this.LoadFromRawSql(HCMIS.Repository.Queries.ItemPrefferedLocation.SelectSaveNewItemPreferredRack(itemId, palletLocation));
            if (this.RowCount == 0)
            {
                this.AddNew();
                this.PalletLocationID = palletLocation;
                this.ItemID = itemId;
                
            }
            IsFixed = isFixed;
            this.Save();
        }


	}
}
