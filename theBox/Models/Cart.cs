﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using theBox.Entity;

namespace theBox.Models
{
    public class Cart
    {
        private List<Cartline> _CartLines = new List<Cartline>();

        public List<Cartline> CartLines
        {
            get { return _CartLines; }
        }

        public void AddProduct(Product product, int quantity) 
        {
            var line = _CartLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line == null)
            {
                _CartLines.Add(new Cartline() { Product = product, Quantity = quantity });

            }
            else
            {
                line.Quantity += quantity;
            }

        }

        public void DeleteProduct(Product product)
        {
            _CartLines.Where(i => i.Product.Id == product.Id);
        }

        public double Total()
        {
            return _CartLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _CartLines.Clear();
        }
    }

    public class Cartline
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}