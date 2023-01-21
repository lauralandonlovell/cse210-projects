using System;

class Entry
{
    public string _date;
    {
        DateTime theCurrentTime = DateTime.Now;
        string Entry.today = theCurrentTime.ToShortDateString();
    }
    public string _place;
    public string _mood;
    public string _dayStart;
    public string _people;
    public string _weather;
    public string _season;
    public string _scenery;
    public string _thought; 

    public void Display() {
        
        Console.WriteLine("Today is {_date}.");
        Console.WriteLine($" I am writing from {_place}. I am in a {_mood} mood. I had a {_dayStart} to my day. I met {_people} today. The weather was {_weather}. The season has been {_season} this year. I am surrounded by {_scenery}. I have been thinking a lot about {_thought}.");

    }

}