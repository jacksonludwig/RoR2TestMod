using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx;
using RoR2;

namespace Jackson
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.jackson.TestMod", "Test Mod", "1.0.0")]
    public class TestMod : BaseUnityPlugin
    {
        public void Awake()
        {
            Logger.LogMessage("Loaded TestMod");

            On.EntityStates.Huntress.ArrowRain.OnEnter += (orig, self) =>
            {
                Chat.AddMessage("Huntress Arrow Rain Used");
                orig(self);
            };
        }
    }
}
