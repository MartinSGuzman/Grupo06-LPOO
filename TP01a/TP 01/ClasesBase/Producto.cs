using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private string Prod_Codigo;

        public string Prod_Codigo1
        {
            get { return Prod_Codigo; }
            set { Prod_Codigo = value; }
        }
        private string Prod_Categoria;

        public string Prod_Categoria1
        {
            get { return Prod_Categoria; }
            set { Prod_Categoria = value; }
        }
        private string Prod_Descripcion;

        public string Prod_Descripcion1
        {
            get { return Prod_Descripcion; }
            set { Prod_Descripcion = value; }
        }
        private decimal Prod_Precio;

        public decimal Prod_Precio1
        {
            get { return Prod_Precio; }
            set { Prod_Precio = value; }
        }
    }
}
