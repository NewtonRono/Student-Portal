<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPages.master" AutoEventWireup="true" CodeFile="Teacher_Registeration.aspx.cs" Inherits="Teacher_Registeration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Student Portal 2.0</h1>    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Teacher Registeration</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
        <asp:Label runat="server" id="status" style="color:Red;"></asp:Label>  
       <div style="margin-left:-220px;"></div>
    <table frame="border" style="width: 100%">
        <tr>
            <td style="text-align: left; width: 116px">
                Fname:</td>
            <td style="width: 151px">
                <asp:TextBox ID="Fname" CssClass="textbox" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="Fname" ErrorMessage="Fname is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="Fname" ErrorMessage="Enter valid fname" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z''-'\s]{1,40}$"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Mname:</td>
            <td style="width: 151px">
                <asp:TextBox ID="Mname" CssClass="textbox" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="Mname" ErrorMessage="Mname is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="Mname" ErrorMessage="Enter valid Mname" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z''-'\s]{1,40}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Lname:</td>
            <td style="width: 151px">
                <asp:TextBox ID="Lname" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="Lname" ErrorMessage="Lname is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="Lname" ErrorMessage="Enter valid lname" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z''-'\s]{1,40}$"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Username:</td>
            <td style="width: 151px">
                <asp:TextBox ID="User_ID" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="User_ID" ErrorMessage="Username is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="User_ID" ErrorMessage="invalid username" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Password:</td>
            <td style="width: 151px">
                <asp:TextBox ID="Passwd" runat="server" TextMode="Password" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="Passwd" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                    ControlToValidate="Passwd" ErrorMessage="Password must be of at least 6 characters" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z0-9'@&#.\s]{6,}$"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Confirm Password:</td>
            <td style="width: 151px">
                <asp:TextBox ID="CPasswd" runat="server" TextMode="Password" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="Passwd" ControlToValidate="CPasswd" 
                    ErrorMessage="Both Password must be same" ForeColor="Red"></asp:CompareValidator>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="CPasswd" ErrorMessage="Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Guardian CNIC:</td>
            <td style="width: 151px">
                <asp:TextBox ID="gid" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="gid" ErrorMessage="Enter Guardian ID" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                    ControlToValidate="gid" ErrorMessage="Gardian ID must be of 13 integers" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d\d\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Gender:</td>
            <td style="width: 151px">
                <asp:DropDownList ID="gender" CssClass="buttonCSS" runat="server" 
                     Width="150px">
                    <asp:ListItem Value="0">Male</asp:ListItem>
                    <asp:ListItem Value="1">Female</asp:ListItem>
                    <asp:ListItem Value="2">Shemale</asp:ListItem>
                </asp:DropDownList>
            </td> 
            <td>
                &nbsp;</td>

        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Date of Birth:</td>
            <td style="width: 151px">
                <asp:TextBox ID="dob" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
          <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ControlToValidate="dob" ErrorMessage="Enter Date of Birth" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
                    ControlToValidate="dob" 
                    ErrorMessage="Date of Birth Must be in format yyyy/mm/dd" ForeColor="Red"           
                    ValidationExpression="^(1[9][0-9][0-9]|2[0][0-9][0-9])[- / .]([1-9]|0[1-9]|1[0-2])[- / .]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])$"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Temporary Address:</td>
            <td style="width: 151px">
                <asp:TextBox ID="temp_addr" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ControlToValidate="temp_addr" ErrorMessage="Enter Temporary address" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Permanent Address:</td>
            <td style="width: 151px">
                <asp:TextBox ID="pr_addr" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                    ControlToValidate="pr_addr" ErrorMessage="Enter Permanent Address" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                CNIC:</td>
            <td style="width: 151px">
                <asp:TextBox ID="cnic" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                    ControlToValidate="cnic" ErrorMessage="Enter CNINC" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" 
                    ControlToValidate="cnic" ErrorMessage="CNIC must be of 13 characters" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d\d\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Contact No:</td>
            <td style="width: 151px">
                <asp:TextBox ID="c_no" runat="server"  CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                    ControlToValidate="c_no" ErrorMessage="Enter Contact No" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" 
                    ControlToValidate="c_no" ErrorMessage="Contact Number Should be of 11 characters" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
            </td>
         <td style="width: 151px"></td>
           <td style="text-align: left; width: 116px">
                Personal Email:</td>
            <td style="width: 151px">
                <asp:TextBox ID="p_em" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                    ControlToValidate="p_em" ErrorMessage="Enter Personal Email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" 
                    ControlToValidate="p_em" ErrorMessage="Invalid Email" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 116px">
                Official Email:</td>
            <td style="width: 151px">
                <asp:TextBox ID="o_em" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="o_em" ErrorMessage="Enter official Email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                    ControlToValidate="o_em" ErrorMessage="Invalid Email" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Department ID:</td>
            <td style="width: 151px">
                <asp:DropDownList ID="deptid" CssClass="buttonCSS" runat="server" 
                     Width="150px">
                    <asp:ListItem Value="0">Computer Science</asp:ListItem>
                       </asp:DropDownList>
            </td>
        </tr>
         <tr>
           <td style="text-align: left; width: 116px">
                Date joined:</td>
            <td style="width: 151px">
                <asp:TextBox ID="d_en" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
           <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                    ControlToValidate="d_en" ErrorMessage="Enter date enrolled" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" 
                    ControlToValidate="d_en" ErrorMessage="Enter in yyyy/mm/dd format" ForeColor="Red" 
                    ValidationExpression="^(1[9][0-9][0-9]|2[0][0-9][0-9])[- / .]([1-9]|0[1-9]|1[0-2])[- / .]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])$"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Blood Group:</td>
            <td style="width: 151px">
                <asp:DropDownList ID="bg" CssClass="buttonCSS" runat="server" 
                     Width="150px">
                    <asp:ListItem Value="0">A+</asp:ListItem>
                    <asp:ListItem Value="1">A-</asp:ListItem>
                    <asp:ListItem Value="2">B+</asp:ListItem>
                    <asp:ListItem Value="3">B-</asp:ListItem>
                    <asp:ListItem Value="2">O+</asp:ListItem>
                    <asp:ListItem Value="3">O-</asp:ListItem>
                    <asp:ListItem Value="2">AB+</asp:ListItem>
                    <asp:ListItem Value="3">AB-</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
        <td style="text-align: left; width: 116px;">
        Upload Image:</td>
        <td style="width: 151px;"> 
        <asp:FileUpload ID="imgupload" runat="server" />
        </td>
        <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="imgUpload" ErrorMessage="Upload Image" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
         <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Campus:</td>
            <td style="width: 151px">
                <asp:DropDownList ID="Campus" CssClass="buttonCSS" runat="server" 
                     Width="150px">
                    <asp:ListItem Value="0">Lahore</asp:ListItem>
                    <asp:ListItem Value="1">Islamabad</asp:ListItem>
                    <asp:ListItem Value="2">Karachi</asp:ListItem>
                    <asp:ListItem Value="3">Peshawar</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        
        <tr>
         <td style="text-align: left; width: 116px">
                Type:</td>
            <td style="width: 151px">
                <asp:DropDownList ID="Type" CssClass="buttonCSS" runat="server" 
                     Width="150px">
                    <asp:ListItem Value="0">Teacher</asp:ListItem>
                    <asp:ListItem Value="1">Admin+Teacher</asp:ListItem>
                    <asp:ListItem Value="2">Admin</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            
             <td style="width: 151px"></td>
            <td style="text-align: left; width: 116px">
                Status:</td>
            <td style="width: 151px">
                <asp:TextBox ID="status1" runat="server" CssClass="textbox" Width="150px"></asp:TextBox>
            </td>
            <td>
            &nbsp;
             </td>
        </tr>
        <tr> <td style="width: 151px"></td>
             <td style="width: 116px; text-align: left">
                &nbsp;</td>
            <td style="width: 151px">
                <asp:Button ID="Button1" runat="server" CssClass="buttonCSS" onclick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</br><asp:Button ID="Button2" runat="server" 
                    CssClass="buttonCSS" onclientclick="Button2_Click()" Text="Reset" Width="63px" />
               </td></tr>
        
    </table>
    <script type="text/javascript">
        function Button2_Click() {
            document.getElementById('<%=Fname.ClientID%>').value = "";
            document.getElementById('<%=Lname.ClientID%>').value = "";
            document.getElementById('<%=Mname.ClientID%>').value = "";
            document.getElementById('<%=User_ID.ClientID%>').value = "";
            document.getElementById('<%=CPasswd.ClientID%>').value = "";

        }
        </script>

</asp:Content>


