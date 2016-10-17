using CIS_407_Inventory.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        /*
        // estblish link to the dataset
        dsUser dsUserLogin;

        // estblish variable for Security Level in tblUserLogin
        string SecurityLevel;

        // Estblish connection to the database
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.accdb"), Login1.UserName, Login1.Password);

        // validation for login
        if (dsUserLogin.User.Count < 1)
        {
            e.Authenticated = false;
            if (clsBusinessLayer.SendEmail("dividingtheway@live.com", "", "", "saul.swain@outlook.com", "Login Incorrect",
                "The login failed for UserName: " + Login1.UserName + " Password: " + Login1.Password))
            {
                Login1.FailureText = Login1.FailureText + " Your incorrect login information was sent to saul.swain@outlook.com";
            }
            return;
        }

        // conection for variable SecurityLevel to tblUserLogin
        SecurityLevel = dsUserLogin.tblUserLogin[0].SecurityLevel.ToString();

        // Switch for SecurityLevel
        switch (SecurityLevel)
        {
            case "A":
                // Case for admin security level "A"
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "A";
                break;
            // Case for users security level "U"
            case "U":
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
                Session["SecurityLevel"] = "U";
                break;
            default:
                e.Authenticated = false;
                break;
        }
        */
    }

}