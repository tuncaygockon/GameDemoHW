using GameDemoHW.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoHW.Abstract
{
    interface ICustomerService
    {
        void SignUp(Customer customer);
        void Update();
        void Delete(string customerName, string customerPassword);
    }
}
