<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DiziYorumProje.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/login.css" rel="stylesheet" />
</head>
<body>
        <div class="loginBox">
            <img class="user" src="https://sun1-20.userapi.com/impf/c857620/v857620737/c43c0/6fLeuHjZmS4.jpg?size=200x0&quality=96&crop=238,0,1833,1833&sign=4eb4f01483783a73e886d09d53f11e8c&c_uniq_tag=sE524RFabYNDHxfyRkXhVdw04Aj-60sfGbwnhPOdQuM&ava=1" alt=""/>
            <h3>Filim Dizi Login Paneli</h3>
            <form action="login.aspx" method="post" runat="server">
                <div class="inputBox">
                    <asp:TextBox ID="TxtAd" runat="server" placeholder="Kullanıcı Ad"></asp:TextBox>
                    <asp:TextBox ID="TxtSifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button ID="BtnGiris" runat="server" Text="Giriş Yap" OnClick="BtnGiris_Click1" />
            </form>
        </div>
</body>
</html>
