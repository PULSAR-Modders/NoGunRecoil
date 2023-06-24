using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_gun_recoil
{
    internal class PawnItem
    {
        [HarmonyPatch(typeof(PLPawnItem_BurstPistol), "FireShot")]
        class BurstPistol
        {
            static void Postfix(PLPawn ___MySetupPawn)
            {
                ___MySetupPawn.VerticalMouseLook.RotationY_AddOverTime -= 1.25f;
                ___MySetupPawn.VerticalMouseLook.RotationY -= 0.5f;
            }
        }

        [HarmonyPatch(typeof(PLPawnItem_HandShotgun), "InternalFireShot")]
        class HandShotgun
        {
            static void Postfix(PLPawn ___MySetupPawn)
            {
                ___MySetupPawn.VerticalMouseLook.RotationY_AddOverTime -= 7f;
            }
        }

        [HarmonyPatch(typeof(PLPawnItem_HeavyPistol), "FireShot")]
        class HeavyPistol
        {
            static void Postfix(PLPawn ___MySetupPawn)
            {
                ___MySetupPawn.VerticalMouseLook.RotationY_AddOverTime -= 0.5f;
            }
        }

        [HarmonyPatch(typeof(PLPawnItem_PhasePistol), "FireShot")]
        class PhasePistol
        {
            static void Postfix(PLPawn ___MySetupPawn)
            {
                ___MySetupPawn.VerticalMouseLook.RotationY_AddOverTime -= 0.3f;
            }
        }

        [HarmonyPatch(typeof(PLPawnItem_VortexGrenade), "FireShot")]
        class VortexGrenade
        {
            static void Postfix(PLPawn ___MySetupPawn)
            {
                ___MySetupPawn.VerticalMouseLook.RotationY_AddOverTime -= 12f;
                ___MySetupPawn.VerticalMouseLook.RotationY -= 2f;
            }
        }

        [HarmonyPatch(typeof(PLPawnItem_WDHeavy), "FireShot")]
        class WDHeavy
        {
            static void Postfix(PLPawn ___MySetupPawn)
            {
                ___MySetupPawn.VerticalMouseLook.RotationY_AddOverTime -= 6f;
                ___MySetupPawn.VerticalMouseLook.RotationY -= 0.5f;
            }
        }
    }
}
