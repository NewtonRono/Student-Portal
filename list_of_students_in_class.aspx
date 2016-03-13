<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeePages.master" AutoEventWireup="true" CodeFile="list_of_students_in_class.aspx.cs" Inherits="list_of_students_in_class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h1>Students List</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
     <asp:GridView Style="margin-left:10px;" ID="Students" runat="server" 
          autogeneratecolumns="false" Font-Size="Large"   CellPadding="6" CellSpacing="6"
         Width="479px" >
         <columns>
  <asp:boundfield datafield="roll_no" headertext="Roll No"><HeaderStyle Width="1000px" /></asp:boundfield>
  <asp:boundfield datafield="first_name" headertext="First Name"><HeaderStyle Width="1000px" /></asp:boundfield>
       <asp:boundfield datafield="middle_name" headertext="Middle Name" ><HeaderStyle Width="1000px" /> </asp:boundfield>
                <asp:boundfield datafield="last_name" headertext="Last Name"><HeaderStyle Width="1000px" /></asp:boundfield>
                        <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Details" CssClass="buttonCSS1" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" 
                     Text="Click To Enter Marks" OnCommand="Enter_Marks" runat="server" />
                                    </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Attendance1" CssClass="buttonCSS1" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" 
                 OnCommand="Mark_Present"    Text="Click To Mark Present" runat="server" />
                                    </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
            <ItemTemplate>
                    <asp:Button ID="Attendance2" CssClass="buttonCSS1" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" 
                 OnCommand="Mark_Absent"    Text="Click To Mark Absent" runat="server" />
                                    </ItemTemplate>
            </asp:TemplateField>
        </columns>
                     
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

