using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public sealed class Repository
    {
        public static Repository Instance { get; } = new Repository();
        public List<Categoria> categorias = new List<Categoria>();
        public List<Productos> productos = new List<Productos>();
        private Repository() { }


    }
}
