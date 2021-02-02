<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="DiziYorumProje.iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="contact-content">
        <div class="container">
            <div class="contact-info">
                <h2>İLETİŞİM</h2>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p>
                            <%# Eval("iletisimAciklama") %>
                        </p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="contact-details">
                <form runat="server">
                    <asp:TextBox ID="TxtAd" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
                    <asp:TextBox ID="TxtMail" runat="server" placeholder="Mail" required=""></asp:TextBox>
                    <asp:TextBox ID="TxtTelefon" runat="server" placeholder="Telefon" required=""></asp:TextBox>
                    <asp:TextBox ID="TxtKonu" runat="server" placeholder="Konu" required=""></asp:TextBox>
                    <asp:TextBox ID="TxtMesaj" runat="server" placeholder="Mesajınız" Height="150px" Width="100%" required=""></asp:TextBox>
                    <asp:Button ID="Btniletisim" runat="server" Text="Gönder" OnClick="Btniletisim_Click" />
                </form>
            </div>
            <div class="contact-details">
                <div class="col-md-6 contact-map">
                    <h4>Biz Burdayız</h4>
                    <div class="mapouter">
                        <div class="gmap_canvas">
                            <iframe width="600" height="500" id="gmap_canvas"
                                src="https://maps.google.com/maps?q=Sivas&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no"
                                marginheight="0" marginwidth="0"></iframe>
                            <a href="https://sites.google.com/view/maps-api-v2/mapv2"></a>
                        </div>
                        <style>
                            .mapouter {
                                position: relative;
                                text-align: right;
                                height: 500px;
                                width: 600px;
                            }

                            .gmap_canvas {
                                overflow: hidden;
                                background: none !important;
                                height: 500px;
                                width: 600px;
                            }
                        </style>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
