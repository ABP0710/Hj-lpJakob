using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HjælpJakob.Classes;

namespace HjælpJakob.Interfaces
{
    public interface IConverter
    {
        public abstract string ConvertBodyToHTML(string plainText);
    }
}
