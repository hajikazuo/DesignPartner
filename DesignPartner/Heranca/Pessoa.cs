﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPartner.Heranca
{
    public class Pessoa
    {
        public string Nome;
        public void Dormir()
        {
            Console.WriteLine($"{Nome} dormindo...");
        }
    }
}
