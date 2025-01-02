
using Microsoft.IdentityModel.Tokens;

namespace VamBlazor.Client.Application.CommonFunc
{
    public static class DateFunctions
    {
        public static int GetDay(string input)
        {
            if (input.Length < 10) return 1;
            var Day = input.Substring(8, 2);
            return int.Parse(Day);
        }
        public static int GetMonth(string input)
        {
            if (input.Length < 10) return 1;
            var Month = input.Substring(5, 2);
            return int.Parse(Month);
        }
        public static int GetYear(string input)
        {
            if (input.Length < 10) return 1;
            var Month = input.Substring(0, 4);
            return int.Parse(Month);
        }
    }
}
