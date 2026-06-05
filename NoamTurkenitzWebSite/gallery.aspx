<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img.gallery{
            width:550px; 
            height:250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 style="color:navy">These are some of the most famous bands and singers who had the biggest influence on music history</h2>
    <img src="images%20for%20html/AdeleMadonaWhitneyKatyCelineLadyGaga.png" class="gallery" />
    <img src="images%20for%20html/BeatlesU2QueenNirvana.jpg" class="gallery"/>
    <img src="images%20for%20html/ElvisMJTimberlakeBonJoviEminemHarryStyles.jpg" class="gallery" />
    <img src="images%20for%20html/ModeCureGunsPolice.jpg" class="gallery"/>
    <img src="images%20for%20html/RhcpREMTHeSMithsBackstreet.jpg" class="gallery" />
    <img src="images%20for%20html/SoulFolkRockPop.jpg" class="gallery"/>
</asp:Content>

