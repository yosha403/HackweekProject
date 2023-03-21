using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProcessor.Model
{
    public class EmailInfo
    {
        public string SenderEmailId  { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}
