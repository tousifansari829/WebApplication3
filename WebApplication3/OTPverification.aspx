<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OTPverification.aspx.cs" Inherits="WebApplication3.OTPverification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            OTP
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send OTP" />
            <br />
            <br />
            Verify OTP
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Verify" />
        </div>
    </form>
</body>
</html>
