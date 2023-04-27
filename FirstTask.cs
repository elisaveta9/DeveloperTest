namespace Library
{
    public static class PrintTasks //должны быть значащие названия. ни в одном из классов не функции Main() - значит эти классы не главные
    {                       //эти классы можно объединить. Обе задачи используются для вывода в консоль, поэтому так назван класс
                            //В классе нет полей, значит лучше его сделать статическим, как и его функции.
        public static void PrintSequence() //функция для вывода последовательности 1, 2, ..., n
        {
            Console.Write("Вывод последовательности от 1 до N. Введите число N: ");
            if (!int.TryParse(Console.ReadLine(), out int n))   //инициализируем n без получения ошибки
            {
                Console.WriteLine("Введенное значение невозможно считать как целочисленную переменную."); 
                return;
            }
            if (n < 1)  //проверяем корректность заданного значения
            {
                Console.WriteLine("Число N должно быть больше либо равно 1.");
                return;
            }
            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }
        
        public static void PrintSquare() //функция для вывода на экран квадрата
        {
            Console.Write("Печать квадрата NxN с «дыркой» в центре. Введите нечетное число N больше 3: ");
            if (!int.TryParse(Console.ReadLine(), out int n))   //инициализируем n без получения ошибки
            {
                Console.WriteLine("Введенное значение невозможно считать как целочисленную переменную."); 
                return;
            }
            if (n < 3)  //проверки на корректность введенного значения
            {
                Console.WriteLine("Не выполнено условие N > 3.");
                return;
            }
            if (n % 2 == 0) // 
            {
                Console.WriteLine("Вы ввели четное N.");
                return;
            }            
            for (int row = 1; row <= n; row++) {
                for (int col = 1; col <= n; col++) {
                    if (row == n / 2 + 1 && col == n / 2 + 1) Console.Write(" ");
                    else Console.Write("#");                    
                }
                Console.WriteLine();
            }
        }
    }
    public class Program
    {
        private static void Main() //примерное использование описанных функций
        {                          
            Console.WriteLine(@"Выбор функции для выполнения.
1. Вывод последовательности от 1 до n.
2. Вывод квадрата с дыркой в центре.
Любой другой вариант - выход из программы");
            if (!int.TryParse(Console.ReadLine(), out int n))   //инициализируем n без получения ошибки
            {
                Console.WriteLine("Введенное значение невозможно считать как целочисленную переменную."); 
                return;
            }
            switch (n)
            {
                case 1:
                    PrintTasks.PrintSequence();
                    break;
                case 2:
                    
                    PrintTasks.PrintSequence();
                    break;
                default:
                    Console.WriteLine("Выход из программы...");
                    break;
            }
        }
    }
}
