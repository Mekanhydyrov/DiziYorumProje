<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="istatistik.aspx.cs" Inherits="DiziYorumProje.Admin.istatistik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <td>
               Toplam Blok Sayısı:  <asp:Label ID="LblBlok" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
              Toplam Yorum Sayısı:  <asp:Label ID="LblYorum" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
              Filim Sayısı:  <asp:Label ID="LblFilim" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
              Dizi Sayısı:  <asp:Label ID="LblDizi" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
             Animasiyon Sayısı:   <asp:Label ID="LblAnimasiyon" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
              En Fazla Yorumlu Blok:   <asp:Label ID="LblYorumBlok" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
