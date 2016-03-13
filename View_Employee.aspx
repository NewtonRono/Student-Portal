<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPages.master" AutoEventWireup="true" CodeFile="View_Employee.aspx.cs" Inherits="View_Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Employee Profile</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:TextBox ID="TextBox1" CssClass="textbox" runat="server"></asp:TextBox>
    <span style="margin: 10px"></span>
    <asp:Button ID="Button1" CssClass="buttonCSS" runat="server" Text="GO" OnClick="Button1_Click"/>
    <br />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="6 Digits Only." ForeColor="Red" 
        ControlToValidate="TextBox1" ValidationExpression="^\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" 
        ErrorMessage="Employee ID is Required." ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
       <div style="margin-left:100px;">
           <asp:GridView Style="margin-left:150px;" ID="Empinfo" runat="server" 
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
    <asp:GridView Style="margin-left:150px;" ID="Empinfo2" runat="server" 
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
    <asp:GridView Style="margin-left:150px;" ID="Empinfo3" runat="server" 
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
    <asp:Button ID="update" visible="false" CssClass="buttonCSS" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" oncommand="EditRow"
                     Text="Click To Update Employee" runat="server" />
               
</div>
 
    <div><asp:Image ID="Image1" style="margin-top:-500px;margin-left:700px;" runat="server" Height="125px" Width="125px" /></div> 
 
    </asp:Content>

