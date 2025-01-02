using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Qvam
    {
        public int ReqNo { get; set; }

        public string? Pcode { get; set; }

        public string? Status { get; set; }

        public long? Mblg { get; set; }

        public string? Date { get; set; }

        public string? Sabtdate { get; set; }

        public string? Type { get; set; }

        public virtual Pvam? Pvam { get; set; }
    }
}
