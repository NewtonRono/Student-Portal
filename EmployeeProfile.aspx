<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeePages.master" AutoEventWireup="true" CodeFile="EmployeeProfile.aspx.cs" Inherits="EmployeeProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<h1>Profile</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <h2 style="text-align:center">Personal Info</h2>
    <asp:GridView Style="margin-left:220px;" ID="Empinfo" runat="server" 
              Font-Size="Large"   
         Width="479px">
             <FooterStyle  ForeColor="#333333" />
             <HeaderStyle  Font-Bold="True" ForeColor="White" />
             <PagerStyle  ForeColor="White" HorizontalAlign="Center" />
             <RowStyle  ForeColor="#333333" />
             <SelectedRowStyle Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F7F7F7" />
             <SortedAscendingHeaderStyle BackColor="#487575" />
             <SortedDescendingCellStyle BackColor="#E5E5E5" />
             <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView><br />

    <h2 style="text-align: center">University Info</h2>
    <asp:GridView Style="margin-left:220px;" ID="Empinfo2" runat="server" 
              Font-Size="Large"   
         Width="590px">
             <FooterStyle  ForeColor="#333333" />
             <HeaderStyle  Font-Bold="True" ForeColor="White" />
             <PagerStyle  ForeColor="White" HorizontalAlign="Center" />
             <RowStyle  ForeColor="#333333" />
             <SelectedRowStyle Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F7F7F7" />
             <SortedAscendingHeaderStyle BackColor="#487575" />
             <SortedDescendingCellStyle BackColor="#E5E5E5" />
             <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>

    <h2 style="text-align: center">Contact Info</h2>
    <asp:GridView Style="margin-left:220px;" ID="Empinfo3" runat="server" 
              Font-Size="Large"   
         Width="479px">
             <FooterStyle  ForeColor="#333333" />
             <HeaderStyle  Font-Bold="True" ForeColor="White" />
             <PagerStyle  ForeColor="White" HorizontalAlign="Center" />
             <RowStyle  ForeColor="#333333" />
             <SelectedRowStyle Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#F7F7F7" />
             <SortedAscendingHeaderStyle BackColor="#487575" />
             <SortedDescendingCellStyle BackColor="#E5E5E5" />
             <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>

</asp:Content>

