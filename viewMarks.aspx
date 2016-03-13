<%@ Page Title="" Language="C#" MasterPageFile="~/StudentPages.master" AutoEventWireup="true" CodeFile="viewMarks.aspx.cs" Inherits="viewMarks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<h1>MarkSheet</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
<br /><br />
<asp:Label runat="server" id="Head1" CssClass="LabelMarks"></asp:Label>
    <br />
<asp:GridView  ID="Course1" runat="server" BackColor="White" autogeneratecolumns="False"
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="6" 
        GridLines="Vertical" CellSpacing="10" ForeColor="Black">
        <AlternatingRowStyle BackColor="White" />
        <columns>
  
                <asp:boundfield datafield="section" headertext="Section"></asp:boundfield>
                <asp:boundfield datafield="quiz1" headertext="Quiz 1"></asp:boundfield>
                <asp:boundfield datafield="quiz2" headertext="Quiz 1"></asp:boundfield>

                <asp:boundfield datafield="quiz3" headertext="Quiz 1"></asp:boundfield>
                  <asp:boundfield datafield="assignment1" headertext="Assignment 1"></asp:boundfield>

                <asp:boundfield datafield="assignment2" headertext="Assignment 2"></asp:boundfield>

                <asp:boundfield datafield="assignment3" headertext="Assignment 3"></asp:boundfield>
                <asp:boundfield datafield="mid1" headertext="Mid 1"></asp:boundfield>

                <asp:boundfield datafield="mid2" headertext="Mid 2"></asp:boundfield>

                <asp:boundfield datafield="final" headertext="Final"></asp:boundfield>
                <asp:boundfield datafield="semesterWork" headertext="Semester Work"></asp:boundfield>
                <asp:boundfield datafield="Grade" headertext="Grade"></asp:boundfield>

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
<br /><br />
<asp:Label runat="server" id="Head2" CssClass="LabelMarks"></asp:Label>
    <br />

<asp:GridView  ID="Course2" runat="server" BackColor="White" autogeneratecolumns="False"
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="6" 
        GridLines="Vertical" CellSpacing="10" ForeColor="Black">
        <AlternatingRowStyle BackColor="White" />
        <columns>
  
                <asp:boundfield datafield="section" headertext="Section"></asp:boundfield>
                <asp:boundfield datafield="quiz1" headertext="Quiz_1"></asp:boundfield>
                <asp:boundfield datafield="quiz2" headertext="Quiz_2"></asp:boundfield>

                <asp:boundfield datafield="quiz3" headertext="Quiz_3"></asp:boundfield>
                  <asp:boundfield datafield="assignment1" headertext="Assignment_1"></asp:boundfield>

                <asp:boundfield datafield="assignment2" headertext="Assignment_2"></asp:boundfield>

                <asp:boundfield datafield="assignment3" headertext="Assignment_3"></asp:boundfield>
                <asp:boundfield datafield="mid1" headertext="Mid_1"></asp:boundfield>

                <asp:boundfield datafield="mid2" headertext="Mid_2"></asp:boundfield>

                <asp:boundfield datafield="final" headertext="Final"></asp:boundfield>
                <asp:boundfield datafield="semesterWork" headertext="Semester_Work"></asp:boundfield>
                <asp:boundfield datafield="Grade" headertext="Grade"></asp:boundfield>

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
<br /><br />
<asp:Label runat="server" id="Head3" CssClass="LabelMarks"></asp:Label>
    <br />

<asp:GridView  ID="Course3" runat="server" BackColor="White" autogeneratecolumns="False"
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="6" 
        GridLines="Vertical" CellSpacing="10" ForeColor="Black">
       <AlternatingRowStyle BackColor="White" />
       <columns>
  
                <asp:boundfield datafield="section" headertext="Section"></asp:boundfield>
                <asp:boundfield datafield="quiz1" headertext="Quiz_1"></asp:boundfield>
                <asp:boundfield datafield="quiz2" headertext="Quiz_2"></asp:boundfield>

                <asp:boundfield datafield="quiz3" headertext="Quiz_3"></asp:boundfield>
                  <asp:boundfield datafield="assignment1" headertext="Assignment_1"></asp:boundfield>

                <asp:boundfield datafield="assignment2" headertext="Assignment_2"></asp:boundfield>

                <asp:boundfield datafield="assignment3" headertext="Assignment_3"></asp:boundfield>
                <asp:boundfield datafield="mid1" headertext="Mid_1"></asp:boundfield>

                <asp:boundfield datafield="mid2" headertext="Mid_2"></asp:boundfield>

                <asp:boundfield datafield="final" headertext="Final"></asp:boundfield>
                <asp:boundfield datafield="semesterWork" headertext="Semester_Work"></asp:boundfield>
                <asp:boundfield datafield="Grade" headertext="Grade"></asp:boundfield>

            </columns>

             <FooterStyle BackColor="#CCCC99" />
             <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#F7F7DE" ForeColor="Black" 
           HorizontalAlign="Right" />
             <RowStyle BackColor="#F7F7DE" />
             <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" 
           ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#FBFBF2" />
             <SortedAscendingHeaderStyle BackColor="#848384" />
             <SortedDescendingCellStyle BackColor="#EAEAD3" />
             <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <br /><br />
