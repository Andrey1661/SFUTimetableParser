using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SFUTimetableParser.Core.Entities;

namespace SFUTimetableParser.Core
{
    /// <summary>
    /// Основной интерфейс, содержащий методы и свойства для работы с расписанием
    /// </summary>
    public interface ITimetableManager
    {
        /// <summary>
        /// Свойство, возвращающее список моделей распиания всех групп
        /// </summary>
        IEnumerable<GroupTimetable> Timetable { get; }

        /// <summary>
        /// Свойство, возвращающее список институтов
        /// </summary>
        IEnumerable<string> Institutes { get; }

        /// <summary>
        /// Свойство, возвращающее список предметов
        /// </summary>
        IEnumerable<string> Subjects { get; }

        /// <summary>
        /// Свойство, возвращающее список групп
        /// </summary>
        IEnumerable<string> Groups { get; }

        /// <summary>
        /// Возвращает расписание заданной группы
        /// </summary>
        /// <param name="groupName">Название группы</param>
        /// <returns>Модель расписания группы</returns>
        GroupTimetable GetGroupTimetable(string groupName);

        /// <summary>
        /// Асинхронно устанавливает соединение с сайтом СФУ и загружает данные
        /// </summary>
        Task LoadDataAsync();
    }
}
