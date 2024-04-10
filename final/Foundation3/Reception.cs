public class Reception : Event
{
    private string emailForRSVP;

    public Reception(string title, string description, DateTime date, string time, Address address, string emailForRSVP)
        : base(title, description, date, time, address)
    {
        this.emailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails() => $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {emailForRSVP}";

    public override string GetShortDescription() => $"Reception: {title} on {date.ToShortDateString()}";
}
