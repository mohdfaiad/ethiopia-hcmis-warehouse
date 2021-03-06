
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using DAL;

namespace BLL
{
    /// <summary>
    /// Pallet 
    /// </summary>
	public class Pallet : _Pallet
	{
        /// <summary>
        /// Loads pallet by pallet number as opposed to the pallet id
        /// </summary>
        /// <param name="palletNumber"></param>
	    public void LoadByPalletNumber(string palletNumber)
        {
            this.LoadFromRawSql(HCMIS.Repository.Queries.Pallet.SelectLoadByPalletNumber(palletNumber));
        }

       

        /// <summary>
        /// Gets the last pallet number 
        /// </summary>
        /// <returns></returns>
        public static int GetLastPanelNumber()
        {
            Pallet pl = new Pallet();
            string query = HCMIS.Repository.Queries.Pallet.SelectGetLastPanelNumber();
            pl.LoadFromRawSql(query);
            if (pl.RowCount == 0 || pl.DataRow["Last"] == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToInt32(pl.DataRow["Last"]);
        }

       

        /// <summary>
        /// Calculates the current volume of a pallet, 
        /// this assumes that the box levels have all the dimentions set.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public double CalculateCurrentVolume( int id)
        {
          
            Pallet p = new Pallet();
            p.GetAllItemsInPallet(id);
            ReceiveDoc rd = new ReceiveDoc();
            ItemManufacturer im = new ItemManufacturer();
            double volume = 0;

            foreach (DataRowView drv in p.DefaultView)
            {
                //Get the recieving box size and manufacturer
                rd.LoadByPrimaryKey(Convert.ToInt32(drv["ReceiveID"]));
                //Handle if the box size was not specified for some reason.
                // this shouldn't happen on a non error condition
                if (drv["BoxSize"].ToString() == "")
                {
                    drv["BoxSize"] = 0;
                }
                im.LoadIMbyLevel(rd.ItemID, rd.ManufacturerId, Convert.ToInt32(drv["BoxSize"]));
                if (im.RowCount == 0)
                {
                    im.LoadIMbyLevel(rd.ItemID, rd.ManufacturerId, 0);
                }
                double quantity = Convert.ToInt32(drv["Balance"])/im.QuantityInBasicUnit;
                volume += quantity * im.Volume;
                // find the volume of the items in the current pallet.


            }
            return volume;
        }

        /// <summary>
        /// Gets all the item balances on a pallet.
        /// This method only loads the receive pallet entries
        /// </summary>
        /// <param name="palletId"></param>
        public void GetAllItemsInPallet(int palletId)
        {
            string query = HCMIS.Repository.Queries.Pallet.SelectGetAllItemsInPallet(palletId);
            this.LoadFromRawSql(query);
        }

        

        /// <summary>
        /// Gets number of SKUs on a given pallet
        /// </summary>
        /// <param name="palletId"></param>
        public void GetAllItemsInPalletSKUTotal(int palletId)
        {
            string query = HCMIS.Repository.Queries.Pallet.SelectGetAllItemsInPalletSKUTotal(palletId);
            this.LoadFromRawSql(query);
        }

       
	}
}
