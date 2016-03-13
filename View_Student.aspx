<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPages.master" AutoEventWireup="true" CodeFile="View_Student.aspx.cs" Inherits="View_Student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Student Profile</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:TextBox ID="TextBox1" CssClass="textbox" runat="server"></asp:TextBox>
    <span style="margin: 10px"></span>
    <asp:Button ID="Button1" CssClass="buttonCSS" runat="server" Text="Go" OnClick="Button1_Click"/>
    <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="6 Digits Only." ForeColor="Red" 
        ControlToValidate="TextBox1" ValidationExpression="^\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textbox1" 
        ErrorMessage="Student ID is Required." ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <div style="margin-left:200px;"> <asp:GridView Style="margin-right:200px;" ID="student"  runat="server" 
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
</div>
 
    <div><asp:Image ID="Image1" style="margin-top:-600px;margin-left:700px;" runat="server" Height="125px" Width="125px" /></div> 
 <asp:Button ID="update" visible="false" CssClass="buttonCSS" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" oncommand="EditRow"
                     Text="Click To Update Student" runat="server" />
                            
 </asp:Content>

