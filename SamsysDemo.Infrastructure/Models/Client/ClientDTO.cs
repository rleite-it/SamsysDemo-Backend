using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsysDemo.Infrastructure.Models.Client
{
    public class ClientDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public bool IsActive { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string ConcurrencyToken { get; set; } = string.Empty;
    }
}
