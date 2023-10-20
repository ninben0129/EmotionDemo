using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.IO;

public class DrawAnimationClipAuto
{
    [MenuItem("Tools/Animation/AutoCopy")]
    static void AssetAutoCopy()
    {
        // AnimationClipを持つFBXの入っているファイルのパス
        string folderPath = "Assets/Animation/ChibaKaito";
        // fbxファイルのリストを取得
        List<string> fbxFiles = GetFbxFiles2(folderPath);

        foreach (string filePath in fbxFiles)
        {
            // ここに処理を記述する
            // Debug.Log("処理中: " + filePath);
            // Debug.Log(GetFileNameWithoutExtension(filePath));
            AssetCopy(filePath);
        }
    }

    static List<string> GetFbxFiles(string directoryPath)
    {
        List<string> fbxFiles = new List<string>();

        try
        {
            // ディレクトリ内のすべてのファイルを取得
            string[] files = Directory.GetFiles(directoryPath, "*.fbx", SearchOption.AllDirectories);

            // リストに追加
            fbxFiles.AddRange(files);
        }
        catch (Exception e)
        {
            Console.WriteLine("エラー: " + e.Message);
        }

        return fbxFiles;
    }

    static List<string> GetFbxFiles2(string directoryPath)
    {
        List<string> fbxFiles = new List<string>();

        try
        {
            // ディレクトリ内のすべてのファイルを取得
            string[] files = Directory.GetFiles(directoryPath, "*.fbx", SearchOption.AllDirectories);

            // リストに追加
            fbxFiles.AddRange(files);

            // パスの区切り文字を / に変換
            for (int i = 0; i < fbxFiles.Count; i++)
            {
                fbxFiles[i] = fbxFiles[i].Replace("\\", "/");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("エラー: " + e.Message);
        }

        return fbxFiles;
    }

    static string GetFileNameWithoutExtension(string filePath)
    {
        try
        {
            // ファイル名を取得し、拡張子を除外
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            return fileName;
        }
        catch (Exception e)
        {
            Console.WriteLine("エラー: " + e.Message);
            return null;
        }
    }

    static void AssetCopy(string fbxPath)
    {
        string filename = GetFileNameWithoutExtension(fbxPath);
        // AnimationClipのファイル名
        string clipName = filename + "|" + filename;
        // AnimationClipの出力先
        string exportPath = Path.GetDirectoryName(fbxPath) + "/Anim/" + filename + ".anim";

        // AnimationClipの取得
        var animations = AssetDatabase.LoadAllAssetsAtPath(fbxPath);
        var originalClip = System.Array.Find<UnityEngine.Object>(animations, item =>
            item is AnimationClip && item.name == clipName
        );

        // AnimationClipをコピーして出力(ユニークなuuid)
        var copyClip = UnityEngine.Object.Instantiate(originalClip);
        AssetDatabase.CreateAsset(copyClip, exportPath);

        // AssetDatabaseリフレッシュ
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}