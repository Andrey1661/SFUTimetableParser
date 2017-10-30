using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /// <summary>
    /// Модель преподавателя
    /// </summary>
    public class Professor
    {
        /// <summary>
        /// Возвращает или задает имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает или задает фамилию
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Возвращает или задает отчество
        /// </summary>
        public string Patronymic { get; set; }
    }
}
