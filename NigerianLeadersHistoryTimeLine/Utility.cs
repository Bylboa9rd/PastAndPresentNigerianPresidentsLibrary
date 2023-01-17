using static NigerianLeadersHistoryTimeLine.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NigerianLeadersHistoryTimeLine
{
    public class Utility
    {
        public static void DisplayPresidentsBy(string? name = null, int? age = null, int? tenures = null, bool? isAlive = null)
        {
            var filteredPresidents = GetPresidents().Where(p => 
                                                                         (name == null || p.Name.Contains(name)) &&
                                                                         (age == null || p.Age == age) &&
                                                                         (tenures == null || p.Tenures == tenures) &&
                                                                         (isAlive == null || p.IsAlive == isAlive)
                                                                         );
            if (!filteredPresidents.Any())
            {
                Console.WriteLine("No results found");
                return;
            }
            else
            {
                foreach (var president in filteredPresidents)
                {
                    Console.WriteLine(president);
                    
                }
            }        
        }

        public static void DisplayAllPresidents()
        {
            var allPresidents = GetPresidents().Take(GetPresidents().Count());

            foreach (var president in allPresidents)
            {
                Console.WriteLine(president);
            }
                                
        }
    }
}
