public class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;
    private string _addressText;

    public Address(string street, string city, string stateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
        _addressText = ($"{street}\n{city}, {stateProv}\n{country}");
    }

    public bool IsInUSA()
    {
        return _country == "USA";
        //     if (_country == "USA")
        //         return true;
        //     else
        //         return false;
    }

    public string GetAddressText()
    {
        return _addressText;
    }
}
//The address contains a string for the street address, the city, state/province, and country.
//The address should have a method that can return whether it is in the USA or not.
//The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)