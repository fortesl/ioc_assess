﻿using System;

namespace CarAppIOC
{
    public class ConsoleLog : ILog
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
