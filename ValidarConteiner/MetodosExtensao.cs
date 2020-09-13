using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarConteiner
{
    public static class MetodosExtensao
    {
        public static bool IsLetter(this string palavra)
        {
            bool retorno = true;
            foreach (char letra in palavra)
            {
                if (!Char.IsLetter(letra))
                    return false;
            }
            return retorno;
        }
    }
}
