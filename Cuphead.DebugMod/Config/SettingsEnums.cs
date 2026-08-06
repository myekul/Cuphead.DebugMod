using System.ComponentModel;

namespace BepInEx.CupheadDebugMod.Config {
    public static class SettingsEnums {

        public enum LobberCritSettings {
            Random,
            Always,
            Never
        }

        public enum RngOverride {
            Custom,
            Vanilla,
            [Description("Perfect RNG (1.1+ Any%)")]
            PerfectRng11
        }

#if v1_3
        public enum RelicLevels {
            Default,
            [Description("Broken Relic")]
            BrokenRelic,
            [Description("Cursed Relic 1")]
            CursedRelic1,
            [Description("Cursed Relic 2")]
            CursedRelic2,
            [Description("Cursed Relic 3")]
            CursedRelic3,
            [Description("Cursed Relic 4")]
            CursedRelic4,
            [Description("Divine Relic")]
            DivineRelic
        }
#endif

        public enum ForestPlatformingAcornSpawnerDirections {
            Random,
            [Description("Left")]
            Left1,
            [Description("Right")]
            Right1,
            [Description("Left")]
            Left2,
            [Description("Left")]
            Left3,
            [Description("Right")]
            Right2,
            [Description("Left")]
            Left4,
            [Description("Right")]
            Right3,
            [Description("Right")]
            Right4
        }

        public enum ForestPlatformingAcornSpawnerYIndexes {
            Random,
            [Description("150")]
            A_150,
            [Description("50")]
            B_50,
            [Description("120")]
            C_120

        }

        public enum FrogsPhaseOnePatterns {
            Random,
            Punches,
            Fireflies
        }

        public enum FrogsPhaseOneFirefliesPatternsEasy {
            Random,
            [Description("2-1-1 (Slow)")]
            Two_One_One_Slow,
            [Description("1-1-2")]
            One_One_Two,
            [Description("2-1-1 (Fast)")]
            Two_One_One_Fast
        }
        public enum FrogsPhaseOneFirefliesPatternsNormal {
            Random,
            [Description("2-2-1-2")]
            Two_Two_One_Two,
            [Description("2-2-2")]
            Two_Two_Two,
            [Description("2-1-2-2")]
            Two_One_Two_Two,
            [Description("2-2-1")]
            Two_Two_One,
        }

        public enum FrogsPhaseOneFirefliesPatternsHard {
            Random,
            [Description("2-2-1")]
            Two_Two_One,
            [Description("1-1-2")]
            One_One_Two,
            [Description("2-2 (Fast)")]
            Two_Two_Fast,
            [Description("2-1-1")]
            Two_One_One,
            [Description("1-2-2")]
            One_Two_Two,
            [Description("2-2 (Slow)")]
            Two_Two_Slow,
            [Description("1-2-1")]
            One_Two_One
        }

        public enum FrogsPhaseFinalPatterns {
            Random,
            Snake,
            Tiger,
            Bison
        }

        public enum SlimePhaseOneJumpCountsNormal {
            Random,
            [Description("5")]
            Five = 5,
            [Description("6")]
            Six = 6,
            [Description("7")]
            Seven = 7
        }

        public enum SlimePhaseOneJumpPatternsNormal {
            Random,
            High01,
            Low01,
            High02,
            Low02,
            Delay,
            Low03,
            Random01,
            High03,
            Low04,
            High04,
            Low05,
            Low06,
            High05,
            Random02,
            Low07,
            Low08
        }

        public enum FlyingBlimpPhaseBlimp2PatternsEasy {
            Random,
            Tornado1,
            Shoot1,
            Shoot2,
        }

        public enum FlyingBlimpPhaseBlimp3PatternsEasy {
            Random,
            Shoot1,
            Shoot2,
            Tornado1,
            Shoot3,
            Shoot4,
            Shoot5,
            Tornado2,
        }

        public enum FlyingBlimpConstellationPatternsNormal {
            Random,
            Sagittarius,
            Gemini,
        }

        public enum FlyingBlimpPhaseBlimp2PatternsNormal {
            Random,
            Tornado1,
            Shoot1,
            Shoot2,
            Shoot3,
            Tornado2,
            Shoot4,
            Shoot5
        }
        public enum FlyingBlimpPhaseBlimp3PatternsNormal {
            Random,
            Shoot1,
            Tornado1,
            Shoot2,
            Shoot3,
            Tornado2,
        }

        public enum FlyingBlimpPhaseBlimp2PatternsHard {
            Random,
            Shoot1,
            Tornado1,
            Shoot2,
            Shoot3,
            Tornado2,
        }

        public enum FlyingBlimpPhaseBlimp3PatternsHard {
            Random,
            Shoot1,
            Shoot2,
            Tornado1,
            Shoot3,
            Shoot4,
            Shoot5,
            Tornado2
        }

        public enum FlowerPhaseGeneric1PatternsNormal {
            Random,
            HeadLunge,
            GatlingGun
        }

        public enum FlowerPhaseGeneric2PatternsNormal {
            Random,
            HeadLunge,
            PodHands
        }

        public enum FlowerPhaseGeneric3PatternsNormal {
            Random,
            PodHands,
            GatlingGun
        }

        public enum FlowerPhaseGenericHeadLungePatternsNormal {
            Random,
            Top1,
            Bottom1,
            Bottom2,
            Top2,
            Bottom3,
            Bottom4,
            Top3,
            Bottom5,
            Bottom6
        }

        public enum FlowerPodHandsAttackCountIndexesEasy {
            Random,
            [Description("0")]
            A_00,
            [Description("1")]
            B_01,
            [Description("2")]
            C_02,
            [Description("3")]
            D_03,
            [Description("4")]
            E_04,
            [Description("5")]
            F_05,
            [Description("6")]
            G_06,
        }

