using System;
using System.Text.RegularExpressions;
using SFUTimetableParser.Core.Entities;

namespace SFUTimetableParser.Implementation
{
    /** 
     * Содержит вспомогательные методы для работы с перечислением DaysOfWeek
     */
    public static class DaysOfWeekUtils
    {
        /** 
         * \brief Возвращает объект перечисления DaysOfWeek по его названию
         * \param day Название дня недели на русском или английском языке
         * \return Объект перечисления, соответствующий названию
         * \throw InvalidDayOfWeekException Выбрасывается, если переданный аргумент не соотвествует ни одному объекту перечисления
         */
        public static DaysOfWeek GetDayFromString(string day)
        {
            day = day.ToLower();

            if (Regex.IsMatch(day, @"\p{IsCyrillic}"))
            {
                switch (day)
                {
                    case "понедельник": return DaysOfWeek.Monday;
                    case "вторник": return DaysOfWeek.Tuesday;
                    case "среда": return DaysOfWeek.Wednesday;
                    case "четверг": return DaysOfWeek.Thursday;
                    case "пятница": return DaysOfWeek.Friday;
                    case "суббота": return DaysOfWeek.Saturday;
                    case "воскресенье": return DaysOfWeek.Sunday;
                    default: throw new InvalidDayOfWeekException();
                }
            }

            if (!Enum.TryParse(day, true, out DaysOfWeek result))
                throw new InvalidDayOfWeekException();

            return result;
        }
    }
}
