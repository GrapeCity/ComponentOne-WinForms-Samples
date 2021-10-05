using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public class TopNDataCreator
    {
        public static SmartPhoneVendor[] SmartPhoneVendors()
        {
            Queue<SmartPhoneVendor> vendors = new Queue<SmartPhoneVendor>();

            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Alcatel",
                Shipments = 34.1
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Apple",
                Shipments = 215.2
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Huawei",
                Shipments = 139
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Lenovo",
                Shipments = 50.7
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "LG",
                Shipments = 55.1
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Oppo",
                Shipments = 92.5
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Samsung",
                Shipments = 310.3
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Vivo",
                Shipments = 71.7
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "Xiaomi",
                Shipments = 61
            });
            vendors.Enqueue(new SmartPhoneVendor()
            {
                Name = "ZTE",
                Shipments = 61.9
            });

            return vendors.ToArray();
        }
    }

    public class SmartPhoneVendor
    {
        public string Name { get; set; }
        public double Shipments { get; set; }
    }
}
