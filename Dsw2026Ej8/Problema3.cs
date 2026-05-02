using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int orginalValue, Product product)
        {
            int copiaValue = orginalValue;
            copiaValue++;

            Product copiaProduct = product;

            copiaProduct.SetDescription("Modificado");

            return $"{orginalValue}-{copiaValue}-{product.GetDescription}";
        }
    }

    internal class Product
    {

        private string description = "Original";

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

    }
}
