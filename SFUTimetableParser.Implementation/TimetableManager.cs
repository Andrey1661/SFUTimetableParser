using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using SFUTimetableParser.Core;
using SFUTimetableParser.Core.Entities;

namespace SFUTimetableParser.Implementation
{
    /// <summary>
    /// Реализация основного интерфейса для работы с раписанием
    /// </summary>
    /// <seealso cref="SFUTimetableParser.Core.ITimetableManager" />
    public class TimetableManager : ITimetableManager
    {
        /// <summary>
        /// Ссылка на сайт СФУ, с которого считывается расписание
        /// </summary>
        private const string Link = "http://edu.sfu-kras.ru/timetable";

        /// <summary>
        /// Контекст для работы с HTML-документами
        /// </summary>
        private readonly IBrowsingContext _context;

        /// <summary>
        /// Основной документ
        /// </summary>
        private IDocument _document;

        /// <summary>
        /// Документ с расписанием определенной группы
        /// </summary>
        private IDocument _groupDocument;

        /// <summary>
        /// Возвращает список моделей распиания всех групп
        /// </summary>
        public IEnumerable<GroupTimetable> Timetable { get; private set; }

        /// <summary>
        /// Возвращает список предметов
        /// </summary>
        public IEnumerable<string> Subjects { get; private set; }

        /// <summary>
        /// Возвращает список групп
        /// </summary>
        public IEnumerable<string> Groups { get; private set; }

        /// <summary>
        /// Возвращает список институтов
        /// </summary>
        public IEnumerable<string> Institutes { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TimetableManager"/>
        /// </summary>
        public TimetableManager()
        {
            var config = Configuration.Default.WithDefaultLoader();
            _context = BrowsingContext.New(config);
        }

        /// <summary>
        /// Возвращает расписание заданной группы
        /// </summary>
        /// <param name="groupName">Название группы</param>
        /// <returns>
        /// Модель расписания группы
        /// </returns>
        public GroupTimetable GetGroupTimetable(string groupName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Асинхронно устанавливает соединение с сайтом СФУ и загружает данные
        /// </summary>
        public async Task LoadDataAsync()
        {
            if (_document == null)
            {
                try
                {
                    _document = await _context.OpenAsync(Link);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            //Groups = LoadGroupList();
            //Institutes = LoadInstitutesList();

            var timetable = await LoadGroupTimetableAsync("ки14-17б");
        }

        /// <summary>
        /// На основе загруженного документа формирует список групп СФУ
        /// </summary>
        /// <returns>СПисок групп</returns>
        private IEnumerable<string> LoadGroupList()
        {
            string selector = "div.collapsed-block ul li > a";
            var cells = _document.QuerySelectorAll(selector);

            return cells.Select(t => t.TextContent).ToList();
        }

        /// <summary>
        ///  На основе загруженного документа формирует список институтов СФУ
        /// </summary>
        /// <returns>Список институтов</returns>
        private IEnumerable<string> LoadInstitutesList()
        {
            string selector = "section > ul > li > div.collapsed-block > a > span";
            var cells = _document.QuerySelectorAll(selector);

            return cells.Select(t => t.TextContent).ToList();
        }

        /// <summary>
        /// Асинхронный метод, формирующий расписание группы с заданным названием
        /// </summary>
        /// <param name="groupName">Название группы</param>
        /// <returns>Модель расписания заданной группы</returns>
        private async Task<GroupTimetable> LoadGroupTimetableAsync(string groupName)
        {
            string linkToGroup = $"{Link}?group={groupName}";

            try
            {
                _document = await _context.OpenAsync(linkToGroup);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            throw new NotImplementedException();
        }
    }
}
