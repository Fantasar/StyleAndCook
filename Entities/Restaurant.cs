namespace StyleAndCook.Entities;

public enum RestaurantType { FastFood, Pizzeria, Gastronomic }

public class Restaurant
{
    public RestaurantType Type { get; set; }
    public int Level { get; set; }

    public Restaurant(RestaurantType type)
    {
        Type = type;
        Level = 1;
    }

    public void Upgrade()
    {
        Level++;
    }
}