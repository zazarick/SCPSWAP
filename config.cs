using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace SCPSwap
{
    public class SCPSwapConfig : IConfig
    {
        [Description("Включение или выключение плагина SCPSwap.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Включить или выключить режим отладки.")]
        public bool Debug { get; set; } = false;

        [Description("Время (в секундах) на смену SCP после начала раунда.")]
        public float SwapTimeSeconds { get; set; } = 30f;

        [Description("Список разрешённых SCP для смены.")]
        public string[] AllowedScps { get; set; } = new[] { "049", "079", "096", "106", "173", "939" };

        [Description("Язык сообщений (ru, en, zh).")]
        public string Language { get; set; } = "ru";

        [Description("Таблица переводов.")]
        public Dictionary<string, SCPSwapTranslation> Translation { get; set; } = new Dictionary<string, SCPSwapTranslation>
        {
            // Русский
            ["ru"] = new SCPSwapTranslation
            {
                StartBroadcast = "Внимание! В течение {time} секунд вы можете один раз сменить свой SCP-класс командой scpswap [номер SCP]",
                NotSCP = "Ты не играешь за SCP!",
                AlreadySwapped = "Ты уже менял SCP-класс в этом раунде!",
                Usage = "Использование: scpswap [номер SCP]\nПример: scpswap 049",
                InvalidScp = "Некорректный номер SCP. Доступные: {allowed}.",
                AlreadyThisScp = "Ты уже играешь за этого SCP!",
                Occupied = "Этот SCP уже занят другим игроком!",
                Success = "Ты сменил SCP-класс на {scp}!",
                TimeExpired = "Время для смены SCP-класса истекло!",
                OnlyPlayer = "Эту команду может использовать только игрок!"
            },
            // Английский
            ["en"] = new SCPSwapTranslation
            {
                StartBroadcast = "Attention! For {time} seconds you can change your SCP class once with the command scpswap [SCP number]",
                NotSCP = "You are not playing as SCP!",
                AlreadySwapped = "You have already changed your SCP class this round!",
                Usage = "Usage: scpswap [SCP number]\nExample: scpswap 049",
                InvalidScp = "Incorrect SCP number. Available: {allowed}.",
                AlreadyThisScp = "You are already playing as this SCP!",
                Occupied = "This SCP is already taken by another player!",
                Success = "You changed your SCP class to {scp}!",
                TimeExpired = "The time to change SCP class has expired!",
                OnlyPlayer = "Only players can use this command!"
            },
            // Китайский (пример)
            ["zh"] = new SCPSwapTranslation
            {
                StartBroadcast = "注意！在 {time} 秒内，你可以使用 scpswap [SCP编号] 命令更换一次SCP职业",
                NotSCP = "你不是SCP！",
                AlreadySwapped = "你本回合已更换过SCP职业！",
                Usage = "用法：scpswap [SCP编号]\n例子：scpswap 049",
                InvalidScp = "SCP编号错误。可用：{allowed}。",
                AlreadyThisScp = "你已经是这个SCP了！",
                Occupied = "该SCP已被其他玩家占用！",
                Success = "你已将SCP职业更换为 {scp}！",
                TimeExpired = "更换SCP职业的时间已过！",
                OnlyPlayer = "只有玩家可以使用该命令！"
            }
        };
    }
}
