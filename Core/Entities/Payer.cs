namespace Core.Entities;

public class Payer
{
    public Payer(string fullName, string document, string fullAddress)
    {
        FullName = fullName;
        Document = document;
        FullAddress = fullAddress;
    }

    public string FullName { get; set; }
    public string Document { get; set; }
    public string FullAddress { get; set; }
}