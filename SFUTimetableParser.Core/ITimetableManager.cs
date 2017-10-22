using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SFUTimetableParser.Core.Entities;

namespace SFUTimetableParser.Core
{
    /**
     * Основной интерфейс, содержащий методы и свойства для работы с расписанием
     */
    public interface ITimetableManager
    {
        /**
         * Свойство, возвращающее список моделей распиания всех групп
         */
        IEnumerable<GroupTimetable> Timetable { get; }

        /**
         * Свойство, возвращающее список институтов
         */
        IEnumerable<string> Institutes { get; }

        /**
         * Свойство, возвращающее список предметов
         */
        IEnumerable<string> Subjects { get; }

        /**
         * Свойство, возвращающее список групп
         */
        IEnumerable<string> Groups { get; }

        /**
         * \brief Возвращает расписание заданной группы
         * \param Название группы
         */
        GroupTimetable GetGroupTimetable(string groupName);

        /**
         * Асинхронный метод, используемы для загрузки данных с сафта СФУ
         */
        Task LoadDataAsync();
    }
}
