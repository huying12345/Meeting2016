var docApiUrl = ""; //本地：http://localhost:44576、发布时为空
var ProfileViewModel = function() {
	var self = this;
	self.airForecast = ko.observableArray([]);
	self.hourWeatherForecast = ko.observableArray([]);
	self.stationData = ko.observableArray([]);
	self.soWeatherData = ko.observableArray([]);
	self.init = function() {
			self.GetStationDataNowByStaIds(); //根据站号获取最新数据（雨量、气温、风向、风速、湿度）
			self.GetAirForecast(); //空气质量预报
			self.GetHourWeatherForecast(); //整点预报
			self.GetSoWeatherData(); //获取搜weather网站数据
			self.GetSHAQI(); //空气质量s实况
		}
		//根据站号获取最新数据（雨量、气温、风向、风速、湿度）
	self.GetStationDataNowByStaIds = function() {
			$.ajax({
				url: 'http://bswx.yamon.cn/api/Weather/Cimiss/GetStationDataNowByStaIds?staIds=58461',
				type: 'POST',
				dataType: 'JSON',
				success: function(data) {
					self.stationData.push(data["data"]);
				}
			});
		}
		//空气质量预报
	self.GetAirForecast = function() {
			$.ajax({
				type: "post",
				url: "http://bswx.yamon.cn/api/Weather/Soweather/GetSoWeatherData?dataType=GetAirForecast",
				dataType: 'JSON',
				success: function(data) {
					$(".top_P_date").text(data["data"].PublishTime);
					var list = data["data"].data;
					for(var i = 0; i < list.length; i++) {
						self.airForecast.push(list[i]);
					}
				}
			});
		}
		//整点预报
	self.GetHourWeatherForecast = function() {
			$.ajax({
				type: "post",
				url: "http://bswx.yamon.cn/api/Weather/Soweather/GetHourWeatherForecast",
				dataType: 'JSON',
				success: function(data) {
					setTimeout(function() {
						$("#weather_icon").attr("class", "iconfont icon-weather-" + data["data"][0].WeatherPY1)
					}, 1000)
					var list = data["data"];
					for(var i = 0; i < list.length; i++) {
						self.hourWeatherForecast.push(list[i]);
					}
					var mySwiper = new Swiper('#weatherSwiper', {
						slidesPerView: 4,
						paginationClickable: true,
						freeMode: true
					});
				}
			});
		}
		//空气质量实况
	self.GetSHAQI = function() {
			$.ajax({
				type: "post",
				url: "http://bswx.yamon.cn/api/Weather/Soweather/GetSHAQI",
				dataType: 'JSON',
				success: function(data) {
					//					$.showLoading();
					setTimeout(function() {
						//						$.hideLoading();
						$("#GradeText").html("&nbsp;&nbsp;" + data["data"].GradeText);
						$("#PM span").html("&nbsp;" + data["data"].PM25);
						$("#PM p").css("border", "1px solid " + GetAqi(data["data"].AQI, '3'));
					}, 1000)

				}
			});
		}
		//获取搜weather网站数据
	self.GetSoWeatherData = function() {
		$.ajax({
			type: "post",
			url: "http://bswx.yamon.cn/api/Weather/Soweather/GetSoWeatherData?dataType=WeatherForecast",
			dataType: 'JSON',
			success: function(data) {
				var list = data["data"];
				for(var i = 0; i < list.length; i++) {
					self.soWeatherData.push(list[i]);
					MinTemp.push(list[i].MinTemp);
					MaxTemp.push(list[i].MaxTemp);
				}
				Echarts();

				if(GetQueryString("id") == "tab2") {
					$("[href='#tab1']").attr("class", "weui_navbar_item swiper-slide");
					$("[href='#tab2']").attr("class", "weui_navbar_item swiper-slide active_on");
					$("#tab1").attr("class", "weui_tab_bd_item");
					$("#tab2").attr("class", "weui_tab_bd_item weui_tab_bd_item_active");
				}
			}
		});
	}
}

