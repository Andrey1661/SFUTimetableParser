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
    /**
     * Реализация основного интерфейса для работы с раписанием
     */
    public class TimetableManager : ITimetableManager
    {
        /// Ссылка на сайт СФУ
        private const string Link = "http://edu.sfu-kras.ru/timetable";

        private readonly IBrowsingContext _context;

        private IDocument _document;
        private IDocument _groupDocument;

        /**
         * Свойство, возвращающее список моделей распиания всех групп
         */
        public IEnumerable<GroupTimetable> Timetable { get; private set; }

        /**
         * Свойство, возвращающее список предметов
         */
        public IEnumerable<string> Subjects { get; private set; }

        /**
         * Свойство, возвращающее список групп
         */
        public IEnumerable<string> Groups { get; private set; }

        /**
         * Свойство, возвращающее список институтов
         */
        public IEnumerable<string> Institutes { get; private set; }

        /**
         * Стандартный конструктор
         */
        public TimetableManager()
        {
            var config = Configuration.Default.WithDefaultLoader();
            _context = BrowsingContext.New(config);
        }

        /**
         * \brief Возвращает расписание заданной группы
         * \param Название группы
         */
        public GroupTimetable GetGroupTimetable(string groupName)
        {
            throw new NotImplementedException();
        }

        /**
         * Асинхронный метод, используемы для загрузки данных с сафта СФУ
         */
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

        /**
         * На основе загруженного документа формирует список групп СФУ
         */
        private IEnumerable<string> LoadGroupList()
        {
            string selector = "div.collapsed-block ul li > a";
            var cells = _document.QuerySelectorAll(selector);

            return cells.Select(t => t.TextContent).ToList();
        }

        /**
         * На основе загруженного документа формирует список институтов СФУ
         */
        private IEnumerable<string> LoadInstitutesList()
        {
            string selector = "section > ul > li > div.collapsed-block > a > span";
            var cells = _document.QuerySelectorAll(selector);

            return cells.Select(t => t.TextContent).ToList();
        }

        /**
         * \brief Асинхронный метод, формирующий расписание группы с заданным названием
         * \param groupName Название группы
         */
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
