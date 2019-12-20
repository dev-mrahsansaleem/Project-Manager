<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="projects.aspx.cs" Inherits="Project_manager.projects" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="padding-left:30%">
            <tr>
                <td>
                    <Strong>Project_Name</Strong>
                </td>
                <td>
                    <asp:TextBox ID="project" runat="server" Width="400px" CssClass="auto-style2"></asp:TextBox>
                </td>
            </tr>
            <br />
            <tr>
                <td>
                    <asp:Button ID="Submit" runat="server" Font-Size="Medium" Text="Submit" OnClick="Insert_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
