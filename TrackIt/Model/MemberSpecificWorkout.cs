using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackIt.Model
{
    public class MemberSpecificWorkout
    {
        public int MemberSpecificWorkoutID { get; set; }
        public int MemberID { get; set; }
        public string WorkoutName { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
