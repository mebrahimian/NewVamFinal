using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Pvam
    {
        public int ReqNo { get; set; }

        public string? Scode { get; set; }

        public long? Mblgvam { get; set; }

        public long? Gst1 { get; set; }

        public long? Gst2 { get; set; }

        public byte? GstNo { get; set; }

        public string? DateD { get; set; }

        public string? DateG { get; set; }

        public int? GstPay { get; set; }

        public string? Status { get; set; }

        public string? Sabtdate { get; set; }

        public int? Pkarmozd { get; set; }

        public int? Mkarmozd { get; set; }

        public string? Lastdate { get; set; }

        public string? Type { get; set; }

        public int? Mblgmain { get; set; }

        public virtual ICollection<Dargst> Dargsts { get; set; } = new List<Dargst>();

        public virtual Qvam ReqNoNavigation { get; set; } = null!;
    }

}
