using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class ModificaTexto
    {
        public static string CenterText(string textExtern = "", string Space = " ")
        {
            // get the console width and subtract the text passed and divide for two 
            int width = (Console.BufferWidth - textExtern.Length) / 2;
            string newText = String.Empty;
            // here the new text give the space before the text 
            for (int i = 0; i < width; i++)
            {
                newText += Space;
            }
            // spaces more the text extern
            newText = newText + textExtern;
            // spaces more the text extern more spaces
            for (int i = 0; i < width; i++)
            {
                newText += Space;
            }
            //return the text centralized
            return newText;
        }
        public static void TextColor(string text, ConsoleColor color)
        {
            // received 2 arguments, with text and color
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void ColorRed(string text)
        {
            // received the argument (text) and pass for the TextColor with the color red
            TextColor(text, ConsoleColor.Red);
        }
        public static void ColorBlue(string text)
        {
            // received the argument (text) and pass for the TextColor with the color red
            TextColor(text, ConsoleColor.Blue);
        }
        public static void ColorCyan(string text)
        {
            // received the argument (text) and pass for the TextColor with the color red
            TextColor(text, ConsoleColor.Cyan);
        }
        public static void ColorGreen(string text)
        {
            // received the argument (text) and pass for the TextColor with the color red
            TextColor(text, ConsoleColor.Green);
        }
        public static void ColorYellow(string text)
        {
            // received the argument (text) and pass for the TextColor with the color red
            TextColor(text, ConsoleColor.Yellow);
        }
        public static void ColorMagenta(string text)
        {
            // received the argument (text) and pass for the TextColor with the color red
            TextColor(text, ConsoleColor.Magenta);
        }
    }
}
