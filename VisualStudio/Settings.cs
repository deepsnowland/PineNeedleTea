using ModSettings;

namespace PineNeedleTeaMod
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Pine Needle Settings")]

        [Name("Pine Needle Spawn Chance")]
        [Description("Adjust the chance for pine needles to spawn under trees. Default: 10%.")]
        [Slider(0f,25f,51)]
        public float NeedleChance = 10.5f;

        [Name("Pine Needle Tea Vitamin C Amount")]
        [Description("Adjust the amount of Vitamin C Pine Needle Tea gives. Default: 30.")]
        [Slider(0,35,30)]
        public int VitaminC = 30;

        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default. (Confirm and scene reload/transition required.)")]
        public bool ResetSettings = false;

        protected override void OnConfirm()
        {
            ApplyReset();
            instance.ResetSettings = false;
            base.OnConfirm();
        }

        public static void ApplyReset()
        {
            if(instance.ResetSettings==true)
            {
                instance.VitaminC = 30;
                instance.NeedleChance = 10.5f;
                instance.RefreshGUI();
            }
        }
    }


}
