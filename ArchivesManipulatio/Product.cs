﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArchivesManipulatio
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double total()
        {
           return Quantity * Price;
        }
    }
}
