using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Hesab
    {
        public string? Scode { get; set; }

        public string? Pcode { get; set; }

        public long HesabNo { get; set; }

        public long? Firstqty { get; set; }

        public string? Date { get; set; }

        public long? Curqty { get; set; }

        public long? Monthqty { get; set; }

        public long? P { get; set; }

        public long? P1 { get; set; }

        public long? IdDi { get; set; }
        [NotMapped]
        public int V_Day => DateFunctions.GetDay(Date);
        [NotMapped]
        public int V_Month => DateFunctions.GetMonth(Date);
        [NotMapped]
        public int V_Year => DateFunctions.GetYear(Date);
        [NotMapped]
        public long V_Mojodi
        {
            get
            {
                return (Firstqty ?? 0) + (Curqty ?? 0); // مجموع یا محاسبه دلخواه
            }
        }
    }
}   


