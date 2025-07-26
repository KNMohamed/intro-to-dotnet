using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpLogging(loggingOptions =>
loggingOptions.LoggingFields = HttpLoggingFields.RequestPropertiesAndHeaders);

var app = builder.Build();

app.UseHttpLogging();

app.Run();