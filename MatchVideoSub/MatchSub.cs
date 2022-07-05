using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchVideoSub
{
    public static class MatchSub
    {
        private static readonly string[] ExcludePattern = { "Thumbs.db", "*.txt", "*.exe" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="target"></param>
        /// <returns>true if target match pattern</returns>
        private static bool WildcardMatch(string pattern, string target)
        {
            if (pattern.StartsWith("*"))
                return target.EndsWith(pattern.Replace("*", ""));
            else if (pattern.EndsWith("*"))
                return target.StartsWith(pattern.Replace("*", ""));
            else
                return target == pattern;
        }

        private static bool WildcardMatch(string target)
        {
            foreach (var pattern in ExcludePattern)
            {
                if (WildcardMatch(pattern, target))
                    return true;
            }
            return false;
        }

        public static bool FileShouldExclude(string filename)
        {
            return WildcardMatch(filename);
        }

        public static IList<string> RenameSubtitles(IList<string> videoNames, IList<string> subNames)
        {
            if (videoNames.Count != subNames.Count)
                throw new Exception("Number of videos and subtitles does not match");

            List<string> newSub = new List<string>(subNames.Count);
            string subExt = Path.GetExtension(subNames[0]);
            foreach (var videoName in videoNames)
            {
                newSub.Add(Path.GetFileNameWithoutExtension(videoName) + subExt);
            }
            return newSub;
        }
    }
}
