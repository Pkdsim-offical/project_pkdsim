using System;
using System.IO;

namespace Unity.Services.Deployment.Editor.Interface.UI.Serialization
{
    interface ISerializableComponent
    {
        string SerializationKey { get; }
        object SerializationValue { get; }
        event Action ValueChanged;

        void ApplySerialization(object serializationValue);

        public static string CreateKey(string itemName, string itemPath) =>
            $"{itemName}{Path.AltDirectorySeparatorChar}{itemPath}";

        public static (string, string) DisassembleKey(string key)
        {
            var splitKey = key.Split(Path.AltDirectorySeparatorChar);

            var name = splitKey[0];
            var path = string.Empty;

            if (splitKey.Length > 1)
            {
                path = string.Join(Path.AltDirectorySeparatorChar, splitKey[1..]);
            }

            return new ValueTuple<string, string>(name, path);
        }
    }
}
