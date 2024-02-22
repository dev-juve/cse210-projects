class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}
