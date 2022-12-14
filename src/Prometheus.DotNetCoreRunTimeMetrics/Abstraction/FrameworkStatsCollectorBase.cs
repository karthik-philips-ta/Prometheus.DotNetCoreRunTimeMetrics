using System;

namespace Prometheus.DotNetCoreRunTimeMetrics.Abstraction
{
    internal abstract class FrameworkStatsCollectorBase : StatsCollectorBase
    {
        protected FrameworkStatsCollectorBase(ICollectorExceptionHandler errorHandler)
            : base(errorHandler)
        {
        }

        protected sealed override Guid EventSourceGuid { get; } = Guid.Parse("8e9f5090-2d75-4d03-8a81-e5afbf85daf1");
    }
}