<asp:Label runat="server" id="Head4" CssClass="LabelMarks"></asp:Label>
    <br />

<asp:GridView  ID="Course4" runat="server" BackColor="White" autogeneratecolumns="False"
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="6" 
        GridLines="Vertical" CellSpacing="10" ForeColor="Black">
       <AlternatingRowStyle BackColor="White" />
       <columns>
  
                <asp:boundfield datafield="section" headertext="Section"></asp:boundfield>
                <asp:boundfield datafield="quiz1" headertext="Quiz_1"></asp:boundfield>
                <asp:boundfield datafield="quiz2" headertext="Quiz_2"></asp:boundfield>

                <asp:boundfield datafield="quiz3" headertext="Quiz_3"></asp:boundfield>
                  <asp:boundfield datafield="assignment1" headertext="Assignment_1"></asp:boundfield>

                <asp:boundfield datafield="assignment2" headertext="Assignment_2"></asp:boundfield>

                <asp:boundfield datafield="assignment3" headertext="Assignment_3"></asp:boundfield>
                <asp:boundfield datafield="mid1" headertext="Mid_1"></asp:boundfield>

                <asp:boundfield datafield="mid2" headertext="Mid_2"></asp:boundfield>

                <asp:boundfield datafield="final" headertext="Final"></asp:boundfield>
                <asp:boundfield datafield="semesterWork" headertext="Semester_Work"></asp:boundfield>
                <asp:boundfield datafield="Grade" headertext="Grade"></asp:boundfield>

            </columns>

             <FooterStyle BackColor="#CCCC99" />
             <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#F7F7DE" ForeColor="Black" 
           HorizontalAlign="Right" />
             <RowStyle BackColor="#F7F7DE" />
             <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" 
           ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#FBFBF2" />
             <SortedAscendingHeaderStyle BackColor="#848384" />
             <SortedDescendingCellStyle BackColor="#EAEAD3" />
             <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <br /><br />
<asp:Label runat="server" id="Head5" CssClass="LabelMarks"></asp:Label>
    <br />

<asp:GridView  ID="Course5" runat="server" BackColor="White" autogeneratecolumns="False"
        BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="6" 
        GridLines="Vertical" CellSpacing="10" ForeColor="Black">
       <AlternatingRowStyle BackColor="White" />
       <columns>
  
                <asp:boundfield datafield="section" headertext="Section"></asp:boundfield>
                <asp:boundfield datafield="quiz1" headertext="Quiz_1"></asp:boundfield>
                <asp:boundfield datafield="quiz2" headertext="Quiz_2"></asp:boundfield>

                <asp:boundfield datafield="quiz3" headertext="Quiz_3"></asp:boundfield>
                  <asp:boundfield datafield="assignment1" headertext="Assignment_1"></asp:boundfield>

                <asp:boundfield datafield="assignment2" headertext="Assignment_2"></asp:boundfield>

                <asp:boundfield datafield="assignment3" headertext="Assignment_3"></asp:boundfield>
                <asp:boundfield datafield="mid1" headertext="Mid_1"></asp:boundfield>

                <asp:boundfield datafield="mid2" headertext="Mid_2"></asp:boundfield>

                <asp:boundfield datafield="final" headertext="Final"></asp:boundfield>
                <asp:boundfield datafield="semesterWork" headertext="Semester_Work"></asp:boundfield>
                <asp:boundfield datafield="Grade" headertext="Grade"></asp:boundfield>

            </columns>

             <FooterStyle BackColor="#CCCC99" />
             <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#F7F7DE" ForeColor="Black" 
           HorizontalAlign="Right" />
             <RowStyle BackColor="#F7F7DE" />
             <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" 
           ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#FBFBF2" />
             <SortedAscendingHeaderStyle BackColor="#848384" />
             <SortedDescendingCellStyle BackColor="#EAEAD3" />
             <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
   
</asp:Content>

