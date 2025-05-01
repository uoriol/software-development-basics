using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentCenter.Shared.EnumRepository
{
    public enum LeetCodeDifficulty
    {
        EASY = 1,
        MEDIUM = 2,
        HARD = 3
    }

    public static class EnumRepository
    {
        public static string GetDifficultyString(LeetCodeDifficulty difficulty)
        {
            switch (difficulty)
            {
                case LeetCodeDifficulty.EASY:
                    return "Easy";
                case LeetCodeDifficulty.MEDIUM:
                    return "Medium";
                default:
                    return "Hard";
            }
        }

        public static string GetDifficultyColor(LeetCodeDifficulty difficulty)
        {
            switch (difficulty)
            {
                case LeetCodeDifficulty.EASY:
                    return "green";
                case LeetCodeDifficulty.MEDIUM:
                    return "orange";
                default:
                    return "red";
            }
        }

        public static string GetDifficultyStyle(LeetCodeDifficulty difficulty)
        {
            string color = "white";
            string background = "green";
            switch (difficulty)
            {
                case LeetCodeDifficulty.MEDIUM:
                    color = "#404040";
                    background = "orange";
                    break;
                case LeetCodeDifficulty.HARD:
                    background = "red";
                    break;
                default:
                    break;
            }

            return "background: " + background + "; color: " + color;
        }
    }
}
