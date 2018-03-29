using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.ApplicationInsights;

namespace ReferenceNewerAppInsights
{
    public static class Function1
    {
        private static TelemetryClient telemetry = new TelemetryClient(new Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration
            { InstrumentationKey = Environment.GetEnvironmentVariable("APPINSIGHTS_INSTRUMENTATIONKEY")
            });

        /// <summary>
        /// Works fine in v1 with 2.5.1
        /// </summary>
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");
            telemetry.TrackEvent("CustomEvent");
            telemetry.Flush();
        }
    }
}
