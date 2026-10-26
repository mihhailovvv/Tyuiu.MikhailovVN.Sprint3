
using Tyuiu.MikhailovVN.Sprint3.Task3.V29.Lib;
namespace Tyuiu.MikhailovVN.Sprint3.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Михайлов В. Н. | Группа: ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Михайлов Валерий Николаевич | Группа: ИСТНб-26-1              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы h в строке:          *");
            Console.WriteLine("* chgr vhhtg hnht                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "chgr vhhtg hnht";
            char item = 'h';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Удаляемая буква: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: " + ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
