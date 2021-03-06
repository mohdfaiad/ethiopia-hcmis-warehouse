
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Diagnostics;
using DAL;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    /// <summary>
    /// Encapsulates logic to log STV printouts, the date and the new numbering that is generated for each STV
    /// </summary>
    public class Issue : _Issue
    {
        public Issue()
        {

        }


        /// <summary>
        /// Gets the log for
        /// </summary>
        /// <param name="refNo">The ref no.</param>
        /// <returns></returns>
        public static string GetLogFor(string refNo)
        {
            Issue log = new Issue();
            log.LoadFromRawSql(HCMIS.Repository.Queries.Issue.SelectGetLogFor(refNo));
            if (log.RowCount == 0)
            {
                // Indicate that this is a number from the old Pick list numbering logic
                return "O-" + refNo;
            }
            return log.ID.ToString("00000");
        }


        /// <summary>
        /// Loads the by store ID and printed ID.
        /// </summary>
        /// <param name="storeID">The store ID.</param>
        /// <param name="stvPrintedID">The STV printed ID.</param>
        public void LoadByStoreIDAndPrintedID(int storeID, int stvPrintedID)
        {
            this.FlushData();
            this.Where.StoreID.Value = storeID;
            this.Where.IDPrinted.Value = stvPrintedID;
            this.Query.Load();
        }

        /// <summary>
        /// Gets the last printed ID.
        /// </summary>
        /// <param name="storeID">The store ID.</param>
        /// <param name="paymentTypeID">The payment type ID.</param>
        /// <returns></returns>
   
        public static int GetLastPrintedIDByPaymentTypeID(int activityId, int? paymentTypeId)
        {
            Issue s = new Issue();
            string query = "";

            query = HCMIS.Repository.Queries.Issue.SelectGetLastPrintedIDByPaymentTypeID(activityId, paymentTypeId);

            s.LoadFromRawSql(query);
            int calculatedId;
            try
            {
                calculatedId = int.Parse(s.GetColumn("IDPrinted").ToString());
            }
            catch
            {
                calculatedId = 0;
            }


            int startingPointID = 0;// A provision in case the STV or invoice number is required to start from a certain number.
            if (calculatedId <= startingPointID && calculatedId != 0)
                return startingPointID;
            else
                return calculatedId;
        }

        /// <summary>
        /// What this fixes: The code for the STVLog had put the PickLitDetailID in the table instead of the PicklistID
        /// </summary>
        public static void FixInconsistencies()
        {
            var query = HCMIS.Repository.Queries.Issue.UpdateFixInconsistencies();
            BLL.Issue s = new Issue();
            s.LoadFromRawSql(query);
        }

        /// <summary>
        /// Gets the issue details.
        /// </summary>
        /// <param name="_stvID">The _STV ID.</param>
        /// <returns></returns>
        public static object GetIssueDetails(int _stvID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetIssueDetails(_stvID);

            BLL.Issue s = new Issue();
            s.LoadFromRawSql(query);
            return s.DefaultView;
        }

        /// <summary>
        /// Marks as dispatched.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="prePrintedSTV">The pre printed STV.</param>
        /// <returns></returns>
        public bool MarkAsDispatched(int userID, int? prePrintedSTV)
        {
            if (!this.IsColumnNull("VoidRequest"))
            {
                if ((this.VoidRequest && this.IsColumnNull("VoidApprovedByUserID"))) //If the approver hasn't acted on the void request.
                {
                    return false;
                }
            }
            //Mark the NoOfPackIssued equal to the NoOfPack.  Discrepancies are supposed to be saved after this function has finished running.
            var query = HCMIS.Repository.Queries.Issue.UpdateMarkAsDispatched(userID, this.ID);

            var queryConfirmIssue = HCMIS.Repository.Queries.Issue.UpdateMarkAsDispatched(this.ID);
            
            if (prePrintedSTV.HasValue)
            {
                this.PrePrintedInvoiceNo = prePrintedSTV.Value;
                this.Save();
            }

            BLL.Issue s = new Issue();
            s.LoadFromRawSql(query);
            s.LoadFromRawSql(queryConfirmIssue);

            BLL.IssueDoc isDoc = new IssueDoc();
            isDoc.Where.STVID.Value = this.ID;
            isDoc.Query.Load();
            if (isDoc.RowCount > 0)
            {
                int orderID = isDoc.OrderID;
                BLL.Order ord = new Order();
                ord.LoadByPrimaryKey(orderID);
                if (ord.RowCount > 0)
                {
                    ord.ChangeStatus(OrderStatus.Constant.DISPATCH_CONFIRMED,CurrentContext.UserId);
                    ord.Save();
                }
            }

            return true;
        }

        /// <summary>
        /// Sends the A void request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        public void SendAVoidRequest(int userID)
        {
            this.VoidRequest = true;
            this.VoidRequestDateTime = DateTimeHelper.ServerDateTime;
            this.VoidRequestUserID = userID;
            this.Save();
        }

        /// <summary>
        /// Cancels the void request.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        public void CancelVoidRequest(int userID)
        {
            this.IsVoided = false;
            this.VoidRequest = false;
            this.VoidApprovedByUserID = userID;
            this.VoidApprovalDateTime = DateTimeHelper.ServerDateTime;
            this.Save();
        }

        

        /// <summary>
        /// Loads the latest reprint.
        /// </summary>
        public void LoadLatestReprint()
        {
            var query = HCMIS.Repository.Queries.Issue.SelectLoadLatestReprint(ID);
            this.LoadFromRawSql(query);
        }

        /// <summary>
        /// Gets the log for facility.
        /// </summary>
        /// <param name="storeID">The store ID.</param>
        /// <param name="facilityID">The facility ID.</param>
        /// <returns></returns>
        public static DataTable GetLogForFacility(int storeID, int facilityID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetLogForFacility(storeID, facilityID);
            BLL.Issue s = new Issue();
            s.LoadFromRawSql(query);
            return s.DataTable;
        } 

        /// <summary>
        /// gets the visit history for a facility.
        /// </summary>
        /// <param name="facilityID">The facility ID.</param>
        /// <returns></returns>
        public static DataRow  GetVisitHistoryForFacility(int facilityID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetVisitHistoryForFacility(facilityID);
            BLL.Issue s = new Issue();
            s.LoadFromRawSql(query);
            return s.DataTable.Rows.Count > 0 ? s.DataTable.Rows[0]: null;
        }

        public static DataRow GetVisitHistoryForFacility(string facilityname)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetVisitHistoryForFacility(facilityname);
            BLL.Issue s = new Issue();
            s.LoadFromRawSql(query);
            return s.DataTable.Rows.Count > 0 ? s.DataTable.Rows[0] : null;
        }
        /// <summary>
        /// Gets the delivery notes to be converted.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public static DataTable GetDeliveryNotesToBeConverted(int storeId)
        {
            // Now ... Consider the user's previlages
            var query = HCMIS.Repository.Queries.Issue.SelectGetDeliveryNotesToBeConverted(storeId);
            Issue stvLog = new Issue();
            stvLog.LoadFromRawSql(query);
            return stvLog.DataTable;
        }

        /// <summary>
        /// Gets the detail items.
        /// </summary>
        /// <param name="STVLogID">The STV log ID.</param>
        /// <returns></returns>
        public static DataTable GetDetailItems(int STVLogID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetDetailItems(STVLogID);
            Issue log = new Issue();
            log.LoadFromRawSql(query);
            return log.DataTable;
        }

        public static DataTable Search(string searchString, string type)
        {
            int paymentType = (type == "Cash")
                                  ? PaymentType.Constants.CASH
                                  : (type == "Credit") ? PaymentType.Constants.CREDIT : PaymentType.Constants.STV;
            var query = HCMIS.Repository.Queries.Issue.SelectSearch(searchString, type, paymentType);
            Issue log = new Issue();
            log.LoadFromRawSql(query);
            return log.DataTable;
        }

        public void LoadAllReprints(int stvID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectLoadAllReprints(stvID);
            this.LoadFromRawSql(query);
        }

        public void LoadAllNotChecked(int userID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectLoadAllNotChecked(userID);
            this.LoadFromRawSql(query);
            Debug.WriteLine(this.RowCount);
        }

        //public void GetTotalPrintedIssues

        
        public void SaveInvoiceChecked()
        {
            this.Rewind();
            while (!this.EOF)
            {
                if (Convert.ToBoolean(this.GetColumn("IsChanged")))
                {
                    var query = HCMIS.Repository.Queries.Issue.UpdateSaveInvoiceChecked(this.IsChecked, this.ID);
                    BLL.Issue iss = new Issue();
                    iss.LoadFromRawSql(query);
                }
                this.MoveNext();
            }
        }

        public void GetIssueDescriptions(int accountID)
        {
            this.FlushData();
            var query = HCMIS.Repository.Queries.Issue.SelectGetIssueDescriptions(accountID);
            this.LoadFromRawSql(query);
        }

        public void GetDisptachConfirmationStatus(int accountID, int warehouseID) //Added for the dispatch confirmation status report
        {
            this.FlushData();
            string query = HCMIS.Repository.Queries.Issue.SelectGetDispatchConfirmationStatus(accountID, warehouseID);
            this.LoadFromRawSql(query);
        }

        public void GetPrintedQtyandActualDisptached(int accountID) //Added to get the printed vs dispatch qty report
        {
            this.FlushData();
            string query = HCMIS.Repository.Queries.Issue.SelectPrintedQtyAndActualDispatched(accountID);
            this.LoadFromRawSql(query);
        }
        
        public void LoadSTVDetails(int stvID)
        {
            this.FlushData();

            var query = HCMIS.Repository.Queries.Issue.SelectLoadSTVDetails(stvID);

            this.LoadFromRawSql(query);
        }

        public static int GetTotalInvoices()
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetTotalInvoices();
            var iss = new Issue();
            iss.LoadFromRawSql(query);
            return Convert.ToInt32(iss.GetColumn("Value"));
        }

        public static int GetUnconfirmedInvoices()
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetUnconfirmedInvoices();
            var iss = new Issue();
            iss.LoadFromRawSql(query);
            return Convert.ToInt32(iss.GetColumn("Value"));
        }

        public static int GetConfirmedInvoices()
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetConfirmedInvoices();
            var iss = new Issue();
            iss.LoadFromRawSql(query);
            return Convert.ToInt32(iss.GetColumn("Value"));
        }

        public static DataView GetIssueDetailByFacility(int accountId,DateTime fromdate,DateTime toDate,int facilityID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectGetIssueDetailByFacility(accountId, fromdate, toDate, facilityID);
            var iss = new Issue();
            iss.LoadFromRawSql(query);
            return iss.DefaultView;
        }

        public string InvoiceNumber
        { 
            get
            {
                FiscalYear fiscalYear = new FiscalYear();
                fiscalYear.LoadByPrimaryKey(FiscalYearID);
                return fiscalYear.GetCode(IDPrinted);
            }
        }

        public  Issue GetIssueByOrderID(int orderid)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectIssueByOrderID(orderid);
            var iss = new Issue();
            iss.LoadFromRawSql(query);
            return iss;
        }

        public void LoadByPicklist(int pickListID)
        {
            var query = HCMIS.Repository.Queries.Issue.SelectIssueByPicklistID(pickListID);
            LoadFromRawSql(query);
        }
    }
}