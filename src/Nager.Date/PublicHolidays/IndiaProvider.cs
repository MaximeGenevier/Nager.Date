using Nager.Date.Contract;
using Nager.Date.Model;
using System.Collections.Generic;
using System.Linq;

namespace Nager.Date.PublicHolidays
{
    /// <summary>
    /// India
    /// </summary>
    public class IndiaProvider : IPublicHolidayProvider, ICountyProvider
    {
        /// <summary>
        /// IndiaProvider
        /// </summary>
        public IndiaProvider()
        {
        }

        ///<inheritdoc/>
        public IDictionary<string, string> GetCounties()
        {
            return new Dictionary<string, string>
            {
                //https://en.wikipedia.org/wiki/ISO_3166-2:IN
                //States
                {"IN-AP", "Andhra Pradesh"}, 
                {"IN-AR", "Arunāchal Pradesh"},
                {"IN-AS", "Assam"},
                {"IN-BR", "Bihār"},
                {"IN-CT", "Chhattīsgarh"},
                {"IN-GA", "Goa"},
                {"IN-GJ", "Gujarāt"},
                {"IN-HR", "Haryāna"},
                {"IN-HP", "Himāchal Pradesh"},
                {"IN-JH", "Jhārkhand"},
                {"IN-KA", "Karnātaka"},
                {"IN-KL", "Kerala"},
                {"IN-MP", "Madhya Pradesh"},
                {"IN-MH", "Mahārāshtra"},
                {"IN-MN", "Manipur"},
                {"IN-ML", "Meghālaya"},
                {"IN-MZ", "Mizoram"},
                {"IN-NL", "Nāgāland"},
                {"IN-OR", "Odisha"},
                {"IN-PB", "Punjab"},
                {"IN-RJ", "Rājasthān"},
                {"IN-SK", "Sikkim"},
                {"IN-TN", "Tamil Nādu"},
                {"IN-TG", "Telangāna"},
                {"IN-TR", "Tripura"},
                {"IN-UT", "Uttarākhand"},
                {"IN-UP", "Uttar Pradesh"},
                {"IN-WB", "West Bengal"}, 
                
                //Union Territories
                {"IN-AN", "Andaman and Nicobar Islands"}, 		
                {"IN-CH", "Chandigarh"}, 		
                {"IN-DH", "Dādra and Nagar Haveli and Damān and Diu"},		
                {"IN-DL", "Delhi"}, 		
                {"IN-JK", "Jammu and Kashmīr"}, 		
                {"IN-LA", "Ladākh"}, 		
                {"IN-LD", "Lakshadweep"}, 		
                {"IN-PY", "Puducherry"}
            };
        }

        ///<inheritdoc/>
        public IEnumerable<PublicHoliday> Get(int year)
        {
            var countryCode = CountryCode.IN;

            var items = new List<PublicHoliday>();

            // National and notable holidays
            items.Add(new PublicHoliday(year, 1, 1, "Navidad", "New Year's Day", countryCode));
            items.Add(new PublicHoliday(year, 1, 14, "Uttarayan", "Uttarayan", countryCode).SetCounties("IN-GJ"));
            items.Add(new PublicHoliday(year, 1, 23, "Netaji Subhas Chandra Bose's Jayanti (Parakram Divas)", "Netaji Subhas Chandra Bose's Jayanti (Parakram Divas)", countryCode).SetCounties("IN-AS", "IN-JH", "IN-OR", "IN-TR", "IN-WB"));
            items.Add(new PublicHoliday(year, 1, 26, "Republic Day", "Republic Day", countryCode));
            items.Add(new PublicHoliday(year, 1, 30, "Mahatma Gandhi's Death Anniversary", "Mahatma Gandhi's Death Anniversary", countryCode));
            items.Add(new PublicHoliday(year, 2, 19, "Chhatrapati Shivaji Maharaj Jayanti", "Chhatrapati Shivaji Maharaj Jayanti", countryCode).SetCounties("IN-MH"));
            items.Add(new PublicHoliday(year, 2, 20, "Statehood Day", "Arunachal Pradesh Day", countryCode).SetCounties("IN-AR"));
            items.Add(new PublicHoliday(year, 2, 26, "Hazrat Ali Jayanti", "Hazrat Ali Jayanti", countryCode));
            items.Add(new PublicHoliday(year, 3, 15, "Kanshi Ram's Jayanti", "Kanshi Ram's Jayanti", countryCode).SetCounties("IN-UP"));
            items.Add(new PublicHoliday(year, 3, 22, "Bihar Day", "Bihar Day", countryCode).SetCounties("IN-BR"));
            items.Add(new PublicHoliday(year, 3, 30, "Rajasthan Day", "Rajasthan Day", countryCode).SetCounties("IN-RJ"));
            items.Add(new PublicHoliday(year, 4, 1, "Utkala Dibasa", "Odisha Day", countryCode).SetCounties("IN-OR"));
            items.Add(new PublicHoliday(year, 4, 14, "Dr. Babasaheb Ambedkar's Jayanti", "Dr. Babasaheb Ambedkar's Jayanti", countryCode).SetCounties("IN-AP", "IN-BR", "IN-CH", "IN-CT", "IN-GA", "IN-GJ", "IN-HR", "IN-HP", "IN-JK", "IN-JH", "IN-KA", "IN-KL", "IN-LA", "IN-MP", "IN-MH", "IN-OR", "IN-PB", "IN-PY", "IN-RJ", "IN-SK", "IN-TN", "IN-TG", "IN-UT", "IN-UP", "IN-WB"));
            items.Add(new PublicHoliday(year, 4, 14, "Samrat Ashoka's Jayanti", "Samrat Ashoka's Jayanti", countryCode).SetCounties("IN-BR"));
            items.Add(new PublicHoliday(year, 4, 15, "Assamese New Year", "Assamese New Year", countryCode).SetCounties("IN-AS"));
            items.Add(new PublicHoliday(year, 5, 1, "Labor Day", "Labor Day", countryCode).SetCounties()); // TODO : add counties
            items.Add(new PublicHoliday(year, 8, 15, "Independance Day", "Independance Day", countryCode));
            items.Add(new PublicHoliday(year, 10, 2, "Mahatma Gandhi's Birthday", "Mahatma Gandhi's Birthday", countryCode));
            items.Add(new PublicHoliday(year, 12, 25, "Christmas Day", "Christmas Day", countryCode));

            return items.OrderBy(o => o.Date);
        }

        ///<inheritdoc/>
        public IEnumerable<string> GetSources()
        {
            return new string[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_India",
                "https://www.india.gov.in/state-and-ut-holiday-calendar"
            };
        }
    }
}
