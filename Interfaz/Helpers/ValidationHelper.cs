using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsTextFieldValid(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }
    }
}
