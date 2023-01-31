using System;
using System.Collections.Generic;
using System.Text;

namespace CHomeWork10
{
    internal class Huawei:ITelephone
    {
        int _number;
        public void Call(int phoneNumber)
        {
            _number += phoneNumber;
        }
    }
}
