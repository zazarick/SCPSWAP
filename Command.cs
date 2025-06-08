using System;
using System.Linq;
using CommandSystem;
using Exiled.API.Features;
using PlayerRoles;

namespace SCPSwap
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    [CommandHandler(typeof(ClientCommandHandler))]
    public class SCPSwapCommand : ICommand
    {
        public string Command => "scpswap";
        public string[] Aliases => Array.Empty<string>();
        public string Description => "Позволяет SCP-игроку один раз за раунд сменить свой SCP-класс на другой, если он свободен. Использование: scpswap 106";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!(sender is CommandSender commandSender) || !Player.TryGet(commandSender.SenderId, out Player player))
            {
                response = SCPSwapPlugin.Singleton.T.OnlyPlayer;
                return false;
            }

            var plugin = SCPSwapPlugin.Singleton;
            if (plugin == null || !plugin.SwapEnabled)
            {
                response = plugin.T.TimeExpired;
                return false;
            }

            if (!player.Role.Type.IsSCP(plugin.Config.AllowedScps))
            {
                response = plugin.T.NotSCP;
                return false;
            }

            if (plugin.SwappedPlayers.Contains(player.Id))
            {
                response = plugin.T.AlreadySwapped;
                return false;
            }

            if (arguments.Count == 0)
            {
                response = plugin.T.Usage;
                return false;
            }

            string input = arguments.At(0);

            RoleTypeId? targetScp = ParseScpRole(input, plugin.Config.AllowedScps);

            if (targetScp == null)
            {
                response = plugin.T.InvalidScp.Replace("{allowed}", string.Join(", ", plugin.Config.AllowedScps));
                return false;
            }

            if (player.Role.Type == targetScp)
            {
                response = plugin.T.AlreadyThisScp;
                return false;
            }

            bool alreadyExists = Player.List.Any(p =>
                p.Role.Type == targetScp && p != player && p.Role.Team == Team.SCPs && !plugin.SwappedPlayers.Contains(p.Id));

            if (alreadyExists)
            {
                response = plugin.T.Occupied;
                return false;
            }

            // Спавним на дефолтной точке нового SCP
            player.Role.Set(targetScp.Value, RoleSpawnFlags.UseSpawnpoint);
            plugin.SwappedPlayers.Add(player.Id);
            response = plugin.T.Success.Replace("{scp}", targetScp.Value.ToString());
            return true;
        }

        private RoleTypeId? ParseScpRole(string input, string[] allowedScps)
        {
            string value = input.Trim();
            if (!allowedScps.Contains(value))
                return null;
            switch (value)
            {
                case "049": return RoleTypeId.Scp049;
                case "079": return RoleTypeId.Scp079;
                case "096": return RoleTypeId.Scp096;
                case "106": return RoleTypeId.Scp106;
                case "173": return RoleTypeId.Scp173;
                case "939": return RoleTypeId.Scp939;
                case "3114": return RoleTypeId.Scp3114;
                default: return null;
            }
        }
    }

    public static class RoleExtensions
    {
        public static bool IsSCP(this RoleTypeId role, string[] allowed)
        {
            foreach (var val in allowed)
            {
                switch (val)
                {
                    case "049": if (role == RoleTypeId.Scp049) return true; break;
                    case "079": if (role == RoleTypeId.Scp079) return true; break;
                    case "096": if (role == RoleTypeId.Scp096) return true; break;
                    case "106": if (role == RoleTypeId.Scp106) return true; break;
                    case "173": if (role == RoleTypeId.Scp173) return true; break;
                    case "939": if (role == RoleTypeId.Scp939) return true; break;
                    case "3114": if (role == RoleTypeId.Scp3114) return true; break;
                }
            }
            return false;
        }
    }
}
