using AdvancedTask_Specflow.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Model
{
    public class PasswordChangeDataModel:CommonDriver
    {
        public string Current { get; set; }
        public string New { get; set; }
        public string Confirm { get; set; }

    }
}
