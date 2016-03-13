<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPages.master" AutoEventWireup="true" CodeFile="Teacher_Courses.aspx.cs" Inherits="Teacher_Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Student Portal 2.0</h1>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:Label runat="server" id="status" style="color:Red;"></asp:Label>  

    <table frame="border" style="width: 100%">
        <tr>
            <td style="text-align: left; width: 116px">
                Employee ID:</td>
            <td style="width: 151px">
                <asp:TextBox ID="empID" CssClass="textbox" runat="server"></asp:TextBox>
            </td>
            <td style="width: 155px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="empID" ErrorMessage="Employee ID is Required." ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="empID" ErrorMessage="Enter a valid ID" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Course:</td>
            <td style="width: 151px">
                <asp:DropDownList ID="dd" CssClass="buttonCSS" runat="server">
                       </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="dd" ErrorMessage="Select a course from the list." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr >
            <td  style="text-align: left; width: 116px"  >
                Available Sections:</td>
            <td style="width: 151px" >
                <asp:DropDownList ID="dd1" CssClass="buttonCSS" runat="server">
                       </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="dd" ErrorMessage="Select a section from the list." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="submit" Text="Submit" OnClick="insert_courses" runat="server" CssClass="buttonCSS" />
             <asp:Button ID="Button1" Text="Submit" OnClick="insert_courses1" runat="server" CssClass="buttonCSS" />
           
            </td>
            <td style="width: 151px">
                <asp:Button ID="reset" Text="Reset" runat="server" CssClass="buttonCSS"
                    OnClientClick="javascript: setNULL()" />
            </td>
        </tr>
        </table>
    <script type="text/javascript">
        function setNULL() {
            document.getElementById('<%=empID.ClientID%>').value = "";
            document.getElementById('<%=dd.ClientID%>').value = "";
        }
    </script>
</asp:Content>

