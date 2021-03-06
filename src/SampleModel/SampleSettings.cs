﻿using MyNatsClient;

namespace SampleModel
{
    public static class SampleSettings
    {
        public static Host[] Hosts = { new Host("ubuntu01", 4222) };
        public static Credentials Credentials = new Credentials("test", "p@ssword1234");

        public static class TimedSample
        {
            public static int NumOfBatches = 5;
            public static int BatchSize = 100000;
            public static int BodyCharSize = 1;
        }
    }
}