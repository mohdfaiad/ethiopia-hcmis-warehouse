﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace HCMIS.Desktop.Forms.Modals.Finance
{
    public partial class MarginPage : DevExpress.XtraEditors.XtraForm
    {
        private int ReceiptID;
        private int ItemID;
        private int ItemUnitID;
        private int ManufacturerID;
        private int ActivityID;
        private double Margin;
        private DataTable ReceiveDocDetails;
        
        public MarginPage()
        {
            InitializeComponent();
        }

        public MarginPage(int ReceiptID, int ItemID, int ItemUnitID, int ManufacturerID, int ActivityID, double Margin)
        {
            InitializeComponent();
            //Load All From Receivedoc
            this.ReceiptID = ReceiptID;
            this.ItemID = ItemID;       
            this.ItemUnitID = ItemUnitID;
            this.ManufacturerID = ManufacturerID;
            this.ActivityID = ActivityID;
            this.Margin = Margin;
        }

        private void PricePerPackPage_Load(object sender, EventArgs e)
        {
            LoadAndBind();
        }
        /// <summary>
        /// Load All Neccessary Data and Bind To DataSource
        /// </summary>
        void LoadAndBind()
        {
            //Bind
            gridRelatedReceives.DataSource = ReceiveDocDetails;
            //Load Detail Table To Grid
            ReceiveDocDetails = ReceiveDoc.GetRelatedReceiveForMarginChange(ReceiptID, ItemID, ItemUnitID, ManufacturerID, ActivityID, (Margin/100));
            gridRelatedReceives.DataSource = ReceiveDocDetails;
            
            //Load Header Information From first row to be displayed
            if (ReceiveDocDetails.Rows.Count > 0)
            {
                DataRow dr = ReceiveDocDetails.Rows[0];
                txtStockCode.EditValue = dr["StockCode"].ToString();
                txtItemName.EditValue = dr["FullItemName"].ToString();
                txtItemUnit.EditValue = dr["ItemUnitName"].ToString();
                txtManufacturerName.EditValue= dr["ManufacturerName"].ToString();
                txtActivityName.EditValue = dr["ActivityName"].ToString();
            }
         
        }
        private void LoadReceivesDetails()
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach (DataRowView Cursor in ReceiveDocDetails.AsDataView())
            {
                int ID = Convert.ToInt32(Cursor["ID"]);
                ReceiveDoc.SetMarginByReceiveDoc(ID, Margin, CurrentContext.UserId);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}