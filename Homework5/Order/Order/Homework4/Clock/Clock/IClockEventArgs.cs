namespace Clock
{
    public interface IClockEventArgs
    {
        int Hour { get; set; }
        int Min { get; set; }
        int Sec { get; set; }
    }
}