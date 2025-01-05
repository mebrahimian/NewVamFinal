using System.ComponentModel.DataAnnotations.Schema;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Application.Dtos
{
    public class PardarDto
    {
        public string? Scode { get; set; }

        public string? Pcode { get; set; }

        public string? Action { get; set; }

        public decimal? Mblg { get; set; }
       
        public string? Date { get; set; }

        public string? ReqNo { get; set; }

        public string? Babat { get; set; }

        public string? Khayer { get; set; }

        public long IdDi { get; set; }
        [NotMapped]
        public int V_Day => DateFunctions.GetDay(Date);
        [NotMapped]
        public int V_Month => DateFunctions.GetMonth(Date);
        [NotMapped]
        public int V_Year => DateFunctions.GetYear(Date);
          
    }
}
