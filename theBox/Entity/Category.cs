﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace theBox.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        public string Name { get; set; }

        [DisplayName("İçerik")]
        public string Description { get; set; }

        public  List<Product> Products { get; set; }

    }
}