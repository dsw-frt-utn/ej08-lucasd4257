using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }

    internal class Sale
    {
        protected decimal numero;

        public Sale(decimal numero)
        {
            this.numero = numero;
        }

        public virtual decimal CalculateTotal()
        {
            return numero;
        }
    }

    internal class RetailSale : Sale
    {
        public RetailSale(decimal numero) : base(numero)
        {
        }
        public override decimal CalculateTotal()
        {
            return numero;
        }
    }

    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal numero) : base(numero)
        {
        }
        public override decimal CalculateTotal()
        {
            return numero * (decimal)0.9;
        }
    }
}
