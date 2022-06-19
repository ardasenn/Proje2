using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET.Entities
{
    public class Activity
    {
        private int activityID;
        private string activityName;
        private double burnedCalorieInActivity;
        public Activity()
        {
            UserAndActivities = new List<UserAndActivity>();
        }
        public Activity(string activityName, double burnedCalorieInActivity)
        {
            this.activityName = activityName;
            this.burnedCalorieInActivity = burnedCalorieInActivity;
            UserAndActivities = new List<UserAndActivity>();
        }

        public int ActivityID { get => activityID; set => activityID = value; }
        public string ActivityName { get => activityName; set => activityName = value; }
        public double BurnedCalorieInActivity { get => burnedCalorieInActivity; set => burnedCalorieInActivity = value; }
        public virtual ICollection<UserAndActivity> UserAndActivities { get; set; }

    }
}
