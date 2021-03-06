﻿using System;
using MyNatsClient.Logging;

namespace MyNatsClient
{
    public static class LoggerManager
    {
        public static Func<Type, ILogger> Resolve { get; set; } = t => NullLogger.Instance;
    }
}