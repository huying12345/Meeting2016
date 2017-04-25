//空气质量页面
var KQViewModel=function(){
	var self = this;
	self.listForecast = ko.observableArray([]);
	self.airForecast = ko.observableArray([]);
	self.init = function() {
			self.GetSHAQI(); //空气质量s实况
			self.GetAirForecast(); //空气质量预报
		}
	self.GetSHAQI = function() {
			$.ajax({
				type: "post",
				url: "http://bswx.yamon.cn/api/Weather/Soweather/GetSHAQI",
				dataType: 'JSON',
				success: function(data) {
					self.listForecast.push(data["data"]);
					GetAQI(data["data"].AQI);
				}
			});
		}
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
}
//空气质量实况图例
function GetAQI(aqispans){
			var aqis = aqispans.replace(/\s*/g, "");
			if(aqis != "") {
				jQuery(".imgs").animate({
					marginLeft: '+' + jQuery('#progressbar').width() / 350 * jQuery('#aqispan').text() + 'px'
				}, 1000);
				jQuery("#dq_text").hide();
				jQuery("#left_aqi").show();
				jQuery("#right_aqi").show();
			} else {
				jQuery("#left_aqi").hide();
				jQuery("#right_aqi").hide();
				jQuery("#dq_text").show();
			}
			var aqi = aqispan.replace(/\s*/g, "");
			if(aqi == "") {

				jQuery('#Influence').text("暂无数据");
				jQuery('#Suggest').text("暂无数据");
			}
}
//空气质量阶段详情
function GetAqi(num, v) {
	num=parseInt(num);
			var v1 = "";
			var v2 = "";
			var v3="";
			if(num >= 0 && num <= 50) {
				jQuery("#bg_imgs").addClass("img_right");
				v1 = "空气质量令人满意，基本无空气污染";
				v2 = "各类人群可正常活动";
				v3="#6BCD07";
			} else if(num >= 51 && num <= 100) {
				jQuery("#bg_imgs").addClass("img_right1");
				v1 = "空气质量可接受，但某些污染物可能对极少数异常敏感人群健康有较弱影响";
				v2 = "极少数异常敏感人群应减少户外活动";
				v3="#FBD029";
			} else if(num >= 101 && num <= 150) {
				jQuery("#bg_imgs").addClass("img_right2");
				v1 = "易感人群症状有轻度加剧，健康人群出现刺激症状";
				v2 = "儿童、老年人及心脏病、呼吸系统疾病患者应减少长时间、高强度的户外锻炼";
				v3="#FE8800";
			} else if(num >= 151 && num <= 200) {
				jQuery("#bg_imgs").addClass("img_right3");
				v1 = "进一步加剧易感人群症状，可能对健康人群心脏、呼吸系统有影响";
				v2 = ("儿童、老年人及心脏病、呼吸系统疾病患者避免长时间、高强度的户外锻炼，一般人群适量减少户外运动");
				v3="#FE0000";
			} else if(num >= 201 && num <= 300) {
				jQuery("#bg_imgs").addClass("img_right4");
				v1 = "心脏病和肺病患者症状显著加剧，运动耐受力降低，健康人群普遍出现症状";
				v2 = "儿童、老年人及心脏病、肺病患者应停留在室内，停止户外运动，一般人群减少户外运动";
				v3="#CC0001";
			} else {
				jQuery("#bg_imgs").addClass("img_right5");
				v1 = "健康人群运动耐受力降低，有明显强烈症状，提前出现某些疾病";
				v2 = "儿童、老年人和病人应停留在室内，避免体力消耗，一般人群避免户外活动";
				v3="#970454";
			}
			if(v == 1) {
				return v1;
			} else if(v == 2) {
				return v2;
			}else if(v == 3) {
				return v3;
			}
		}
