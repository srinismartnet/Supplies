using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBlazorCURD.Shared
{
    public class ManufacturingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Pincode { get; set; } = null!;
        public string District { get; set; } = null!;
        public string LicenseNumber { get; set; } = null!;
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime ValidUpToDate { get; set; } = DateTime.Now;
        public string EmailId { get; set; } = null!;
        public string NameOfContact { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Mandal { get; set; } = null!;
        public string Village { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public byte[]? FileContent { get; set; } = null;
    }
}
