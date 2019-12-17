<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectManger.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
        <h1>Project Management System</h1>
        <h2>asp .net C# Project</h2>
        <hr />
        <div style="background-color:azure; height:15%; width:25%;">

        <table border="1">
            <tr>
                <td>Admin User Id</td>
                <td><asp:TextBox ID="txtAdminId" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Admin Password</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="btnLogin" runat="server" Text="Login" Width="100%" OnClick="btnLogin_Click" /></td>
                <td><asp:Label ID="lblMsg" runat="server" Text="" Width="100%"></asp:Label></td>
            </tr>
        </table>

        </div>
    </div>
    </form>
</body>
</html>
