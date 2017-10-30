using System;
using System.Text.RegularExpressions;
using SFUTimetableParser.Core.Entities;

namespace SFUTimetableParser.Implementation
{
    /// <summary>
    /// Содержит вспомогательные методы для работы с перечислением <see cref="DaysOfWeek"/>
    /// </summary>
    public static class DaysOfWeekUtils
    {
        /// <summary>
        /// Возвращает объект перечисления <see cref="DaysOfWeek"/> по его названию
        /// </summary>
        /// <param name="day">Название дня недели (на русском или английском)</param>
        /// <returns>Объект перечисления, соответствующий названию</returns>
        /// <exception cref="InvalidDayOfWeekException">
        /// Выбрасывается, если переданный аргумент не соотвествует ни одному объекту перечисления
        /// </exception>
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
