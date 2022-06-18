using ABOACIDIYET.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class Target
    {
        public int TargetID { get; set; }
        public TargetType TargetType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Success { get; set; }
        public int UserID { get; set; } // one to many olduğundan one olan taraf foreign key gelir
        public virtual User User { get; set; }


    }
}
