﻿using CreationalDP.Interfaces;
using CreationalDP.Qutoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.Factories
{
    public class LongQuoteFactory : IQuoteFactory
    {
        public IQuote CreateQuote()
        {
            return new LongQuote();
        }
    }
}
