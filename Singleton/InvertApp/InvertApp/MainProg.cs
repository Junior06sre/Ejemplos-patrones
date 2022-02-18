using System;

namespace InvertApp
{
    class MainProg
    {
        public void MainMenu()
        {
            try
            {
                int MainMenuOption;

                MenuMantenimientoCategoria menuMantenimientoCategoria = new MenuMantenimientoCategoria();
                MenuMantenimientoProducto menuMantenimientoproducto = new MenuMantenimientoProducto();
                Inventory entradaInventario = new Inventory();


                Console.Clear();

                Console.WriteLine("     InvertApp     \n");
                Console.WriteLine("1. Mantenimiento de categorías \n2. Mantenimientos de productos " +
                    "\n3. Entrada de inventario \n4. Salida de inventario \n5. Salir");
                MainMenuOption = Convert.ToInt32(Console.ReadLine());

                switch (MainMenuOption)
                {
                    case (int)EnumMainProg.MANT_CATEGORIAS:
                        menuMantenimientoCategoria.MenuMaintenace_Categorias();
                        break;
                    case (int)EnumMainProg.MANT_PRODUCTOS:
                        menuMantenimientoproducto.MenuMaintenace_Productos();
                        break;
                    case (int)EnumMainProg.ENTRADA_INV:
                        entradaInventario.EntrInv();
                        break;
                    case (int)EnumMainProg.SALIDA_INV:
                        entradaInventario.SalidaInv();
                        break;
                    case (int)EnumMainProg.SALIR:
                        Console.WriteLine("Salir");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción en silla de ruedas, es decir, INVALIDA");
                        Console.ReadKey();
                        MainMenu();
                        break;
                } 
            }
            catch (Exception)
            {
                Console.WriteLine("Este valor es como tú, un ERROR. \nNah no es cierto, intenta algo más :D");
                Console.ReadKey();
                MainMenu();
            }
        }
    }
}
