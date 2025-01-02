namespace VamBlazor.Client.Application.CommonFunc
{
    public static class TextHelper
    {
        public static string NormalizeString(string input)
        {
            // تبدیل تمام حروف "ی"  به "ي"
            return input.Replace('ی', 'ي');  // یا برعکس
        }

    }
}