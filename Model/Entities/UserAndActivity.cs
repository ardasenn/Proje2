using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class UserAndActivity
    {
        //[Key, Column(Order = 0)]
        public  int UserID { get; set; }
        //[Key, Column(Order = 1)]
        public int ActivityID { get; set; }

        public  virtual User User { get; set; }
        public virtual Activity Activity { get; set; }  

        public int ActivityDuration { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
