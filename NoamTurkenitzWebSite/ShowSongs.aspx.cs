using System;
using System.Data;

public partial class ShowSongs : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "SELECT * FROM Songs";

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        st = "<table border='1'>";
        st += "<tr>";
        st += "<th>ID</th>";
        st += "<th>Song Name</th>";
        st += "<th>Artist</th>";
        st += "<th>Genre</th>";
        st += "<th>Year</th>";
        st += "</tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            st += "<tr>";
            st += "<td>" + dt.Rows[i]["SongID"] + "</td>";
            st += "<td>" + dt.Rows[i]["SongName"] + "</td>";
            st += "<td>" + dt.Rows[i]["Artist"] + "</td>";
            st += "<td>" + dt.Rows[i]["Genre"] + "</td>";
            st += "<td>" + dt.Rows[i]["ReleaseYear"] + "</td>";
            st += "</tr>";
        }

        st += "</table>";
    }
}