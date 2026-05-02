using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;

namespace Dsw2026Ej8
{
    internal class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            
            return code.ToProductCode();
        }
    }
    
}
