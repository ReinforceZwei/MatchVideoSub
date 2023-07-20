using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        private static bool IsValidList(IList<string> videoPaths, IList<string> subPaths)
        {
            return videoPaths.Count == subPaths.Count 
                && videoPaths.Count > 0 
                && subPaths.Count > 0;
        }

        public static bool FileShouldExclude(string filename)
        {
            return WildcardMatch(filename);
        }

        public static IList<string> CreateSubtitleFilename(IList<string> videoNames, IList<string> subNames)
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

        public static void Match(IList<string> videoPaths, IList<string> subPaths)
        {
            if (!IsValidList(videoPaths, subPaths))
                throw new Exception("Number of video and subtitle mismatch");

            videoPaths = videoPaths.OrderBy(x => x, new NaturalStringComparer()).ToList();
            subPaths = subPaths.OrderBy(x => x, new NaturalStringComparer()).ToList();

            var destPath = Path.GetDirectoryName(subPaths[0]);
            var newSubtitle = CreateSubtitleFilename(videoPaths, subPaths);

            for (int i = 0; i < videoPaths.Count; i++)
            {
                File.Move(subPaths[i], Path.Combine(destPath, newSubtitle[i]), true);
            }
        }

        public static void Match(IList<string> videoPaths, IList<string> subPaths, string destPath)
        {
            if (!IsValidList(videoPaths, subPaths))
                throw new Exception("Number of video and subtitle mismatch");

            videoPaths = videoPaths.OrderBy(x => x, new NaturalStringComparer()).ToList();
            subPaths = subPaths.OrderBy(x => x, new NaturalStringComparer()).ToList();

            var newSubtitle = CreateSubtitleFilename(videoPaths, subPaths);

            for (int i = 0; i < videoPaths.Count; i++)
            {
                File.Copy(subPaths[i], Path.Combine(destPath, newSubtitle[i]), true);
            }
        }
    }

    internal static class SafeNativeMethods
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);
    }

    public sealed class NaturalStringComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a, b);
        }
    }
}
