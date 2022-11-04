using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseKestrel()
    .ConfigureKestrel((context, options) =>
    {
        options.ListenAnyIP(5000, listenOptions =>
        {
            listenOptions.UseConnectionLogging();
            listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
        });
        options.ListenAnyIP(5001, listenOptions =>
        {
            listenOptions.UseHttps();
            listenOptions.UseConnectionLogging();
            listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
        });
        options.ListenAnyIP(5002, listenOptions =>
        {
            listenOptions.UseConnectionLogging();
            listenOptions.UseHttps(StoreName.My, "localhost");
            listenOptions.Protocols = HttpProtocols.Http3;
        });
    });
