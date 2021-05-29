<%@ Page Language="C#" AutoEventWireup="true" CodeFile="izle.aspx.cs" Inherits="izle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type="text/css">
    .center {
      margin: 0 auto;
    }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 282px;
        }
        .auto-style3 {
            width: 58px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <button onclick="myFunction()" type="button">Bir sonraki dersi izlemek için dersin tamamını izlemeli, ders sonu sorularını cevaplamalısınız!</button><br>
        
        <%string vid = Request.QueryString["vid"]; %>
      
          <video id="myVideo" width="100%" height="600" controls>
        <source src="<%=vid%>" type="video/mp4">
  
        Tarayıcınız videoyu desteklememektedir.
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
            <br />
            <br />
           
</div>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;Dersin Adı:
        </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Dersin Haftası:
        </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ders İçeriği:
        </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ders Hakkında:
        </td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="120px" Width="554px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Dersin Dökümanları:
        </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ödev:</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="89px" Width="631px"></asp:TextBox>
                </td>
            </tr>
        </table>
								<div class="services">
									<div class="row">
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-diamond"></i>
												<h3 class="service_item--title">Accounting</h3>
												<div class="service_item--text">
													<p>Ut et coue augue. Maecenas fernum vel ante a aliam etiam vivera mius as sapien.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-reviewer"></i>
												<h3 class="service_item--title">Finance Planning</h3>
												<div class="service_item--text">
													<p>Ut et coue augue. Maecenas fernum vel ante a aliam. Etiam vivera mius as sapien.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="clearfix visible-sm-block"></div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-umbrella"></i>
												<h3 class="service_item--title">Finance Aid</h3>
												<div class="service_item--text">
													<p>Integer sodles at sen seanto dapibus. Vivus tincint urars ac enim plinar, mosie acums.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="clearfix visible-md-block visible-lg-block"></div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-business"></i>
												<h3 class="service_item--title">Consulting</h3>
												<div class="service_item--text">
													<p>Aenean a neque odio. Integer mattis, orci id laoret vultate, urna dim gravida elit.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="clearfix visible-sm-block"></div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-online-support"></i>
												<h3 class="service_item--title">Worldwide Support</h3>
												<div class="service_item--text">
													<p>Ut et coue augue. Maecenas fernum vel ante a aliam etiam vivera mius as sapien.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-currency-exchange"></i>
												<h3 class="service_item--title">Money Transfers</h3>
												<div class="service_item--text">
													<p>Ut et coue augue. Maecenas fernum vel ante a aliam etiam vivera mius as sapien.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="clearfix visible-sm-block visible-md-block visible-lg-block"></div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-overtime"></i>
												<h3 class="service_item--title">Planning Events</h3>
												<div class="service_item--text">
													<p>Aenean a neque odio. Integer mattis, orci id laoret vultate, urna dim gravida elit.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-training"></i>
												<h3 class="service_item--title">Professional Training</h3>
												<div class="service_item--text">
													<p>Ut et coue augue. Maecenas fernum vel ante a aliam etiam vivera mius as sapien.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="col-md-4 col-sm-6 col-sm-offset-0 col-xs-10 col-xs-offset-1">
											<div class="service_item -horizontal">
												<i style="color: #34c1e4" class="service_item--icon icons8-idea"></i>
												<h3 class="service_item--title">Idea Generation</h3>
												<div class="service_item--text">
													<p>Ut et coue augue. Maecenas fernum vel ante a aliam etiam vivera mius as sapien.</p>
												</div>
												<footer class="service_item--footer"><a href="services.html#" class="link -blue_light">Learn More</a></footer>
											</div>
										</div>
										<div class="clearfix visible-sm-block visible-md-block visible-lg-block"></div>
									</div>
								</div>
      
&nbsp;</form>
</body>
</html>
