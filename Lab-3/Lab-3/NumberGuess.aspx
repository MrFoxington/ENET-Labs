<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NumberGuess.aspx.cs" Inherits="Lab_3.NumberGuesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Guess the number between 1 - 10!</h3>
        Previous Guesses:<br />
        <asp:Label ID="lbl_prevGuess" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <br />
        Enter Guesse
        <br />
        <asp:TextBox ID="txt_guess" runat="server"></asp:TextBox>
        <asp:Button ID="btn_submitGuess" runat="server" Text="Submit Guess" OnClick="btn_submitGuess_Click" />
        <asp:Button ID="btn_reset" runat="server" Text="Reset Game" OnClick="btn_reset_Click" />
    
    </div>
    </form>
</body>
</html>
