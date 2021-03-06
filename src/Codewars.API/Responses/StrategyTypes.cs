﻿using System.Runtime.Serialization;

namespace Codewars.API
{
    /// <summary>
    /// Values for selecting a code challenge selection strategy
    /// </summary>
    [DataContract]
    public enum StrategyTypes
    {
        /// <summary>
        /// Also referred to as the “Rank Up” workout. Will select a challenge that is above your current level.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,
        /// <summary>
        /// Randomly selected code challenges
        /// </summary>
        [EnumMember(Value = "random")]
        Random,
        /// <summary>
        /// Will select code challenges that are tagged as reference.
        /// </summary>
        [EnumMember(Value = "reference_workout")]
        ReferenceWorkout,
        /// <summary>
        /// Will select beta code challenges.
        /// </summary>
        [EnumMember(Value = "beta_workout")]
        BetaWorkout,
        /// <summary>
        /// Will focus on code challenges that you have already completed.
        /// </summary>
        [EnumMember(Value = "retrain_workout")]
        RetrainWorkout,
        /// <summary>
        /// Will focus on algorithm code challenges that you have already completed.
        /// </summary>
        [EnumMember(Value = "algorithm_retest")]
        AlgorithmRetest,
        /// <summary>
        /// Will focus on 8 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_8_workout")]
        Kyu8Workout,
        /// <summary>
        /// Will focus on 7 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_7_workout")]
        Kyu7Workout,
        /// <summary>
        /// Will focus on 6 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_6_workout")]
        Kyu6Workout,
        /// <summary>
        /// Will focus on 5 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_5_workout")]
        Kyu5Workout,
        /// <summary>
        /// Will focus on 4 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_4_workout")]
        Kyu4Workout,
        /// <summary>
        /// Will focus on 3 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_3_workout")]
        Kyu3Workout,
        /// <summary>
        /// Will focus on 2 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_2_workout")]
        Kyu2Workout,
        /// <summary>
        /// Will focus on 1 kyu code challenges.
        /// </summary>
        [EnumMember(Value = "kyu_1_workout")]
        Kyu1Workout
    }
}
