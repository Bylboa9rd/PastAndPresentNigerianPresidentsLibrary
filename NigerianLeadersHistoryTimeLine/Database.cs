using System;
using System.Collections.Generic;

namespace NigerianLeadersHistoryTimeLine
{
    public class Database
    {
        private static List<President> _presidents = new List<President>()
        {
            new President("Chief Dr Benjamin Nnamdi Azikiwe", 91, new DateTime(1904, 11, 16), new List<string>(){"October, 1963 - January, 1966"}, 1, false, new DateTime(1996, 5, 11)),
            new President("Major-General Johnson Thomas Umunnakwe Aguiyi-Ironsi", 42, new DateTime(1924, 3, 3), new List<string>(){"January, 1966 - July, 1966"}, 1, false, new DateTime(1966, 7, 29)),
            new President("General Yakubu Gowon", 88, new DateTime(1934, 10, 19), new List<string>(){"August, 1966 - July, 1975"}, 1, true, null),
            new President("General Murtala Ramat Muhammed", 37, new DateTime(1938, 11, 8), new List<string>(){"July, 1975 - February, 1976"}, 1, false, new DateTime(1976, 2, 13)),
            new President("General Olusegun Aremu Okikiola Matthew Obasanjo", 85, new DateTime(1937, 3, 5), new List<string>(){"February, 1976 - October 1979", "May 1999 - May 2007" }, 3, true, null),
            new President("Shehu Usman Aliyu Shagari", 93, new DateTime(1925, 2, 25), new List<string>(){"October, 1979 - December, 1983"}, 1, false, new DateTime(2018, 12, 28)),
            new President("Major-General Muhammadu Buhari", 80, new DateTime(1942, 12, 17), new List<string>(){"December, 1983 - August 1985", "May 2015 - Date"}, 3, true, null),
            new President("General Ibrahim Badamasi Babangida", 81, new DateTime(1941, 8, 17), new List<string>(){"August, 1985 - August 1993"}, 2, true, null),
            new President("Chief Ernest Adekunle Oladeinde Shonekan", 85, new DateTime(1936, 5, 9), new List<string>(){"August, 1993 - November 1993"}, 1, false, new DateTime(2022, 1, 11)),
            new President("General Sanni Abacha", 54, new DateTime(1943, 9, 20), new List<string>(){"November, 1993 - June 1998" }, 1, false, new DateTime(1998, 6, 8)),
            new President("General Abdulsalami Alhaji Abubakar", 80, new DateTime(1942, 6, 13), new List<string>(){"June, 1998 - May, 1999"}, 1, true, null),
            new President("Umaru Musa Yar'adua", 58, new DateTime(1951, 8, 16), new List<string>(){"May, 2007 - May, 2010"}, 1, false, new DateTime(2010, 5, 5)),
            new President("Dr Goodluck Ebele Jonathan", 65, new DateTime(1957, 11, 20), new List<string>(){"May, 2010 - May, 2015"}, 1, true, null)
        };

        public static IEnumerable<President> GetPresidents()
        {
            return _presidents;
        }

    }

}

