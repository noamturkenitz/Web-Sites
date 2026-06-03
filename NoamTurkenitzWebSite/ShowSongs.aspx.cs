using System;
using System.Data;

public partial class ShowSongs : System.Web.UI.Page
{
    public string tableData = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null && Session["nihul"] == null)
        {
            Response.Redirect("home.aspx");
        }

        string sql = "SELECT * FROM Songs ORDER BY TotalRating DESC";

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        int rank = 1;

        tableData += "<table border='1' style='width:100%; text-align:center;'>";

        if (rank == 1)
        {
            tableData += "<tr style='background-color:gold'>";
        }
        else if (rank == 2)
        {
            tableData += "<tr style='background-color:silver'>";
        }
        else if (rank == 3)
        {
            tableData += "<tr style='background-color:#cd7f32'>";
        }
        else
        {
            tableData += "<tr>";
        }
        tableData += "<th>Rank</th>";
        tableData += "<th>Added By</th>";
        tableData += "<th>Song</th>";
        tableData += "<th>Artist</th>";
        tableData += "<th>Genre</th>";
        tableData += "<th>Year</th>";
        tableData += "<th>Popularity</th>";
        tableData += "</tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            tableData += "<tr>";

            tableData += "<td>" + rank + "</td>";
            tableData += "<td>" + dt.Rows[i]["AddedBy"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["SongName"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["Artist"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["Genre"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["ReleaseYear"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["TotalRating"] + "</td>";

            tableData += "</tr>";

            rank++;
        }

        tableData += "</table>";
    }
}