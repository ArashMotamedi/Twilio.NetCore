# Twilio for .NET Standard (Core)
.NET Standard (Core) port of Twilio Rest Client library

## Install
From Nuget: **https://www.nuget.org/packages/Twilio.NetCore/1.0.0**

## About
This is an unofficial port of the [twilio-csharp](https://github.com/twilio/twilio-csharp) library for .Net Standard (Core). The original library is well organized and its sole dependency is on RestSharp. I replaced RestSharp with [RestSharp.NetCore](https://www.nuget.org/packages/RestSharp.NetCore/) and made a couple of small modifications on the `Core.cs` file to call RestSharp.NetCore's `ExecuteAsync` methods synchronously. 

## License
I offer this package in accordance with Twilio's original license agreement and under the exact same terms. I have not tested the ported library and offer no warranty with regards to its functionality or any consequences from the use of it whatsoever. This library is offered as a stop-gap solution until the awesome Twilio team releases a .Net Standard compatible library.

## Contribute
Be a hero and port the original Twilio unit tests!
