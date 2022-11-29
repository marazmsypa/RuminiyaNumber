using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuminiyaNumberLibrary
{
    public class RuminiyaNumberClass
    {
        public string ReturnNumber(DateTime DateOfBirth, int cityCode, bool sex, string surname, bool rezident )
        {
            string number = "";
            int[] arrayNumber = new int[13];
            if ((DateOfBirth.Year >= 1900 && DateOfBirth.Month >= 1 && DateOfBirth.Day >= 1) &&(DateOfBirth.Year <= 1949 && DateOfBirth.Month <= 12 && DateOfBirth.Day <= 31))
            {
                number += "1";
                arrayNumber[0] = 1;
            }
            if ((DateOfBirth.Year >= 1950 && DateOfBirth.Month >= 1 && DateOfBirth.Day >= 1) && (DateOfBirth.Year <= 1999 && DateOfBirth.Month <= 12 && DateOfBirth.Day <= 31))
            {
                number += "2";
                arrayNumber[0] = 2;
            }
            if ((DateOfBirth.Year >= 1800 && DateOfBirth.Month >= 1 && DateOfBirth.Day >= 1) && (DateOfBirth.Year <= 1849 && DateOfBirth.Month <= 12 && DateOfBirth.Day <= 31))
            {
                number += "3";
                arrayNumber[0] = 3;
            }
            if ((DateOfBirth.Year >= 1850 && DateOfBirth.Month >= 1 && DateOfBirth.Day >= 1) && (DateOfBirth.Year <= 1899 && DateOfBirth.Month <= 12 && DateOfBirth.Day <= 31))
            {
                number += "4";
                arrayNumber[0] = 4;
            }
            if ((DateOfBirth.Year >= 2000 && DateOfBirth.Month >= 1 && DateOfBirth.Day >= 1) && (DateOfBirth.Year <= 2049 && DateOfBirth.Month <= 12 && DateOfBirth.Day <= 31))
            {
                number += "5";
                arrayNumber[0] = 5;
            }
            if ((DateOfBirth.Year >= 2050 && DateOfBirth.Month >= 1 && DateOfBirth.Day >= 1) && (DateOfBirth.Year <= 2099 && DateOfBirth.Month <= 12 && DateOfBirth.Day <= 31))
            {
                number += "6";
                arrayNumber[0] = 6;
            }
            if (!rezident)
            {
                Random rnd = new Random();
                int random;
                random = rnd.Next(7,10);
                arrayNumber[0] = random;
                number = "";
                number += random.ToString();
            }
            int numberTwoAndThree = (DateOfBirth.Year)% 100;
            arrayNumber[1] = numberTwoAndThree / 10;
            arrayNumber[2] = numberTwoAndThree % 10;
            number += numberTwoAndThree.ToString();
            int numberFourAndFive = DateOfBirth.Month;
            string numberFourAndFiveString = numberFourAndFive.ToString();
            if (numberFourAndFiveString.Length == 1)
            {
                arrayNumber[3] = 0;
                arrayNumber[4] = numberFourAndFive;
                number += "0";
                number += numberFourAndFive.ToString();
            }
            else
            {
                arrayNumber[3] = numberFourAndFive / 10;
                arrayNumber[4] = numberFourAndFive % 10;
                number += numberFourAndFive.ToString();
            }

            int numberSixAndSeven = DateOfBirth.Day;
            string numberSixAndSevenString = numberSixAndSeven.ToString();
            if (numberSixAndSevenString.Length == 1)
            {
                arrayNumber[5] = 0;
                arrayNumber[6] = numberSixAndSeven;
                number += "0";
                number += numberSixAndSeven.ToString();
            }
            else
            {
                arrayNumber[5] = numberSixAndSeven / 10;
                arrayNumber[6] = numberSixAndSeven % 10;
                number += numberSixAndSeven.ToString();
            }

            int numberEightAndNine = cityCode;
            arrayNumber[7] = numberEightAndNine / 10;
            arrayNumber[8] = numberEightAndNine % 10;
            number += numberEightAndNine.ToString();
            if (sex)
            {
                arrayNumber[9] = 1; // мужик
                number += "1";
            }
            else
            {
                arrayNumber[9] = 2;
                number += "2";
            }
            surname = surname.ToUpper();
            surname = surname[0].ToString();
            byte[] bytes = Encoding.ASCII.GetBytes(surname);
            string numberElAndTwStr = "";
            foreach (byte item in bytes)
            {
                numberElAndTwStr += item.ToString();
            }
            int numberElAndTw = Convert.ToInt32(numberElAndTwStr);
            arrayNumber[10] = numberElAndTw / 10;
            arrayNumber[11] = numberElAndTw % 10;
            number += numberElAndTw.ToString();
            int[] arrayMnojitel = new int[12] {1,2,3,4,5,6,7,8,9,0,1,2 };
            int summa = 0;
            foreach (int item in arrayMnojitel)
            {
                int i = 0;
                summa += item * arrayNumber[i];
                i++;
            }
            if (summa % 11 == 10)
            {
                number += "1";
            }
            else
            {
                number += (summa % 11).ToString();
            }
            return number;
        }
    }
}
