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
        [Required(ErrorMessage = "کدسپرده گذار اجباری است ")]
        [MaxLengthAttribute(5, ErrorMessage = "حداکثر 5 عدد وارد کنید")]
        public string Pcode { get; set; } = null!;
        [Display(Name = "شماره حساب")]
        [Required(ErrorMessage = "شماره حساب اجباری است ")]
        public long HesabNo { get; set; }
        public string? Date { get; set; }
        public long? Firstqty { get; set; } = 0;

        public long? Monthqty { get; set; } = 0;

        public long? Curqty { get; set; } = 0;

        public long? P { get; set; }

        public long? P1 { get; set; }

        public long? IdDi { get; set; }
        public int V_Day {  get; set; }  
        public int V_Month { get; set; }
        public int V_Year { get; set; }  
        

        public string PcodePlaceHolder => "کدشخص را وارد کنید ";
        public string HesabNoPlaceHolder => "شماره حساب را وارد کنید";
    }
}
