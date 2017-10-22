using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /**
     * Модель предмета в расписании
     */
    public class SubjectModel
    {
        /// Название
        public string Name { get; set; }

        /// Тип (лекция или практика)
        public string Type { get; set; }

        /// Аудитория
        public string Auditory { get; set; }

        /// Модель преподавателя
        public Professor Professor { get; set; }
    }
}
