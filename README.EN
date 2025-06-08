# SCPSwap

**SCPSwap** is a plugin for SCP: Secret Laboratory that allows SCP players to change their SCP class once per round to any available SCP.  
The plugin supports multiple languages (Russian, English, Chinese — set in the config).

---

## Features

- Allows SCP players to change their SCP class once per round to another available SCP.
- The list of available SCPs is configurable.
- Time-limited: class change is only available during the first N seconds of the round.
- Multilanguage: all messages and hints are automatically translated when you change the language in the config (`ru`, `en`, `zh`).

---

## Installation

1. Download and put the `.dll` plugin file into `~\SCPSL\EXILED\Plugins\`.
2. On first launch, the config file `SCPSwap.yml` or `SCPSwap.json` will appear in `~\SCPSL\EXILED\Configs\`.
3. Open the config file and set the parameters to your liking.

---

## Config settings

### Example config (`SCPSwap.yml`):

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
Language: "en"
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

- **Language** — message language: `"ru"` (Russian), `"en"` (English), `"zh"` (Chinese).
- **AllowedScps** — list of SCPs that can be swapped to.
- **SwapTimeSeconds** — period (in seconds) after round start when class change is allowed.

---

## Usage

- After the round starts, all SCPs will receive a message with instructions and the time window for using the command.
- An SCP player can use the command in console/chat within the allowed time:
  ```
  .scpswap 106
  ```
  where `106` is the desired SCP number (see config).

- Each player can use the swap only once per round and only to a free SCP.

---

## Compatibility

- Requires Exiled 8.x or higher.
- Works on all modern versions of SCP:SL.

---

## License

Free to use with author attribution.  
Plugin author: [Zazar](https://github.com/zazarick)

---
