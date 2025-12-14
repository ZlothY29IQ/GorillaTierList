using BepInEx;
using System.Reflection;
using HarmonyLib;
using GorillaTierList.Behaviors;
using System.Threading.Tasks;
using System;

namespace GorillaTierList
{
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            new Harmony(Constants.GUID).PatchAll(assembly);
           
        }
        
       
    }
}
