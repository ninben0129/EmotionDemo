using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class fbxcount : MonoBehaviour
{
    [MenuItem("tool/fbxcount")]
    static void AssetCopy()
    {
        List<string> levelList = new List<string>() { "L", "M", "H" };
        List<string> emotionList = new List<string>()
        {
            "neutral", "anger", "contempt", "disgust", "fear", "gratitude", "guilt",
            "jealousy", "joy", "pride", "sadness", "shame", "surprise"
        };
        string rootpath = "Assets/Animation/main/";
        for (int person = 1; person <= 97; person++)
        {
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
                    }
                }

                if (flag1 == false)
                {
                    Debug.Log(person.ToString()+ temp1 + " cant find");
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
                            }
                        }

                        if (flag2 == false)
                        {
                            Debug.Log(person.ToString()+temp2 + " can't find");
                        }
                    }
                }
            }
        }
    }
}