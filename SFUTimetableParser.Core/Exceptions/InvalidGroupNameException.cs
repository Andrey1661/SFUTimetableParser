using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Exceptions
{
    public class InvalidGroupNameException : Exception
    {
        public string GroupName { get; set; }

        public InvalidGroupNameException(string groupName)
        {
            GroupName = groupName;
        }

        public InvalidGroupNameException(string groupName, string message) : base(message)
        {
            GroupName = groupName;
        }
    }
}
