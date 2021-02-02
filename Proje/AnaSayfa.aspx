<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="DiziYorumProje.AnaSayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                <img class="infoimg" src="<%# Eval("BlokGorsel") %>" alt="" />
                                <div class="post-info">
                                    <h4><a href="BlokDetay.aspx?Blokid=<%#Eval("Blokid")%>"><%# Eval("BlokBaslik") %></a><%# Eval("BlokTarih")%></h4>
                                    <p><%# Eval("Blokicerik") %></p>
                                    <a href="BlokDetay.aspx"><span></span>Devamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>EN SON BLOKLAR</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li>
                                    <a href="BlokDetay.aspx?Blokid=<%#Eval("Blokid")%>"><%# Eval("BlokBaslik") %></a>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="comments">
                    <h3>SON YORUMLAR</h3>
                    <ul>
                        <asp:Repeater ID="Repeater4" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%# Eval("KullaniciAd") %>: <%# Eval("Yorumicerik") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>

                    </ul>
                </div>

                <div class="categories">
                    <h3>KATEGORİLER</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="KategoriDetay.aspx?Kategoriid=<%#Eval("Kategoriid")%>"><%# Eval("KategoriAd") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <%--</div>--%>
            </div>
        </div>
    </div>
</asp:Content>
