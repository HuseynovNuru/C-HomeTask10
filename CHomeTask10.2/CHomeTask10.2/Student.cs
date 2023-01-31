using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace CHomeTask10._2
{
    internal class Student
    {
        private static int _totalCount;
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }

        public string Name;
        public int No;
        public string GroupNo;

        static public void CheckNo()
        {
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                    {
                        return false;
                    }
                }
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
