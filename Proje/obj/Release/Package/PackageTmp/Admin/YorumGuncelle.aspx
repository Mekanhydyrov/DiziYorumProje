<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProje.Admin.YorumGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <form runat="server" class="form-group">
        <asp:TextBox ID="TxtBaslik" runat="server" placeholder="Başlik" Enabled="false" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtKullanici" runat="server" placeholder="Kullanıcı Ad" CssClass="form-control"></asp:TextBox>
        <br /> 
        <asp:TextBox ID="Txticerik" runat="server" placeholder="Yorum İçerik" CssClass="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="BtnKayit" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="BtnKayit_Click"/>
    </form>


</asp:Content>
