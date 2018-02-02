using System;

public class Appointement: ISlot {
    public string Contact { get; set; }
    public DateTime StartTime { get; set; }
    public int DurationInMinutes { get; set; }
    public string Text { get; set; }
}