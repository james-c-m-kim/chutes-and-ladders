﻿using System;
using System.Collections.Generic;

namespace ShootsAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameShell().Start();
#if DEBUG
            Console.ReadLine();
#endif
        }
    }
}