using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterEffects
{
    public class Job
    {
        public int JobID { get; set; }
        public string TitleText { get; set; }
        public string SubjectText { get; set; }
        public string Format { get; set; }
        public string Filename { get; set; }
        public string OutputFolder { get; set; }
        public bool Hebrew { get; set; }

        public ColorObject colorObject { get; set; }

    }
}
