using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;
using MEC;

namespace RpManager
{
    public class MtfSpawnHint
    {
        public void OnNtfSpawning(SpawningEventArgs ev)
        {
            if (ev.Player.Team == Team.MTF)
            {
                if (ev.Player.Role == RoleType.NtfCaptain)
                {
                    ev.Player.ShowHint(Plugin.Singleton.Config.NtfCommanderHint, 10);
                }

                if (ev.Player.Role == RoleType.NtfPrivate)
                {
                    ev.Player.ShowHint(Plugin.Singleton.Config.OtherNtfHint, 10);
                }
            }
        }

        
    }
}
