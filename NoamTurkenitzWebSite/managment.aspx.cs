using System;
using System.Data;

public partial class managment : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        {
            if (Request.Form["reset"] != null)
            {
                Response.Redirect("managment.aspx");
                return;
            }
            if (Session["nihul"] == null || Session["nihul"].ToString() != "ok")
            {
                Response.Redirect("home.aspx");
            }
            
            
            string fullname = Request.Form["fun1"]; 
            string email = Request.Form["email"];

            string sql;

            if (fullname == "" && email == "")
            {
                sql = "SELECT * FROM tUsers";
            }   
            else
            {
                sql = "SELECT * FROM tUsers WHERE " +
                      "name LIKE N'%" + fullname + "%' AND " +
                      "Email LIKE N'%" + email + "%'";
            }

            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
st = "No data was found";            }
            else
            {
                st += "<table border='1'>";
                st += "<tr>";
                st += "<th>name</th>";
                st += "<th>email</th>";
                st += "<th>type</th>";
                st += "<th>connection</th>";
                st += "<th>recommend</th>";
                st += "<th>age</th>";
                st += "</tr>";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st += "<tr>";

                    st += "<td>" + dt.Rows[i]["name"] + "</td>";
                    st += "<td>" + dt.Rows[i]["Email"] + "</td>";
                    st += "<td>" + dt.Rows[i]["types"] + "</td>";
                    st += "<td>" + dt.Rows[i]["connections"] + "</td>";
                    st += "<td>" + dt.Rows[i]["recommend"] + "</td>";
                    st += "<td>" + dt.Rows[i]["age"] + "</td>";

                    st += "</tr>";
                }

                st += "</table>";
            }
        }
    }
}