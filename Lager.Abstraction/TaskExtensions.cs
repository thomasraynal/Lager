using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Abstraction
{
    public static class TaskHelper
    {
        public static Task CompletedTask { get; } = Task.Delay(0);
    }
}
