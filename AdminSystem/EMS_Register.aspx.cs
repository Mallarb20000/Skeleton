using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EMS_Register : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create a new instance of clsRegister
        clsRegister clsNewRegister = new clsRegister();
        //capture the username
        clsNewRegister.username = txtUsername.Text;
        //store the username in the session object
        Session["clsNewRegister"] = clsNewRegister;
        //navigate tothe next page
        Response.Redirect("5List.aspx");
    }
}