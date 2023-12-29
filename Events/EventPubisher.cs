public delegate void myDelegate();
public class Publisher
{
    //create event
    public event myDelegate myEvent = delegate { };
    public void RaiseEvent()
    {
        myEvent?.Invoke();
    }
    public void SubscribeToEvent()
    {
        myEvent += onMyEventRaised;
    }
     private void onMyEventRaised()
    {
        Console.WriteLine("button clicked...");
    }
}