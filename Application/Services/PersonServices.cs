namespace VamBlazor.Client.Application.Services
{
    public class PersonServices
    {
        // تابع برای ساخت مسیر تصویر
        public string GetPersonPictureAddress(string personCode)
        {
            if (string.IsNullOrEmpty(personCode))
            {
                // در صورتی که PersonCode مقدار ندارد
                return "";  // یا می‌توانید یک مسیر پیش‌فرض بازگردانید
            }
            string[] extensions = { ".jpg", ".Jpeg",".png", ".gif" };
            foreach (var ext in extensions)
            {
                string imagePath = Path.Combine("wwwroot/Images", personCode + ext);

                if (File.Exists(imagePath))  // اگر فایل با این مسیر وجود داشته باشد
                {
                    return imagePath.Substring(8);  // مسیر صحیح تصویر را باز می‌گردانیم
                }
            }

            return Path.Combine("Images", "sun1.Jpeg");
        }

        public string GetPersonPlaceDesc(string personCode)
        {
            return "";
        }
    }
}
