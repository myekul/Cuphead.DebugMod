#if v1_3
using System;
using BepInEx.CupheadDebugMod.Config;
using HarmonyLib;
using MonoMod.Cil;
using static BepInEx.CupheadDebugMod.Config.Settings;
using static BepInEx.CupheadDebugMod.Config.SettingsEnums;
using OpCodes = Mono.Cecil.Cil.OpCodes;

namespace BepInEx.CupheadDebugMod.Components.RNG;

[HarmonyPatch]
internal class OldManPatternSelector : PluginComponent {
    [HarmonyPatch(typeof(OldManLevelPlatformManager), "handle_remove_platforms_cr", MethodType.Enumerator)]
    [HarmonyILManipulator]
    private static void PlatformRemoveOrderManipulator(ILContext il) {
        ILCursor cursor = new(il);
        if (cursor.TryGotoNext(MoveType.After, i =>
                i.OpCode == OpCodes.Call && i.Operand.ToString().Contains("UnityEngine.Random::Range(System.Int32,System.Int32)"))) {
            cursor.EmitDelegate<Func<int, int>>(randomIndex =>
                Level.ScoringData.difficulty == Level.Mode.Normal &&
                OldManPhaseOnePlatformRemoveOrderNormal.Value != OldManPhaseOnePlatformRemoveOrdersNormal.Random
                    ? (int)OldManPhaseOnePlatformRemoveOrderNormal.Value - 1
                    : randomIndex);
        }
    }

    [HarmonyPatch(typeof(OldManLevelSockPuppetHandler), "bounce_ball_cr", MethodType.Enumerator)]
    [HarmonyILManipulator]
    private static void PuppetPositionManipulator(ILContext il) {
        ILCursor cursor = new(il);
        if (cursor.TryGotoNext(MoveType.After,
                i => i.OpCode == OpCodes.Ldfld && i.Operand.ToString().Contains("Hands::leftHandPosString"),
                i => i.OpCode == OpCodes.Newobj && i.Operand.ToString().Contains("PatternString::.ctor"))) {
            cursor.EmitDelegate<Func<PatternString, PatternString>>(positions =>
                SetPuppetPosition(positions, GetLeftPuppetPattern()));
        }

        cursor.Index = 0;
        if (cursor.TryGotoNext(MoveType.After,
                i => i.OpCode == OpCodes.Ldfld && i.Operand.ToString().Contains("Hands::rightHandPosString"),
                i => i.OpCode == OpCodes.Newobj && i.Operand.ToString().Contains("PatternString::.ctor"))) {
            cursor.EmitDelegate<Func<PatternString, PatternString>>(positions =>
                SetPuppetPosition(positions, GetRightPuppetPattern()));
        }
    }

    private static PatternString SetPuppetPosition(PatternString positions, int selectedIndex) {
        if (selectedIndex != 0) {
            positions.SetSubStringIndex(selectedIndex - 2);
        }
        return positions;
    }

    private static int GetLeftPuppetPattern() {
        return Level.ScoringData.difficulty == Level.Mode.Hard
            ? (int)OldManPhaseTwoLeftPuppetPatternHard.Value
            : (int)OldManPhaseTwoLeftPuppetPatternNormal.Value;
    }

    private static int GetRightPuppetPattern() {
        return Level.ScoringData.difficulty == Level.Mode.Hard
            ? (int)OldManPhaseTwoRightPuppetPatternHard.Value
            : (int)OldManPhaseTwoRightPuppetPatternNormal.Value;
    }
}
#endif
