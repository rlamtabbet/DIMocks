﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction.Interfaces
{
    public interface INotifier
    {
        void SendReceipt(OrderInfo orderInfo);
    }
}
