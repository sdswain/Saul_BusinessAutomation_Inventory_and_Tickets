using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace CIS_407_Inventory
{
    public partial class frmViewTickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnSubmitView_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;");
            Server.MapPath("CIS470A_BusinessAutomation.accdb");

            string strSQL = "SELECT ApplicationForm,Description,DateOfSubmition FROM Tickets WHERE DateOfSubmition = '" +
                ddlTicketDate.SelectedValue + "';";


            DataTable dtViewTicket = new DataTable();
            dtViewTicket.Columns.AddRange(new DataColumn[3] { new DataColumn("ApplicationForm", typeof(string)),
            new DataColumn("Description", typeof(string)),
            new DataColumn("DateOfSubmition", typeof(DateTime))});

            lstViewTicket.DataSource = dtViewTicket;
            lstViewTicket.DataTextField = "ApplicationForm";
            lstViewTicket.DataTextField = "Description";
            lstViewTicket.DataTextField = "DateOfSumition";
            
            lstViewTicket.DataBind();
        }
    }
}