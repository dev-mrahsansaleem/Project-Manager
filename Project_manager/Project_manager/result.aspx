<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="Project_manager.result" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>

                <td>
                    <asp:Panel ID="Panel1" runat="server">
                        Result Form <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </asp:Panel>
                    <asp:Button ID="Button1" runat="server" Font-Size="Medium" Text="Export to PDF" OnClick="Button1_Click" />
                </td>
                
                <td style="padding-left: 40%" class="auto-style1">
                    <asp:Button ID="Button3" runat="server" Font-Size="Medium" Text="Click to View Group details" OnClick="Button3_Click" />
                    <asp:Panel ID="Panel2" runat="server">
                        Group_Details<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                        <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                    </asp:Panel>               
                    <asp:Button ID="Button2" runat="server" Font-Size="Medium" Text="Export groups to PDF" OnClick="Button2_Click" />
                </td>
            </tr>
        </table>          
    </div>
</asp:Content>
