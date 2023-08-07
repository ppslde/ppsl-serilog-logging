using Microsoft.AspNetCore.Builder;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using Serilog.Templates;
using Serilog.Templates.Themes;

namespace Ppsl.Serilog.Logging;

public static class ConfigureServices
{
    public static WebApplicationBuilder AddLogging(this WebApplicationBuilder builder, string logfile)
    {
        Logger logger = new LoggerConfiguration()
          .MinimumLevel.Information()
          .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
          .Enrich.FromLogContext()
          .Enrich.WithExceptionDetails()
          .Enrich.WithEnvironmentName()
          .Enrich.WithMachineName()
          .Enrich.WithProcessId()
          .Enrich.WithProcessName()
          .Enrich.WithThreadId()
          .Destructure.ToMaximumDepth(4)
          .Destructure.ToMaximumStringLength(80)
          .Destructure.ToMaximumCollectionCount(5)
          .ReadFrom.Configuration(builder.Configuration)
          .WriteTo.Async(w =>
            w.File(
                 new CompactJsonFormatter(),
                logfile,
                rollingInterval: RollingInterval.Day,
                rollOnFileSizeLimit: true,
                fileSizeLimitBytes: 10485760,
                retainedFileCountLimit: 7,
                flushToDiskInterval: TimeSpan.FromSeconds(10),
                shared: true
            ))
          .WriteTo.Async(w =>
            w.Console(
                new ExpressionTemplate(
                        "[{@t:HH:mm:ss:ffffff}][{@l:u3}]" +
                                "{#if SourceContext is not null}[{SourceContext}]{#end}" +
                                "{#if ProcessId is not null}[{ProcessId}]{#end}" +
                                "{#if ThreadId is not null}[{ThreadId}]{#end}" +
                                "{#if RequestId is not null}[{RequestId}]{#end}" +
                                "{#if RequestPath is not null}[{RequestPath}]{#end}" +
                                " {@m}\n{@x}",
                        theme: TemplateTheme.Literate)
            ))
          .CreateLogger();

        builder.Host.UseSerilog(logger);

        return builder;
    }
}