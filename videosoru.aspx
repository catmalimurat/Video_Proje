<%@ Page Language="C#" AutoEventWireup="true" CodeFile="videosoru.aspx.cs" Inherits="soru" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Panel ID="Panel1" runat="server">
                <div>
                    <asp:RadioButton ID="S1" runat="server" GroupName="s" />
                    <br />
                    <asp:RadioButton ID="S2" runat="server" GroupName="s" />
                    <br />
                    <asp:RadioButton ID="S3" runat="server" GroupName="s" />
                    <br />
                    <asp:RadioButton ID="S4" runat="server" GroupName="s" />
                </div>
                <asp:RadioButton ID="S5" runat="server" GroupName="s" />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                <br />
                 <br>


                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cevapla" />
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
