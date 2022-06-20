using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class KiloRepository
    {
        AboDbContext db;
        public KiloRepository()
        {
            db = new AboDbContext();
        }


        public double GetLatestKilo(int userID)
        {

            return db.Kilos.Where(a => a.UserID == userID).OrderByDescending(a => a.CreationDate).Select(x=> x.Weight).FirstOrDefault();
        }

        public List<Kilo>GetByUserId(int userID)
        {
            return db.Kilos.Where(a => a.UserID == userID).ToList();

        }
        /// <summary>
        /// kilo ekleme
        /// </summary>
        /// <param name="kilo"></param>
        /// <returns></returns>
        public int Insert(Kilo kilo)
        {
            db.Kilos.Add(kilo);
            int affRows = db.SaveChanges();
            return affRows;
        }
        
    }
}
