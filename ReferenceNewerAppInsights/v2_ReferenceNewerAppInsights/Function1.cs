using System;
using Microsoft.ApplicationInsights;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace v2_ReferenceNewerAppInsights
{
    public static class Function1
    {
        private static TelemetryClient telemetry = new TelemetryClient(new Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration
            { InstrumentationKey = Environment.GetEnvironmentVariable("APPINSIGHTS_INSTRUMENTATIONKEY")
        });

        /// <summary>
        /// Throws an exception System.Private.CoreLib: Exception while executing function: Function1. v2_ReferenceNewerAppInsights: Could not load file or assembly 'Microsoft.ApplicationInsights, Version=2.5.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'. Could not find or load a specific file. (Exception from HRESULT: 0x80131621). System.Private.CoreLib: Could not load file or assembly 'Microsoft.ApplicationInsights, Version=2.5.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
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