var mySwiper = new Swiper('#swiper-container1', {
	autoplay: 2000,
	loop: true,
	pagination: '.swiper-pagination',
	observer: true, //修改swiper自己或子元素时，自动初始化swiper
	observeParents: true, //修改swiper的父元素时，自动初始化swiper
});
var mySwiper = new Swiper('.container2', {
	pagination: '.swiper-pagination',
	autoplay: false,
	loop: true,
	pagination: '.swiper-pagination',
	paginationType: 'progress',
	observer: true, //修改swiper自己或子元素时，自动初始化swiper
	observeParents: true, //修改swiper的父元素时，自动初始化swiper

});
var mySwiper = new Swiper('.container1', {
	autoplay: false,
	loop: true,
	pagination: '.swiper-pagination',
	observer: true, //修改swiper自己或子元素时，自动初始化swiper
	observeParents: true, //修改swiper的父元素时，自动初始化swiper

});

//酒店简介切换效果
$('#weui_tab_bd2 .navbar a').click(function() {
	var index = $(this).index();
	$(this).addClass('bar_item_on').siblings().removeClass('bar_item_on');
	$('.tab_bd_item').eq(index).addClass('tab_bd_item_active').siblings().removeClass('tab_bd_item_active');
})

$(function() {
	$('#line').click(function() {
		$(this).css('color', '#10AEFF');
		window.location.href = 'http://cn.ihg.com/crowneplaza/shgqr/hoteldetail';
	});
	var onoff = true;
	$('#dingwei').click(function() {
		if(onoff == false) {
			$('.roteLines ul').animate({
				right: '15%',
			}, 500);
		} else {
			$('.roteLines ul').animate({
				right: '-200px',
			}, 500);
			$('.dtLine').hide();
		}
		onoff = !onoff;
	});
	$('#gjLine').click(function() {
		$('.gjLine').toggle();
	})
	$('#dtLine').click(function() {
		$('.dtLine').toggle();
		$('.gjLine').hide();
	});
	$('.dtLine').click(function() {
		$(this).hide();
	})
	$('.gjLine').click(function() {
		$(this).hide();
	});

});

//获取网址传递的参数
function GetQueryString(name) {
	var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
	var r = window.location.search.substr(1).match(reg);
	if(r != null) return unescape(r[2]);
	return null;
}
//天气预报曲线图
function Echarts() {
	var myChart = echarts.init(document.getElementById('Echarts'));
	var option = {
		tooltip: {
			trigger: 'item'
		},
		xAxis: {
			show: false,
			type: 'category',
			boundaryGap: false,
			data: []
		},
		yAxis: {
			show: false,
		},
		series: [{
			name: '最高气温',
			type: 'line',
			smooth: true,
			symbolSize: 5,
			symbol: 'circle',
			showAllSymbol: true,
			itemStyle: {
				normal: {
					color: '#fff',
					borderWidth: 0.3,
					label: {
						show: true,
						formatter: '{c}℃',
						position: 'top',
						textStyle: {
							fontWeight: '100',
							fontSize: '16',
							color: '#fff'
						}
					},
					lineStyle: {
						color: '#FF8F59',
						width: 2
					}
				}
			},
			data: MaxTemp,
			markLine: {}
		}, {
			name: '最低气温',
			type: 'line',
			smooth: true,
			symbolSize: 5,
			symbol: 'circle',
			showAllSymbol: true,
			itemStyle: {
				normal: {
					color: '#fff',
					borderWidth: 0.3,
					label: {
						show: true,
						formatter: '{c}℃',
						position: 'bottom',
						textStyle: {
							fontWeight: '100',
							fontSize: '16',
							color: '#fff'
						}
					},
					lineStyle: {
						color: '#84C1FF',
						width: 2
					}
				}
			},
			data: MinTemp,
			markLine: {}
		}]
	};
	myChart.setOption(option);
	window.onresize = myChart.resize;
}