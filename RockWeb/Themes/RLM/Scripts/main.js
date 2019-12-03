function createCookie(name, value, days) {
    var expires;

    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toGMTString();
    } else {
        expires = "";
    }
    document.cookie = encodeURIComponent(name) + "=" + encodeURIComponent(value) + expires + "; path=/";
}

function readCookie(name) {
    var nameEQ = encodeURIComponent(name) + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ')
            c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0)
            return decodeURIComponent(c.substring(nameEQ.length, c.length));
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name, "", -1);
}

function create_mail(eNaam, eDomain, eTLD, eLabel) {
	var wMail = "";
	if (eLabel == "show") {
		eLabel = eNaam + '&#64;' + eDomain + '.' + eTLD;
	}
	wMail += '<a href="' + 'ma' + 'il' + 'to:' + eNaam;
	wMail += '&#64;' + eDomain + '.' + eTLD;
	wMail += '">' + eLabel + '<' + '/a>';
	document.write(wMail);
}
function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

var currentScrollTop;
var afterModalScrollTop;
var campusModalOpen, menuModalOpen, headerSearchOpen, mobileSearchOpen, menuBtnClicked = false;

function openCampusModal() {
	if (menuModalOpen) {
		closeMenuModal();
	}
	$('.modal-bg').show();
	$('.modal-locs').show();
	campusModalOpen = true;
}
function closeCampusModal() {
	$('.modal-bg').hide();
	$('.modal-locs').hide();
	campusModalOpen = false;
}

function openMenuModal(loc) {
	console.log('open');
	$('.modal-bg').show();
	$('.header .menu-btn .hamburger').addClass('is-active');
	$('.header .menu-btn-txt').addClass('is-active');
	var modalMenuWidth = $(window).width() * 0.8;
	$('.modal-menu .inner').css('right','-' + modalMenuWidth + 'px');
	$('.modal-menu').css('display','block').children('.inner').animate({'right':0},200);
	$('#menu-' + loc).show();
	if (mobileSearchOpen) {
		closeMobileSearch();
	}
	if (campusModalOpen) {
		closeCampusModal();
	}
	afterModalScrollTop = currentScrollTop;
	$('html,body').css('overflow','hidden');
	$('html,body').animate({'scrollTop':afterModalScrollTop + 'px'},100);
	menuModalOpen = true;
}
function closeMenuModal() {
	console.log('close');
	$('.modal-bg').hide();
	$('.header .menu-btn .hamburger').removeClass('is-active');
	$('.header .menu-btn-txt').removeClass('is-active');
	$('.modal-menu .inner').animate({'right':'-100%'},300, function() {
		$('.modal-menu').css('display','none');
		$('.modal-menu ul.menu').hide();
	});
	var curTopPosition = afterModalScrollTop;
	$('html,body').css('overflow','initial');
	$('html,body').animate({'scrollTop':curTopPosition + 'px'},100);
	menuModalOpen = false;
}

function openHeaderSearch() {
	$('.header .search-btn .hamburger').addClass('is-active');
	$('.header .search-btn i').hide();

	$('.header .search-box').show().css('opacity','1');
	TweenMax.to($('.header .search-input'), 0.25, {left:0, ease: Expo.easeOut});
	$('.header .search-input input').focus();
	headerSearchOpen = true;
}
function closeHeaderSearch() {
	$('.header .search-btn i').show();
	$('.header .search-btn .hamburger').removeClass('is-active');

	TweenMax.to($('.header .search-input'), 0.25, {left:700, ease: Expo.easeOut});
	$('.header .search-box').css('opacity','0').hide();
	headerSearchOpen = false;
}

function openMobileSearch() {
	$('.header .mobile-search-btn .hamburger').addClass('is-active');
	$('.header .mobile-search-btn i').hide();
	$('.modal-search').show(1,function() {
		$('.modal-search').find('input[type="text"]').focus();
	});
	if (menuModalOpen) {
		closeMenuModal();
	}
	mobileSearchOpen = true;
}
function closeMobileSearch() {
	$('.modal-search').hide();
	$('.header .mobile-search-btn i').show();
	$('.header .mobile-search-btn .hamburger').removeClass('is-active');
	mobileSearchOpen = false;
}

function showMainNavBG() {
	$('body').addClass('scroll');
}
function hideMainNavBG() {
	$('body').removeClass('scroll');
}

