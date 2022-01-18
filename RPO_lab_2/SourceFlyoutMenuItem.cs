using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPO_lab_2
{
    public class SourceFlyoutMenuItem
    {
        public SourceFlyoutMenuItem()
        {
            TargetType = typeof(SourceFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}