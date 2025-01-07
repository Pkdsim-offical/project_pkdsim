using System;
using System.Text.RegularExpressions;

namespace Unity.Services.CloudCode.Authoring.Editor.Core.Dotnet
{
    class SemVersion
    {
        static Regex s_SemverRegex = new Regex(@"(\d*)\.(\d*)\.(\d*)-?([\w\.]*)?\+?([\w\.]*)?");
        public Version Version { get; }
        public string PrerelaseTag { get; }
        public string RawString { get; }

        public SemVersion(
            Version version,
            string prereleaseTag,
            string rawString)
        {
            Version = version;
            PrerelaseTag = prereleaseTag;
            RawString = rawString;
        }

        public static SemVersion ParseString(string str)
        {
            var match = s_SemverRegex.Match(str);
            if (!match.Success)
                return null;
            var maj = int.Parse(match.Groups[1].Value);
            var min = int.Parse(match.Groups[2].Value);
            var patch = int.Parse(match.Groups[3].Value);
            var prereleaseTag = match.Groups.Count >= 5 ? match.Groups[4].Value : null;
            return new SemVersion(new Version(maj, min, patch), prereleaseTag, str);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(PrerelaseTag))
                return $"{Version}";
            return $"{Version}-{PrerelaseTag}";
        }
    }
}
