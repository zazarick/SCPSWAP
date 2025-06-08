using System.ComponentModel;

namespace SCPSwap
{
    public class SCPSwapTranslation
    {
        [Description("Сообщение-броадкаст для SCP в начале раунда. {time} заменяется на время в секундах.")]
        public string StartBroadcast { get; set; } = "Внимание! В течение {time} секунд вы можете один раз сменить свой SCP-класс командой scpswap [номер SCP]";

        [Description("Ошибка: не SCP.")]
        public string NotSCP { get; set; } = "Ты не играешь за SCP!";

        [Description("Ошибка: уже менял SCP.")]
        public string AlreadySwapped { get; set; } = "Ты уже менял SCP-класс в этом раунде!";

        [Description("Ошибка: неверное использование команды.")]
        public string Usage { get; set; } = "Использование: scpswap [номер SCP]\nПример: scpswap 049";

        [Description("Ошибка: неверный номер SCP.")]
        public string InvalidScp { get; set; } = "Некорректный номер SCP. Доступные: {allowed}.";

        [Description("Ошибка: уже этот SCP.")]
        public string AlreadyThisScp { get; set; } = "Ты уже играешь за этого SCP!";

        [Description("Ошибка: занят.")]
        public string Occupied { get; set; } = "Этот SCP уже занят другим игроком!";

        [Description("Успешная смена SCP.")]
        public string Success { get; set; } = "Ты сменил SCP-класс на {scp}!";

        [Description("Ошибка: истекло время.")]
        public string TimeExpired { get; set; } = "Время для смены SCP-класса истекло!";

        [Description("Ошибка: только игроки.")]
        public string OnlyPlayer { get; set; } = "Эту команду может использовать только игрок!";
    }
}
