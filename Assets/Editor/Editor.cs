using System.IO;
using UnityEngine;
using UnityEditor;

public class WindowTest : EditorWindow
{

    [MenuItem("Test/Count")]
    static void Init()
    {
        WindowTest window = (WindowTest) EditorWindow.GetWindow(typeof(WindowTest));
        window.Show();
    }

    private int result = 0;


    int SearchCsFileRecursive(string path)
    {
        var count = 0;
        var files = Directory.GetFiles(path);
     
        foreach (var file in files)
        {
            var ext = Path.GetExtension(file);
            if (ext.ToLower() == ".cs")
            {//拡張子が.csなら
                count++;
            }
        }
        var directories = Directory.GetDirectories(path);
        foreach (var directory in directories)
        {//再帰的に検索
            Debug.Log(directory);
            count += SearchCsFileRecursive(directory);
        }


        return count;
      
    }
    void OnGUI()
    {
        GUILayout.Label("ファイル数 : " + result);
        if (GUILayout.Button("csファイル数カウント"))
        {
            result = SearchCsFileRecursive("Assets/Scripts");
        }
    }
}