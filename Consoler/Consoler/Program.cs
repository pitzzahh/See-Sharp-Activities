using System;

namespace Consoler
{
    public class Account
    {
        public int account_number;

        // Rest of the class implementation...
    }
}

public struct Product
{
    public string code;
    public string description;
    public double price;

    // Rest of the struct implementation...
}

public class Person
{
    public string full_name;

    public Person()
    {
        full_name = default(string);
    }

    // Rest of the class implementation...
}

public class CircleUtils
{
    public double getCircleDiameter(double radius)
    {
        return radius * 2;
    }
}
