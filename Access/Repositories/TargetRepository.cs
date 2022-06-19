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
        public List<Target> GetTargets()
        {
            List<Target> targets = new List<Target>();
            targets = db.Targets.ToList();
            return targets;
        }
        public List<Target> GetByUserId(int userID)
        {
            return db.Targets.Where(a => a.UserID == userID).OrderByDescending(a => a.StartDate).ToList();
        }
        public Target GetTarget(int userID,DateTime dateTime)
        {
          return db.Targets.Where(a => a.UserID == userID && a.EndDate>dateTime).OrderBy(a => a.StartDate).FirstOrDefault();
        }
        public List<Target> GetByTargets(int targetId)
        {
            return db.Targets.Where(a => a.TargetID == targetId).ToList();
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
        public int Delete(int targetId)
        {
            Target deleteTarget = db.Targets.Find(targetId);
            db.Targets.Remove(deleteTarget);
            int affRows = db.SaveChanges();
            return affRows;
        }
    }
}
