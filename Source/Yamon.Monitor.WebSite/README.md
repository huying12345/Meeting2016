#重新预编译web文件



Install-Package Microsoft.AspNet.Mvc -Version 4.0.40804.0
Install-Package Microsoft.AspNet.Mvc.zh-Hans -Version 4.0.40804.0
Install-Package Microsoft.AspNet.Razor.zh-Hans -Version 2.0.30506.0
Install-Package RazorGenerator.Mvc -Version 2.4.2

Enable-RazorGenerator

Redo-RazorGenerator Yamon.Module.Monitor.Web;Redo-RazorGenerator  Yamon.Module.ServiceUser.Web;Redo-RazorGenerator  Yamon.Module.OnePublish.Web;Redo-RazorGenerator Yamon.Metting2017.WebSite

