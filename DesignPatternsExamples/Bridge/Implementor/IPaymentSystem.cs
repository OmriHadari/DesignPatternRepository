﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Implementor Interface
    /// </summary>
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}
