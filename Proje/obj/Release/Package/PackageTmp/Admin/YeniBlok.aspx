<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="YeniBlok.aspx.cs" Inherits="DiziYorumProje.Admin.YeniBlok" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        <asp:TextBox ID="TxtBaslik" runat="server" placeholder="Başlik" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtTarih" runat="server" placeholder="Tarıh" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtGorsel" runat="server" placeholder="Görsel" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataTextField="TurAd" DataValueField="Turid"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataTextField="KategoriAd" DataValueField="Kategoriid"></asp:DropDownList>
        <br />
        <asp:TextBox ID="Txticerik" runat="server" placeholder="İçerik" CssClass="form-control" Height="150px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="BtnKayit" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="BtnKayit_Click" />
    </form>

</asp:Content>
