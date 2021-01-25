using System;
using System.Collections.Generic;
using System.Text;
using GameDemoHW.Abstract;
using GameDemoHW.Entities;

namespace GameDemoHW.Concrete
{
    class EDevletManager : IEDevletService

    {
        public bool ValidCustomer()
        {
            Console.WriteLine("E-Devlet girişiniz onaylandı.");
            return true;
        }


    }
}