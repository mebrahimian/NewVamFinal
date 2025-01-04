using DAL;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.IdentityModel.Tokens;

namespace VamBlazor.Client.Application.CommonFunc
{
    public static class DateFunctions
    {
              
        public static int GetDay(string? input)
        {
            if (input != null)
            {
                if (input.Length < 10) return 1;
                var Day = input.Substring(8, 2);
                return int.Parse(Day);
            }
            else
            {
                return 1;
            }
        }
        public static int GetMonth(string? input)
        {
            if (input != null)
            {
                if (input.Length < 10) return 1;
                var Month = input.Substring(5, 2);
                return int.Parse(Month);
            }
            else
            {
                {  return 1; }
            }
        }
        public static int GetYear(string? input)
        {
            if (input != null)
            {
                if (input.Length < 10) return 1;
                var Month = input.Substring(0, 4);
                return int.Parse(Month);
            }
            else
            {
                return 1400;
            }
        }
        public static bool IsValidShamsiDay(DatabaseContext _Db, string? input)
        {
            
            if (input != null) { 
                if (_Db.tblDates.Any(p => p.HDate == input))
                return true;    
            }
            return false;
        }
        public static string ConvertToPersianDate(DateTime gregorianDate)
        {
            int gYear = gregorianDate.Year;
            int gMonth = gregorianDate.Month;
            int gDay = gregorianDate.Day;

            // محاسبه تعداد روزهای گذشته از 1 ژانویه 0001 میلادی
            DateTime startOfGregorian = new DateTime(1, 1, 1);
            int totalDays = (gregorianDate - startOfGregorian).Days;

            // محاسبه تعداد روزهای گذشته از تاریخ شمسی مرجع (21 مارس 622 میلادی)
            int jd = totalDays - 79;  // 79 روز اختلاف از 1 ژانویه 0001 میلادی تا 1 فروردین 622 میلادی

            // سال شمسی
            int persianYear = 0;
            int persianMonth = 0;
            int persianDay = 0;

            // محاسبه سال شمسی
            int j = (jd - 1) / 36524;  // تعداد سال‌های شمسی گذشته
            int k = jd - (365 * j);

            persianYear = 1400 + j;

            // محاسبه ماه شمسی
            if (k <= 0)
            {
                persianMonth = 7;
            }
            else
            {
                persianMonth = 5;
            }

            return $"{persianYear}/{persianMonth}/{persianDay}";
        }
    }
}
