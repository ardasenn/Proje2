using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class TargetRepository
    {
        AboDbContext db;
        public TargetRepository()
        {
            db = new AboDbContext();
        }
        public Target GetByUserId(int userID)
        {
            return db.Targets.Where(a => a.UserID == userID).OrderByDescending(a=>a.StartDate).FirstOrDefault();

        }
        public int Insert(Target target)
        {
            db.Targets.Add(target);
            int affRows = db.SaveChanges();
            return affRows;
        }
        public Target GetByTargetId(int targetID)
        {
            return db.Targets.Find(targetID);
        }
        public int Delete(Target target)
        {
            Target deleteTarget = db.Targets.Find(target.TargetID);
            db.Targets.Remove(deleteTarget);
            int affRows = db.SaveChanges();
            return affRows;
        }
    }
}
