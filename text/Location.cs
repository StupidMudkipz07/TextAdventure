struct Location
{
    public string name;
    public string description;
    public List<LocationPointer> PossibleLocationsToGoTo;
    
    public Location(string name, string description, List<LocationPointer> locations)
    {
        name = name;
        description = description;
        PossibleLocationsToGoTo = locations;
    }
}