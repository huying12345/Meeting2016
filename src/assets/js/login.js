//登陆功能
var loginViewModel = function () {
    var self = this;
    self.beforeBinding = function () {

    }
    self.login = function () {
        //15618714866
        var tel = $("#LoginForm_phone").val();
        var pwd = $("#LoginForm_password").val();
        YamonAPI.POST('/api/Member/MemberInfo/MemberLogin',
            {
                phone: tel,
                password: pwd,
                validate: ''
            },
            function (result) {
                alert(result.MemberInfo.MemberName)
                if (result.success == true) {
                    $.cookie('__isMemberLogin', 1);
                    $.cookie('MemberName', result.MemberInfo.MemberName);
                    $.cookie('MemberNo', result.MemberInfo.MemberNo);
                    window.location.href = "my.html"
                } else {
                    alert(result.message);
                }
            });
    }
}


var myViewModel = function () {
    if ($.cookie('__isMemberLogin') != null) {
        $(".weui_media_title").text($.cookie('MemberName'));
    } else {
        alert("请先登录!");
        window.location.href = "Login.html";
    }    
}

