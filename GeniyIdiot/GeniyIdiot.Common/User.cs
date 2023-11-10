using System;

namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public string Diagnose;
        public int PercentOfRightAnswers;

        public User(string name, string diagnose, int percentOfRightAnswers)
        {
            Name = name;
            Diagnose = diagnose;
            PercentOfRightAnswers = percentOfRightAnswers;
        }


    }
}