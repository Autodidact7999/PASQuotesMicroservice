using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PolicyAdmin.QuotesMS.API.Data;
using PolicyAdmin.QuotesMS.API.Models;
using PolicyAdmin.QuotesMS.API.Models.Enum;

namespace PolicyAdmin.QuotesMS.API.DataLayer
{
    public class DataGenerator
    {
        public DataGenerator( ) { }
        public static void Initialize(QuotesContext context)
        {
            List<QuoteMaster> quotes = getQuotes();
            for (int i = 0; i < quotes.Count; i++)
            {
                context.QuotesMaster.Add(quotes[i]);
            }
            context.SaveChanges();
                
            
        }
            private static List<QuoteMaster> getQuotes()
        {
            return new List<QuoteMaster>() {
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=30300 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=73900 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=91500 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=85300 },
                new QuoteMaster {PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=99300 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=40000 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=89100 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=22400 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=14700 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=83700 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=21800 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=98700 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=56200 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=77100 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=46800 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=78200 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Equipment, Quote=30300 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=73900 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Equipment, Quote=85300 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Equipment, Quote=99300 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=40000 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=89100 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Equipment, Quote=22400 },
                new QuoteMaster {PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Equipment, Quote=14700 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=83700 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=21800 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Equipment, Quote=98700 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Equipment, Quote=56200 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=77100 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=46800 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Equipment, Quote=78200 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Singage, Quote=30300 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=73900 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=91500 },
                new QuoteMaster { PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Singage, Quote=85300 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Singage, Quote=99300 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=40000 },
                new QuoteMaster { PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=89100 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Singage, Quote=14700 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=83700 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=21800 },
                new QuoteMaster { PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Singage, Quote=98700 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Singage, Quote=56200 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=77100 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=46800 },
                new QuoteMaster { PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Singage, Quote=78200 },
            };
        }
    }

}



// Generate Random Values Python Script

//propertyType = {
//    0:"PropertyType.Building",
//    1:"PropertyType.Equipment",
//    2:"PropertyType.Singage",
//    3:"PropertyType.Inventory",
//    4:"PropertyType.Furniture"
//}
//a = []
//b = []
//for i in range(200):
//    pvrf = random.randint(0, 8)
//    pvrt = random.randint(pvrf, 8)
//    bvrf = random.randint(0, 8)
//    bvrt = random.randint(pvrf, 8)
//    pt = random.randint(0, 4)
//    quote = random.randint(100, 9999) * 100


//    a.append("new QuoteMaster {{ Id={0},PropertyValueRangeFrom={1}, PropertyValueRangeTo={2}, BusinesssValueRangeFrom={3}, BusinesssValueRangeTo={4}, PropertyType={5}, Quote={6} }}".format(i + 1, pvrf, pvrt, bvrf, bvrt, propertyType[pt], quote))
//    b.append("({},{},{},{},{},{})".format(pvrf, pvrt, bvrf, bvrt, pt, quote))

//print(*a, sep = ",\n")
//print(*b, sep = ",\n")