namespace Core.Classes;

public class Bear(string name, string furColor, int age, FoodType feed) : Animal(name, age, feed)
{
    public string FurColor = furColor;
}