using BepInEx;
using BepInEx.Logging;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BawkLib
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            SceneManager.sceneLoaded += SceneLoaded;
        }

        private void SceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            if(arg0.name == "MainDayScene")
            {
                Events.onLevelLoaded.Invoke();
            }
        }
    }
}
