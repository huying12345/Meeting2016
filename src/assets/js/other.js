var docApiUrl = "http://localhost:44576"; //本地：http://localhost:44576、发布时为空
//多级文章
var NewViewModel = function() {
	var self = this;
	self.InfoList = ko.observableArray([]);
	self.init = function(id) {
		self.GetInfoList(id);
	}
	self.GetInfoList = function(id) {
		$.ajax({
			type: "post",
			url: docApiUrl + "/api/Doc/DocInformationView/GetInfoList/"+id,
			dataType: 'JSON',
			
			success: function(data) {	
				for(var i = 0; i < data["data"].length; i++) {
					self.InfoList.push(data["data"][i]);
				}
			}
		});
	}
}

//单个文章
var ProgrammeViewModel=function(){
	var self=this;
	self.list=ko.observableArray([]);
	self.init=function(id){
		self.GetInfo(id);
	}
	self.GetInfo=function(id){
		$.ajax({
			type:"post",
			url:docApiUrl + '/api/Doc/DocInformationView/GetInfo/'+id,
			dataType:'json',
			async: false,
			success:function(data){
				self.list.push(data["data"]);
			}
		});
	}
}	

//获取网址传递的参数
function GetQueryString(name) {
	var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
	var r = window.location.search.substr(1).match(reg);
	if(r != null) return unescape(r[2]);
	return null;
}
