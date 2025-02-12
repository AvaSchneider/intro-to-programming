
namespace Banking.Tests.Syntax;

public class Types
{
    string Name = "Bob";

    [Fact]
    public void DeclaringVariables()
    {
        //type identifier [= initializer]
        var age = 55;

        int dogAge;



        var yourAge = 16.5;

        var myHourlyPay = 18.23M; // declare a local variable to type Decimal with the initial value of ...

        // a variable in a strongly typed language cannot change its type.

        Assert.Equal("Bob", Name);

        Assert.Equal(55, age);
    }

    [Fact]
    public void AnotherThing()
    {
        Assert.Equal("Bob", this.Name);
    }
}
