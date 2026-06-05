using System;
using System.Data;

public partial class log_in : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) return;

        string email = Request.Form["Email"];
        string pass = Request.Form["Password"];

        if (email == "noam.turkenitz@gmail.com" && pass == "Manager123")
        {
            Session["user"] = "ok";
            Session["nihul"] = "ok";
            Session["userName"] = "Admin";

            Response.Redirect("managment.aspx");
            return;
        }

        string sql = "SELECT * FROM tUsers WHERE Email=N'" + email + "' AND password=N'" + pass + "'";
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        if (dt.Rows.Count > 0)
        {
            Session["user"] = "ok";
            Session["nihul"] = "no"; 
            Session["userName"] = dt.Rows[0]["name"].ToString();

            Response.Redirect("home.aspx");
        }
        else
        {
            Session["user"] = null;
            Session["nihul"] = null;
            Session["userName"] = "Guest";

            st = "Invalid email or password";
        }
    }
}