        public enum FlowerPodHandsAttackCountIndexesNormal {
            Random,
            [Description("0")]
            A_00,
            [Description("1")]
            B_01,
            [Description("2")]
            C_02,
            [Description("3")]
            D_03,
            [Description("4")]
            E_04,
            [Description("5")]
            F_05,
            [Description("6")]
            G_06,
            [Description("7")]
            H_07,
            [Description("8")]
            I_08,
            [Description("9")]
            J_09,
            [Description("10")]
            K_10,
            [Description("11")]
            L_11,
            [Description("12")]
            M_12,
            [Description("13")]
            N_13,
            [Description("14")]
            N_14,
            [Description("15")]
            N_15,
            [Description("16")]
            N_16,
            [Description("17")]
            N_17
        }

        public enum FlowerPodHandsAttackCountIndexesHard {
            Random,
            [Description("0")]
            A_00,
            [Description("1")]
            B_01,
            [Description("2")]
            C_02,
            [Description("3")]
            D_03,
            [Description("4")]
            E_04,
            [Description("5")]
            F_05,
            [Description("6")]
            G_06,
            [Description("7")]
            H_07,
            [Description("8")]
            I_08,
            [Description("9")]
            J_09,
            [Description("10")]
            K_10,
            [Description("11")]
            L_11,
            [Description("12")]
            M_12,
            [Description("13")]
            N_13,
            [Description("14")]
            N_14,
            [Description("15")]
            N_15,
            [Description("16")]
            N_16,
            [Description("17")]
            N_17
        }

        public enum FlowerPodHandsAttackTypeIndexesEasy {
            Random,
            [Description("1")]
            B_01,
            [Description("2")]
            C_02,
            [Description("4")]
            E_04,
            [Description("7")]
            H_07,
            [Description("9")]
            J_09,
            [Description("10")]
            K_10,
            [Description("12")]
            M_12,
            [Description("13")]
            N_13,
        }

        public enum FlowerPodHandsAttackTypeIndexesNormal {
            Random,
            [Description("1")]
            B_01,
            [Description("2")]
            C_02,
            [Description("4")]
            E_04,
            [Description("6")]
            G_06,
            [Description("7")]
            H_07,
            [Description("8")]
            I_08,
            [Description("10")]
            K_10,
            [Description("12")]
            M_12
        }

        public enum FlowerPodHandsAttackTypeIndexesHard {
            Random,
            [Description("1")]
            B_01,
            [Description("2")]
            C_02,
            [Description("5")]
            F_05,
            [Description("7")]
            H_07,
            [Description("8")]
            I_08,
            [Description("9")]
            J_09,
            [Description("12")]
            M_12,
            [Description("14")]
            N_14
        }

        public enum FlowerBlinkCounts {
            Random,
            A_2,
            B_3,
            C_4,
            D_5
        }

        public enum BaronessMinibossesEasy {
            Random,
            Gumball,
            Waffle,
            CandyCorn,
            Jawbreaker
        }

        public enum BaronessMinibossesNormal {
            Random,
            Gumball,
            Waffle,
            CandyCorn,
            Cupcake,
            Jawbreaker
        }

        public enum BaronessMinibossesHard {
            Random,
            Gumball,
            Waffle,
            CandyCorn,
            Cupcake,
            Jawbreaker
        }

        public enum FlyingBirdPhaseOneDirections {
            Random,
            Up,
            Down
        }


        public enum FlyingBirdPhaseOnePatternsEasy {
            Random,
            Eggs01,
            Lasers01,
            Eggs02,
            Eggs03,
            Lasers02
        }

        public enum FlyingBirdPhaseTwoPatternsEasy {
            Random,
            Eggs01,
            Eggs02,
            Eggs03,
            Lasers01,
            Eggs04,
            Eggs05,
            Eggs06,
            Eggs07,
            Lasers02
        }

        public enum FlyingBirdPhaseOnePatternsNormal {
            Random,
            Eggs,
            Lasers
        }

        public enum FlyingBirdPhaseTwoPatternsNormal {
            Random,
            Eggs01,
            Eggs02,
            Eggs03,
            Lasers01,
            Eggs04,
            Eggs05,
            Eggs06,
            Eggs07,
            Lasers02
        }

        public enum FlyingBirdPhaseOnePatternsHard {
            Random,
            Eggs01,
            Eggs02,
            Eggs03,
            Lasers01,
            Eggs04,
            Eggs05,
            Lasers02,
            Eggs06,
            Eggs07,
            Eggs08,
            Lasers03,
            Eggs09,
            Eggs10,
            Lasers04,
            Eggs11,
            Eggs12,
            Eggs13,
            Lasers05,
        }

        public enum FlyingBirdPhaseThreeDirections {
            Random,
            Up,
            Down
        }

        public enum FlyingBirdPhaseFinalPatterns {
            Random,
            Garbage,
            Heart
        }

        public enum FlyingBirdPhaseFinalDirections {
            Random,
            Right,
            Left
        }

        public enum FlyingGeniePhaseOneTreasurePatterns {
            Random,
            Swords,
            Gems,
            Sphinx
        }

        public enum FlyingGeniePhaseOneSwordTypesEasyNormal {
            Random,
            [Description("Parry")]
            P_01,
            [Description("Regular")]
            R_01,
            [Description("Regular")]
            R_02,
            [Description("Regular")]
            R_03,
            [Description("Regular")]
            R_04,
            [Description("Parry")]
            P_02,
            [Description("Regular")]
            R_05,
            [Description("Regular")]
            R_06,
            [Description("Regular")]
            R_07,
            [Description("Regular")]
            R_08,
            [Description("Regular")]
            R_09
        }

