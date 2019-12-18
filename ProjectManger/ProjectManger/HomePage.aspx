<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectManger.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 405px;
        }
        .auto-style3 {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center; margin:20px auto" class="auto-style2">
        
        <div style="background-color:azure;">
            <h1>Project Management System</h1>
            <h2>asp .net C# Project</h2>
            <hr />
            <table style="margin: 20px auto; width:100%" border="1">
                <tr>
                    <td class="auto-style3">Admin User Id</td>
                    <td><asp:TextBox ID="txtAdminId" runat="server" Width="100%"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3">Admin Password</td>
                    <td><asp:TextBox ID="txtPassword" runat="server"  Width="100%" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style3"><asp:Button ID="btnLogin" runat="server" Text="Login" Width="100%" OnClick="btnLogin_Click" /></td>
                    <td><asp:Label ID="lblMsg" runat="server" Text="" Width="100%"></asp:Label></td>
                </tr>
            </table>

        </div>
    </div>
    </form>
</body>
</html>
