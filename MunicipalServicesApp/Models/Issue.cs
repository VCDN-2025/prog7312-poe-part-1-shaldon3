using System;
using System.Collections.Generic;

namespace MunicipalServicesApp.Models
{
    public class Issue
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> AttachmentPaths { get; set; } = new List<string>();
        public DateTime SubmittedAt { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Submitted";
    }
}
