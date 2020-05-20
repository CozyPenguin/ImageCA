using System;


namespace ImageCA.Colors {
    /// <summary>
    /// Convert colors from one colorspace to another
    /// </summary>
    public static class ColConverter {
        /// <summary>
        /// Convert a color to HSV
        /// </summary>
        /// <param name="inputColor">The input color, a RGB color</param>
        /// <returns>HSV color equivalent of the input color</returns>
        [Obsolete ("Method is deprecated, please use the method provided by the color class (IColor.ToRGB())")]
        public static ColorHSV ToHSV (ColorRGB inputColor) {
            Debug.Log ("Color conversion RGB -> HSV started.", LogLevel.Info);

            ColorHSV outputColor = new ColorHSV ();

            double rVal = inputColor.R / 255;
            double gVal = inputColor.G / 255;
            double bVal = inputColor.B / 255;

            double max = Math.Max (Math.Max (rVal, gVal), bVal);
            double min = Math.Min (Math.Min (rVal, gVal), bVal);

            outputColor.V = max;

            if (max == 0 || min == 1) outputColor.S = 0;
            else outputColor.S = (max - min) / max;

            if (outputColor.S == 0) {
                outputColor.H = 0;

                Debug.Log ($"Color conversion RGB -> HSV finished. Output color is {outputColor}.", LogLevel.Info);
                return outputColor;
            }

            double delta = max - min;

            if (max == rVal) outputColor.H = (gVal - bVal) / delta;
            else if (max == gVal) outputColor.H = (bVal - rVal) / delta;
            else if (max == bVal) outputColor.H = (rVal - gVal) / delta;

            outputColor.H *= 60;

            if (outputColor.H < 0.0) outputColor.H += 360;

            Debug.Log ($"Color conversion RGB -> HSV finished. Output color is {outputColor}.", LogLevel.Info);

            return outputColor;
        }

        /// <summary>
        /// Convert a color to RGB
        /// </summary>
        /// <param name="inputColor">The input color, a HSV color</param>
        /// <returns>RGB color equivalent of the input color</returns>
        [Obsolete ("Method is deprecated, please use the method provided by the color class (IColor.ToRGB())")]
        public static ColorRGB ToRGB (ColorHSV inputColor) {
            Debug.Log ("Color conversion HSV -> RGB started.", LogLevel.Info);

            ColorRGB outputColor = new ColorRGB ();

            double hex = inputColor.H / 360;

            int main = (int) hex;
            double sub = hex - main;

            double var1 = (1 - inputColor.S) * inputColor.V;
            double var2 = (1 - (inputColor.S * sub)) * inputColor.V;
            double var3 = (1 - (inputColor.S * (1 - sub))) * inputColor.V;

            switch (main) {
                case 0:
                    outputColor.R = inputColor.V;
                    outputColor.G = var3;
                    outputColor.B = var1;
                    break;
                case 1:
                    outputColor.R = var2;
                    outputColor.G = inputColor.V;
                    outputColor.B = var1;
                    break;
                case 2:
                    outputColor.R = var1;
                    outputColor.G = inputColor.V;
                    outputColor.B = var3;
                    break;
                case 3:
                    outputColor.R = var1;
                    outputColor.G = var2;
                    outputColor.B = inputColor.V;
                    break;
                case 4:
                    outputColor.R = var3;
                    outputColor.G = var1;
                    outputColor.B = inputColor.V;
                    break;
                case 5:
                    outputColor.R = inputColor.V;
                    outputColor.G = var1;
                    outputColor.B = var2;
                    break;
                default:
                    throw new InvalidOperationException ("This behaviour is not intended. Please report this as a bug on https://github.com/CozyPenguin/ImageCA/issues. HSV -> RGB");
            }

            Debug.Log ($"Color conversion HSV -> RGB finished. Output color is {outputColor}.", LogLevel.Info);

            return outputColor;
        }
    }
}