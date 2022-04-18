using CreationalDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.Qutoes
{
    public class ShortQuote : IQuote
    {
        public string GetQuote() => "Be you";
    }
}