        public enum FlyingGeniePhaseOneSwordTypesHard {
            Random,
            [Description("Parry")]
            P_01,
            [Description("Regular")]
            R_01,
            [Description("Regular")]
            R_02,
            [Description("Regular")]
            R_03,
            [Description("Regular")]
            R_04,
            [Description("Parry")]
            P_02,
            [Description("Regular")]
            R_05,
            [Description("Regular")]
            R_06,
            [Description("Regular")]
            R_07,
            [Description("Regular")]
            R_08,
            [Description("Regular")]
            R_09,
            [Description("Regular")]
            R_10,
        }

        public enum FlyingGeniePhaseOneGemsTypesEasy {
            Random,
            [Description("Parry")]
            P_01,
            [Description("Regular")]
            R_01,
            [Description("Regular")]
            R_02,
            [Description("Regular")]
            R_03,
            [Description("Regular")]
            R_04,
            [Description("Regular")]
            R_05,
            [Description("Regular")]
            R_06,
            [Description("Regular")]
            R_07,
            [Description("Regular")]
            R_08,
            [Description("Regular")]
            R_09,
            [Description("Regular")]
            R_10,
            [Description("Regular")]
            R_11,
        }

        public enum FlyingGeniePhaseOneGemsTypesNormalHard {
            Random,
            [Description("Parry")]
            P_01,
            [Description("Regular")]
            R_01,
            [Description("Regular")]
            R_02,
            [Description("Regular")]
            R_03,
            [Description("Regular")]
            R_04,
            [Description("Regular")]
            R_05,
            [Description("Regular")]
            R_06,
            [Description("Regular")]
            R_07,
            [Description("Regular")]
            R_08,
            [Description("Regular")]
            R_09,
            [Description("Regular")]
            R_10,
            [Description("Regular")]
            R_11,
            [Description("Regular")]
            R_12
        }

        public enum FlyingGeniePhaseOneSphinxTypes {
            Random,
            [Description("Parry")]
            P_01,
            [Description("Regular")]
            R_01,
            [Description("Regular")]
            R_02,
            [Description("Regular")]
            R_03,
            [Description("Regular")]
            R_04,
            [Description("Regular")]
            R_05,
            [Description("Parry")]
            P_02,
            [Description("Regular")]
            R_06,
            [Description("Regular")]
            R_07,
            [Description("Regular")]
            R_08,
            [Description("Regular")]
            R_09,
            [Description("Regular")]
            R_10,
            [Description("Regular")]
            R_11,
            [Description("Regular")]
            R_12
        }

        public enum FlyingGeniePhaseTwoObeliskPatterns {
            Random,
            [Description("1")]
            AA_1,
            [Description("4")]
            AB_4,
            [Description("2")]
            AC_2,
            [Description("5")]
            AD_5,
            [Description("1-4")]
            AE_1_4,
            [Description("5")]
            AF_5,
            [Description("1")]
            AG_1,
            [Description("3")]
            AH_3,
            [Description("2-5")]
            AI_2_5,
            [Description("3")]
            AJ_3,
            [Description("1")]
            AK_1,
            [Description("2-5")]
            AL_2_5,
            [Description("4")]
            AM_4,
            [Description("2")]
            AN_2,
            [Description("3")]
            AO_3,
            [Description("1-4")]
            AP_1_4,
            [Description("2")]
            AQ_2,
            [Description("5")]
            AR_5,
            [Description("4")]
            AS_4,
            [Description("1")]
            AT_1,
            [Description("2")]
            AU_2,
            [Description("1-4")]
            AV_1_4,
            [Description("3")]
            AW_3,
            [Description("5")]
            AX_5,
            [Description("1")]
            AY_1,
            [Description("3")]
            AZ_3,
            [Description("2-5")]
            BA_2_5
        }


        public enum ClownDashDelaysEasy {
            Random,
            [Description("5B")]
            A_3_3,
            [Description("3B")]
            B_1_8,
            [Description("5B")]
            C_3_5,
            [Description("4B+")]
            D_3,
            [Description("2B")]
            E_1_5,
            [Description("4B")]
            F_2_7,
            [Description("4B+")]
            G_3,
            [Description("3B")]
            H_2,
            [Description("2B")]
            J_1_5
        }

        public enum ClownDashDelaysNormal {
            Random,
            [Description("5B")]
            A_3_3,
            [Description("3B++")]
            B_2_4,
            [Description("5B")]
            C_3_5,
            [Description("4B+")]
            D_3,
            [Description("2B+")]
            E_1_5,
            [Description("5B")]
            F_3_5,
            [Description("4B+")]
            G_3,
            [Description("5B+")]
            H_3_8,
            [Description("3B")]
            J_2,
            [Description("2B+")]
            K_1_5
        }

        public enum ClownDashDelaysHard {
            Random,
            [Description("5B")]
            A_3_3,
            [Description("5B")]
            B_3_6,
            [Description("3B")]
            C_2_2,
            [Description("5B")]
            D_3_5,
            [Description("4B+")]
            E_3,
            [Description("2B")]
            F_1_5,
            [Description("5B")]
            G_3_5,
            [Description("3B")]
            H_2,
            [Description("5B+")]
            J_3_8,
            [Description("3B")]
            K_2,
            [Description("2B")]
            L_1_5
        }

        public enum ClownHorseTypes {
            Random,
            Green1,
            Yellow1,
            Yellow2,
            Green2,
            Yellow3,
            Green3,
            Green4,
            Yellow4
        }

        public enum ClownHorseDirections {
            Random,
            Left,
            Right
        }

        public enum DragonPhaseOnePatternsEasy {
            Random,
            Peashot1,
            Meteor1,
            Peashot2,
            Peashot3,
            Meteor2,
            Peashot4,
            Meteor3,
            Peashot5,
            Peashot6,
            Peashot7,
            Meteor4
        }

