using System.Collections.Generic;
using WebDriverOnCore.TestsInit;

namespace WebDriverOnCore.TestsData
{
    public static class ExpectedValues
    {

        public static readonly string MainPageHeadTitle
            = "Football.ua — Новости футбола. Всё о футболе: новости, обзоры, результаты матчей, видео, фото — football.ua";

        public static readonly List<string> HeaderMenuItemsList = new List<string>()
        {
            "Главная",
            "Новости",
            "Матчи и турниры",
            "Видео",
            "Фотогалереи",
            "Футбол на ТВ",
            "Конференции",
            "Блоги",
            ""
        };

        public static readonly Dictionary<string, string> PageNameUrlDictionary = new Dictionary<string, string>
        {
            { "Новости", TestSettings.NewsUrl },
            { "Матчи и турниры", TestSettings.ScoreBoardUrl },
            { "Видео", TestSettings.VideoUrl },
            { "Фотогалереи", TestSettings.PhotoUrl },
            { "Футбол на ТВ", TestSettings.TvScheduleUrl },
            { "Конференции", TestSettings.ConferencesUrl },
        };
    }
}
