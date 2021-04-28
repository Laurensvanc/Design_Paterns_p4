using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class BatchProcessor
    {
        private List<BigDataLoader> _bigDataLoaders = new List<BigDataLoader>();

        public void AddBigDataLoader(BigDataLoader loader)
        {
            _bigDataLoaders.Add(loader);
        }

        public void ProcessBatch()
        {
            foreach (BigDataLoader loader in _bigDataLoaders)
            {
                loader.InitETL();
                Console.WriteLine();
            }
        }
    }
}
