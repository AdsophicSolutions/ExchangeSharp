/*
MIT LICENSE

Copyright 2017 Digital Ruby, LLC - http://www.digitalruby.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/


using System;
using System.Collections.Generic;
using static System.Console; 
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExchangeSharp
{
    public static partial class ExchangeSharpConsole
    {
        public static void RunShowHelp(Dictionary<string, string> dict)
        {
            WriteLine("------------------------------------------------------------");
            WriteLine("ExchangeSharpConsole v. {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            WriteLine("------------------------------------------------------------");
            WriteLine("Command line arguments should be key=value pairs, separated by space. Please add quotes around any key/value pair with a space in it.");
            WriteLine();
            WriteLine("Command categories:");
            WriteLine("------------------------------------------------------------");
            WriteLine("help - Show this help screen, or just run without arguments to show help as well.");
            WriteLine();
            WriteLine("test - Run integrations test code against exchanges.");
            WriteLine(" test currently has no additional arguments.");
            WriteLine();
            WriteLine("export - export exchange data. CSV files have millisecond timestamp, price and amount columns. The export will also convert the CSV to bin files. This can take a long time depending on your sinceDateTime parameter.");
            WriteLine(" Please note that not all exchanges will let you do this and may ban your IP if you try to grab to much data at once. I've added sensible sleep statements to limit request rates.");
            WriteLine(" export exchange=gemini symbol=btcusd path=../../data/gemini sinceDateTime=20150101");
            WriteLine();
            WriteLine("convert - convert csv exchange data to bin files for optimized reading. Files are converted in place and csv files are left as is.");
            WriteLine(" convert symbol=btcusd path=../../data/gemini");
            WriteLine();
            WriteLine("stats - show stats from all exchanges. This is a great way to see the price, order book and other useful stats.");
            WriteLine(" stats currently has no additional arguments.");
            WriteLine();
            WriteLine("keys - encrypted API key file utility - this file is only valid for the current user and only on the computer it is created on.");
            WriteLine(" Create a key file:");
            WriteLine("  keys mode=create path=pathToKeyFile.bin keylist=key1,key2,key3,key4,etc.");
            WriteLine("  The keys parameter is comma separated and may contain any number of keys in any order.");
            WriteLine(" Display a key file:");
            WriteLine("  keys mode=display path=pathToKeyFile.bin");               
            WriteLine();
            WriteLine("example - simple example showing how to create an API instance and get the ticker, and place an order.");
            WriteLine(" example currently has no additional arguments.");
            WriteLine();
        }
    }
}
