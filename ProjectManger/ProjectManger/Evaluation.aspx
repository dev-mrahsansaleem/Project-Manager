<%@ Page Title="" Language="C#" MasterPageFile="~/PMS.Master" AutoEventWireup="true" CodeBehind="Evaluation.aspx.cs" Inherits="ProjectManger.Evaluation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:azure;text-align:center; margin:20px auto;width: 350px;">
        <h1>This is Evaluation page</h1>

        <table border="1" style="width:100%">
            <tr>
                <td style="width: 150px">Studnet name</td>
                <td><asp:DropDownList ID="dpStudentname" runat="server" width="100%" DataSourceID="students" DataTextField="Uname" DataValueField="Uname" OnSelectedIndexChanged="dpStudentname_SelectedIndexChanged"></asp:DropDownList>
                    <asp:SqlDataSource ID="students" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" SelectCommand="SELECT [Uname], [Uid] FROM [Users] WHERE ([UType] = @UType)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Student" Name="UType" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 150px">total marks</td>
                <td><asp:TextBox ID="txttotal" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px">obtain marks</td>
                <td><asp:TextBox ID="txtobtain" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px">weightage</td>
                <td><asp:TextBox ID="txtweight" runat="server" Width="100%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100%" OnClick="btnSubmit_Click" /></td>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnPrint" runat="server" Text="Print Report" Width="226%" OnClick="btnPrint_Click" />

                </td>
            </tr>
        </table>

        

        <asp:Panel ID="panelpdf" runat="server" Width="100%">
            <h2>Report <asp:Label ID="lbltime" runat="server" Text=""></asp:Label></h2>
            <asp:GridView ID="gridviewData" runat="server" Width="100%" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="griddata" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" ForeColor="Black" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="stdID" HeaderText="stdID" SortExpression="stdID" />
                    <asp:BoundField DataField="TotalMarks" HeaderText="TotalMarks" SortExpression="TotalMarks" />
                    <asp:BoundField DataField="obtainMarks" HeaderText="obtainMarks" SortExpression="obtainMarks" />
                    <asp:BoundField DataField="weightage" HeaderText="weightage" SortExpression="weightage" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="griddata" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnection %>" SelectCommand="SELECT * FROM [Evaluation]"></asp:SqlDataSource>
        </asp:Panel>

    </div>


</asp:Content>
