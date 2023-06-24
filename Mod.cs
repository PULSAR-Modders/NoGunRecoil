using PulsarModLoader;

namespace No_gun_recoil
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Removes gun recoil";

        public override string Name => "No gun recoil";

        public override string ModID => "nogunrecoil";

        public override string HarmonyIdentifier()
        {
            return "id107.nogunrecoil";
        }
    }
}
