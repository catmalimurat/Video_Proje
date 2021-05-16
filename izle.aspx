<%@ Page Language="C#" AutoEventWireup="true" CodeFile="izle.aspx.cs" Inherits="izle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <button onclick="myFunction()" type="button">Bir sonraki dersi izlemek için dersin tamamını izlemeli, ders sonu sorularını cevaplamalısınız!</button><br>
        
        <%string vid = Request.QueryString["vid"]; %>
          <video id="myVideo" width="320" height="240" controls>
        <source src="<%=vid%>" type="video/mp4">
    
        Your browser does not support the video tag.
    </video>
            
        

       
<script>
var vid = document.getElementById("myVideo");

function myFunction() { 
   
    if (vid.ended) {
        document.getElementById('<%= Button1.ClientID %>').click();
    }
    else {
         alert('Ders videosunun tamamını izlemeden ve ders sonu sorusunu cevaplamadan bir sonraki dersi izleyemezsiniz');
    }
} 
</script> 

        <br />
        <div hidden>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" ClientIDMode="Static" />
</div>
    </form>
</body>
</html>
