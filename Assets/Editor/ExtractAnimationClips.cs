using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class ExtractAnimationClip
{
    [MenuItem("Animation/ExtractAnimationClip")]
    static void AssetCopy()
    {
        List<string> levelList = new List<string>() { "L", "M", "H" };
        List<string> emotionList = new List<string>()
        {
            "neutral", "anger", "contempt", "disgust", "fear", "gratitude", "guilt",
            "jealousy", "joy", "pride", "sadness", "shame", "surprise"
        };
        string rootpath = "Assets/Animation/main/";
        int person = 5;
        string folderpath = rootpath + person.ToString("00");

        string[] guids = AssetDatabase.FindAssets("t:Model", new string[] { folderpath });
        for (int sce = 1; sce <= 3; sce++)
        {
            string temp1 = "neutral_" + sce.ToString() + ".fbx";
            bool flag1 = false;
            foreach (string guid in guids)
            {
                string filepath = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
                if (filepath.Contains(temp1))
                {
                    flag1 = true;
                    var animations = AssetDatabase.LoadAllAssetsAtPath(filepath);
                    var originalClip = System.Array.Find<Object>(animations, item =>
                        item is AnimationClip
                    );
                    string exportPath = folderpath + "/" + person.ToString("00")+"_" + "neutral_" + sce.ToString() + ".anim";
                    var copyClip = Object.Instantiate(originalClip);
                    AssetDatabase.CreateAsset(copyClip, exportPath);
                    //AssetDatabase.CreateAsset(originalClip, exportPath);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                }
            }

            if (flag1 == false)
            {
                Debug.Log(temp1+" cant find");
            }

            for (int emo = 1; emo <= 12; emo++)
            {
                for (int lev = 0; lev <= 2; lev++)
                {
                    string temp2 = emotionList[emo] + "_" + sce.ToString() + "_" + levelList[lev] + ".fbx";
                    bool flag2 = false;
                    foreach (string guid in guids)
                    {
                        string filepath = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
                        if (filepath.Contains(temp2))
                        {
                            flag2 = true;
                            var animations = AssetDatabase.LoadAllAssetsAtPath(filepath);
                            var originalClip = System.Array.Find<Object>(animations, item =>
                                item is AnimationClip
                            );
                            string exportPath = folderpath + "/" + person.ToString("00")+"_" + emotionList[emo] + "_" + sce.ToString() +
                                                "_" + levelList[lev] + ".anim";
                            var copyClip = Object.Instantiate(originalClip);
                            AssetDatabase.CreateAsset(copyClip, exportPath);
                            //AssetDatabase.CreateAsset(originalClip, exportPath);
                            AssetDatabase.SaveAssets();
                            AssetDatabase.Refresh();
                        }
                    }

                    if (flag2 == false)
                    {
                        Debug.Log(temp2+" can't find");
                    }
                }
            }
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}