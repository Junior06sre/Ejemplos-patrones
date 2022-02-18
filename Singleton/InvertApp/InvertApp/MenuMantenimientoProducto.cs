using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class MenuMantenimientoProducto
    {
        ServiceProducto serviceProducto = new ServiceProducto();
        public void MenuMaintenace_Productos()
        {
            try
            {
                MainProg mainProg = new MainProg();
                int MaintenaceMenuOption;

                Console.Clear();

                Console.WriteLine("   Mantenimiento de Productos   \n");
                Console.WriteLine("1. Agregar producto \n2. Editar producto " +
                    "\n3. Eliminar producto \n4. Listar producto \n5. Volver atrás");
                MaintenaceMenuOption = Convert.ToInt32(Console.ReadLine());

                switch (MaintenaceMenuOption)
                {
                    case (int)CRUOptions.ADD:
                        serviceProducto.Add();
                        MenuMaintenace_Productos();
                        break;
                    case (int)CRUOptions.EDIT:
                        serviceProducto.Edit();
                        MenuMaintenace_Productos();
                        break;
                    case (int)CRUOptions.DELETE:
                        serviceProducto.Delete();
                        MenuMaintenace_Productos();
                        break;
                    case (int)CRUOptions.LIST:
                        serviceProducto.List();
                        Console.ReadKey();
                        MenuMaintenace_Productos();
                        break;
                    case (int)CRUOptions.BACK:
                        mainProg.MainMenu();
                        break;
                    default:
                        Console.WriteLine("Opción en silla de ruedas, es decir, INVALIDA");
                        Console.ReadKey();
                        MenuMaintenace_Productos();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Este valor es como tú, un ERROR. \nNah no es cierto, intenta algo más :D");
                Console.ReadKey();
                MenuMaintenace_Productos();
            }
        }
    }
}
