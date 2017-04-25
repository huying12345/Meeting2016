function checkPlatform() {
	if(/(iPhone|iPad|iPod|iOS)/i.test(navigator.userAgent)) {
		$('.EastWeather').click(function() {
			
			location.href = 'http://fusion.qq.com/cgi-bin/qzapps/unified_jump?appid=12259786&from=wx&isTimeline=false&actionFlag=0&params=pname%3Dcom.orientweather%26versioncode%3D8%26channelid%3D%26actionflag%3D0';
		})
	} else {
		$('.EastWeather').click(function() {
			$('#popup').popup();
		});
		$('#popup .weui-popup-modal').click(function() {
			location.href = 'http://app.qq.com/#id=detail&appid=1105261925';
		})
	}
	//		if(/Linux/i.test(navigator.userAgent)) {
	//			document.write("This is Linux'browser."); //这是Linux平台下浏览器
	//		}
	//
	//		if(/Linux/i.test(navigator.platform)) {
	//			document.write("This is Linux operating system."); //这是Linux操作系统平台
	//		}
	//		if(/MicroMessenger/i.test(navigator.userAgent)) {
	//			document.write("This is MicroMessenger'browser."); //这是微信平台下浏览器
	//		}
}
$(document).ready(function() {
	checkPlatform();
});