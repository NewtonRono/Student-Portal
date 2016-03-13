<%@ Page Title="" Language="C#" MasterPageFile="~/Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
            <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <p style="margin-top: 20px">
            <h2>Login Details</h2>
          </p>      
</asp:Content>
 <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server"> 
     <p1 style="margin-left:90px">Login as
  </p1><span style="margin-left: 78px"></span>
  <asp:DropDownList class="buttonCSS" id="Login_As" runat="server">
            <asp:ListItem Value="0">Student</asp:ListItem>
            <asp:ListItem Value="1">Staff</asp:ListItem>
            <asp:ListItem Value="2">Admin</asp:ListItem>
        </asp:DropDownList>
         <br/><br/>
     <p1 style="margin-left:90px">Select Campus
  </p1><span style="margin-left: 36px"></span>
  <asp:DropDownList class="buttonCSS" id="logincampus" runat="server">
            <asp:ListItem Value="0">Lahore</asp:ListItem>
            <asp:ListItem Value="1">Islamabad</asp:ListItem>
            <asp:ListItem Value="2">Faisalabad</asp:ListItem>
            <asp:ListItem Value="3">Peshawar</asp:ListItem>
        </asp:DropDownList>
         <br/><br/>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="Server">
    <asp:RequiredFieldValidator style="margin-left:225px;"
        ID="RequiredFieldValidator1" runat="server" ControlToValidate="user_id" 
        ErrorMessage="Username is Required" ForeColor="Red"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="6 Digits Only." ForeColor="Red" 
        ControlToValidate="user_id" ValidationExpression="^\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
    <p style="margin-top: 20px">
<p1 style="margin-left:90px">Username<span style="color: red" title="Required">*</span><span style="margin-left: 61px"></span>
                <asp:TextBox ID="user_id" CssClass="textbox"  runat="server"></asp:TextBox></p1><br />
                <p1 style="margin-left:225px;font-size:12px;">e-g 134256</p1>
            <br />
                 <p1 style="margin-left:90px">Password<span style="color: red" title="Required">*</span><span style="margin-left: 64px"></span>
                <asp:TextBox ID="user_pass" TextMode="Password" CssClass="textbox" runat="server"></asp:TextBox></p1><br />
    <asp:RequiredFieldValidator style="margin-left:225px;" ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="user_pass" ErrorMessage="Password is required" 
        ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
                <span style="margin-left: 223px"></span><asp:Button ID="b1" 
        CssClass="buttonCSS" runat="server" Text="Login" onclick="b1_Click" />
            </p>
                <script type="text/javascript">
                    function checkUserName() {
                        var campus = document.getElementById("<%=logincampus.ClientID%>").value;
                        var usern = document.getElementById("<%=user_id.ClientID%>").value;
                        var i = 1, found1 = 0, found2 = 0;
                        if (usern.length == 6) {
                            found1 = 1;
                        }

                        if (found1 == 1) {
                            for (; i < usern.length; i++) {
                                if (usern[i] > "9" && usern[i] < "0") {
                                    break;
                                }
                            }
                            if (i == usern.length) {
                                found2 = 1; 
                               /*/ if (campus == "0") {
                                    var i = usern.length - 1;
                                    for (; i > 3; i--) {
                                        unsern[i + 2] = usern[i];
                                    }
                                    usern[i] = '-';
                                    i--;
                                  usern[i] = 'L';
                                }
                              else if (campus == "1") {

                              var i = usern.length - 1;
                                    for (; i > 3; i--) {
                                        unsern[i + 2] = usern[i];
                                    }
                                    usern[i] = '-';
                                    i--;
                                    usern[i] = 'I';
                                }
                                else if (campus == "2") {
                                var i = usern.length - 1;
                                    for (; i > 3; i--) {
                                        unsern[i + 2] = usern[i];
                                    }
                                    usern[i] = '-';
                                    i--;
                                    usern[i] = 'F';
                                }
                                else if (campus == "3") {
                                var i = usern.length - 1;
                                    for (; i > 3; i--) {
                                        unsern[i + 2] = usern[i];
                                    }
                                    usern[i] = '-';
                                    i--;
                                    usern[i] = 'P';
                                }
                             /*/  
                            }
                        }
                        if (found1 == 0 || found2 == 0) {
                            alert("Invalid username");
                            document.getElementById("<%=user_id.ClientID%>").value = "";
                            return 1;
                        }
                        return 0;
                    }
                    function checkMandatoryFields() {
                        var flag1 = 0;
                        if (document.getElementById("<%=user_id.ClientID%>").value == "") {
                            alert("Please Enter username");
                        }
                        if (document.getElementById("<%=user_pass.ClientID%>").value == "") {
                            alert("Please Enter Password");
                        }
                        if (document.getElementById("<%=user_id.ClientID%>").value != "") {
                           flag1= checkUserName();
                       }
                       
                       //PageMethods.b1_Click();

                        return 0;
                    }
                </script>
</asp:Content>

