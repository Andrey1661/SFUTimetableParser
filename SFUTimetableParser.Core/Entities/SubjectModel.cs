using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /// <summary>
    /// Модель учебного предмета
    /// </summary>
    public class SubjectModel
    {
        /// <summary>
        /// Возвращает или задает название предмета
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает или задает вид занятию (лекция | практика)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Возвращает или задает аудиторию
        /// </summary>
        public string Auditory { get; set; }

        /// <summary>
        /// Возвращает или задает преподавателя
        /// </summary>
        public Professor Professor { get; set; }
    }
}
