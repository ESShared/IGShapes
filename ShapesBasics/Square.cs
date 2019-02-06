﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesBasics
{
    public class Square
    {
        // The length of the square
        public int Length;

        public int CalculateArea()
        {
			// Return the area calculated for a square, which is just the length multiplied by itself.
            return Length * Length;
        }
    }
}
