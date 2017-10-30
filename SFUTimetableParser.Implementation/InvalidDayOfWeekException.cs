using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFUTimetableParser.Core.Entities;

namespace SFUTimetableParser.Implementation
{
    /// <summary>
    /// Возникает при ошибках в работе с перечислением <see cref="DaysOfWeek"/>
    /// </summary>
    public class InvalidDayOfWeekException : Exception
    {
    }
}