        public enum DragonPhaseTwoPatternsEasy {
            Random,
            Peashot1,
            Meteor1,
            Peashot2,
            Peashot3,
            Meteor2,
            Peashot4,
            Meteor3,
            Peashot5,
            Peashot6,
            Meteor4
        }

        public enum DragonPhaseThreePatternsNormal {
            Random,
            Meteor,
            Peashot
        }

        public enum DragonPhaseOnePatternsHard {
            Random,            
            Peashot,
            Meteor
        }

        public enum DragonPhaseTwoPatternsHard {
            Random,
            Meteor,
            Peashot
        }

        public enum DragonPhaseOneMeteorPatternsEasy {
            Random,
            [Description("Up-Down (3x as likely!)")]
            UD,
            [Description("Down-Up-Down (3x as likely!)")]
            DUD,
            [Description("Down-Up-Down (2x as likely!)")]
            UDU,
            [Description("Down-Down")]
            DD,
            [Description("Up-Up")]
            UU,
        }

        public enum DragonPhaseTwoMeteorPatternsEasy {
            Random,
            [Description("Up-Down (3x as likely!)")]
            UD,
            [Description("Down-Up-Down (3x as likely!)")]
            DUD,
            [Description("Down-Up-Down (2x as likely!)")]
            UDU,
            [Description("Down-Down")]
            DD,
            [Description("Up-Up")]
            UU,
        }

        public enum DragonPhaseTwoMeteorPatternsNormal {
            Random,
            [Description("Up-Down-Up-Down")]
            UDUD,
            [Description("Down-Up-Down")]
            DUD,
            [Description("Down-Up-Down-Up")]
            DUDU,
            [Description("Up-Down-Up")]
            UDU
        }

        public enum DragonPhaseThreeMeteorPatternsNormal {
            Random,
            [Description("Up-Both")]
            UB,
            [Description("Both-Down")]
            BD,
            [Description("Down-Both")]
            DB,
            [Description("Both-Up")]
            BU
        }

        public enum DragonPhaseOneMeteorPatternsHard {
            Random,
            [Description("Up-Down (2x as likely!)")]
            UD,
            [Description("Down-Up-Down")]
            DUD,
            [Description("Down-Up")]
            DU,
            [Description("Up-Down-Up")]
            UDU
        }

        public enum DragonPhaseTwoMeteorPatternsHard {
            Random,
            [Description("Up-Up-Down (2x as likely!)")]
            UUD,
            [Description("Down-Up-Down (2x as likely!)")]
            DUU,
            [Description("Down-Up-Both")]
            DUB
        }

        public enum DragonPhaseOneLaserPatternsEasy {
            Random,
            [Description("2 (Faster) #1")]
            Two_1,
            [Description("2 (Slower)")]
            Two_2,
            [Description("1 (Faster)")]
            One_1,
            [Description("2 (Faster) #2")]
            Two_3,
            [Description("1 (Slower)")]
            One_2
        }

        public enum DragonPhaseTwoLaserPatternsEasy {
            Random,
            [Description("2 (Faster) #1")]
            Two_1,
            [Description("2 (Slower)")]
            Two_2,
            [Description("1 (Faster)")]
            One_1,
            [Description("2 (Faster) #2")]
            Two_3,
            [Description("1 (Slower)")]
            One_2
        }

        public enum DragonPhaseOneLaserPatternsNormal {
            Random,
            [Description("3")]
            Three,
            [Description("2 (Slower)")]
            Two_1,
            [Description("2 (Faster)")]
            Two_2
        }

        public enum DragonPhaseThreeLaserPatternsNormal {
            Random,
            [Description("2")]
            Two,
            [Description("1 (2x as likely!)")]
            One
        }

        public enum DragonPhaseOneLaserPatternsHard {
            Random,
            [Description("2 #1")]
            Two_1,
            [Description("2 #2")]
            Two_2,
            [Description("3")]
            Three
        }

        public enum DragonPhaseTwoLaserPatternsHard {
            Random,
            [Description("2 #1")]
            Two_1,
            [Description("2 #2")]
            Two_2,
            [Description("3")]
            Three
        }

        public enum BeePhaseTwoPatternsEasy {
            Random,
            Orbs1,
            Triangles1,
            Orbs2,
            Triangles2,
            Triangles3,
            Orbs3,
            Triangles4,
            Orbs4,
            Triangles5,
            Orbs5,
            Orbs6
        }

        public enum BeePhaseTwoPatternsNormal {
            Random,
            Orbs,
            Triangles,
            Chain
        }

        public enum BeePhaseTwoPatternsHard {
            Random,
            Orbs,
            Chain1,
            Triangles,
            Chain2
        }

        public enum BeePhaseTwoOrbsDirections {
            Random,
            Left,
            Right
        }

        public enum BeePhaseTwoTrianglesDirections {
            Random,
            Left,
            Right
        }

        public enum RobotPhaseFinalGemColors {
            Random,
            Red,
            Blue
        }

        public enum SallyStageplayPatternsEasy {
            Random,
            Jump1,
            Kiss1,
            Teleport1,
            Jump2,
            Kiss2,
            Jump3,
            Teleport2,
            Kiss3,
            Jump4,
            Teleport3
        }

        public enum SallyStageplayPatternsNormalHard {
            Random,
            Jump1,
            Kiss1,
            Teleport1,
            Jump2,
            Kiss2,
            Jump3,
            Teleport2
        }

        public enum SallyStageplayJumpTypesEasy {
            Random,
            DiveKick1,
            DiveKick2,
            DoubleJump1,
            DiveKick3,
            DiveKick4,
            DiveKick5,
            DoubleJump2
        }

