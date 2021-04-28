using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            main.Start();
        }

        void Start()
        {
            BatchProcessor batch = new BatchProcessor();

            CallDataLoader callDL = new CallDataLoader();
            TwitterDataLoader twitterDL = new TwitterDataLoader();
            SensorDataLoader sensorDL = new SensorDataLoader();

            batch.AddBigDataLoader(callDL);
            batch.AddBigDataLoader(twitterDL);
            batch.AddBigDataLoader(sensorDL);

            batch.ProcessBatch();
        }
    }
}
