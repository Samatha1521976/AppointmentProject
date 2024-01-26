using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentProject
{
  internal  class Appointment
    {
        public string Day { get; }
        public int Time { get; }

        public Appointment(string day, int time)
        {
            Day = day;
            Time = time;
        }

        public string CheckSlot()
        {
            Dictionary<string, int> timeSlots = GetTimeSlots();

            if (timeSlots.ContainsKey(Day) && Time >= 8 && Time < timeSlots[Day])
            {
                return "Available";
            }
            else
            {
                return "Not Available";
            }
        }

        private Dictionary<string, int> GetTimeSlots()
        {
            Dictionary<string, int> timeSlots = new Dictionary<string, int>
        {
            {"Monday", 17},
            {"Tuesday", 16},
            {"Wednesday", 14},
            {"Thursday", 12},
            {"Friday", 10},
            {"Saturday", 0}, // No appointments on Saturday
            {"Sunday", 0}    // No appointments on Sunday
        };

            return timeSlots;
        }
    }
}
