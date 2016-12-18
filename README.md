# Abp.Web.Api.Restc
 visualize REST requests RESTful 接口调试分享利器

这个工具来自于https://elemefe.github.io/restc/  


restc 的原理是根据请求头中的 accept 字段来判断请求是来自浏览器页面打开还是 ajax 请求（直接用页面打开时浏览器的 accept 会包含 text/html）。   

对于浏览器页面打开的请求将对其渲染测试工具的 UI 界面。    

 ![image](https://raw.githubusercontent.com/yuzukwok/Abp.Web.Api.Restc/master/screenshot/1.png)

* 引入成本低：可以低成本地引入到绝大多数现有的 Web API 项目中。
* 使用方便：客户端无需下载额外的软件或插件，在任何现代浏览器中直接访问 API endpoint 即可调试该 API。
* 便于分享：由于是直接访问 API endpoint，因此可以很方便地分享某个请求。


