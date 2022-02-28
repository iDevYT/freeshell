﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Color = System.ConsoleColor;
using Figgle;

namespace cmd_interprt
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.ForegroundColor = Color.Green;
            string welcome = FiggleFonts.Standard.Render("Welcome To Freeshell!");
            System.Console.WriteLine(welcome);
            Console.Write(">");
            string? input = Console.ReadLine();
            Console.WriteLine("running " + input);
            if (input == "help")
            {
              System.Console.WriteLine("FRESHELL.NET help \n no help now");
              Main(args);
            }
            if(input == "exit")
            {
                Environment.Exit(0);
            
            }
            if (input == "proj")
            {
                System.Console.WriteLine("FRESHELL.NET1 by iDev \n GH repo: https://github.com/iDevYT/freeshell \n Enjoy! ");
                Main(args);
            }
        }
    }
}