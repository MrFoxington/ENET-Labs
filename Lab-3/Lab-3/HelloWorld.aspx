<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="Lab_3.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your name stranger?<br />
        <asp:TextBox ID="txtBox_EnterName" runat="server">Enter your Name here!</asp:TextBox>
        <asp:Button ID="btn_EnterName" runat="server" Text="GO! GO! Lets GO!" OnClick="btn_EnterName_Click" />
    
        <br />
        <br />
    
        <asp:Label ID="lbl_Name" runat="server" Text="Label" Visible="false"></asp:Label>
    
    </div>
    </form>
</body>
</html>
