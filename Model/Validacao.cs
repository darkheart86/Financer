using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Model
{
    public class Validacao
    {

        public static bool validarData(string str)
        {
            Regex r = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            return r.Match(str).Success;
        }
    }
}
