<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPages.master" AutoEventWireup="true" CodeFile="updateStudent.aspx.cs" Inherits="updateStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h1>Update Student</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
 
<div class="GridDock" id="dvGridWidth">
<asp:GridView ID="grdContact" runat="server" AutoGenerateColumns="False"  
        OnRowCancelingEdit="grdContact_RowCancelingEdit" 
        OnRowDataBound="grdContact_RowDataBound" OnRowEditing="grdContact_RowEditing"
 OnRowUpdating="grdContact_RowUpdating" 
OnRowCommand="grdContact_RowCommand"
 ShowFooter="True" 
OnRowDeleting="grdContact_RowDeleting"
                BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" 
        GridLines="Vertical" BackColor="White" ForeColor="Black" >
        <AlternatingRowStyle BackColor="White" />
        <Columns> 
            <asp:TemplateField HeaderText="Edit" ShowHeader="False" HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:LinkButton ID="lbkUpdate" runat="server" class="buttonCSS" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton> 
                    <asp:LinkButton ID="lnkCancel" runat="server" class="buttonCSS" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton> 
                </EditItemTemplate> 
                 
                <ItemTemplate> 
                    <asp:LinkButton ID="lnkEdit" runat="server" class="buttonCSS" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>  
        
            <asp:TemplateField HeaderText="Guardian ID"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t2" runat="server" class="textbox" Text='<%# Bind("Guardian_ID") %>'></asp:Textbox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="t2" ErrorMessage="Enter Guardian ID" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
                    ControlToValidate="t2" ErrorMessage="Gardian ID must be of 13 integers" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d\d\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
            <asp:Label ID="lbl2" runat="server" Text='<%# Bind("Guardian_ID") %>'></asp:Label> 
                  
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField> 
            <asp:TemplateField HeaderText="First Name"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate>
                <asp:Textbox ID="t3" runat="server" class="textbox" Text='<%# Bind("First_Name") %>'></asp:Textbox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="t3" ErrorMessage="Middle name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="t3" ErrorMessage="Enter valid Middle Name" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z''-'\s]{1,40}$"></asp:RegularExpressionValidator>
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl3" runat="server" Text='<%# Bind("First_Name") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Middle Name"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t5" runat="server" class="textbox" Text='<%# Bind("Middle_Name") %>'></asp:Textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="t5" ErrorMessage="Middle name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                    ControlToValidate="t5" ErrorMessage="Enter valid Middle Name" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z''-'\s]{1,40}$"></asp:RegularExpressionValidator>
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl5" runat="server" Text='<%# Bind("Middle_Name") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
        
            
            <asp:TemplateField HeaderText="Last Name"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t4" runat="server" class="textbox" Text='<%# Bind("Last_Name") %>'></asp:Textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="t4" ErrorMessage="Last Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="t4" ErrorMessage="Enter valid Last Name" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z''-'\s]{1,40}$"></asp:RegularExpressionValidator>
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl4" runat="server" Text='<%# Bind("Last_Name") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Gender"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:DropDownList  cssClass="buttonCSS" style="margin-top:-30px;" id="gen" runat="server">
            <asp:ListItem Value="0">Male</asp:ListItem>
            <asp:ListItem Value="1">Female</asp:ListItem>
        </asp:DropDownList>
                     </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl6" runat="server" Text='<%# Bind("Gender") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Date of Birth"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t7" runat="server" class="textbox" Text='<%# Bind("Date_of_Birth") %>'></asp:Textbox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ControlToValidate="t7" ErrorMessage="Enter Date of Birth" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" 
                    ControlToValidate="t7" 
                    ErrorMessage="Date of Birth Must be in format yyyy/mm/dd" ForeColor="Red"           
                    ValidationExpression="^(1[9][0-9][0-9]|2[0][0-9][0-9])[- / .]([1-9]|0[1-9]|1[0-2])[- / .]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])$"></asp:RegularExpressionValidator>
               
                </EditItemTemplate>
                <ItemTemplate> 
                    <asp:Label ID="lbl7" runat="server" Text='<%# Bind("Date_of_Birth") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
        
            <asp:TemplateField HeaderText="Temporary Address"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t8" runat="server" class="textbox" style="margin-top:-12px;" Text='<%# Bind("Temporary_Address") %>'></asp:Textbox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                    ControlToValidate="t8" ErrorMessage="Enter Temporary address" ForeColor="Red"></asp:RequiredFieldValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl8" runat="server" Text='<%# Bind("Temporary_Address") %>'></asp:Label> 
          
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
        
            <asp:TemplateField HeaderText="Permanent Address"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t9" runat="server" class="textbox" style="margin-top:-12px;" Text='<%# Bind("Permanent_address") %>'></asp:Textbox>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ControlToValidate="t9" ErrorMessage="Enter Permanent address" ForeColor="Red"></asp:RequiredFieldValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl9" runat="server" Text='<%# Bind("Permanent_address") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Contact#"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t10" runat="server" class="textbox" Text='<%# Bind("Contact_No") %>'></asp:Textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                    ControlToValidate="t10" ErrorMessage="Enter Contact No" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator21" runat="server" 
                    ControlToValidate="t10" ErrorMessage="Contact Number Should be of 11 characters" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl10" runat="server" Text='<%# Bind("Contact_No") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="CNIC"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t11" runat="server" class="textbox" Text='<%# Bind("CNIC") %>'></asp:Textbox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                    ControlToValidate="t11" ErrorMessage="Enter CNINC" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator13" runat="server" 
                    ControlToValidate="t11" ErrorMessage="CNIC must be of 13 characters" ForeColor="Red" 
                    ValidationExpression="^\d\d\d\d\d\d\d\d\d\d\d\d\d$"></asp:RegularExpressionValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl11" runat="server" Text='<%# Bind("CNIC") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText=" Personal Email"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t12" runat="server" class="textbox" style="margin-top:-12px;" Text='<%# Bind("Personal_Email") %>'></asp:Textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                    ControlToValidate="t12" ErrorMessage="Enter Personal Email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" 
                    ControlToValidate="t12" ErrorMessage="Invalid Email" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl12" runat="server" Text='<%# Bind("Personal_Email") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Official Email"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t13" runat="server" class="textbox" style="margin-top:-12px;" Text='<%# Bind("Official_Email") %>'></asp:Textbox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                    ControlToValidate="t13" ErrorMessage="Enter official Email" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" 
                    ControlToValidate="t13" ErrorMessage="Invalid Email" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl13" runat="server" Text='<%# Bind("Official_Email") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Date Enrolled"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t14" runat="server" class="textbox" Text='<%# Bind("date_enrolled") %>'></asp:Textbox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                    ControlToValidate="t14" ErrorMessage="Enter Date Enrolled" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator22" runat="server" 
                    ControlToValidate="t14" 
                    ErrorMessage="Date Enrolled Must be in format yyyy/mm/dd" ForeColor="Red"           
                    ValidationExpression="^(1[9][0-9][0-9]|2[0][0-9][0-9])[- / .]([1-9]|0[1-9]|1[0-2])[- / .]([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])$"></asp:RegularExpressionValidator>      
    
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl14" runat="server" Text='<%# Bind("date_enrolled") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Blood Group"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                        <asp:DropDownList ID="t15" CssClass="buttonCSS" style="margin-top:-30px;" runat="server" 
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
    
                 </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl15" runat="server" Text='<%# Bind("blood_group") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Campus#"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                   <asp:DropDownList class="buttonCSS" style="margin-top:-30px;" id="cmp" runat="server">
            <asp:ListItem Value="0">Lahore</asp:ListItem>
            <asp:ListItem Value="1">Islamabad</asp:ListItem>
            <asp:ListItem Value="2">Faisalbad</asp:ListItem>
            <asp:ListItem Value="3">Peshawar</asp:ListItem>
           
        </asp:DropDownList>
                 </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl16" runat="server" Text='<%# Bind("campus_id") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
        
           <asp:TemplateField HeaderText=" CGPA"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t17" runat="server"  class="textbox" style="margin-top:-12px;" Text='<%# Bind("CGPA") %>'></asp:Textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                    ControlToValidate="t17" ErrorMessage="Enter CGPA" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator14" runat="server" 
                    ControlToValidate="t17" ErrorMessage="Enter valid cgpa" ForeColor="Red" 
                    ValidationExpression="^[0]|[0-3]\.(\d?\d?)|[4].[0]$"></asp:RegularExpressionValidator>
            
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl17" runat="server" Text='<%# Bind("CGPA") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Warning Count"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t18" runat="server" class="textbox" Text='<%# Bind("warning_count") %>'></asp:Textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                    ControlToValidate="t18" ErrorMessage="Enter Warning Count" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator25" runat="server" 
                    ControlToValidate="t18" ErrorMessage="Enter valid Warning Count i.e of one integer" ForeColor="Red" 
                    ValidationExpression="^\d$"></asp:RegularExpressionValidator>
        
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl18" runat="server" Text='<%# Bind("warning_count") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Password"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t19" runat="server" class="textbox" Text='<%# Bind("password") %>'></asp:Textbox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                    ControlToValidate="t19" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator20" runat="server" 
                    ControlToValidate="t19" ErrorMessage="Password must be of at least 6 characters" ForeColor="Red" 
                    ValidationExpression="^[a-zA-Z0-9'@&#.\s]{6,}$"></asp:RegularExpressionValidator>
          
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl19" runat="server" Text='<%# Bind("password") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Pic Path"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
           <asp:FileUpload ID="t20" class="buttonCSS" style="margin-top:-12px;" runat="server" />
          <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                    ControlToValidate="t20" ErrorMessage="Upload Image" ForeColor="Red"></asp:RequiredFieldValidator>
      
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl20" runat="server" Text='<%# Bind("photo") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
            <asp:TemplateField HeaderText="Status"  HeaderStyle-HorizontalAlign="Left"> 
                <EditItemTemplate> 
                    <asp:Textbox ID="t21" runat="server" class="textbox" style="margin-top:-30px;" Text='<%# Bind("status") %>'></asp:Textbox>
                </EditItemTemplate> 
                <ItemTemplate> 
                    <asp:Label ID="lbl21" runat="server" Text='<%# Bind("status") %>'></asp:Label> 
                </ItemTemplate> 

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>     
        
        </Columns>
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
   </div>
    <asp:Label runat="server" id="status" style="color:Red;"></asp:Label>  

</asp:Content>

