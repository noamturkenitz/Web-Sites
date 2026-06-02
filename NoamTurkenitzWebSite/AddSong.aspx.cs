using System;

public partial class AddSong : System.Web.UI.Page
{
    public string strRes = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            string songName = Request.Form["songName"];
            string artist = Request.Form["artist"];
            string genre = Request.Form["genre"];
            string year = Request.Form["year"];

            string sql = "INSERT INTO Songs " +
                         "(SongName, Artist, Genre, ReleaseYear) VALUES (" +
                         "N'" + songName + "'," +
                         "N'" + artist + "'," +
                         "N'" + genre + "'," +
                         year + ")";

            MyAdoHelper.DoQuery("MyDB.mdf", sql);

            strRes = "Song added successfully";
        }
    }
}