<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowSongs.aspx.cs" Inherits="ShowSongs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script>
    function checkSearch() {
        var value = document.getElementById("searchValue").value.trim();
        var err = document.getElementById("searchErr");

        err.innerHTML = "";

        if (value == "") {
            err.innerHTML = "Please enter search value";
            return false;
        }

        return true;
    }
</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2>All Songs Ranked By Popularity</h2>

<form method="post" onsubmit="return checkSearch();">

Search by:
<br />

<input type="radio" name="searchType" value="song" checked /> Song Name
<input type="radio" name="searchType" value="artist" /> Artist
<input type="radio" name="searchType" value="year" /> Year
<input type="radio" name="searchType" value="genre" /> Genre

<br /><br />

<input type="text" name="searchValue" id="searchValue" />
<span id="searchErr"></span>

<br /><br />

<input type="submit" value="Search" />

</form>

<br />

<%= tableData %>

</asp:Content>