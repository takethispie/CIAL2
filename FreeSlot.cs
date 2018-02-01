using System;

public class FreeSlot : ISlot
{
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get { return 0; } set { DurationInMinutes = 0; }  }
    public string Text { get; set; }
}