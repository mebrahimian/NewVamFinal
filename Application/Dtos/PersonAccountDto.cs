using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Application.Dtos
{
    public class PersonAccountDto
    {
        public string? FullName { set; get; }
        public string? Family { get; set; }
        public string? Name { get; set; }
        public string? Father { get; set; }
        public string? Scode { get; set; }
        [Display(Name = "کد سپرده گذار")]
        [Required(ErrorMessage = "کدسپرده گذار.. اجباری است ")]
        [MaxLengthAttribute(5, ErrorMessage = "حداکثر 5 عدد وارد کنید")]
        public string Pcode { get; set; } = null!;
        [Display(Name = "شماره حساب")]
        [Required(ErrorMessage = "شماره حساب اجباری است ")]
        public long HesabNo { get; set; }
        [Display(Name = "تاریخ افتتاح")]
        [Required(ErrorMessage = "تاریخ افتتاح ..اجباری است ")]
        public string? Date { get; set; }
        [Display(Name = "موجودی اولیه")]
        [Required(ErrorMessage = "موجودی اولیه اجباری است ")]
        [Range(1, int.MaxValue, ErrorMessage = "موجودی اولیه نمی‌تواند صفر یا منفی باشد.")]
        public long? Firstqty { get; set; } = 0;

        [Display(Name = "مبلغ ماهیانه")]
        [Required(ErrorMessage = "مبلغ ماهیانه اجباری است ")]
        [Range(1, int.MaxValue, ErrorMessage = "مبلغ ماهیانه نمی‌تواند صفر یا منفی باشد.")]
        public long? Monthqty { get; set; } = 0;

        public long? Curqty { get; set; } = 0;

        public long? P { get; set; } = 0;

        public long? P1 { get; set; } = 0;

        public long? IdDi { get; set; } = 0;
        public int V_Day {  get; set; } 
        public int V_Month { get; set; } 
        public int V_Year { get; set; } 
        public long? V_Mojodi { get; set; } = 0;    
        

    }
}
