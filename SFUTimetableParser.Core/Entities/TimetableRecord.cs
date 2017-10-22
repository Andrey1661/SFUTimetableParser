using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /**
     * Запись дневного расписания
     */
    public class TimetableRecord
    {
        /// Модель предмета по чётным неделям
        public SubjectModel SubjectOnEven { get; set; }

        /// Модель предмета по нечётным неделям
        public SubjectModel SubjectOnOdd { get; set; }

        /// Строковое представление временного периода занятия
        public string Period { get; set; }

        /// Порядковый номер занятия
        public int Number { get; set; }

        /// Определяет, зависит ли предмет от номера недели
        public bool DependedOnWeek => SubjectOnEven != SubjectOnOdd;
    }
}
