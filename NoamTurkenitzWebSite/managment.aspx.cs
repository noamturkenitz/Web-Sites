using System;
using System.Data;

public partial class managment : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string fullname = Request.Form["fun1"]; // asp:name
            string email = Request.Form["email"];

            // אוסף את כל הרשומות
            string sql = "SELECT * FROM tUsers WHERE " +
                         "name Like N'%" + fullname + "%' AND " +
                         "Email Like N'%" + email + "%'";
            //string sqlselect = "SELECT * FROM tUsers";

            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                st = "no data was founded";
            }
            else
            {
                st += "<table border='1'>";
                st += "<tr>";
                st += "<th>name</th>";
                st += "<th>email</th>";
                st += "<th>password</th>";
                st += "<th>type</th>";
                st += "<th>connection</th>";
                st += "<th>recommend</th>";
                st += "<th>age</th>";
                st += "</tr>";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st += "<tr>";

                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        st += "<td>" + dt.Rows[i][k] + "</td>";
                    }

                    st += "</tr>";
                }

                st += "</table>";
            }
        }
    }
}