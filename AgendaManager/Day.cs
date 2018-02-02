using System;
using System.Collections.Generic;
using System.Linq;

public class Day {
    public DateTime DayDate { get; set; }
    public List<ISlot> Slots { get; set; }
    
    public Day(DateTime date) {
        this.DayDate = date;
        this.Slots = new List<ISlot>();
        var temp = new DateTime(date.Year, date.Month, date.Day,8,0,0);        
        for(int i = 0; i < 10; i++) {
            Slots.Add(new FreeSlot(temp,60));
            temp = temp.AddHours((double)1);
        }
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
            if(index > -1) {
                Slots[index] = new FreeSlot(Slots[index].StartTime, Slots[index].DurationInMinutes);
                return true;
            } else return false;
        } catch (Exception ex) {
            return false;
        }
    }
}