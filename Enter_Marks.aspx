<%@ Page Title="" Language="C#" MasterPageFile="~/EmployeePages.master" AutoEventWireup="true" CodeFile="Enter_Marks.aspx.cs" Inherits="Enter_Marks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<h1>Enter Marks</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <table>
        <tr>
            <td>
                <p1>Quiz 1:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="quiz1" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ErrorMessage="2 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="quiz1" ValidationExpression="^[0-9]+(\.[0-9]){1,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Quiz 2:</p1> 
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="quiz2" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ErrorMessage="2 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="quiz2" ValidationExpression="^[0-9]+(\.[0-9]){1,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Quiz 3:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="quiz3" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
        ErrorMessage="2 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="quiz3" ValidationExpression="^[0-9]+(\.[0-9]){1,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Assignment 1:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="ass1" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
        ErrorMessage="2 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="ass1" ValidationExpression="^[0-9]+(\.[0-9]){1,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Assignment 2:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="ass2" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
        ErrorMessage="2 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="ass2" ValidationExpression="^[0-9]+(\.[0-9]){1,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Assignment 3:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="ass3" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
        ErrorMessage="2 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="ass3" ValidationExpression="^[0-9]+(\.[0-9]){1,2}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Mid Term 1:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="mid1" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
        ErrorMessage="3 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="mid1" ValidationExpression="^[0-9]+(\.[0-9]){1,4}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>
                <p1>Mid Term 2:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="mid2" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
        ErrorMessage="3 maximium digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="mid2" ValidationExpression="^[0-9]+(\.[0-9]){1,4}$"></asp:RegularExpressionValidator>
        </td>
                </tr>
        <tr>
            <td>
                <p1>Final:</p1>
            </td>
            <td style="width: 62px">
                <asp:TextBox ID="final" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
            <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
        ErrorMessage="3 maximum Digits upto 1 decimal point." ForeColor="Red" 
        ControlToValidate="final" ValidationExpression="^[0-9]+(\.[0-9]){1,4}$"></asp:RegularExpressionValidator>
        </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="submit" runat="server" CssClass="buttonCSS" Text="Submit"
                    style="margin: 0 auto" Width="89px" OnClick="submit_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>

