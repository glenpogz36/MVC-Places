using System.Collections.Generic;

namespace PlaceList.Models
{
  public class Place
  {

    private string _cityName;
    private string _description;
    private string _picture;
    private int _id;
    private static List<Place> _instances = new List<Place> {};

    public Place (string cityName, string description, string picture)
    {
      _cityName = cityName;
      _description = description;
      _picture = picture;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetCityName()
    {
      return _cityName;
    }

    public string GetDescription()
    {
      return _description;
    }

    public string GetPicture()
    {
      return _picture;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetId()
    {
      return _id;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}