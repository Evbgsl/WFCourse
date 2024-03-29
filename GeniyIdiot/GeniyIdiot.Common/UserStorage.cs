﻿using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace GeniyIdiot.Common
{

    public class UserStorage
    {
        public List<int> UserAnswers;

        public UserStorage(List<int> userAnswers)
        {
            UserAnswers = userAnswers;

        }

        public static int GetNumber()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }
        }


        public static void SetResult(User user, int percentOfRightAnswers, string userDiagnose, string fileName)
        {
            var _testResult = $"result#@{user.Name}@{percentOfRightAnswers}@{userDiagnose}";
            DataFileProvider.Append(fileName, _testResult);
        }

        public static List<string[]> GetResultsFromFile(string fileName)
        {
            Console.WriteLine("{0,20} | {1,20} | {2, 20}", "ФИО", "% верных ответов", "Диагноз");
            var value = DataFileProvider.GetValue(fileName);
            var lines = value.Split('\n');
            var string_collection = new List<string[]>();
            foreach (string line in lines)
            {
                if (line.StartsWith("result#"))
                {
                    var lineArray = line.Split('@');
                    string_collection.Add(lineArray);
                    
                }
            }
            return string_collection;
        }
    }


}
