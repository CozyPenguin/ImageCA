﻿using System;
using ImageCA.Logging;

namespace ImageCA.Colors
{
    public static class ColConverter
    {

        public static ColorHSV ToHSV(ColorRGB inputColor)
        {
            Logger.Log("Color processing RGB -> HSV started.", LogLevel.Info);

            ColorHSV outputColor = new ColorHSV();

            double rVal = inputColor.R / 255;
            double gVal = inputColor.G / 255;
            double bVal = inputColor.B / 255;

            double max = Math.Max(Math.Max(rVal, gVal), bVal);
            double min = Math.Min(Math.Min(rVal, gVal), bVal);

            if (max == min) outputColor.H = 0;
            else if (max == rVal) outputColor.H = 60 * (0 + ((gVal - bVal) / (max - min)));
            else if (max == gVal) outputColor.H = 60 * (2 + ((bVal - rVal) / (max - min)));
            else if (max == bVal) outputColor.H = 60 * (4 + ((rVal - gVal) / (max - min)));

            if (outputColor.H < 0.0) outputColor.H += 360;

            if (max == 0 || min == 1) outputColor.S = 0;
            else outputColor.S = (max - min) / (1 - Math.Abs(max + min - 1));

            outputColor.V = max;

            return (outputColor);
        }
    }
}
