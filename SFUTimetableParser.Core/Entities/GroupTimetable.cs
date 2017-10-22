using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /**
     * Модель расписания группы
     */
    public class GroupTimetable
    {
        /// Название группы
        public string GroupName { get; set; }

        /// Словарь, содержащий пары: день недели - список записей расписания
        public Dictionary<DaysOfWeek, ICollection<TimetableRecord>> Days { get; set; }
    }
}
