using UnityEngine;

namespace Rouge_Legacy_2___Internal_Mod
{
    public class Loader
    {
        public static void Init()
        {
            Loader.Load = new GameObject();
            Loader.Load.AddComponent<Mods>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }
        
        public static void Unload()
        {
            UnloadLoad();
        }

        private static void UnloadLoad()
        {
            GameObject.Destroy(Load);
        }

        private static GameObject Load;
    }
}