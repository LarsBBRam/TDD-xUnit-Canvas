namespace Core.Classes;

public class Animal(string name, int age, FoodType feed)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public FoodType FoodType { get; set; } = feed;
}