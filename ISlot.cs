using System;

public interface ISlot {
    DateTime StartTime { get; set; }
    int DurationInMinutes { get; set; }
    string Text { get; set; }
}