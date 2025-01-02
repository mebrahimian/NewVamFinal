
namespace VamBlazor.Client.Application.CommonFunc
{
    public static class CodeToStringFunctions
    {
        public static string GetCityDesc(string input)
        {
            if (input == "1") return "شاهرود";
            if (input == "2") return "گرگان";
            if (input == "3") return "تهران";
            if (input == "4") return "سایـر";
            return "";
        }
        public static string GetSex(string input)
        {
            if (input == "1") return "مرد";
            if (input == "2") return "زن";
            return "";
        }
    }
}
