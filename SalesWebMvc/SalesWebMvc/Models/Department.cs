﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models {
    public class Department {
        public int id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() {

        }
        public Department(int id, string name) {
            this.id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) {
            this.Sellers.Add(seller);
        }

        public double TotalSeller(DateTime init, DateTime fin) {
            return Sellers.Sum(Seller => Seller.TotalSales(init, fin)); 
        }
    }
}
