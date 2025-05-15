using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace Tests;

using Core.Classes;

public class AnimalTest
{
    [Fact]
    public void TestCreateBearIsSuccessfull()
    {
        //Arrange
        string name = "Einar";
        int age = 10;
        string furColor = "Black";
        FoodType feed = FoodType.Omnivore;

        //Act
        var bear = new Bear(name, furColor, age, feed);

        //Assert
        Assert.NotNull(bear);

        Assert.Equal(bear.Age, age);

        Assert.Equal(bear.Name, name);

        Assert.Equal(bear.FurColor, furColor);

        Assert.Equal(bear.FoodType, feed);

        Assert.IsAssignableFrom<Animal>(bear);
    }
}