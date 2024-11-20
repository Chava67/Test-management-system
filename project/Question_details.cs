using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Question_details
    {
        public string Id_test { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public string[] Answer { get; set; }
        public string[] AnswersOptions { get; set; }
        public string Percent { get; set; }

        public Question_details(string id_test, string content, string type, string[] answer, string[] answersOptions, string percent)
        {
            Id_test = id_test;
            Content = content;
            Type = type;
            Answer = answer;
            AnswersOptions = answersOptions;
            Percent = percent;
        }
    }
}
