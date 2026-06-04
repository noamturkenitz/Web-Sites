using System;
using System.Data;

public partial class TopSongs : System.Web.UI.Page
{
    public string tableData = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null && Session["nihul"] == null)
        {
            Response.Redirect("home.aspx");
        }

        string sql = "SELECT TOP 5 * FROM Songs ORDER BY TotalRating DESC";
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        tableData += "<h2> Top 5 Songs</h2>";
        tableData += "<table border='1' style='width:100%; text-align:center;'>";

        tableData += "<tr>";
        tableData += "<th>Rank</th>";
        tableData += "<th>Song</th>";
        tableData += "<th>Artist</th>";
        tableData += "<th>popularity</th>";
        tableData += "</tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (i == 0)
                tableData += "<tr style='background-color:gold'>";
            else if (i == 1)
                tableData += "<tr style='background-color:silver'>";
            else if (i == 2)
                tableData += "<tr style='background-color:#cd7f32'>";
            else
                tableData += "<tr>"; 

            tableData += "<td>" + (i + 1) + "</td>";
            tableData += "<td>" + dt.Rows[i]["SongName"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["Artist"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["TotalRating"] + "</td>";
            tableData += "</tr>";
        }

        tableData += "</table>";
    }
}