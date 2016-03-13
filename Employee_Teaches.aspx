<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeePages.master" AutoEventWireup="true" CodeFile="Employee_Teaches.aspx.cs" Inherits="Employee_Teaches" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h1>Courses You are Teaching </h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:GridView  ID="teacher_course_info" runat="server" BackColor="White" AutoGenerateColumns="False" 
      Font-Size="20px"  BorderColor="#DEDFDE" BorderStyle="None" 
        BorderWidth="1px" CellPadding="4"  
        style="margin-left:200px;"
        GridLines="Vertical" CellSpacing="6" ForeColor="Black"  >     <AlternatingRowStyle BackColor="White" />
        <columns>
  <asp:boundfield datafield="CourseID" headertext="CourseID"></asp:boundfield>
       <asp:boundfield datafield="courseName" headertext="Course Name"></asp:boundfield>
                <asp:boundfield datafield="sectionID" headertext="Section"></asp:boundfield>
                        <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="Details" CssClass="buttonCSS" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" 
                    OnCommand="GridView1_RowCommand" Text="Click To See Details" runat="server" />
                                    </ItemTemplate>
            </asp:TemplateField>
        </columns>
             <FooterStyle BackColor="#CCCC99" />
             <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#F7F7DE" ForeColor="Black" 
            HorizontalAlign="Right" />
             <RowStyle BackColor="#F7F7DE" />
             <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#FBFBF2" />
             <SortedAscendingHeaderStyle BackColor="#848384" />
             <SortedDescendingCellStyle BackColor="#EAEAD3" />
             <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
</asp:Content>
