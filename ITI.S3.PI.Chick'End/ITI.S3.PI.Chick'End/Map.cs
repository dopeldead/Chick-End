﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.S3.PI.Chick_End
{
    public class Map
    {
        MapElement[,] _mapElements;

        internal Map()
        {
            MapElement[,] _mapElements = new MapElement[15,15];
        }
    }
}
