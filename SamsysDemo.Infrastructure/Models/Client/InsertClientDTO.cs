﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsysDemo.Infrastructure.Models.Client
{
    public class InsertClientDTO
    {
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public string PhoneNumber { get; set; } = string.Empty;
        public string ConcurrencyToken { get; set; } = string.Empty;
    }
}
