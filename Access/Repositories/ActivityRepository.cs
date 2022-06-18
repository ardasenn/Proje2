using ABOACIDIYET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class ActivityRepository
    {
        AboDbContext db;
        public ActivityRepository()
        {
            db = new AboDbContext();
        }
        /// <summary>
        /// DataBasede olan aktiviteleri döner
        /// </summary>
        /// <returns></returns>
        public List<Activity> GetActivity()
        {
            List<Activity> activities = new List<Activity>();
            activities = db.Activities.ToList();
            return activities;
        }
        /// <summary>
        /// Aktivitelerin UserId ye göre listelenmesi
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<UserAndActivity> GetByUserId(int userID)
        {
            return db.UsersAndActivities.Where(a => a.UserID == userID).ToList();
        }
        /// <summary>
        /// aktiviteye tıkladığımda onunla ilgili bişeyler yapabilirim
        /// </summary>
        /// <param name="activiytID"></param>
        /// <returns></returns>
        public Activity GetByActivityId(int activiytID)
        {
            return db.Activities.Find(activiytID);
        }
        /// <summary>
        /// aktivite ekle
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        public int Insert(Activity activity)
        {
            db.Activities.Add(activity);
            int affRows = db.SaveChanges();
            return affRows;
        }
        /// <summary>
        /// aktivite silme,bulunan ıd ye göre
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public int Delete(Activity activity)
        {
            Activity deleteActivity = db.Activities.Find(activity.ActivityID);
            db.Activities.Remove(deleteActivity);
            int affRows = db.SaveChanges();
            return affRows;
        }
    }
}