using System;

public class Entry
{
    public string _place;

    public string _mood;

    public string _dayStart;

    public string _dayEnd;

    public void Display()
    {
    
        Console.WriteLine($"I am writing from {_place} today. I am in a {_mood} sort of mood today. I had a {_dayStart} to my day.");
        Console.WriteLine($"Looking back, I had a {_dayEnd} day today.");
    }

}