        public enum SallyStageplayJumpTypesNormalHard {
            Random,
            DiveKick1,
            DiveKick2,
            DoubleJump1,
            DiveKick3,
            DoubleJump2,
            DiveKick4,
            DiveKick5,
            DiveKick6,
            DoubleJump3
        }

        public enum SallyStageplayJumpCountsEasy {
            Random,
            [Description("1")]
            One_1,
            [Description("3")]
            Three_1,
            [Description("2")]
            Two_1,
            [Description("3")]
            Three_2,
            [Description("1")]
            One_2,
            [Description("2")]
            Two_2,
            [Description("3")]
            Three_3,
            [Description("2")]
            Two_3,
            [Description("2")]
            Two_4
        }

        public enum SallyStageplayJumpCountsNormalHard {
            Random,
            [Description("1")]
            One_1,
            [Description("3")]
            Three_1,
            [Description("2")]
            Two_1,
            [Description("3")]
            Three_2,
            [Description("1")]
            One_2,
            [Description("2")]
            Two_2,
            [Description("3")]
            Three_3,
            [Description("2")]
            Two_3,
            [Description("2")]
            Two_4,
            [Description("3")]
            Three_4
        }

        public enum SallyStageplayTeleportOffsetsEasy {
            Random,
            [Description("0")]
            A_0,
            [Description("100")]
            B_100,
            [Description("-100")]
            C_Neg100,
            [Description("0")]
            D_0,
            [Description("50")]
            E_50,
            [Description("0")]
            F_0,
            [Description("-50")]
            G_Neg50
        }

        public enum SallyStageplayTeleportOffsetsNormalHard {
            Random,
            [Description("0")]
            A_0,
            [Description("100")]
            B_100,
            [Description("-100")]
            C_Neg100,
            [Description("0")]
            D_0,
            [Description("200")]
            E_200,
            [Description("-200")]
            F_Neg200,
            [Description("50")]
            G_50,
            [Description("-200")]
            H_Neg100,
            [Description("0")]
            I_0,
            [Description("150")]
            J_150
        }

        public enum MousePhaseOnePatternsEasy {
            Random,
            Dash1,
            Catapult1,
            CherryBomb1,
            Dash2,
            CherryBomb2,
            Catapult2,
            Dash3,
            Catapult3
        }

        public enum MousePhaseOnePatternsNormal {
            Random,
            CherryBomb1,
            Dash1,
            Catapult1,
            Dash2,
            CherryBomb2,
            Catapult2,
            Dash3,
            CherryBomb3,
            Catapult3,
            CherryBomb4,
            Dash4,
            CherryBomb5,
            Catapult4,
            Dash5
        }

        public enum MousePhaseOnePatternsHard {
            Random,
            CherryBomb1,
            Catapult1,
            Dash1,
            CherryBomb2,
            Dash2,
            Catapult2,
            Dash3,
            Catapult3,
            CherryBomb3,
            Dash4
        }

        public enum MouseCherryBombPatternsNormal {
            Random,
            [Description("2-2-2 #1")]
            Two_Two_Two_1,
            [Description("3-2")]
            Three_Two,
            [Description("2-2-2 #2")]
            Two_Two_Two_2,
            [Description("2-3")]
            Two_Three
        }

        public enum MouseCherryBombPatternsHard {
            Random,
            [Description("3-3 #1")]
            Three_Three_1,
            [Description("4-2")]
            Four_Two,
            [Description("2-2-2 #1")]
            Two_Two_Two_1,
            [Description("3-3 #2")]
            Three_Three_2,
            [Description("2-4")]
            Two_Four,
            [Description("2-2-2 #2")]
            Two_Two_Two_2
        }

        public enum MouseCatapultPatternsEasy {
            Random,
            CGGGN,
            GGGNC,
            CGGNG,
            BGGCG
        }

        public enum MouseCatapultPatternsNormal {
            Random,
            BNGCG,
            CGPGC,
            PGGCN,
            BPGGN
        }

        public enum MouseCatapultPatternsHard {
            Random,
            BNGCG,
            CBGGN,
            NGGCB,
            CGBGN,
            NBGGC
        }

        public enum PiratePhaseThreeGunPatternsEasy {
            Random,
            [Description("1-2")]
            One_Two,
            [Description("2-1")]
            Two_One,
            [Description("3")]
            Three
        }

        public enum PiratePhaseFourGunPatternsEasy {
            Random,
            [Description("1-1 #1")]
            One_One_1,
            [Description("1-1 #2")]
            One_One_2,
            [Description("2 (2x as likely!)")]
            Two,
            [Description("1-1 Longer")]
            One_One_Longer,
            [Description("1-1 Shorter")]
            One_One_Shorter
        }

        public enum PiratePhaseSevenGunPatternsEasy {
            Random,
            [Description("2-1-2 #1")]
            Two_One_Two_1,
            [Description("2-2-1 (2x as likely!)")]
            Two_Two_One,
            [Description("3")]
            Three,
            [Description("1-2-2")]
            One_Two_Two,
            [Description("1-3")]
            One_Three,
            [Description("2-1-2 #2")]
            Two_One_Two_2,
            [Description("4")]
            Four
        }

        public enum PiratePhaseOneGunPatternsNormal {
            Random,
            [Description("3-1")]
            Three_One,
            [Description("2-2")]
            Two_Two,
            [Description("1-3")]
            One_Three
        }

        public enum PiratePhaseTwoGunPatternsNormal {
            Random,
            [Description("1-1-2")]
            One_One_Two,
            [Description("2-1-1 (Bugged!)")]
            Two_One_One
        }

        public enum PiratePhaseThreeGunPatternsNormal {
            Random,
            [Description("2-1")]
            Two_One,
            [Description("1-2")]
            One_Two,
        }

