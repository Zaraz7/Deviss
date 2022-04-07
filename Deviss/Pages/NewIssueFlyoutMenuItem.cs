using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deviss.Pages
{
    public class NewIssueFlyoutMenuItem
    {
        public NewIssueFlyoutMenuItem()
        {
            TargetType = typeof(NewIssueFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}