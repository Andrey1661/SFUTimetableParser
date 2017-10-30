using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /// <summary>
    /// Модель расписания группы
    /// </summary>
    public class GroupTimetable
    {
        /// <summary>
        /// Задает или возвращает название группы

        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Словарь, содержащий распиание по дням недели
        /// <remarks>
        /// Ключ словаря - день недели (см. <see cref="DaysOfWeek"/>);
        /// Соответсвующее ключу значение - список записей расписания на день.
        /// </remarks>
        /// </summary>
        public Dictionary<DaysOfWeek, ICollection<TimetableRecord>> Days { get; set; }
    }
}
