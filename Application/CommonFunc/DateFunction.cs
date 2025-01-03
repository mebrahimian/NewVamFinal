
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
    }
}
