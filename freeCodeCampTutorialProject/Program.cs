﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freeCodeCampTutorialProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();


            Console.ReadLine();
        }
        
            

    }
}
