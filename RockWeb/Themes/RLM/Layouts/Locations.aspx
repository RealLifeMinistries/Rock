<%@ Page Language="C#" AutoEventWireup="true" Inherits="Rock.Web.UI.RockPage" %>
<%@ Import Namespace="System.Web.Optimization" %>
<!DOCTYPE html>

<html class="no-js">
<head runat="server">
	<link rel="apple-touch-icon" sizes="180x180" href="/apple-touch-icon.png">
	<link rel="icon" type="image/png" sizes="32x32" href="/favicon-32x32.png">
	<link rel="icon" type="image/png" sizes="16x16" href="/favicon-16x16.png">
	<link rel="manifest" href="/site.webmanifest">
	<link rel="mask-icon" href="/safari-pinned-tab.svg" color="#ef4326">
	<meta name="msapplication-TileColor" content="#ef4326">
	<meta name="theme-color" content="#ef4326">

    <!-- Set the viewport width to device width for mobile -->
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no">

    <meta http-equiv="X-UA-Compatible" content="IE=10" />
    <title></title>

    <script src="<%# ResolveRockUrl("~/Scripts/modernizr.js", true) %>"></script>
    <script src="<%# ResolveRockUrl("~/Scripts/jquery-1.12.4.min.js", true) %>"></script>

	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,900|Oswald:300,400,500,600|Alfa+Slab+One" rel="stylesheet">
	<link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css">
	
    <link rel="stylesheet" href="<%# ResolveRockUrl("~~/Styles/bootstrap.css", true) %>" />
    <link rel="stylesheet" href="<%# ResolveRockUrl("~~/Styles/theme.css", true) %>" />
    <link rel="stylesheet" href="<%# ResolveRockUrl("~/Styles/developer.css", true) %>" />
    <link rel="stylesheet" href="<%# ResolveRockUrl("~~/Styles/style.css", true) %>" />

	<!--[if lt IE 9]>
	<script src="<%# ResolveRockUrl("~/Themes/RLM/Scripts/html5.js" ) %>" type="text/javascript"></script>
	<![endif]-->
	
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/3.1.25/jquery.fancybox.min.css" />
	<script src="https://cdnjs.cloudflare.com/ajax/libs/fancybox/3.1.25/jquery.fancybox.min.js"></script>
	<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/Swiper/4.0.7/css/swiper.min.css">
	<script src="https://cdnjs.cloudflare.com/ajax/libs/Swiper/4.0.7/js/swiper.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/1.19.0/TweenMax.min.js"></script>
	<link rel="stylesheet" href="<%# ResolveRockUrl("~~/Scripts/outdatedbrowser/outdatedbrowser.min.css" ) %>">
	<script src="<%# ResolveRockUrl("~~/Scripts/outdatedbrowser/outdatedbrowser.min.js" ) %>"></script>
	<script src="<%# ResolveRockUrl("~~/Scripts/main.js?v=09" ) %>" type="text/javascript"></script>
	
</head>

<body runat="server" id="body">
    <form id="form1" runat="server">
		<div class="pjs-container">
			<asp:ScriptManager ID="sManager" runat="server" />

			<asp:UpdateProgress ID="updateProgress" runat="server" DisplayAfter="800">
				<ProgressTemplate>
					<div class="updateprogress-status">
						<div class="spinner">
							<div class="rect1"></div>
							<div class="rect2"></div>
							<div class="rect3"></div>
							<div class="rect4"></div>
							<div class="rect5"></div>
						</div>
					</div>
					<div class="updateprogress-bg modal-backdrop">
					</div>
				</ProgressTemplate>
			</asp:UpdateProgress>

			<main class="container-fluid">
			
				<!-- Start Content Area -->
				<Rock:Zone Name="Header" runat="server" />
				<Rock:Zone Name="Main" runat="server" />
				<Rock:Zone Name="Footer" runat="server" />

			</main>
		</div>
    </form>
	
	<div id="outdated"></div>
	
	<script>$(document).ready(function() {$("[data-fancybox]").fancybox({});});</script>
	<script type="text/javascript" src="//s7.addthis.com/js/300/addthis_widget.js#pubid=ra-5ab130ecb08d211c"></script>
</body>
</html>