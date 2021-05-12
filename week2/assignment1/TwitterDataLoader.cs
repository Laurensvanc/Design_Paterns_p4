﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class TwitterDataLoader : BigDataLoader
    {
        public override void Extract()
        {
            Console.WriteLine("extracting twitter data...");
        }

        public override void Transform()
        {
            Console.WriteLine("transforming twitter data...");
        }
    }
}
