using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_pruebas1
{
    internal class Global
    {
        public static Form regreso = new Form1();
        public static Form prod2 = new Producto2();
        public static Form prod1 = new Producto1();
        public static Form productos = new PaginaClientes();
        public static Form admin = new PaginaAdministrador();
        public static Form ContraseñaAdmin = new ContraseñaAdmin();
        public static Form pedidos = new PantallaPago();
        public static Form PaginaAdmin = new PaginaAdministrador();
        public static int precioproducto1=219, precioproducto2=399;
        public static bool america;
    }
}
