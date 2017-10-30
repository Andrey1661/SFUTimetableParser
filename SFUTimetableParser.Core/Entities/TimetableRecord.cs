using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SFUTimetableParser.Core.Entities
{
    /// <summary>
    /// Запись расписания на день
    /// <remarks>
    /// Данная модель соответствует строке в расписании на день
    /// </remarks>
    /// </summary>
    public class TimetableRecord
    {
        /// <summary>
        /// Возвращает или задает модель предмета по четным дням недели
        /// </summary>
        public SubjectModel SubjectOnEven { get; set; }

        /// <summary>
        /// Возвращает или задает модель предмета по нечетным дням недели
        /// </summary>
        public SubjectModel SubjectOnOdd { get; set; }

        /// <summary>
        /// Возвращает или задает строковое представление временного периода занятия
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// Возвращает или задает порядковый номер занятия
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Определяет, зависит ли предмет от номера недели
        /// <remarks>
        /// Возвращает истину, если предметы на раных неделях различаются, ложь - в противном случае
        /// </remarks>
        /// </summary>
        public bool DependedOnWeek => SubjectOnEven != SubjectOnOdd;
    }
}
