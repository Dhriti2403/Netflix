<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="NetflixHistory.SignUp" %>


<form id="form1" runat="server">
    <p>
        User Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="IdTextBox" runat="server" Height="27px" Width="161px"></asp:TextBox>
    </p>
    <p>
        User Name&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="NameTextBox" runat="server" Height="27px" Width="161px"></asp:TextBox>
    </p>
    <p>
        User Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="EmailTextBox" runat="server" Height="27px" Width="161px"></asp:TextBox>
    </p>
    <p>
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PassTextBox" runat="server" Height="27px" Width="161px"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="signup1" runat="server" Height="29px" OnClick="SignUpButton_Click" Text="SignUp" Width="93px" />
        &nbsp;</p>
</form>



