using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PI_Service
{
    public static class CheckFields
    {

        /// <summary>
        /// если проверка пройдена, то вернется пустая строка
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        public static string CheckPrice(string checkString)
        {
            string price;
            string s = checkString;
            s = s.Replace(".", ",");
            int kk = s.IndexOf(",");
            Regex regexPrice = new Regex(@"^[0-9]{0,10}(?:[.,][0-9]{0,2})?\z");

            if (checkString.Length > 11)
            {
                return "Слишком длинное число. Не более 11 символов";
            }
            else if (s.IndexOf(",") != -1)
            {
                if (s.Substring(0, s.LastIndexOf(',')).Length > 8)
                {
                    return "Слишком длинное число. Не более 8 знаков до запятой";
                }
            }
            if (regexPrice.IsMatch(checkString))
            {
                price = checkString.Replace(".", ",");
            }
            else
            {
                return "Несоответсвие формату Сумма";
            }

            return "";
        }



        /// <summary>
        /// если проверка пройдена, то вернется пустая строка
        /// </summary>
        /// <param name="checkString"></param>
        /// <returns></returns>
        public static string CheckCount(string checkString)
        {
            if (checkString.Length > 10)
            {
                return "Слишком большое число";
            }
            try
            {
                Convert.ToInt32(checkString);
            }
            catch
            {
                return "Кол-во должно быть целым числом";
            }
            return "";
        }
    }
}
