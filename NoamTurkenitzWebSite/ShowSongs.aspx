<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
AutoEventWireup="true" CodeFile="ShowSongs.aspx.cs" Inherits="ShowSongs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script>
    function checkSearch() {
        var value = document.getElementById("searchValue").value.trim();
        var err = document.getElementById("searchErr");

        err.innerHTML = "";

        if (value === "") {
            err.innerHTML = "Please enter search value";
            return false;
        }

        return true;
    }
</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2>My Website's Biggest Hits Ranked by You</h2>

<form method="post" onsubmit="return checkSearch();">

Search by:
<br />

<input type="radio" name="searchType" value="song" checked /> Song Name
<input type="radio" name="searchType" value="artist" /> Artist
<input type="radio" name="searchType" value="genre" /> Genre
<input type="radio" name="searchType" value="year" /> Year
<input type="radio" name="searchType" value="addedby" /> Added By
<input type="radio" name="searchType" value="popularity" /> Popularity
<input type="radio" name="searchType" value="votes" /> Votes
    <br />
<input type="submit" name="reset" value="Reset" />

<br /><br />

<input type="text" name="searchValue" id="searchValue"
       placeholder="Enter search value..." />

<span id="searchErr" style="color:red;"></span>

<br /><br />

<input type="submit" value="Search" />

</form>

<hr />

<%= tableData %>

</asp:Content>