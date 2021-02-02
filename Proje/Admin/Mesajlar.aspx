<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Mesajlar.aspx.cs" Inherits="DiziYorumProje.Admin.Mesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="table table-bordered">
        <tr>
            <th>id</th>
            <th>AD SOYAD</th>
            <th>MAİL</th>
            <th>TELEFON</th>
            <th>KONU</th>
            <th>MESAJ</th>
            <th>SİL</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("Mesajid") %></td>
                    <td><%# Eval("AdSoyad") %></td>
                    <td><%# Eval("Mail") %></td>
                    <td><%# Eval("Telefon") %></td>
                    <td><%# Eval("Konu") %></td>
                    <td><%# Eval("Mesaj") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"MesajSil.aspx?Mesajid="+Eval("Mesajid")%>'
                            CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
