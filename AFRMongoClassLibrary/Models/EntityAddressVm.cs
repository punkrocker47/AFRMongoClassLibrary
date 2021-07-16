using System;

namespace AFRMongoClassLibrary.Models
{
    public class EntityAddressVm
    {
        public DateTime? CurrentAsOfDate { get; set; }

        public AddressVm Address { get; set; } = new();
    }
}