using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    class ComprobarCategoria
    {
        public bool CompruebaCategoria()
        {
            int conteo = Repository.Instance.categorias.Count;

            if(conteo != 0)
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}
