////
////微信自带功能
////图片幻灯片
//var imgs2 = new Array();
//var nowImgurl2 = "";
//$(function() {
//	$('#synopsis a').click(function() {
//		var id = $('.weui_tab_bd_item').eq($(this).index()).find('.weui_tab_bd').attr('id');
//		if(id == 'weather') {
//			return;
//		}
//		addLoadEvent(getPicInfo(id)); //监听事件
//	});
//})
//
//function addLoadEvent(func) {
//	var oldonload = window.onload;
//	if(typeof window.onload != "function") {
//		window.onload = func();
//	} else {
//		window.onload = function() {
//			oldonload();
//			func();
//		}
//	}
//}
//
//function getPicInfo(Id) {
//	var imgObj2 = document.getElementById(Id).getElementsByTagName('img'); //获取图文中所有的img标签对象  
//	for(var i = 0; i < imgObj2.length; i++) {
//		imgs2.push(imgObj2[i].src);
//		imgObj2[i].onclick = function() {
//			nowImgurl2 = this.src; //获取当前点击图片url  
//			WeixinJSBridge.invoke("imagePreview", {
//				"urls": imgs2,
//				"current": nowImgurl2
//			})
//		}
//	}
//}