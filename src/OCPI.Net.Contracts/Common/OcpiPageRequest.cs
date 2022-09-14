using BitzArt.Pagination;

namespace OCPI
{
    public class OcpiPageRequest : PageRequest
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}
