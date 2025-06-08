using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using MEC;
using System.Collections.Generic;
using System.Linq;

namespace SCPSwap
{
    public class SCPSwapPlugin : Plugin<SCPSwapConfig>
    {
        public override string Name => "SCPSwap";
        public override string Author => "Zazar";
        public override string Prefix => "scpswap";
        public override System.Version Version => new System.Version(1, 0, 0);

        public static SCPSwapPlugin Singleton;

        public HashSet<int> SwappedPlayers = new HashSet<int>();
        public bool SwapEnabled = false;

        private CoroutineHandle timerCoroutine;

        // Получение перевода для текущего языка
        public SCPSwapTranslation T => Config.Translation.ContainsKey(Config.Language)
            ? Config.Translation[Config.Language]
            : Config.Translation["ru"];

        public override void OnEnabled()
        {
            Singleton = this;
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
            Singleton = null;
            base.OnDisabled();
        }

        private void OnRoundStarted()
        {
            SwappedPlayers.Clear();
            SwapEnabled = true;
            if (timerCoroutine.IsRunning)
                Timing.KillCoroutines(timerCoroutine);
            timerCoroutine = Timing.RunCoroutine(DisableSwapAfterTime());

            // Броадкаст только SCP
            string message = T.StartBroadcast.Replace("{time}", Config.SwapTimeSeconds.ToString());
            foreach (var ply in Player.List)
            {
                if (ply.Role.Team == PlayerRoles.Team.SCPs)
                    ply.Broadcast(8, message, Broadcast.BroadcastFlags.Normal, true);
            }
        }

        private IEnumerator<float> DisableSwapAfterTime()
        {
            yield return Timing.WaitForSeconds(Config.SwapTimeSeconds);
            SwapEnabled = false;
        }
    }
}
