using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class Kilo
    {
        public int KiloID { get; set; }
        public int Weight { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserID { get; set; } // one to many olduğundan one olan taraf foreign key gelir
        public virtual User User { get; set; }
        
    }
}
