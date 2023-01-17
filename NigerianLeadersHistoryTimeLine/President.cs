using System;
using System.Collections.Generic;
using System.Text;

namespace NigerianLeadersHistoryTimeLine
{
    public class President
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public DateTime? DOB { get; set; }
        public List<string>? PeriodOfService { get; set; }
        public int Tenures { get; set; }
        public bool IsAlive { get; set; }
        public DateTime? DateOfDeath { get; set; }
               
        public override string ToString() => $"Name: {Name}\t\t\tAge: {Age}\t\tTenures: {Tenures}\t\tAlive: {IsAlive}";

        public President(string? name, int age, DateTime? dob, List<string>? periodOfService, int tenures, bool isAlive, DateTime? dateOfDeath)
        {
            Name = name;
            Age = age;
            DOB = dob;
            PeriodOfService = periodOfService;
            Tenures = tenures;
            IsAlive = isAlive;
            DateOfDeath = dateOfDeath;       
        }
        public President() { }
    }
}
