public class Meddelande
{
    public string Text { get; set; }

    public string VisaMeddelande()
    {
        return "Hello world!! " + Text;
    }
}