        public enum PiratePhaseOneGunPatternsHard {
            Random,
            [Description("2-3 Longer")]
            Two_Three_Longer,
            [Description("2-3 Shorter")]
            Two_Three_Shorter,
            [Description("3-2 #1")]
            Three_Two_1,
            [Description("3-2 #2")]
            Three_Two_2,
            [Description("4")]
            Four
        }

        public enum PiratePhaseTwoGunPatternsHard {
            Random,
            [Description("3-1")]
            Three_One,
            [Description("4 (2x as likely!)")]
            Four,
            [Description("2-2")]
            Two_Two,
            [Description("1-3")]
            One_Three
        }

        public enum PiratePhaseThreeGunPatternsHard {
            Random,
            [Description("2 (2x as likely!)")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four
        }

        public enum PiratePhaseFourPatternsEasy {
            Random,
            Peashot,
            Shark
        }

        public enum PiratePhaseSevenPatternsEasy {
            Random,
            Peashot01,
            Peashot02,
            Peashot03,
            Shark01,
            Peashot04,
            Peashot05,
            Shark02,
            Peashot06,
            Peashot07,
            Shark03,
            Peashot08,
            Peashot09,
            Peashot10,
            Shark04,
        }

        public enum PiratePhaseTwoPatternsNormalHard {
            Random,
            [Description("Peashot -> Shark")]
            PeashotShark,
            Shark,
            [Description("Peashot -> Squid")]
            PeashotSquid,
            Squid,
            [Description("Peashot -> Dogfish")]
            PeashotDogfish,
            Dogfish
        }

        public enum PiratePhaseThreePatternsNormalHard {
            Random,
            [Description("Peashot -> Shark")]
            PeashotShark,
            Shark,
            [Description("Peashot -> Squid")]
            PeashotSquid,
            Squid,
            [Description("Peashot -> Dogfish")]
            PeashotDogfish,
            Dogfish
        }

        public enum FlyingMermaidPhaseOneFirstPatternsEasy {
            Random,
            Ghosts,
            Summon,
        }

        public enum FlyingMermaidPhaseOneSecondPatternsEasy {
            Random,
            Fish,
            Summon
        }

        public enum FlyingMermaidPhaseOnePatternsNormalHard {
            Random,
            Ghosts,
            Summon1,
            Fish,
            Summon2
        }

        public enum FlyingMermaidPhaseOneFishPatterns {
            Random,
            Yellow,
            Red
        }

        public enum FlyingMermaidPhaseOneSummonPatterns {
            Random,
            Seahorse,
            Pufferfish,
            Turtle
        }

        public enum TrainPumpkinStartingDirections {
            Random,
            Left,
            Right
        }

        public enum TrainStartingGhouls {
            Random,
            Left,
            Right
        }

        public enum DicePalaceHeartPositions1 {
            Random,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three
        }

        public enum DicePalaceHeartPositions2 {
            Random,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("6")]
            Six
        }

        public enum DicePalaceHeartPositions3 {
            Random,
            [Description("7")]
            Seven,
            [Description("8")]
            Eight,
            [Description("9")]
            Nine
        }

        public enum DicePalaceCigarSpitAttackCountsNormal {
            Random,
            [Description("1")]
            One1,
            [Description("2")]
            Two1,
            [Description("1")]
            One2,
            [Description("2")]
            Two2,
            [Description("2")]
            Two3,
            [Description("3")]
            Three1,
            [Description("1")]
            One3,
            [Description("2")]
            Two4,
        }

        public enum DicePalaceCigarSpitAttackCountsHard {
            Random,
            [Description("2")]
            Two1,
            [Description("1")]
            One1,
            [Description("3")]
            Three1,
            [Description("2")]
            Two2,
            [Description("3")]
            Three2,
            [Description("1")]
            One2,
            [Description("3")]
            Three3,
            [Description("3")]
            Three4,
            [Description("2")]
            Two3,
        }

        public enum DicePalaceChipsPatternsNormal {
            Random,
            [Description("1-2-3-4,5-6-7-8")] OneTwoThreeFour_FiveSixSevenEight,
            [Description("1-8,2-7,3-4-5-6")] OneEight_TwoSeven_ThreeFourFiveSix,
            [Description("3-4-5,1-2-6-7-8")] ThreeFourFive_OneTwoSixSevenEight,
            [Description("5-6-7-8,1-2-3-4")] FiveSixSevenEight_OneTwoThreeFour,
            [Description("5-6-7,1-2-8,3-4")] FiveSixSeven_OneTwoEight_ThreeFour,
            [Description("1-2-3-4-5-6,7-8")] OneTwoThreeFourFiveSix_SevenEight,
            [Description("1-2-8,7-6,3-4-5")] OneTwoEight_SevenSix_ThreeFourFive,
            [Description("2-3-4-5,1-6-7-8")] TwoThreeFourFive_OneSixSevenEight,
            [Description("8-5,2-3-4,1-6-7")] EightFive_TwoThreeFour_OneSixSeven,
            [Description("1-8,2-3-4-5,6-7")] OneEight_TwoThreeFourFive_SixSeven,
            [Description("3-4-5,1-6-7,2-8")] ThreeFourFive_OneSixSeven_TwoEight,
            [Description("6-7-8,3-4-5,1-2")] SixSevenEight_ThreeFourFive_OneTwo,
            [Description("5-6-7,1-8,2-3-4")] FiveSixSeven_OneEight_TwoThreeFour,
            [Description("1-2-7-8,3-4-5-6")] OneTwoSevenEight_ThreeFourFiveSix
        }

