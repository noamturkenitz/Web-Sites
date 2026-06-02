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

        // ===== ADMIN =====
        if (email == "noam.turkenitz@gmail.com" && pass == "M123")
        {
            Session["user"] = "ok";
            Session["nihul"] = "ok";
            Session["userName"] = "Admin";

            Response.Redirect("managment.aspx");
            return;
        }

        // ===== USER =====
        string sql = "SELECT * FROM tUsers WHERE Email=N'" + email + "' AND password=N'" + pass + "'";
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        if (dt.Rows.Count > 0)
        {
            Session["user"] = "ok";
            Session["nihul"] = "no"; // חשוב שיהיה מוגדר
            Session["userName"] = dt.Rows[0]["name"].ToString();

            Response.Redirect("home.aspx");
        }
        else
        {
            Session["user"] = null;
            Session["nihul"] = null;
            Session["userName"] = "Guest";

            st = "Email or password are wrong";
        }
    }
}