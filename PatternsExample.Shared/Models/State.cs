using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsExample.Shared.Models
{
    public enum State
    {
        [Description("None")] None,
        [Description("Error")] Error,
        [Description("Info")] Info,
        [Description("Ok")] Ok
    }
}
