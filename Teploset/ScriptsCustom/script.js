$(document).ready(function(){
		$('#menu').slicknav();
		
		$('.flexslider').flexslider({
			prevText: '',
			nextText: ''
		});

		$('.testimonails-slider').flexslider({
			animation: 'slide',
			slideshowSpeed: 5000,
			prevText: '',
			nextText: '',
			controlNav: false
		});
});