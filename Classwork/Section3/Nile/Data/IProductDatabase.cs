﻿using System.Collections.Generic;

namespace Nile.Data
{
    public interface IProductDatabase
    {
        Product Add( Product product, out string message );
        Product Edit( Product product, out string message );
        IEnumerable<Product> GetAll();
        void Remove( int id );
    }
}