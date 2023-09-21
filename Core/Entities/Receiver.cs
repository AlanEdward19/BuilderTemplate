namespace Core.Entities;

public class Receiver
{
    public Receiver(string fullName, string document, string fullAddress)
    {
        FullName = fullName;
        Document = document;
        FullAddress = fullAddress;
    }

    public string FullName { get; set; }
    public string Document { get; set; }
    public string FullAddress { get; set; }
}