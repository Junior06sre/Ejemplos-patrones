using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class ServiceCategoria
    {
        public void Add()
        {
            Console.WriteLine("Ingrese el nombre de la Categoría:");
            string nameCategoria = Console.ReadLine();

            Categoria categoria = new Categoria(nameCategoria);

            Repository.Instance.categorias.Add(categoria);

            Console.WriteLine("Categoría agregada con éxito");
            Console.ReadKey();
        }

        public void Edit()
        {
            try
            {
                
                List();

                Console.WriteLine("Seleccione la categoría a Editar: ");
                int indexCategoria = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nuevo nombre de la categoría: ");
                string name = Console.ReadLine();

                Repository.Instance.categorias[indexCategoria - 1].Name = name;

                Console.WriteLine("Categoría editada con éxito");
                Console.ReadKey();

            } catch (Exception)
            {
                Console.WriteLine("Has intrducido un valor inválido");
                Console.ReadKey();
                Edit();
            }
        }

        public void Delete()
        {
            try
            {
                List();

                Console.WriteLine("Seleccione la categoría a Eliminar: ");
                int indexCategoria = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Seguro que desea eliminar la categoría? s/n ");
                string delConfirm = Console.ReadLine();

                if (delConfirm == "s")
                {
                    Repository.Instance.categorias.RemoveAt(indexCategoria - 1);

                    Console.WriteLine("Categoría eliminada con éxito");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Operación cancelada");
                    Console.ReadKey();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Has intrducido un valor inválido");
                Console.ReadKey();
                Delete();
            }
        }

        public void List()
        {
            int count = 1;
            foreach(Categoria item in Repository.Instance.categorias)
            {
                Console.WriteLine($"{count}- {item.Name}");
                count++;
            }
        }
    }
}
