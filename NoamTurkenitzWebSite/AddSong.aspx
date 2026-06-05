<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddSong.aspx.cs" Inherits="AddSong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>

function checkSong()
{
    songErr.innerHTML = "";
    artistErr.innerHTML = "";
    yearErr.innerHTML = "";

    var result = true;

    if(document.getElementById("songName").value == "")
    {
        songErr.innerHTML = "enter song name";
        result = false;
    }

    if(document.getElementById("artist").value == "")
    {
        artistErr.innerHTML = "enter artist";
        result = false;
    }

    if(document.getElementById("year").value == "")
    {
        yearErr.innerHTML = "enter year";
        result = false;
    }

    return result;
}

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form runat="server" method="post" onsubmit="return checkSong();">        
        <h2>Add Song</h2>

        <br />

        Enter Song Name
        <input type="text" name="songName" id="songName" placeholder="enter the name of the song" />
<span id="songErr"></span>
        <br />

        Enter Artist
      <input type="text" name="artist" id="artist"  placeholder="enter the name of the Artist" />
<span id="artistErr"></span>

        <br />

        Select Genre
        <select name="genre" id="genre">
            <option>Rock</option>
            <option>Pop</option>
            <option>Jazz</option>
            <option>Hip Hop</option>
            <option>Classical</option>
        </select>

        <br />
    enter release year
 <input type="number" name="year" id="year" placeholder="enter the release year" />
<span id="yearErr"></span>

        <br />
        <br />

Enter Rating (1-5)
<select name="rating" id="rating">
    <option value="1">1</option>
    <option value="2">2</option>
    <option value="3">3</option>
    <option value="4">4</option>
    <option value="5">5</option>
</select>
        <br />

        <input id="Submit1" type="submit" value="Add Song" />

        <br />

        <%=strRes %>

    </form>

</asp:Content>