function playVideo(thisVideo) {
	// videoId = thisVideo.find('.id').html();
	// videoType = thisVideo.find('.type').html();
	videoURL = thisVideo.find('.url').html();
	if (videoURL.indexOf('vimeo') >= 0){
		var match = /vimeo.*\/(\d+)/i.exec( videoURL );
		if (match) {
			var videoID = match[1];
		}
		videoIframe = '<iframe width="100%" height="100%" src="https://player.vimeo.com/video/' + videoID + '?autoplay=1&title=0&byline=0&portrait=0" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>';
	} else if (videoURL.indexOf('youtube') >= 0 || videoURL.indexOf('youtu') >= 0){
		var regExp = /.*(?:youtu.be\/|v\/|u\/\w\/|embed\/|watch\?v=)([^#\&\?]*).*/;
		var match = videoURL.match(regExp);
		if (match) {
			var videoID = match[1];
		}
		videoIframe = '<iframe width="100%" height="100%" src="https://www.youtube.com/embed/' + videoID + '?rel=0&autoplay=1" frameborder="0" allowfullscreen></iframe>';
	} else {
		videoIframe = '<iframe width="100%" height="100%" src="' + videoURL + '" frameborder="0" allowfullscreen></iframe>';
	}
	thisVideo.find('.info-section').fadeOut(250);
	thisVideo.find('.chevrons').fadeOut(250);
	thisVideo.find('.img').fadeOut(250);
	
	thisVideo.find('.vidframe').append(videoIframe);
	thisVideo.find('.video-panel').fadeIn(250);
}

function switchMedia(type) {
	if (type == 'audio') {
		$('.banner.sub').removeClass('has-video').addClass('has-audio');
		$('.banner.sub .video-panel .vidframe iframe').remove();
		$('.banner.sub .video-panel').fadeOut(250);
		$('.banner.sub .play-btn').fadeOut(250);
		$('.banner.sub .img').fadeOut(250);
		$('.banner.sub .chevrons').fadeOut(250);
		$('.banner.sub.min').css('min-height','90px');
		var detailContentLeft = $('.watch-detail .content').offset().left;
		$('.banner.sub .pjs-audio-player').css({'bottom':'25%','left':detailContentLeft+'px'}).fadeIn(250);
		$('.banner.sub .pjs-audio-player audio').trigger('play');
		$('html, body').animate({scrollTop:$('.pjs-container').position().top + 'px'},500);
	} else {
		$('.banner.sub').removeClass('has-audio').addClass('has-video');
		$('.banner.sub .pjs-audio-player audio').trigger('pause');
		$('.banner.sub .pjs-audio-player').fadeOut(250);
		$('.banner.sub.min').css('min-height','260px');
		playVideo($('.banner.has-video'));
	}
}

function footerCheck() {
	var winPos = $(window).scrollTop();
	var space = $(window).height() - $('.footer').height();
	var scrollArea = winPos + space;
	var footerStart = $('.footer').offset().top;
	if (winPos == 0 && (scrollArea > footerStart)) {
		$('.footer').css({'position':'fixed','bottom':'0'});
	} else {
		$('.footer').css({'position':'relative','bottom':'auto'});
	}
}

//adjust styles on browser resize
function resizeCheck() {
	var browserWidth = $(window).width();
	var browserHeight = $(window).height();
	var headerTopHeight = $('.header').outerHeight();
	var menuModalScrollHeight;

	if (browserWidth > 980) {
		$('body').removeClass('mobile').addClass('dt');
		if (mobileSearchOpen) {
			closeMobileSearch();
		}

		//menu modal
		menuModalScrollHeight = browserHeight - $('.modal-menu .close-btn').outerHeight() - 20;
		$('.modal-menu').css('height',browserHeight + 'px');
		$('.modal-menu .inner').css('position','fixed');
		$('.modal-menu .scroll').css('height',menuModalScrollHeight + 'px');
		
		//position of main nav
		var mainNavOffset = $('.header .main-nav').width()/2;
		$('.header .main-nav').css('margin-left','-' + mainNavOffset + 'px');

		//set up header search box
		var mainSearchWidth = $('.header .main-nav > ul').width() + 10;
		var mainSearchOffset = $('.header .main-nav').position().left - mainNavOffset - 2;
		$('.header .search-box').css({'width':mainSearchWidth + 'px','left':mainSearchOffset + 'px'});
	} else {
		$('body').removeClass('dt').addClass('mobile');

		//menu modal
		menuModalHeight = browserHeight - headerTopHeight;
		menuModalScrollHeight = menuModalHeight - 20;
		$('.modal-menu').css({'height':menuModalHeight + 'px'});
		$('.modal-menu .inner').css('position','absolute');
		$('.modal-menu .scroll').css('height',menuModalHeight + 'px');

		//set up header search box
		$('.header .search-box').css({'width':'100%','left':'0'});
	}

	//choose campus modal modal-locs
	var chooseCampusModalScrollHeight = browserHeight - $('.modal-locs .main-title').outerHeight() - 20;
	$('.modal-locs .items').css('height',chooseCampusModalScrollHeight + 'px');
	
	//close header search if browser is resized
	if (headerSearchOpen) {
		closeHeaderSearch();
	}

	//homepage banner
	if ($('.banner.home').length > 0) {
		if ($('body').hasClass('mobile')) {
			$('.banner.home, .banner.home .img').css('height',(browserHeight - headerTopHeight) + 'px');
		} else {
			$('.banner.home, .banner.home .img').css('height',browserHeight + 'px');
		}
	}
	
	//header videos
	if ($('.banner.sub .video-panel').length > 0) {
		var bannerVidHeight = browserHeight - headerTopHeight;
		$('.banner.sub .video-panel').css('height',bannerVidHeight + 'px');
		if (browserWidth > 767) {
			$('.banner.sub .video-panel .vidframe').css('height',bannerVidHeight + 'px');
			$('.banner.sub .video-panel iframe').css('height',bannerVidHeight + 'px');
		} else {
			$('.banner.sub .video-panel .vidframe').css('height','0');
			$('.banner.sub .video-panel iframe').css('height','100%');
		}
	}
	
	//audio player position
	if ($('.banner.sub').hasClass('has-audio')) {
		var detailContentLeft = $('.watch-detail .content').offset().left;
		$('.banner.sub .pjs-audio-player').css('left',detailContentLeft+'px');
	}
	
	//two column graphics
	if ($('.two-col-alt').length > 0) {
		$('.two-col-alt').each(function() {
			var tcaImgHeight = $(this).height();
			$(this).find('.img .img-bg').css('height',tcaImgHeight + 'px');
		});
	}
	
	//check footer placement
	footerCheck();
}

$(document).ready(function() {
	// read location cookie
	var rlmLocation = readCookie('rlm-location');
	var rlmCampusID = readCookie('rlm-campusid');
	var redirectLink = "";
	// if (rlmLocation != '') {
		// var thisPagePath = window.location.pathname;
		// // alert(thisPagePath);
		
		// if (thisPagePath != '/post-falls' &&
			// thisPagePath != '/coeur-d-alene' &&
			// thisPagePath != '/north-campus' &&
			// thisPagePath != '/online-campus' && 
			// thisPagePath == '/') {
			// window.location = '/' + rlmLocation;
		// }
	// }
	
	//open menu modal
	$('.menu-btn').click(function() {
		menuBtnClicked = true;
		if (!menuModalOpen) {
			if (rlmLocation == null) {
				openCampusModal();
			} else {
				openMenuModal(rlmLocation);
			}
		} else {
			closeMenuModal();
		}
	});
	
	//open campus modal
	// $('.modal-menu a').click(function(e) {
		// if (!$(this).parent('li').hasClass('no-campus')) {
			// if (rlmLocation == null) {
				// redirectLink = $(this).data('link');
				// e.preventDefault();
				// openCampusModal();
			// }
		// }
	// });
	
	//close campus modal
	$('.modal-locs .close').click(function() {
		closeCampusModal();
	});
	
	//select a campus from modal
	$('.modal-locs .inner .items .item').click(function() {
		var thisCampus = $(this).data('campusname');
		var thisCampusID = $(this).data('campusid');
		var thisCampusGUID = $(this).data('guid');
		if (thisCampus) {
			createCookie('rlm-location', thisCampus, 30);
			createCookie('rlm-campusid', thisCampusID, 30);
			createCookie('rlm-campusguid', thisCampusGUID, 30);
			
			if (menuBtnClicked) { //from hamburger menu button
				openMenuModal(thisCampus);
			} else {
				window.location = '/' + thisCampus + '/' + redirectLink;
			}
		}
	});
	
	//main nav dropdowns
	$('.main-nav > ul > li').hover(function(){
		if($(this).hasClass('open')){
			TweenMax.to($(this).find('.sub-nav'), 0.5, {opacity:0, display:'none', ease: Expo.easeOut});
			$(this).removeClass('open');
		}else{
			TweenMax.to($('.main-nav > ul > li .sub-nav'), 0.25, {opacity:0, display:'none', ease: Expo.easeOut});
			$('.main-nav > ul > li').removeClass('open');
			TweenMax.to($(this).find('.sub-nav'), 0.25, {opacity:1, display:'block', ease: Expo.easeOut});
			$(this).addClass('open');
		}
	});
	
	$('.main-nav .sub-nav > ul > li').click(function(){
		// alert($(this).data('url'));
		if ($(this).data('campusname')) {
			createCookie('rlm-location', $(this).data('campusname'), 30);
			createCookie('rlm-campusid', $(this).data('campusid'), 30);
			createCookie('rlm-campusguid', $(this).data('guid'), 30);
			window.location = '/' + $(this).data('campusname');			
		}
	});
	
	$('.primary-header-nav .set-campus-item li').click(function(){
		if ($(this).data('campusname')) {
			createCookie('rlm-location', $(this).data('campusname'), 30);
			createCookie('rlm-campusid', $(this).data('campusid'), 30);
			createCookie('rlm-campusguid', $(this).data('guid'), 30);
			window.location = '/' + $(this).data('campusname');			
		}
	});
	
	$('.footer-main .left > ul > li').click(function(){
		// alert($(this).data('url'));
		if ($(this).data('campusname')) {
			createCookie('rlm-location', $(this).data('campusname'), 30);
			createCookie('rlm-campusid', $(this).data('campusid'), 30);
			createCookie('rlm-campusguid', $(this).data('guid'), 30);
			window.location = '/' + $(this).data('campusname');			
		}
	});
	
	$('.dropdown.campuses li').click(function(){
		if ($(this).data('campusname')) {
			createCookie('rlm-location', $(this).data('campusname'), 30);
			createCookie('rlm-campusid', $(this).data('campusid'), 30);
			createCookie('rlm-campusguid', $(this).data('guid'), 30);
			window.location = '/' + $(this).data('campusname');			
		}
	});
	
	//campus panel links
	$('.all-campus-panel .col').click(function(e){
		var innerTarget = $(e.target).attr('class'); //get the class name of what is being clicked on
		var addyLink = $(this).find('.inner-link').data('link'); //campus address link
		//if address is clicked on, open address link
		if (innerTarget == 'inner-link') {
			if (addyLink) {
				window.open(addyLink);
			} else {
				createCookie('rlm-location', $(this).data('campusname'), 30);
				createCookie('rlm-campusid', $(this).data('campusid'), 30);
				createCookie('rlm-campusguid', $(this).data('guid'), 30);
				window.location = '/' + $(this).data('campusname');	
			}
		} else {
			createCookie('rlm-location', $(this).data('campusname'), 30);
			createCookie('rlm-campusid', $(this).data('campusid'), 30);
			createCookie('rlm-campusguid', $(this).data('guid'), 30);
			window.location = '/' + $(this).data('campusname');		
		}
	});
	// $('.all-campus-panel a').click(function(e) {
		// e.preventDefault();
		// var campusLink = $(this).attr('href'); //campus link for whole box
		// var innerTarget = $(e.target).attr('class'); //get the class name of what is being clicked on
		// var addyLink = $(this).find('.inner-link').data('link'); //campus address link
		// //if address is clicked on, open address link; otherwise open link from <a>
		// if (innerTarget == 'inner-link') {
			// if (addyLink) {
				// window.open(addyLink);
			// } else {
				// window.location = campusLink;
			// }
		// } else {
			// window.location = campusLink;
		// }
	// });
	
	$('.watchLink').click(function(e) {
		var rlmCampusGUID = readCookie('rlm-campusguid');
		if (rlmCampusGUID != null) {
			window.location = "/watch-listen?Location=" + rlmCampusGUID;
		} else {
			window.location = "/watch-listen";
		}		
	});
	
	//related stories section item's tags
	$('.items-related .item a').click(function(e) {
		e.preventDefault();
		var storyLink = $(this).attr('href'); //link for whole box
		var innerTarget = $(e.target); //get the class name of what is being clicked on
		var tagLink = $(this).find('.inner-link').data('link'); //tag link
		//if tag is clicked on, open tag link; otherwise open link from <a>
		if (innerTarget.attr('class') == 'inner-link') {
			if (innerTarget.data('link')) {
				window.location = innerTarget.data('link');
			} else {
				window.location = storyLink;
			}
		} else {
			window.location = storyLink;
		}
	});
	
	$('.stories-grid .item a').click(function(e) {
		e.preventDefault();
		var storyLink = $(this).attr('href'); //link for whole box
		var innerTarget = $(e.target); //get the class name of what is being clicked on
		var tagLink = $(this).find('.inner-link').data('link'); //tag link
		//if tag is clicked on, open tag link; otherwise open link from <a>
		if (innerTarget.attr('class') == 'inner-link') {
			if (innerTarget.data('link')) {
				window.location = innerTarget.data('link');
			} else {
				window.location = storyLink;
			}
		} else {
			window.location = storyLink;
		}
	});
	
	//watch page campus dropdowns
	$('.watch-campus-dropdown .selected').click(function(){
		if($(this).parent().hasClass('open')){
			TweenMax.to($(this).siblings('.dropdown-items'), 0.25, {opacity:0, display:'none', ease: Expo.easeOut});
			$(this).parent().removeClass('open');
		}else{
			TweenMax.to($(this).siblings('.dropdown-items'), 0.25, {opacity:1, display:'block', ease: Expo.easeOut});
			$(this).parent().addClass('open');
		}
	});
	
	//location landing page campus dropdowns
	$('.info-section .selected').click(function(){
		if($(this).parent().hasClass('open')){
			TweenMax.to($(this).siblings('.dropdown-items'), 0.25, {opacity:0, display:'none', ease: Expo.easeOut});
			$(this).parent().removeClass('open');
		}else{
			TweenMax.to($(this).siblings('.dropdown-items'), 0.25, {opacity:1, display:'block', ease: Expo.easeOut});
			$(this).parent().addClass('open');
		}
	});

	//event page calendar
	$(document).on('click', '.event-landing .mini-calendar .mini-calendar-icon', function() {
		if ($(this).siblings('.calendar').is(':visible')) {
			$(this).siblings('.calendar').slideUp();
		} else {
			$(this).siblings('.calendar').slideDown();
		}
	});				
	
	//show header nav bg when scrolled
	if ($('.pjs-container').length > 0) {
		$(document).on('scroll',function () {
			currentScrollTop = window.pageXOffset ? window.pageXOffset : document.documentElement.scrollTop ? document.documentElement.scrollTop : document.body.scrollTop;
			if (currentScrollTop > 65) {
				showMainNavBG();
				if (headerSearchOpen) {
					closeHeaderSearch();
				}
			} else {
				hideMainNavBG();
			}
		});
		var loadTop = $('.pjs-container').position().top;
		if (loadTop > 65) {
			showMainNavBG();
			if (headerSearchOpen) {
				closeHeaderSearch();
			}
		}
	}

	//header search bar
	$('.header .search-btn').click(function() {
		// if ($('body').hasClass('mobile')) {
			// if (mobileSearchOpen) {
				// closeMobileSearch();
			// } else {
				// openMobileSearch();
			// }
		// } else {
			if (headerSearchOpen) {
				closeHeaderSearch();
			} else {
				openHeaderSearch();
			}
		// }
	});

	//switch between video and audio
	$('.watch-video-link').click(function() {
		switchMedia('video');
	});
	$('.listen-audio-link').click(function() {
		switchMedia('audio');
	});
	
	//check if url has query string for audio
	if ($('.section.banner.watch').length > 0) {
		var urlParams = new URLSearchParams(window.location.search);
		var checkAudio = urlParams.get('t');
		if (checkAudio == 'audio') {
			switchMedia('audio');
		}
	}
	
	//play video
	$('.banner.has-video').click(function() {
		if (!$('.pjs-audio-player').is(':visible')) {
			playVideo($(this));
		}
	});
	
	//watch page listen/notes dropdowns
	$('.watch-detail .options li').each(function() {
		$(this).click(function() {
			if ($(this).has('i').length) {
				if ($(this).children('.sub').is(':visible')) {
					$(this).children('.sub').hide();
				} else {
					$('.watch-detail .options li .sub').hide();
					$(this).children('.sub').show();
				}
			}
		});
	});
	
	//close modal menu when clicking outside of menu area
	$('.modal-bg').click(function(e) {
		if (!$(e.target).closest('.modal-menu .scroll').length) {
			if (menuModalOpen) {
				closeMenuModal();
			}
		}
	});

	//close search box when clicking outside of search box area
	$('.pjs-container').click(function(e) {
		if (!$(e.target).closest('.search-box').length && !$(e.target).closest('.header .search-btn').length) {
			if (headerSearchOpen) {
				closeHeaderSearch();
			}
		}
	});

	//close campus landing page dropdown when clicking outside of dropdown area
	$('.pjs-container').click(function(e) {
		if (!$(e.target).closest('.dropdown').length) {
			if ($('.info-section .dropdown .dropdown-items').is(':visible')) {
				TweenMax.to($('.info-section .dropdown .dropdown-items'), 0.25, {opacity:0, display:'none', ease: Expo.easeOut});
				$('.info-section .dropdown').removeClass('open');
			}
		}
	});
	
	//close listen/notes dropdown when clicking outside of dropdown area
	$('.pjs-container').click(function(e) {
		if (!$(e.target).closest('.watch-detail .options li.has-sub').length) {
			if ($('.watch-detail .options li.has-sub .sub').is(':visible')) {
				$('.watch-detail .options li.has-sub .sub').hide();
			}
		}
	});

	//close modals if escape is pressed
	$(document).keyup(function(e) {
		if (e.keyCode == 27) {
			if (menuModalOpen) {
				closeMenuModal();
			} else if (headerSearchOpen) {
				closeHeaderSearch();
			} else if (mobileSearchOpen) {
				closeMobileSearch();
			} else if (campusModalOpen) {
				closeCampusModal();
			} else if ($('.info-section .dropdown .dropdown-items').is(':visible')) {
				TweenMax.to($('.info-section .dropdown .dropdown-items'), 0.25, {opacity:0, display:'none', ease: Expo.easeOut});
				$('.info-section .dropdown').removeClass('open');
			} else if ($('.watch-detail .options li.has-sub .sub').is(':visible')) {
				$('.watch-detail .options li.has-sub .sub').hide();
			} else {
				if ($('.modal-bg').is(':visible')) {
					$('.modal-bg').hide();
				}
			}
		}
	});

	//close modals
	$('.modal .close-btn').click(function() {
		if (menuModalOpen) {
			closeMenuModal();
		} else {
			$('.modal-bg').hide();
			$(this).parents('.modal').hide();
		}
	});

	//modal menu subnavs
	$('.modal-menu .menu-item-has-children').prepend('<div class="hamburger hamburger--3dx"><div class="hamburger-box"><div class="hamburger-inner"></div></div></div>');
	$('.modal-menu .hamburger').click(function() {
		if ($(this).parent().children('.sub-menu').is(':visible')) {
			$(this).parent().children('.sub-menu').slideUp('fast');
			$(this).removeClass('is-active');
		} else {
			$('.modal-menu .menu-item-has-children .hamburger').removeClass('is-active');
			$('.modal-menu .menu-item-has-children .sub-menu').slideUp('fast');
			$(this).parent().children('.sub-menu').slideDown('fast');
			$(this).addClass('is-active');
		}
	});

	//if window is resized
	$(window).resize(function() {
		resizeCheck();
	});
	resizeCheck();

});

setTimeout(function() {
	resizeCheck();
},1000);

// $(window).load(function() {
	// var topPos = window.pageXOffset ? window.pageXOffset : document.documentElement.scrollTop ? document.documentElement.scrollTop : document.body.scrollTop;
	// if (topPos > 140) {
		// showMainNavBG();
	// }
	// resizeCheck();

	// //outdated browser check
	// outdatedBrowser({
		// bgColor: '#f25648',
		// color: '#ffffff',
		// lowerThan: 'transform',
		// languagePath: 'en.html'
	// });

// });
