using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class MenuMantenimientoCategoria
    {
        ServiceCategoria serviceCategoria = new ServiceCategoria();

        public void MenuMaintenace_Categorias()
        {
            try
            {
                MainProg mainProg = new MainProg();
                
                int MaintenaceMenuOption;

                Console.Clear();

                Console.WriteLine("   Mantenimiento de categorías   \n");
                Console.WriteLine("1. Agregar categoría \n2. Editar categoría " +
                    "\n3. Eliminar categoría \n4. Listar categorías \n5. Volver atrás");
                MaintenaceMenuOption = Convert.ToInt32(Console.ReadLine());

                switch (MaintenaceMenuOption)
                {
                    case (int)CRUOptions.ADD:
                        serviceCategoria.Add();
                        MenuMaintenace_Categorias();
                        break;
                    case (int)CRUOptions.EDIT:
                        serviceCategoria.Edit();
                        MenuMaintenace_Categorias();
                        break;
                    case (int)CRUOptions.DELETE:
                        serviceCategoria.Delete();
                        MenuMaintenace_Categorias();
                        break;
                    case (int)CRUOptions.LIST:
                        serviceCategoria.List();
                        Console.ReadKey();
                        MenuMaintenace_Categorias();
                        break;
                    case (int)CRUOptions.BACK:
                        mainProg.MainMenu();
                        break;
                    default:
                        Console.WriteLine("Opción en silla de ruedas, es decir, INVALIDA");
                        Console.ReadKey();
                        MenuMaintenace_Categorias();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Este valor es como tú, un ERROR. \nNah no es cierto, intenta algo más :D");
                Console.ReadKey();
                MenuMaintenace_Categorias();
            }
        }
    }
}
