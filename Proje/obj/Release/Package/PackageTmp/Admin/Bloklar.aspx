<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Bloklar.aspx.cs" Inherits="DiziYorumProje.Admin.Bloklar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <table class="table table-bordered">
      <tr>
          <th>id</th>
          <th>BAŞLIK</th>
          <th>TARIH</th>
          <th>TÜR</th>
          <th>KATEGORİ</th>
          <th>SİL</th>
          <th>GÜNCELLE</th>
      </tr>
      <asp:Repeater ID="Repeater1" runat="server">
          <ItemTemplate>
              <tr>
                  <td><%# Eval("Blokid") %></td>
                  <td><%# Eval("BlokBaslik") %></td> 
                  <td><%# Eval("BlokTarih") %></td>
                  <td><%# Eval("TurAd") %></td>
                  <td><%# Eval("KategoriAd") %></td>
                  <td>
                      <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"BlokSil.aspx?Blokid="+Eval("Blokid")%>' 
                          CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                  <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"BlokGuncelle.aspx?Blokid="+Eval("Blokid")%>' 
                          CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
              </tr>
          </ItemTemplate>
      </asp:Repeater>
  </table>
    <a href="YeniBlok.aspx" class="btn btn-primary">Yeni Blok</a>
</asp:Content>
