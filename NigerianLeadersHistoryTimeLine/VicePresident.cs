using System;
using System.Collections.Generic;
using System.Text;

namespace NigerianLeadersHistoryTimeLine
{
    public class VicePresident : President
    {
        public VicePresident(string? name, int age, DateTime? dob, List<string>? periodOfService, int tenures, bool isAlive, DateTime? dateOfDeath) : base(name, age, dob, periodOfService, tenures, isAlive, dateOfDeath)
        {

        }
    }
}
