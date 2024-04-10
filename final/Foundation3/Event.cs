public abstract class Event
{
    protected string title;
    protected string description;
    protected DateTime date;
    protected string time;
    protected Address address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails() => $"{title}\n{description}\nDate: {date.ToShortDateString()}, Time: {time}\nLocation: {address}";

    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}
