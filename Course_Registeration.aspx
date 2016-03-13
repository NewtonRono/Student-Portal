<%@ Page Title="" Language="C#" MasterPageFile="~/StudentPages.master" AutoEventWireup="true" CodeFile="Course_Registeration.aspx.cs" Inherits="Course_Registeration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Student Portal 2.0</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Course Registeration</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:Label runat="server" id="status" style="color:Red;"></asp:Label>
    <br />
    <table style="margin: 0 auto">
        <tr>
            <td style="text-align: left; width: 150px"></td>
            <td style="text-align: left; width: 151px">3 Credit Hour Courses</td>
            <td style="text-align: left; width: 107px"></td>
            <td style="text-align: left; width: 151px">1 Credit Hour Courses</td>
        </tr>
        <tr>
            <td style="text-align: left; width: 150px">
             <asp:Label runat="server" id="Label1" style="color:Red;"></asp:Label>
                    </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList0" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
               <asp:RadioButton ID="add31" runat="server" Text="Add" GroupName="add/drop1"  />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop31" runat="server" Text="Drop" GroupName="add/drop1" />
                 </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList5" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
               <asp:RadioButton ID="add11" runat="server" Text="Add" GroupName="add/drop2"  />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop11" runat="server" Text="Drop" GroupName="add/drop2"  />
               
               </td>
                <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label2" style="color:Red;"></asp:Label>
             </td>
           
        </tr>
        <tr>
     <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label3" style="color:Red;"></asp:Label>
                     </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList1" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
                <asp:RadioButton ID="add32" runat="server" Text="Add" GroupName="add/drop3"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop32" runat="server" Text="Drop" GroupName="add/drop3"  />
                </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList6" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
            <asp:RadioButton ID="add12" runat="server" Text="Add" GroupName="add/drop4"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop12" runat="server" Text="Drop" GroupName="add/drop4" />
               
            </td>
            <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label4" style="color:Red;"></asp:Label>
             </td>
          
        </tr>
        <tr>
            <td style="text-align: left; width: 150px">
                    <asp:Label runat="server" id="Label5" style="color:Red;"></asp:Label>
             </td>
          
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList2" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
                <asp:RadioButton ID="add33" runat="server" Text="Add" GroupName="add/drop5"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop33" runat="server" Text="Drop" GroupName="add/drop5"  />
               
                </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList7" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
                <asp:RadioButton ID="add13" runat="server" Text="Add" GroupName="add/drop6"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop13" runat="server" Text="Drop" GroupName="add/drop6"  />
               
            </td>
            <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label6" style="color:Red;"></asp:Label>
             </td>
          
        </tr>
        <tr>
            <td style="text-align: left; width: 150px">
             <asp:Label runat="server" id="Label7" style="color:Red;"></asp:Label>
             
          </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList3" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
                <asp:RadioButton ID="add34" runat="server" Text="Add" GroupName="add/drop7"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop34" runat="server" Text="Drop" GroupName="add/drop7" />
               </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList8" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
               <asp:RadioButton ID="add14" runat="server" Text="Add" GroupName="add/drop8"  />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop14" runat="server" Text="Drop" GroupName="add/drop8" />
               
               </td>
               <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label8" style="color:Red;"></asp:Label>
             </td>
          
        </tr>
        <tr>
          <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label9" style="color:Red;"></asp:Label>
             </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList4" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
                <asp:RadioButton ID="add35" runat="server" Text="Add" GroupName="add/drop9"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop35" runat="server" Text="Drop" GroupName="add/drop9" />
               
            </td>
            <td style="width: 151px">
                <asp:DropDownList ID="DropDownList9" CssClass="buttonCSS" runat="server">
                </asp:DropDownList>
            </td>
            <td style="width: 107px">
                <asp:RadioButton ID="add15" runat="server" Text="Add" GroupName="add/drop10"   />
                <span style="margin-left: 10px"></span>
                <asp:RadioButton ID="drop15" runat="server" Text="Drop" GroupName="add/drop10" />
               </td>
               <td style="text-align: left; width: 150px"><asp:Label runat="server" id="Label10" style="color:Red;"></asp:Label>
             </td>
          
        </tr>
        <tr>
            <td style="text-align: left; width: 150px"></td>
            <td style="width: 151px"></td>
            <td style="width: 107px">
                <asp:Button ID="submit" runat="server" CssClass="buttonCSS" Text="Submit"  
                     Width="105px" onclick="submit_Click"/><!--OnClientClick="javascript: checkBoxes()"-->
                </td>
          
        </tr>
    </table>
    <script type="text/javascript">
        function checkBoxes() {
            var course = document.getElementById('<%=DropDownList0.ClientID%>').value;
            var x = document.getElementById('<%=add31.ClientID%>').checked;
            var y = document.getElementById('<%=drop31.ClientID%>').checked;
            if (course != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            course = document.getElementById('<%=DropDownList1.ClientID%>').value;
            x = document.getElementById('<%=add32.ClientID%>').checked;
            y = document.getElementById('<%=drop32.ClientID%>').checked;
            if (course != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            course = document.getElementById('<%=DropDownList2.ClientID%>').value;
            x = document.getElementById('<%=add33.ClientID%>').checked;
            y = document.getElementById('<%=drop33.ClientID%>').checked;
            if (course != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            course = document.getElementById('<%=DropDownList3.ClientID%>').value;
            x = document.getElementById('<%=add34.ClientID%>').checked;
            y = document.getElementById('<%=drop34.ClientID%>').checked;
            if (course != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            course = document.getElementById('<%=DropDownList4.ClientID%>').value;
            x = document.getElementById('<%=add35.ClientID%>').checked;
            y = document.getElementById('<%=drop35.ClientID%>').checked;
            if (course != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            // now for labs
            var lab = document.getElementById('<%=DropDownList5.ClientID%>').value;
            x = document.getElementById('<%=add11.ClientID%>').checked;
            y = document.getElementById('<%=drop11.ClientID%>').checked;
            if (lab != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            lab = document.getElementById('<%=DropDownList6.ClientID%>').value;
            x = document.getElementById('<%=add12.ClientID%>').checked;
            y = document.getElementById('<%=drop12.ClientID%>').checked;
            if (lab != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            lab = document.getElementById('<%=DropDownList7.ClientID%>').value;
            x = document.getElementById('<%=add13.ClientID%>').checked;
            y = document.getElementById('<%=drop13.ClientID%>').checked;
            if (lab != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            lab = document.getElementById('<%=DropDownList8.ClientID%>').value;
            x = document.getElementById('<%=add14.ClientID%>').checked;
            y = document.getElementById('<%=drop14.ClientID%>').checked;
            if (lab != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
            lab = document.getElementById('<%=DropDownList9.ClientID%>').value;
            x = document.getElementById('<%=add15.ClientID%>').checked;
            y = document.getElementById('<%=drop15.ClientID%>').checked;
            if (lab != "" && x == y) {
                alert("Select to either add or drop the course.");
                return;
            }
        }
    </script>
</asp:Content>

