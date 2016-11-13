# ASP.NET-WebHook-Preview-Demo
Microsoft ASP.NET WebHook Preview 的測試專案，Receiver 專案可透過不同的Id來處理不同的 Sender 系統.

### Usage
- using Visual Studio 2015 open WebHookDemo.sln
- WebHook 的 DB 請俢改 WebHookDemo.Sender 專案中 web.config 的 MS_SqlStoreConnectionString 設定值 
- 建立 WebHook 的資料庫時，請先專啟始專案設定成 WebHookDemo.Sender 專案 ，然後到 Package Manager Console 中下 update-database 
- 說明可參考:[Microsoft ASP.NET WebHook Preview](https://dotblogs.com.tw/rainmaker/2016/11/06/152425) 
- ![UI](https://github.com/rainmakerho/ASP.NET-WebHook-Preview-Demo/blob/master/SubscribeImage.png?raw=true)
- ![DefaultHookHandler](https://github.com/rainmakerho/ASP.NET-WebHook-Preview-Demo/blob/master/DefaultHookHandler.png?raw=true)
- ![ProductHookHandler](https://github.com/rainmakerho/ASP.NET-WebHook-Preview-Demo/blob/master/ProductHookHandler.png?raw=true)
- ![registrations](https://github.com/rainmakerho/ASP.NET-WebHook-Preview-Demo/blob/master/registrations.png?raw=true)


### 學習目標
- 使用 Microsoft ASP.NET WebHook Preview 來測試 WebHook 的功能
- Receiver 可以處理不同的 Sender 系統，透過區分 context?.Id 的方式

