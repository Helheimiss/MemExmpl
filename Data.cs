namespace MemExmpl
{
    internal class Data
    {
        private static string GAME = "Muck.exe";
        private static string MODULE = "mono-2.0-bdwgc.dll";


        public static float hp = 0;
        private static uint[] hp_PTR = { 0x00494A90, 0xC98, 0x9B0 };

        public static float hunger = 0;
        private static uint[] hunger_PTR = { 0x00494A90, 0xC98, 0x9CC };

        public static float stamina = 0;
        private static uint[] stamina_PTR = { 0x00494A90, 0xC98, 0x9C4 };


        public static int max_hp = 0;
        private static uint[] max_hp_PTR = { 0x00494A90, 0xC98, 0x9B4 };

        public static float max_hunger = 0;
        private static uint[] max_hunger_PTR = { 0x00494A90, 0xC98, 0x9D0 };

        public static float max_stamina = 0;
        private static uint[] max_stamina_PTR = { 0x00494A90, 0xC98, 0x9C8 };


        // get
        public static void GetHP()
        {
            SOE_DLL.ReadMemEx(GAME, MODULE, hp_PTR, hp_PTR.Length, out hp, sizeof(float));
        }

        public static void GetHunger()
        {
            SOE_DLL.ReadMemEx(GAME, MODULE, hunger_PTR, hunger_PTR.Length, out hunger, sizeof(float));
        }

        public static void GetStamina()
        {
            SOE_DLL.ReadMemEx(GAME, MODULE, stamina_PTR, stamina_PTR.Length, out stamina, sizeof(float));
        }

        public static void GetMaxHP()
        {
            SOE_DLL.ReadMemEx(GAME, MODULE, max_hp_PTR, max_hp_PTR.Length, out max_hp, sizeof(int));
        }

        public static void GetMaxHunger()
        {
            SOE_DLL.ReadMemEx(GAME, MODULE, max_hunger_PTR, max_hunger_PTR.Length, out max_hunger, sizeof(float));
        }

        public static void GetMaxStamina()
        {
            SOE_DLL.ReadMemEx(GAME, MODULE, max_stamina_PTR, max_stamina_PTR.Length, out max_stamina, sizeof(float));
        }

        // set
        public static void SetHP(float newValue)
        {
            SOE_DLL.WriteMemEx(GAME, MODULE, hp_PTR, hp_PTR.Length, ref newValue, sizeof(float));
        }

        public static void SetHunger(float newValue)
        {
            SOE_DLL.WriteMemEx(GAME, MODULE, hunger_PTR, hunger_PTR.Length, ref newValue, sizeof(float));
        }

        public static void SetStamina(float newValue)
        {
            SOE_DLL.WriteMemEx(GAME, MODULE, stamina_PTR, stamina_PTR.Length, ref newValue, sizeof(float));
        }

        public static void SetMaxHP(int newValue)
        {
            SOE_DLL.WriteMemEx(GAME, MODULE, max_hp_PTR, max_hp_PTR.Length, ref newValue, sizeof(int));
        }

        public static void SetMaxHunger(float newValue)
        {
            SOE_DLL.WriteMemEx(GAME, MODULE, max_hunger_PTR, max_hunger_PTR.Length, ref newValue, sizeof(float));
        }

        public static void SetMaxStamina(float newValue)
        {
            SOE_DLL.WriteMemEx(GAME, MODULE, max_stamina_PTR, max_stamina_PTR.Length, ref newValue, sizeof(float));
        }
    }
}