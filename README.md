# BTSEClient.Net
BTSE Client C# .Net Core

Client for BTSE API

Both spot and futures are supported
REST only as of now. No Web Sockets support.

How to use: 

1. Open Soultion file in Visual Studio and build it.
2. Go to /BTSEClient/BtseApi.Client/jsconfig.json and fill in your BTSE Prod and/or Testnet ApiKey and SecretKey. If you want to turn on Prod version (not testnet) set IsProduction to true in this file
3. You can start using the Client. See NUnit tests for Client use examples.

How to install and use from Nuget Pakcge Manager
1. Find and install BtseApi.Client
2. Edit jsconfig.json file.
3. Start using BTSE API. For example: 
   var info = BtseApi.Client.Operations.Spot.PublicEndpoints.MarketSummary.ExecuteObj("BTC-USD");
