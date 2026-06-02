<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddSong.aspx.cs" Inherits="AddSong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form runat="server" method="post">
        
        <h2>Add Song</h2>

        <br />

        Enter Song Name
        <input type="text" name="songName" id="songName" placeholder="Enter song name" />

        <br />

        Enter Artist
        <input type="text" name="artist" id="artist" placeholder="Enter artist name" />

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

        Enter Release Year
        <input type="number" name="year" id="year" placeholder="Enter release year" />

        <br />

        <input id="Submit1" type="submit" value="Add Song" />

        <br />

        <%=strRes %>

    </form>

</asp:Content>