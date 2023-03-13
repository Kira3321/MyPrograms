namespace Practice.MainScenario.Exceptions;

public class Pers
{
    private int _age;
    public string FirstName { get; set; }
    public string LastName { get; set; }
   
    public int Age
    {
        get => _age;
        set
        {
            if (value > 150 && value < 0)
            {
                throw new InvalidAgeException("Некорректный возраст");
            }

            _age = value;
        }
    } 
}

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string? message) : base(message) { }
}

