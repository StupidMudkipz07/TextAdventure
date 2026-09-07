struct LocationPointer
{
    public LocationPointer(string name, string  description, Location location)
    {
        Name = name;
        Description = description;
        locationToGoTo = location;
    }

    public string Name;
    public string Description;

    public Location locationToGoTo;
}