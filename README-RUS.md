# SCPSwap

**SCPSwap** — это плагин для SCP: Secret Laboratory, который позволяет игрокам, играющим за SCP, один раз за раунд сменить свой SCP-класс на другой, если он свободен.  
Плагин поддерживает мультиязычность (русский, английский, китайский — настраивается в конфиге).

---

## Возможности

- Позволяет SCP-игроку один раз за раунд сменить свой SCP-класс на другой.
- Список доступных для выбора SCP настраивается в конфиге.
- Ограничение по времени: сменить SCP можно только в течение заданного времени после начала раунда.
- Мультиязычность: все сообщения и подсказки автоматически переводятся при смене языка в конфиге (`ru`, `en`, `zh`).

---

## Установка

1. Скачайте и поместите `.dll` файл плагина в папку `~\SCPSL\EXILED\Plugins\`.
2. После первого запуска в папке `~\SCPSL\EXILED\Configs\` появится файл конфига `SCPSwap.yml` или `SCPSwap.json`.
3. Откройте конфиг и настройте параметры по вашему желанию.

---

## Настройки конфига

### Пример конфига (`SCPSwap.yml`):

```yaml
IsEnabled: true
Debug: false
SwapTimeSeconds: 30
AllowedScps:
  - "049"
  - "079"
  - "096"
  - "106"
  - "173"
  - "939"
Language: "ru"
Translation:
  ru:
    StartBroadcast: "Внимание! В течение {time} секунд вы можете один раз сменить свой SCP-класс командой scpswap [номер SCP]"
    NotSCP: "Ты не играешь за SCP!"
    AlreadySwapped: "Ты уже менял SCP-класс в этом раунде!"
    Usage: "Использование: scpswap [номер SCP]\nПример: scpswap 049"
    InvalidScp: "Некорректный номер SCP. Доступные: {allowed}."
    AlreadyThisScp: "Ты уже играешь за этого SCP!"
    Occupied: "Этот SCP уже занят другим игроком!"
    Success: "Ты сменил SCP-класс на {scp}!"
    TimeExpired: "Время для смены SCP-класса истекло!"
    OnlyPlayer: "Эту команду может использовать только игрок!"
  en:
    StartBroadcast: "Attention! For {time} seconds you can change your SCP class once with the command scpswap [SCP number]"
    NotSCP: "You are not playing as SCP!"
    AlreadySwapped: "You have already changed your SCP class this round!"
    Usage: "Usage: scpswap [SCP number]\\nExample: scpswap 049"
    InvalidScp: "Incorrect SCP number. Available: {allowed}."
    AlreadyThisScp: "You are already playing as this SCP!"
    Occupied: "This SCP is already taken by another player!"
    Success: "You changed your SCP class to {scp}!"
    TimeExpired: "The time to change SCP class has expired!"
    OnlyPlayer: "Only players can use this command!"
  zh:
    StartBroadcast: "注意！在 {time} 秒内，你可以使用 scpswap [SCP编号] 命令更换一次SCP职业"
    NotSCP: "你不是SCP！"
    AlreadySwapped: "你本回合已更换过SCP职业！"
    Usage: "用法：scpswap [SCP编号]\\n例子：scpswap 049"
    InvalidScp: "SCP编号错误。可用：{allowed}。"
    AlreadyThisScp: "你已经是这个SCP了！"
    Occupied: "该SCP已被其他玩家占用！"
    Success: "你已将SCP职业更换为 {scp}！"
    TimeExpired: "更换SCP职业的时间已过！"
    OnlyPlayer: "只有玩家可以使用该命令！"
```

- **Language** — язык сообщений: `"ru"` (русский), `"en"` (английский), `"zh"` (китайский).
- **AllowedScps** — список SCP, на которых разрешена смена.
- **SwapTimeSeconds** — время (в секундах) после начала раунда, в течение которого доступна команда смены.

---

## Использование

- После старта раунда всем SCP выводится сообщение с инструкцией и временем для использования команды.
- SCP-игрок может в течение указанного времени прописать команду в консоль/чат:
  ```
  .scpswap 106
  ```
  где `106` — номер желаемого SCP (см. список в конфиге).

- Каждый игрок может сменить SCP только один раз за раунд и только на свободного SCP.

---

## Совместимость

- Требует Exiled 8.x и выше.
- Работает на всех современных версиях SCP:SL.

---

## Лицензия

Свободное использование с сохранением указания автора.  
Автор плагина: [Zazar](https://github.com/zazarick)

---
