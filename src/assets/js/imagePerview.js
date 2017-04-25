//
//微信自带功能
//图片幻灯片
function addLoadEvent(func) {
			var oldonload = window.onload;
			if(typeof window.onload != "function") {
				window.onload = func();
			} else {
				window.onload = function() {
					oldonload();
					func();
				}
			}
		}
		var imgs = new Array();
		var nowImgurl = "";

		function getPicInfo() {
			var imgObj = $('img[alt="img"]'); //获取图文中所有的img标签对象  

			for(var i = 0; i < imgObj.length; i++) {
				imgs.push(imgObj[i].src);
				imgObj[i].onclick = function() {
					nowImgurl = this.src; //获取当前点击图片url  
					WeixinJSBridge.invoke("imagePreview", {
						"urls": imgs,
						"current": nowImgurl
					})
				}
			}
		}
		addLoadEvent(getPicInfo); //监听事件