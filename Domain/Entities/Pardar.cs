using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Pardar
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
    }

}
