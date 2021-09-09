using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using UnityEngine;

namespace RpManager
{
    public class ClassDRandomBC
    {
        public static void OnSpawningClassd(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.ClassD)
            {
                string[] array = Plugin.Singleton.Config.BcListClassD.ToArray();

                int num = (UnityEngine.Random.Range(0, array.Length));
                ev.Player.ShowHint(array[num], 10);
            }
        }
    }
}
