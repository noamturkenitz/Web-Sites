<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gallery.aspx.cs" Inherits="gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        img.gallery{
            width:150px;
            height:250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>gallery</h2>
    
        <img src="https://cdn.teachercreated.com/covers/600w/V1651.jpg?v=20260420" class="gallery"/>
    <img src="https://vocabzoo.com/wp-content/uploads/2025/10/String-Instruments-List-Names-with-Pictures.png" class="gallery" />
    <img src="https://www.vedantu.com/seo/content-images/d113e14a-4bfd-4799-8366-ee4074f66685_1..png" class="gallery" />
</asp:Content>

