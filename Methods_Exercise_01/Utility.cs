namespace Methods_Exercise_01;
internal static class Utility
{
    // TODO: Create a Method that accepts a number and returns true if it is even
    public static bool IsEven(int x)
    {
        if (x % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // TODO: Create a Method that accepts a number and returns true if it is odd
    public static bool IsOdd(int x)
    {
        return x % 2 != 0;
    }

    // TODO: Create a Method that accepts a string (person's name) and returns a greeting
    public static string Greet(string name)
    {
        return $"Hello, {name}!";
    }

    // TODO: Create a method that accepts 2 integers and adds them 
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // TODO: Create a method that accepts 3 doubles and subtracts them
    public static double Subtract(double a, double b, double c) 
    {
        return a - b - c;
    }

    // TODO: Create a method that takes a string and returns the last character of that string
    public static char LastLetter(string str)
    {
        return str[str.Length - 1];
    }

    // TODO: Create a method that takes an array of strings and returns the string that has the greatest length
    public static string GreatestLength(string[] strings)
    {
        string answer = "";
        foreach (var str in strings)
        {
            if (str.Length > answer.Length)
            {
                answer = str;
            }
        }

        return answer;
    }

    // TODO: Create a method that takes a list of integers and returns the smallest number
    public static int SmallestNumber(List<int> numbers)
    {
        int answer = numbers[0];
        foreach (var number in numbers)
        {
            if (number < answer)
            {
                answer = number;
            }
        }
        return answer;
    }

    // BONUS: Create a method that takes a list of dogs and returns the name of the dog who is the oldest (the dog class and list of dogs has already been created)
    public static string OldestDog(List<Dog> dogs) 
    {
        var answer = "";
        var oldestDog = new Dog();

        foreach (var dog in dogs)
        {
            if (dog.Age > oldestDog.Age)
            {
                answer = dog.Name;
                oldestDog.Age = dog.Age;
            }
        }

        return answer;
    }

}
