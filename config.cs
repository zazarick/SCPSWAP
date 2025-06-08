using Exiled.API.Interfaces;
using System.ComponentModel;

namespace SCPSwap
{
    public class SCPSwapConfig : IConfig
    {
        [Description("Включение или выключение плагина SCPSwap.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Время (в секундах) на смену SCP после начала раунда.")]
        public float SwapTimeSeconds { get; set; } = 30f;

        [Description("Сообщение-броадкаст для SCP в начале раунда. {time} заменяется на время в секундах.")]
        public string StartBroadcast { get; set; } = "Внимание! В течение {time} секунд вы можете один раз сменить свой SCP-класс командой scpswap [номер SCP]";

        [Description("Список разрешённых SCP для смены.")]
        public string[] AllowedScps { get; set; } = new[] { "049", "079", "096", "106", "173", "939" };

        [Description("Включить или выключить режим отладки.")]
        public bool Debug { get; set; } = false;
    }
}
