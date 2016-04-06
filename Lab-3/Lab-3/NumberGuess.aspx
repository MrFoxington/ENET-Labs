<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberGuess.aspx.cs" Inherits="Lab_3.NumberGuesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label">Enter Guess</asp:Label>
        <br />
        <asp:TextBox ID="txt_guess" runat="server"></asp:TextBox>
        <asp:Button ID="btn_submitGuess" runat="server" Text="Submit Guess" />
    
    </div>
    </form>
</body>
</html>
