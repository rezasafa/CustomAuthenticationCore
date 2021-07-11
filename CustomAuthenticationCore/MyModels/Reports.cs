using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepehr4Core.MyModels.Reports
{
    class Reports
    {
    }

    public class ReportGroup
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Status { get; set; } = false;
    }

    public class ReportRepository
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int GroupID { get; set; }
        public bool Status { get; set; } = false;
        public bool DefaultReadOnly { get; set; } = false;
        public int TemplateID { get; set; }
        public string AccessLevel { get; set; }

    }



}
