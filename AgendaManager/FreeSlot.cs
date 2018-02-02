using System;

public class FreeSlot : ISlot
{
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get; set;  }
    public string Text { get; set; }

    public FreeSlot(DateTime startTime, int duration) {
        this.StartTime = startTime;
        this.DurationInMinutes = duration;
    }
}