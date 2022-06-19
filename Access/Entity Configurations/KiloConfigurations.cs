using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Entity_Configurations
{
    public class KiloConfigurations : EntityTypeConfiguration<Kilo>
    {
        public KiloConfigurations()
        {

            HasKey(a => a.KiloID);

        }
    }
}
