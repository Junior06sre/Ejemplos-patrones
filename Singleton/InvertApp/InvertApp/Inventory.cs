using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class Inventory
    {
        ServiceProducto serviceProducto = new ServiceProducto();
        MainProg mainProg = new MainProg();

        public void EntrInv()
        {
            try
            {
                ListCant();
                Console.WriteLine("A qué producto desea dar entrada? ");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qué cantidad desea agregar? ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Repository.Instance.productos[index - 1].Cantidad += cantidad;

                Console.WriteLine("Cantidad de producto actualizada");
                Console.ReadKey();
                mainProg.MainMenu();

            } catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
                mainProg.MainMenu();
            }

        }

        public void SalidaInv()
        {
            try
            {
                ListCant();
                Console.WriteLine("A qué producto desea dar salida? ");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qué cantidad desea sacar? ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (cantidad > Repository.Instance.productos[index - 1].Cantidad)
                {
                    Console.WriteLine("Has superado la Cantidad disponible");
                    Console.ReadKey();
                    mainProg.MainMenu();

                }
                else
                {
                    Repository.Instance.productos[index - 1].Cantidad -= cantidad;

                    Console.WriteLine("Cantidad de producto actualizada");
                    Console.ReadKey();
                    mainProg.MainMenu();
                }

            } catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
                Console.ReadKey();
                mainProg.MainMenu();
            }

        }

        public void ListCant()
        {
            int count = 1;
            foreach (Productos item in Repository.Instance.productos)
            {
                Console.WriteLine($"{count}- {item.Name}");
                Console.WriteLine($" Cantidad: {item.Cantidad}\n");
                count++;
            }
        }
    }
}
