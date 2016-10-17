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
    public partial class frmInventoryTabPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            try
            {

                bool allOK = true;
                if (Request["ProductDescription"].ToString().Trim() == "")
                {
                    ProductDescription.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Product Description Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductDescription.BackColor = System.Drawing.Color.White;
                }

                if (Request["ProductType"].ToString().Trim() == "")
                {
                    ProductType.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Product Type Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductType.BackColor = System.Drawing.Color.White;
                }

                if (Request["Quanity"].ToString().Trim() == "")
                {
                    ProductQuantity.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Quanity Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductQuantity.BackColor = System.Drawing.Color.White;
                }

                if (Request["ProductCost"].ToString().Trim() == "")
                {
                    ProductCost.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Price Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductCost.BackColor = System.Drawing.Color.White;
                }

                if (allOK)
                {
                    Session["ProductDiscription"] = ProductDescription.Text;
                    Session["ProductType"] = ProductType.Text;
                    Session["ProductQuanity"] = ProductQuantity.Text;
                    Session["ProductCost"] = ProductCost.Text;
                }
                else
                {
                    lblErrorMsg.Text = errorMessage;
                }
                
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = ex.Message;
            }

            if (clsDataLayer.AddProduct(Server.MapPath("CIS470A_BusinessAutomation.accdb"),
           ProductDescription.Text, ProductType.Text, ProductQuantity.Text, ProductCost.Text))
            {
                lblErrorMsg.Text = "The Product Was Successfully Added!";
                lblErrorMsg.ForeColor = System.Drawing.Color.Green;
                lblErrorMsg.Visible = true;
            }
            else
            {
                lblErrorMsg.Text = "The Product Was Not Added!";
                lblErrorMsg.Visible = true;
            }
        }//button_click Add Product


        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            try
            {

                bool allOK = true;

                if (Request["txtEditType"].ToString().Trim() == "")
                {
                    ProductType.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Product Type Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductType.BackColor = System.Drawing.Color.White;
                }

                if (Request["txtEditQuantity"].ToString().Trim() == "")
                {
                    ProductQuantity.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Quanity Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductQuantity.BackColor = System.Drawing.Color.White;
                }

                if (Request["txtEditPrice"].ToString().Trim() == "")
                {
                    ProductCost.BackColor = System.Drawing.Color.Yellow;
                    errorMessage = errorMessage + "Price Can Not Be Empty.";
                    allOK = false;
                }
                else
                {
                    ProductCost.BackColor = System.Drawing.Color.White;
                }

                if (allOK)
                {
                    Session["ddlSelectProduct"] = ddlSelectProduct.SelectedValue;
                    Session["txtEditType"] = ProductType.Text;
                    Session["txtEditQuantity"] = ProductQuantity.Text;
                    Session["txtEditPrice"] = ProductCost.Text;
                }
                else
                {
                    lblEditErrorMsg.Text = errorMessage;
                }
            }
            catch (Exception ex)
            {
                lblEditErrorMsg.Text = ex.Message;
            }


            if (clsDataLayer.EditProduct(Server.MapPath("CIS470A_BusinessAutomation.accdb"),
          ddlSelectProduct.SelectedValue, txtEditType.Text, txtEditQuantity.Text, txtEditPrice.Text))
            {
                lblEditErrorMsg.Text = "The Product Was Successfully Updated!";
                lblEditErrorMsg.ForeColor = System.Drawing.Color.Green;
                lblEditErrorMsg.Visible = true;
            }
            else
            {
                lblEditErrorMsg.Text = "The Product Was Not Updated!";
                lblEditErrorMsg.Visible = true;
            }
        }


        protected void btnClear_Click(object sender, EventArgs e)
        {
            ProductDescription.Text = null;
            ProductType.Text = null;
            ProductQuantity.Text = null;
            ProductCost.Text = null;
           
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Session["ddlSelectProduct"] = ddlSelectProduct.SelectedValue;
            //Session["ddlSelectType"] = ddlSelectType.SelectedValue;

            if (clsDataLayer.DeleteProduct(Server.MapPath("CIS470A_BusinessAutomation.accdb"),
           ddlProductDescription.SelectedValue))
            {
                lblDeleteMsg.Text = "The Product Was Successfully Deleted!";
                lblDeleteMsg.ForeColor = System.Drawing.Color.Green;
                lblDeleteMsg.Visible = true;
            }
            else
            {
                lblDeleteMsg.Text = "The Product Was Not Deleted!";
                lblDeleteMsg.Visible = true;
            }
        }

        protected void btnRefreshData_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmInventoryTabPage.aspx");
        }
    }//class
}//namespace