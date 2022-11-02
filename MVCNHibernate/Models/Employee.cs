using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCNHibernate.Models
{
    public class Employee
    {
       
        public virtual int? Id { get; set; }
        [DisplayName("Nombre")]
        public virtual string FullName { get; set; }
        [DisplayName("Designación")]
        public virtual string Designation { get; set; }
        [DisplayName("Genero")]

        public virtual string Gender { get; set; }
        [DisplayName("Salario")]
        public virtual double Salary { get; set; }
        [DisplayName("Ciudad")]
        public virtual string City { get; set; }
        [DisplayName("Estado")]
        public virtual string State { get; set; }
        [DisplayName("Zip")]
        public virtual string Zip { get; set; }
       
    }
}