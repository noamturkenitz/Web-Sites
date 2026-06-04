using System;

public partial class AddSong : System.Web.UI.Page
{
    public string strRes = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null && Session["nihul"] == null)
        {
            Response.Redirect("home.aspx");
        }

        if (IsPostBack)
        {
            string songName = Request.Form["songName"];
            string artist = Request.Form["artist"];
            string genre = Request.Form["genre"];
            string year = Request.Form["year"];
            string rating = Request.Form["rating"];

            songName = songName.Replace("'", "''"); /*מחליף גרש אחד לשניים אך לא מראה למשתמש מכיוון שגרש אחד סוגר את הטקסט ואז מראה תקלה 
                                                      זו הדרך היחידה לתת למתמש לרשום גרש במילה באנגלית למשל don't 
                                                     מבלי שתיווצר שגיאה
                                                     */


            artist = artist.Replace("'", "''");
            genre = genre.Replace("'", "''");

            if (songName == "" || artist == "" || year == "")
            {
                strRes = " Please fill all fields";
                return;
            }

            string checkSql =
      "SELECT * FROM Songs WHERE SongName = N'" + songName + "' AND Artist = N'" + artist + "'";

            if (MyAdoHelper.IsExist(checkSql))
            {
                string updateSql =
                    "UPDATE Songs SET " +
                    "TotalRating = TotalRating + " + rating + "," +
                    "NumRatings = NumRatings + 1 " +
                    "WHERE SongName = N'" + songName + "' AND Artist = N'" + artist + "'";

                MyAdoHelper.DoQuery(updateSql);

                strRes = "Rating added successfully!";
                return;
            }

            string sql = "INSERT INTO Songs " +
                "(SongName, Artist, Genre, ReleaseYear, Rating, AddedBy, TotalRating, NumRatings) VALUES (" +
                "N'" + songName + "'," +
                "N'" + artist + "'," +
                "N'" + genre + "'," +
                year + "," +
                rating + "," +
                "N'" + Session["userName"] + "'," +
                rating + "," +
                "1)";

            MyAdoHelper.DoQuery(sql);

            strRes = " Song added successfully!";
        }
    }
}