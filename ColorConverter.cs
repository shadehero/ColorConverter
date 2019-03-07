using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ColorConverter
{
	public class ColorConverter
	{
		public static ConsoleColor ToConsoleColor(Color c)
		{
			// Transform Color to 8bit
			Bitmap pixelColor = new Bitmap(1, 1);
			pixelColor.SetPixel(0, 0, c);
			Bitmap pixelColor8Bit = pixelColor.Clone(new Rectangle(0, 0, pixelColor.Width, pixelColor.Height), PixelFormat.Format4bppIndexed);
			Color color8bit = pixelColor8Bit.GetPixel(0, 0);
			Color[] palete8bit = pixelColor8Bit.Palette.Entries;

			if (color8bit == palete8bit[0]) { return ConsoleColor.Black; }
			else if (color8bit == palete8bit[1]) { return ConsoleColor.Blue; }
			else if (color8bit == palete8bit[3]) { return ConsoleColor.Green; }
			else if (color8bit == palete8bit[4]) { return ConsoleColor.Cyan; }
			else if (color8bit == palete8bit[5]) { return ConsoleColor.Red; }
			else if (color8bit == palete8bit[6]) { return ConsoleColor.Magenta; }
			else if (color8bit == palete8bit[7]) { return ConsoleColor.White; }
			else if (color8bit == palete8bit[8]) { return ConsoleColor.Yellow; }
			else if (color8bit == palete8bit[9]) { return ConsoleColor.Gray; }
			else if (color8bit == palete8bit[10]) { return ConsoleColor.DarkGray; }
			else if (color8bit == palete8bit[11]) { return ConsoleColor.DarkRed; }
			else if (color8bit == palete8bit[12]) { return ConsoleColor.DarkGreen; }
			else if (color8bit == palete8bit[13]) { return ConsoleColor.DarkBlue; }
			else if (color8bit == palete8bit[14]) { return ConsoleColor.DarkYellow; }
			else if (color8bit == palete8bit[15]) { return ConsoleColor.DarkMagenta; }
			else if (color8bit == palete8bit[16]) { return ConsoleColor.DarkCyan; }
			else { return Console.ForegroundColor; }
		}
	}
}
