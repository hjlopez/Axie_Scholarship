using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axie_Scholarship.Constants
{
    public static class DescriptionConstants
    {
        public const string CWin = "win";
        public const string CLose = "loss";
        public const string CDraw = "draw";
        public const string COnce = "once";
        public const string CWinningRecord = "winning record";
        public const string CLosingRecord = "winning record";
        public const string CTimesDuring = "times during";
        public const string CTotal = "total of";
        public static string[] checker =
        {
            "win",
            "loss",
            "draw",
            "winning record",
            "losing record",
            "exact record",
            "once",
            "times during",
            "during cashout"
        };

        public static string and = "and ";
        public static string win = "({0}) win/s ";
        public static string loss = "({0}) loss/es ";
        public static string draw = "({0}) draw/s ";
        public static string winningRecord = "a winning record or more than 50% wins during the cutoff period.";
        public static string losingRecord = "a losing record or less than 50% wins during the cutoff period.";
        public static string exactRecord = "an exact record or exactly 50% wins during the cutoff period.";

        public static string openingDescriptionBonus = "Scholar will earn an additional ";
        public static string openingDescriptionPenalty = "Scholar will have a penalty of ";
        public static string percentSLP = "({0}%) of total SLP earned ";
        public static string exactSLP = "({0}) SLP ";

        public static string descriptionOnceOrCustom = "if he/she accumulates ";
        public static string descriptionTotal = "if he/she accumulates a total of ";

        public static string once = "in a day once during the cutoff period.";
        public static string custom = "in a day ({0}) times during the cutoff period";
        public static string total = "during cashout.";
    }
}
