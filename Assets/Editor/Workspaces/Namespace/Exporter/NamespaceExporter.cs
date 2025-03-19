using System.IO;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace project_pkdsim.Assets.Editor.Workspaces.Namespace.Exporter
{
    public class NamespaceExporter : EditorWindow
    {
        private static string csvPath = "C:/Users/pkdsim_offical/project_pkdsim/PS/NamespaceList.csv";

        [MenuItem("Window/Export Namespaces to CSV")]
        public void ExportNamespaces()
        {
            string[] scriptFiles = Directory.GetFiles(Application.dataPath, "*.cs", SearchOption.AllDirectories);
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("File Name,Namespace");

            foreach (string scriptPath in scriptFiles)
            {
                string fileName = Path.GetFileName(scriptPath);
                string[] lines = File.ReadAllLines(scriptPath);
                string namespaceLine = lines.FirstOrDefault(line => line.Trim().StartsWith("namespace "));

                string namespaceName = namespaceLine != null ? namespaceLine.Split(' ')[1].Trim() : "No Namespace";

                csvContent.AppendLine($"{fileName},{namespaceName}");
            }

            File.WriteAllText(csvPath, csvContent.ToString());
            AssetDatabase.Refresh();

            Debug.Log($"Namespace export completed! File saved at: {csvPath}");
        }
    }
}