        public enum DicePalaceChipsPatternsHard {
            Random,
            [Description("1-2-8,3-4-5,6-7")] OneTwoEight_ThreeFourFive_SixSeven,
            [Description("1-2,3-8,4-5-6-7")] OneTwo_ThreeEight_FourFiveSixSeven,
            [Description("1-2-3-4,5-6-7-8")] OneTwoThreeFour_FiveSixSevenEight,
            [Description("2-4-6-1,3-8,5-7")] TwoFourSixOne_ThreeEight_FiveSeven,
            [Description("1-7-8,2-3,4-5-6")] OneSevenEight_TwoThree_FourFiveSix,
            [Description("2-3-8,1-5-6,4-7")] TwoThreeEight_OneFiveSix_FourSeven,
            [Description("3-4-5-6,1-2-7-8")] ThreeFourFiveSix_OneTwoSevenEight,
            [Description("4-5-6-7,1-2-3-8")] FourFiveSixSeven_OneTwoThreeEight,
            [Description("5-6-7-8,1-2-3-4")] FiveSixSevenEight_OneTwoThreeFour_1,
            [Description("2-3-8-1,4-5-6-7")] TwoThreeEightOne_FourFiveSixSeven,
            [Description("3-4-5,1-2-6-7-8")] ThreeFourFive_OneTwoSixSevenEight,
            [Description("1-8,3-4-5,2-6-7")] OneEight_ThreeFourFive_TwoSixSeven,
            [Description("4-5-6,1-2-3-7-8")] FourFiveSix_OneTwoThreeSevenEight,
            [Description("5-6-7-8,1-2-3-4")] FiveSixSevenEight_OneTwoThreeFour_2,
            [Description("2-3-4,1-5-6-7-8")] TwoThreeFour_OneFiveSixSevenEight,
            [Description("3-4-5-6,1-8,2-7")] ThreeFourFiveSix_OneEight_TwoSeven,
            [Description("1-2-3-8,4-5-6-7")] OneTwoThreeEight_FourFiveSixSeven
        }

        public enum DicePalaceRabbitPatterns {
            Random,
            Wand01,
            Parry01,
            Wand02,
            Wand03,
            Parry02,
            Wand04,
            Wand05,
            Parry03,
            Wand06,
            Parry04,
            Wand07,
            Parry05,
            Wand08,
            Wand09,
            Parry06,
            Wand10,
            Wand11,
            Wand12,
            Parry07,
            Wand13,
            Wand14,
            Parry08
        }

        public enum DicePalaceRabbitParryDirections {
            Random,
            Top,
            Bottom
        }

        public enum DicePalaceRoulettePatterns {
            Random,
            Twirl,
            Marble
        }

        public enum DicePalaceRouletteTwirlAmountsNormal {
            Random,
            [Description("4")]
            Four,
            [Description("5")]
            Five
        }

        public enum DevilPhaseOnePatterns {
            Random,
            Head1,
            Clap1,
            Pitchfork1,
            Clap2,
            Head2,
            Clap3,
            Pitchfork2
        }

        public enum DevilPhaseOneHeadTypes {
            Random,
            Dragon,
            Spider
        }

        public enum DevilPhaseOneDragonDirections {
            Random,
            Left,
            Right
        }

        public enum DevilPhaseOnePitchforkTypes {
            Random,
            Bouncer,
            Pinwheel,
            Ring
        }

        public enum DevilPhaseOneBouncerParryIndexes {
            Random,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four
        }

        public enum DevilPhaseOneRingParryIndexes {
            Random,
            [Description("1")]
            One,
            [Description("2")]
            Two,
            [Description("3")]
            Three,
            [Description("4")]
            Four,
            [Description("5")]
            Five,
            [Description("6")]
            Six
        }

        public enum DevilPhaseOneBouncerAnglesNormal {
            Random,
            [Description("55 (Standard)")]
            A_55,
            [Description("30 (Standard)")]
            B_30,
            [Description("35 (Standard)")]
            C_35,
            [Description("60 (Standard)")]
            D_60,
            [Description("40 (Standard)")]
            E_40,
            [Description("70 (1.5s slower)")]
            F_70,
            [Description("20 (1.5s slower)")]
            G_20,
            [Description("35 (Standard)")]
            H_35,
            [Description("50 (Standard)")]
            I_50,
            [Description("100 (3s slower)")]
            J_100,
            [Description("200 (1.5s slower)")]
            K_200,
        }

        public enum DevilPhaseOneBouncerAnglesHard {
            Random,
            [Description("55")]
            A_55,
            [Description("30")]
            B_30,
            [Description("35")]
            C_35,
            [Description("60")]
            D_60,
            [Description("40")]
            E_40,
            [Description("70")]
            F_70,
            [Description("20")]
            G_20,
            [Description("35")]
            H_35,
            [Description("50")]
            I_50,
            [Description("100")]
            J_100,
            [Description("200")]
            K_200,
            [Description("35")]
            L_35,
            [Description("60")]
            M_60,
            [Description("35")]
            N_35,
            [Description("55")]
            O_55,
            [Description("100")]
            P_100,
            [Description("70")]
            Q_70,
            [Description("20")]
            R_20,
            [Description("30")]
            S_30,
            [Description("50")]
            T_50,
            [Description("40")]
            U_40,
            [Description("200")]
            V_200
        }

        public enum DevilPhaseOneSpiderOffsets {
            Random,
            [Description("-150")]
            A_Neg150,
            [Description("50")]
            B_50,
            [Description("-50")]
            C_Neg50,
            [Description("300")]
            D_300,
            [Description("-200")]
            E_Neg200,
            [Description("50")]
            F_50,
            [Description("150")]
            G_150,
            [Description("-300")]
            H_Neg300,
            [Description("0")]
            I_0,
            [Description("100")]
            J_100,
            [Description("-50")]
            K_Neg50,
            [Description("200")]
            L_200,
            [Description("50")]
            M_50,
            [Description("0")]
            N_0,
            [Description("100")]
            O_100,
            [Description("-150")]
            P_Neg150,
            [Description("50")]
            Q_50,
            [Description("-250")]
            R_Neg250,
            [Description("200")]
            S_200,
            [Description("0")]
            T_0
        }

