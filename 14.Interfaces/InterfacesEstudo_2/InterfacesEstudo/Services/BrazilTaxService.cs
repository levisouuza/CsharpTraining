﻿using System;


namespace InterfacesEstudo.Services
{
    class BrazilTaxService : ITaxService //realizacao de interface
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
