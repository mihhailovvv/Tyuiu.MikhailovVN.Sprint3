
using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MikhailovVN.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            foreach (char del in value)
            {
                if (del == item)
                {
                    value = value.Replace(item.ToString(), "");
                }
            }
            return value;
        }
    }
}