        public enum DevilPhaseOneSpiderHopCounts {
            Random,
            [Description("3")]
            Num_3,
            [Description("4")]
            Num_4,
            [Description("5")]
            Num_5

        }

        public enum DevilPhaseTwoPatternsNormal {
            Random,
            BombEye01,
            SkullEye01,
            BombEye02,
            SkullEye02,
            BombEye03,
            SkullEye03,
            SkullEye04,
            BombEye04,
            SkullEye05,
            SkullEye06,
            SkullEye07,
            BombEye05,
            SkullEye08,
            BombEye06,
            SkullEye09,
            BombEye07,
            SkullEye10,
            SkullEye11
        }

        public enum DevilPhaseTwoPatternsHard {
            Random,
            BombEye01,
            SkullEye01,
            BombEye02,
            BombEye03,
            SkullEye02,
            BombEye04,
            SkullEye03,
            SkullEye04,
            BombEye05,
            SkullEye05,
            BombEye06,
            BombEye07,
            SkullEye06,
            BombEye08,
            SkullEye07,
            BombEye09,
            SkullEye08,
            SkullEye09,
        }

        public enum DevilPhaseTwoBombEyeDirections {
            Random,
            Left,
            Right
        }

        public enum DevilPhaseTwoPlatformRisePatterns {
            Random,
            [Description("1")]
            One,
            [Description("3")]
            Two,
            [Description("2")]
            Three,
            [Description("5")]
            Four,
            [Description("4")]
            Five,
            [Description("1")]
            Six,
            [Description("5")]
            Seven,
            [Description("4")]
            Eight,
            [Description("2")]
            Nine,
            [Description("3")]
            Ten,
            [Description("1")]
            Eleven,
            [Description("3")]
            Twelve,
            [Description("5")]
            Thirteen,
            [Description("4")]
            Fourteen,
            [Description("2")]
            Fifteen
        }

        public enum DevilPhaseThreeSkullTypes {
            Random,
            Regular1,
            Regular2,
            Regular3,
            Regular4,
            Parry
        }

#if v1_3
        public enum OldManPhaseOnePlatformRemoveOrdersNormal {
            Random,
            [Description("0,2")]
            Order01,
            [Description("0,3")]
            Order02,
            [Description("0,4")]
            Order03,
            [Description("1,3")]
            Order04,
            [Description("3,1")]
            Order05,
            [Description("2,0")]
            Order06,
            [Description("3,0")]
            Order07,
            [Description("2,4")]
            Order08,
            [Description("0,1")]
            Order09,
            [Description("0,2")]
            Order10,
            [Description("0,3")]
            Order11
        }

        public enum OldManPhaseTwoLeftPuppetPatternsEasy {
            Random,
            Low01,
            Mid01,
            High01,
            Low02,
            Mid02,
            Low03,
            High02,
            Mid03,
            Low04
        }

        public enum OldManPhaseTwoRightPuppetPatternsEasy {
            Random,
            High01,
            High02,
            Low01,
            Mid01,
            High03,
            Low02,
            Mid02,
            Low03
        }

        public enum OldManPhaseTwoLeftPuppetPatternsNormal {
            Random,
            Low01,
            Mid01,
            High01,
            Low02,
            Mid02,
            Low03,
            High02,
            Mid03,
            Low04
        }

        public enum OldManPhaseTwoRightPuppetPatternsNormal {
            Random,
            High01,
            High02,
            Low01,
            Mid01,
            High03,
            Low02,
            Mid02,
            Low03
        }

        public enum OldManPhaseTwoLeftPuppetPatternsHard {
            Random,
            High01,
            High02,
            Low01,
            Mid01,
            High03,
            Low02,
            Mid02,
            Low03
        }

        public enum OldManPhaseTwoRightPuppetPatternsHard {
            Random,
            Low01,
            Mid01,
            High01,
            Low02,
            Mid02,
            Low03,
            High02,
            Mid03,
            Low04
        }

        public enum AirplanePhaseOnePatterns {
            Random,
            Parachute,
            Cat
        }

        public enum AirplanePhaseOneSides {
            Random,
            [Description("L")]
            Left01,
            [Description("R")]
            Right01,
            [Description("R")]
            Right02,
            [Description("L")]
            Left02,
            [Description("R")]
            Right03,
            [Description("L")]
            Left03,
            [Description("L")]
            Left04,
            [Description("R")]
            Right04,
            [Description("L")]
            Left05,
            [Description("R")]
            Right05
        }

        public enum AirplanePhaseOneParryPatterns {
            Random,
            Regular01,
            Regular02,
            Parry01,
            Regular03,
            Parry02
        }

        public enum RumRunnersPhaseThreeSnoutPositions {
            Random,
            Low01,
            Mid01,
            High01,
            Low02,
            High02,
            Low03,
            Low04,
            Mid02,
            High03,
            Mid03,
            Mid04,
            Low05,
            High04,
            High05,
            Mid05,
            Low06,
            Mid06
        }

        public enum SaltbakerPhaseOnePatterns {
            Random,
            Dough01,
            Limes01,
            Strawberries01,
            Sugarcubes01,
            Limes02,
            Dough02,
            Sugarcubes02,
            Strawberries02,
            Limes03,
            Dough03,
            Strawberries03,
            Sugarcubes03,
            Dough04,
            Limes04,
            Sugarcubes04,
            Strawberries04,
            Limes05,
            Sugarcubes05,
            Limes06,
            Strawberries05,
            Limes07
        }

        public enum SaltbakerPhaseThreeSawPatterns {
            Random,
            Left,
            Right
        }

#endif


    }
}
