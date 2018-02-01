using System;
using System.Collections.Generic;
using System.Linq;

public class Day {
    public DateTime DayDate { get; set; }
    public List<ISlot> Slots { get; set; }
    
    public Day(DateTime date) {
        this.DayDate = date;
    }

    public bool AddAppointement(DateTime date, string contact, string remarque) {
        try {
            int index = Slots.FindIndex(slot => { 
                if(slot.StartTime == date && slot.GetType() == typeof(FreeSlot)) return true; 
                else return false;
            });
            Appointement appo = new Appointement();
            appo.Contact = contact;
            appo.Text = remarque;
            appo.StartTime = date;
            Slots[index] = appo;
            return true;
        } catch (Exception ex) {
            return false;
        }
    }

    public bool DeleteAppointement(DateTime date) {
        try {
            int index = Slots.FindIndex(slot => { 
                if(slot.StartTime == date && slot.GetType() == typeof(Appointement)) return true; 
                else return false;
            });
            Slots[index] = new FreeSlot();
            return true;
        } catch (Exception ex) {
            return false;
        }
    }

    public bool AddFreeslot(DateTime date, int duration) {
        DateTime endTime = date.AddMinutes((double) duration);
        List<ISlot> res = Slots.FindAll(sl => { 
            DateTime slEndTime = sl.StartTime.AddMinutes((double)sl.DurationInMinutes);
            if(sl.StartTime <= date && slEndTime >= endTime) return true;
            else return false;
         });
        return false;
    }

    public bool RemoveFreeslot(DateTime date) {
        return false;
    }
}