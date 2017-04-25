//
//swiper + 图片放大
//图片幻灯片（img标签加属性 name="pb1" class="pb1" ）（z-index: 0;）(swiper.js)
var imgs = new Array();
var nowImgurl = "";
window.onload = function() {
	setTimeout(function() {
		$.hideLoading();
		var imgObj = document.getElementsByName('pb1'); //获取图文中所有的img标签对象

		for(var i = 0; i < imgObj.length; i++) {
			imgs.push(imgObj[i].src);
		}
		var pb1 = $.photoBrowser({
			items: imgs,
			initialSlide: 3,
			onSlideChange: function(index) {
				console.log(this, index);
			},
			onOpen: function(index) {
				console.log("onOpen", this);
			},
			onClose: function() {
				console.log("onClose", this);
			}
		});
		$(".pb1").click(function() {
			pb1.open();
		});

		for(var i = 0; i < imgObj.length; i++) {
			imgObj[i].onclick = (function(n) {
				return function() {
					pb1.open('initialSlide', n);
				}
			})(i)
		}
		var mySwiper = new Swiper('.swiper-container', {
			direction: 'horizontal',
			observer: true,
			observeParents: true,
			slidesPerView:1,
			freeMode:false,
			paginationClickable: true,
			
		})
	}, 1000)
}