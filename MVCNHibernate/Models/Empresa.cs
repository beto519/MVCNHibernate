using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCNHibernate.Models
{
    public class Empresa
    {
        public virtual int? Id { get; set; }
        [DisplayName("Nombre")]
        public virtual string Nombre { get; set; }
        [DisplayName("Descripcion")]
        public virtual string Descripcion { get; set; }
        [DisplayName("Giro")]

        public virtual string Giro { get; set; }


    }
}