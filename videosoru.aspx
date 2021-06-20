<%@ Page Language="C#" AutoEventWireup="true" CodeFile="videosoru.aspx.cs" Inherits="soru" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style>
.button {
  background-color: #4CAF50; /* Green */
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  margin: 4px 2px;
  cursor: pointer;
}
         .auto-style1 {
             width: 100%;
         }
         .auto-style2 {
             width: 688px;
         }
         .auto-style3 {
             width: 475px;
         }
     </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                    <asp:RadioButton ID="S1" runat="server" GroupName="s" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                    <asp:RadioButton ID="S2" runat="server" GroupName="s" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                    <asp:RadioButton ID="S3" runat="server" GroupName="s" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                    <asp:RadioButton ID="S4" runat="server" GroupName="s" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                <asp:RadioButton ID="S5" runat="server" GroupName="s" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style2">


                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cevapla" class="button" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <div>
                    <br />
                    <br />
                    <br />
                </div>
                <br />
                <br />
                 <br>


                </asp:Panel>
            <br />
        </div>
        <br />
        <br />

        <script>



</script> 
    </form>
</body>
</html>
