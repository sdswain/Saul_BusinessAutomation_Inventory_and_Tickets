using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS_407_Inventory
{
    public partial class frmSubmitTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTicketSubmit_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            try
            {

                bool allOK = true;
                if (Request["txtTicketForm"].ToString().Trim() == "")
                {
                    txtTicketForm.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Product Description Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    txtTicketForm.BackColor = System.Drawing.Color.White;
                }

                if (Request["txtTicketDiscription"].ToString().Trim() == "")
                {
                    txtTicketDiscription.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Product Type Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    txtTicketDiscription.BackColor = System.Drawing.Color.White;
                }

                if (allOK)
                {
                    Session["txtTicketForm"] = txtTicketForm.Text;
                    Session["txtTicketDiscription"] = txtTicketDiscription.Text;
                }
                else
                {
                    lblTicketResult.Text = errorMessage;
                }

            }
            catch (Exception ex)
            {
                lblTicketResult.Text = ex.Message;
            }

            if (clsDataLayer.SubmitTicket(Server.MapPath("CIS470A_BusinessAutomation.accdb"),
           txtTicketForm.Text, txtTicketDiscription.Text))
            {
                lblTicketResult.Text = "The Ticket Was Successfully Submited!";
                lblTicketResult.ForeColor = System.Drawing.Color.Green;
                lblTicketResult.Visible = true;
            }
            else
            {
                lblTicketResult.Text = "The Ticket Was Not Submited!";
                lblTicketResult.Visible = true;
            }
        }
    }
}