﻿using BabyStroller.SDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Lib
{
    public class Sheep : IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meeeee!");
            }
        }
    }
}
