namespace Practice.MainScenario.Delegates;

public class Closure
{
    public static Action FibonachiNumbers(int max)
    {
        var finish = max;
        var start = 0;
        var number1 = 0;
        var number2 = 0;

        void Innder()
        {
            if (start >= max)
            {
                Console.WriteLine(number2);
                return;
            }
            if (number1 == 0) number1++;
            if (start % 2 == 0)
            {
                number1 += number2;
                Console.WriteLine(number1);
            }
            else
            {
                number2 += number1;
                Console.WriteLine(number2);
            }

            start++;
        }

        return Innder;
    }
}


/*Пример задания*/
/*var fn = Closure.FibonachiNumbers(10);

for (int i = 0; i < 10; i++)
{
    fn();
}*/