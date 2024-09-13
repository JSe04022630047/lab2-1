using System.Xml.Linq;

internal class Account
{
    private string name; // Instance variable (Field)

    // Method that sets the account name in the object
    public void SetName(string accountName)
    {
        name = accountName; // Store the account name
    }

    // Method that retrieves the account name from the object
    public string GetName()
    {
        return name; // Returns name's value to this method's caller
    }
}