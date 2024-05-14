using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsRegister
        clsRegister clsNewRegister = new clsRegister();
        //get data from the session object
        clsNewRegister = (clsRegister)Session["clsNewRegister"];
        //display username 
        Response.Write(clsNewRegister.username);
        
    }
}