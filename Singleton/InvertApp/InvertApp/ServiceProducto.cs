using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class ServiceProducto
    {
        ServiceCategoria serviceCategoria = new ServiceCategoria();
        ComprobarCategoria comprobarCategoria = new ComprobarCategoria();

        public void Add()
        {
            try
            {
                if (comprobarCategoria.CompruebaCategoria())
                {
                    Console.WriteLine("Ingrese el nombre del Producto:");
                    string nameProducto = Console.ReadLine();

                    Console.WriteLine("Ingrese el precio del Producto:");
                    double precioProducto = Convert.ToDouble(Console.ReadLine());

                    serviceCategoria.List();
                    Console.WriteLine("Ingrese a la Categoria que pertenece el Producto:");
                    int indexcategoriaProducto = Convert.ToInt32(Console.ReadLine());

                    string categoriaProducto = Repository.Instance.categorias[indexcategoriaProducto - 1].Name;

                    Productos productos = new Productos(nameProducto, precioProducto, categoriaProducto);

                    Repository.Instance.productos.Add(productos);

                    Console.WriteLine("Producto agregado con éxito");
                    Console.ReadKey();
                } else
                {
                    Console.WriteLine("No hay categorías agregadas");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Has intrducido un valor inválido");
                Console.ReadKey();
                Add();
            }
        }

        public void Edit()
        {
            try
            {
                if (comprobarCategoria.CompruebaCategoria())
                {
                    List();

                    Console.WriteLine("Seleccione el producto a Editar: ");
                    int indexProductos = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese el nuevo nombre del producto: ");
                    string nameProducto = Console.ReadLine();

                    Console.WriteLine("Ingrese el nuevo precio del Producto:");
                    double precioProducto = Convert.ToDouble(Console.ReadLine());

                    serviceCategoria.List();
                    Console.WriteLine("Ingrese la nueva categoria a la que pertenece el Producto:");
                    int indexcategoriaProducto = Convert.ToInt32(Console.ReadLine());

                    string categoriaProducto = Repository.Instance.categorias[indexcategoriaProducto - 1].Name;

                    Repository.Instance.productos[indexProductos - 1].Name = nameProducto;
                    Repository.Instance.productos[indexProductos - 1].Precio = precioProducto;
                    Repository.Instance.productos[indexProductos - 1].Categoria = categoriaProducto;

                    Console.WriteLine("Producto editado con éxito");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No hay categorías agregadas");
                    Console.ReadKey();
                }


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
                if (comprobarCategoria.CompruebaCategoria())
                {
                    List();

                    Console.WriteLine("Seleccione el producto a Eliminar: ");
                    int indexProducto = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("¿Seguro que desea eliminar el producto? s/n ");
                    string delConfirm = Console.ReadLine();

                    if (delConfirm == "s")
                    {
                        Repository.Instance.productos.RemoveAt(indexProducto - 1);

                        Console.WriteLine("Producto eliminado con éxito");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Operación cancelada");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("No hay categorías agregadas");
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
            if (comprobarCategoria.CompruebaCategoria())
            {
                int count = 1;
                foreach (Productos item in Repository.Instance.productos)
                {
                    Console.WriteLine($"{count}- {item.Name}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("No hay categorías agregadas");
                Console.ReadKey();
            }
        }

    }
}
