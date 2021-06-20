<%@ Page Language="C#" AutoEventWireup="true" CodeFile="izle.aspx.cs" Inherits="izle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
	<title>Main page</title>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://fonts.googleapis.com/css?family=Open+Sans:400,300,600,300italic,400italic,600italic" rel="stylesheet" type="text/css">
	<link rel="stylesheet" href="assets/styles/main.css">
    </style>
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
</style>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
        }
        .auto-style2 {
            display: inline-block;
            vertical-align: middle;
            position: relative;
            white-space: normal;
            overflow: hidden;
            border-radius: 3px;
            color: white;
            font-size: 13px;
            font-family: "Open Sans", Arial, sans-serif;
            font-weight: 600;
            line-height: normal;
            text-align: center;
            transition: color 0.2s, background-color 0.2s;
            top: 1px;
            left: 4px;
            text-decoration: none;
            cursor: pointer;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            margin: 4px 2px;
            padding: 15px 32px;
            background-color: #4CAF50;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
       <br>
        
        <%string vid = Request.QueryString["vid"]; %>
      
          <video id="myVideo" width="100%" height="400" controls>
        <source src="<%=vid%>" type="video/mp4">
  
        Tarayıcınız videoyu desteklememektedir.
    </video>
        <%VideoCrud videocrud = new VideoCrud();
            string vkod = Request.QueryString["videokod"];
            bool izlendi = true;
            izlendi = videocrud.izlendimi(Session["uye"].ToString(), vkod);
            if (izlendi == false)
            {
                %><button onclick="myFunction()" type="button" class="auto-style2">Bir sonraki dersi izlemek için dersin tamamını izlemeli, ders sonu sorularını cevaplamalısınız!</button> <%
    }
    else
    { %>
        <asp:Button ID="Button2" runat="server" Text="Diğer Ders Videoları İçin Tıklayınız" class="button" OnClick="Button2_Click"/>
               <%} %>                                                                                                                                                                               
                                                                                                                                                                                          
            
        

       
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
            <br />
            <br />
           
</div>
        <br />
								<div class="services">
									<div class="row">
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-training"></i>
												<h3 class="service_item--title">Ders Dökümanları:</h3>
												<div class="service_item--text">
													<p><asp:TextBox ID="TextBox1" runat="server" Height="120px" Width="554px" CssClass="auto-style1"></asp:TextBox>
                                                    </p>
												</div>
												<footer class="service_item--footer"><a href="#" class="link -blue_light">Daha fazlası...</a></footer>
											</div>
										</div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-business"></i>
												<h3 class="service_item--title">Ödev</h3>
												<div class="service_item--text">
													<p><asp:TextBox ID="TextBox2" runat="server" Height="120px" Width="554px"></asp:TextBox>
                                                    </p>
												</div>
												<footer class="service_item--footer"><a href="#" class="link -blue_light">Daha fazlası...</a></footer>
											</div>
										</div>
										<div class="clearfix visible-sm-block"></div>
										
										<div class="clearfix visible-sm-block visible-md-block visible-lg-block"></div>
									</div>
								</div>
      
&nbsp;</form>
</body>
</html>
