<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NetflixHistory.Login" %>


<form id="form1" runat="server">
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" BackColor="#FF9999" Text="Login Page"></asp:Label>
        &nbsp;</p>
    <p>
        User Name</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="175px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Password</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="175px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Login1" runat="server" Height="28px" OnClick="LoginButton_Click1" Text="Login" Width="76px" />
        &nbsp;</p>

   <asp:HyperLink ID="HyperLink1" ForeColor="red" Text="SignUp?" Target="_blank"
   runat="server" NavigateUrl="SignUp.aspx">
</asp:HyperLink>

</form>
</form>



