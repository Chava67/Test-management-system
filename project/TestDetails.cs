using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project
{
    public class TestDetails
    {
        //static int num = 0;
        public String Name { get; set; }
        public string Id { get; set; }
        public int NumofQuestion { get; set; }
        public int Percnt { get; set; }
        public bool Status { get; set; }
        public TestDetails(string neme)
        {
            int Idcount=int.Parse(File.ReadAllText("Idcount.txt"));
            Name = neme;
            Id= Idcount.ToString();
            NumofQuestion = 0;
            Percnt = 0;
            Status = false;
            Idcount += 1;
            File.WriteAllText("Idcount.txt", Idcount.ToString());
        }

    }
}
