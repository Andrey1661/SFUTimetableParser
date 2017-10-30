using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Exceptions
{

    /// <summary>
    /// Возникает, если в метод, работающий с группами, передано несуществующее имя
    /// </summary>
    public class InvalidGroupNameException : Exception
    {
        /// <summary>
        /// Возвращает или задает имя группы, из-за которого было вызвано исключение
        /// </summary>
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
