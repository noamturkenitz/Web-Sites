using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class log_in : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["Email"];
            string pass = Request.Form["Password"];
            if (email == "noam.turkenitz@gmail.com" && pass == "M123")
            {
                Response.Redirect("managment.aspx");
            }
            else
            {



                string sql = "Select * from tUsers where Email=N'" + email + "' AND password = N'" + pass + "'";

                bool isExist = MyAdoHelper.IsExist(sql);
                if (!isExist)
                {
                    st = "email or password are wrong";
                }
                else
                {
                    Response.Redirect("home.aspx");
                }
            }
        }











    }
}