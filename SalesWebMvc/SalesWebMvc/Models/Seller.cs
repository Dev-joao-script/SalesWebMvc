using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models {
    public class Seller {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseDalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseDalary, Department department) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseDalary = baseDalary;
            Department = department;
        }

        public void AddSeller(SalesRecord Sr) {
            Sales.Add(Sr);
        }

        public void RemoveSeller(SalesRecord Sr) {
            Sales.Remove(Sr);
        }

        public double TotalSales(DateTime init, DateTime fin) {
            return Sales.Where(sl => sl.Date >= init && sl.Date <= fin).Sum(sl => sl.Amount);
        }
    }
}
