using System;
using System.Data;
using System.Web.UI;

public partial class log_in : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["Email"];
            string pass = Request.Form["Password"];

            // Admin login
            if (email == "noam.turkenitz@gmail.com" && pass == "M123")
            {
                Session["userName"] = "Admin";
                Session["nihul"] = "ok";
                Response.Redirect("managment.aspx");
            }
            else
            {
                string sql = "SELECT * FROM tUsers WHERE Email = N'" + email + "' AND password = N'" + pass + "'";
                //bool isExist = MyAdoHelper.IsExist(sql);
                DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

                if (dt.Rows.Count==0)
                {
                    Session["userName"] = "Guest";
                    st = "Email or password are wrong";
                }
                else
                {
                    Session["user"] = "ok";
                    Session["userName"] = dt.Rows[0]["name"];
                    Response.Redirect("home.aspx");
                }
            }
        }
    }
}