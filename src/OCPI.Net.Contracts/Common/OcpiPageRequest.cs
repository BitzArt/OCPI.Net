using BitzArt.Pagination;
using System;

namespace OCPI
{
    public class OcpiPageRequest : PageRequest
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
