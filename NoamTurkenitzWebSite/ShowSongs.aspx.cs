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

        string searchType = Request.Form["searchType"];
        string searchValue = Request.Form["searchValue"];

        string sql = "SELECT AddedBy, SongName, Artist, Genre, ReleaseYear, TotalRating, NumRatings FROM Songs";

        if (!string.IsNullOrEmpty(searchValue))
        {
            if (searchType == "song")
                sql += " WHERE SongName LIKE N'%" + searchValue + "%'";
            else if (searchType == "artist")
                sql += " WHERE Artist LIKE N'%" + searchValue + "%'";
            else if (searchType == "year")
                sql += " WHERE ReleaseYear = " + searchValue;
            else if (searchType == "genre")
                sql += " WHERE Genre LIKE N'%" + searchValue + "%'";
        }

        sql += " ORDER BY TotalRating DESC";

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        int rank = 1;
        tableData = "";

        if (dt.Rows.Count == 0)
        {
            tableData = "<h3 style='color:red'>No songs found</h3>";
            return;
        }

        tableData += "<table border='1' style='width:100%; text-align:center;'>";
        tableData += "<tr><th>Rank</th><th>Added By</th><th>Song</th><th>Artist</th><th>Genre</th><th>Year</th><th>Popularity</th><th>Votes</th></tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (rank == 1)
                tableData += "<tr style='background-color:gold'>";
            else if (rank == 2)
                tableData += "<tr style='background-color:silver'>";
            else if (rank == 3)
                tableData += "<tr style='background-color:#cd7f32'>";
            else
                tableData += "<tr>"; tableData += "<td>" + rank + "</td>";
            tableData += "<td>" + dt.Rows[i]["AddedBy"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["SongName"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["Artist"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["Genre"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["ReleaseYear"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["TotalRating"] + "</td>";
            tableData += "<td>" + dt.Rows[i]["NumRatings"] + "</td>";
            tableData += "</tr>";

            rank++;
        }

        tableData += "</table>";
    }
}