// AnimatorCreator.cs

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Animations;
using System.IO;

/// <summary>
/// Animator / Animation Clip を自動生成
/// </summary>
public static class AllAnimCreatorrevised
{
    [MenuItem("tool/animcreaterev")]
    public static void CreateAnimator()
    {
        List<string> levelList = new List<string>() { "L", "M", "H" };
        List<string> emotionList = new List<string>()
        {
            "neutral","anger","contempt","disgust","fear","gratitude","guilt",
            "jealousy","joy", "pride","sadness","shame","surprise"
        };
        string rootpath = "Assets/Animation/main/";
        




        for (int person = 11; person <= 97; person++)
        {
            //controller
            AnimatorController controller = AssetDatabase.LoadAssetAtPath("Assets/Animator Controller/allmotion.controller", typeof(AnimatorController)) as AnimatorController;
            //statemachine
            var stateMachine = controller.layers[0].stateMachine;
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
                        var animClip = System.Array.Find<Object>(animations, item =>
                            item is AnimationClip && item.name.Contains("preview")==false
                        ) as AnimationClip;
                        var state_n1 = controller.AddMotion(animClip);
                        var exittransition1 = state_n1.AddExitTransition();
                        exittransition1.hasExitTime = true;
                        var anystatetransition1 = stateMachine.AddAnyStateTransition(state_n1);
                        anystatetransition1.canTransitionToSelf = false;
                        anystatetransition1.AddCondition(AnimatorConditionMode.Equals, 0, "trans");
                        anystatetransition1.AddCondition(AnimatorConditionMode.Equals, sce, "scenario");
                        anystatetransition1.AddCondition(AnimatorConditionMode.Equals, person, "person");
                    }
                }

                if (flag1 == false)
                {
                    Debug.Log(person.ToString() + temp1 + " cant find");
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
                                var animClip = System.Array.Find<Object>(animations, item =>
                                    item is AnimationClip && item.name.Contains("preview")==false
                                ) as AnimationClip;
                                var state_n1 = controller.AddMotion(animClip);
                                var exittransition1 = state_n1.AddExitTransition();
                                exittransition1.hasExitTime = true;
                                var anystatetransition1 = stateMachine.AddAnyStateTransition(state_n1);
                                anystatetransition1.canTransitionToSelf = false;
                                anystatetransition1.AddCondition(AnimatorConditionMode.Equals, emo, "trans");
                                anystatetransition1.AddCondition(AnimatorConditionMode.Equals, sce, "scenario");
                                anystatetransition1.AddCondition(AnimatorConditionMode.Equals, person, "person");
                                anystatetransition1.AddCondition(AnimatorConditionMode.Equals, lev + 1, "level");
                            }
                        }

                        if (flag2 == false)
                        {
                            Debug.Log(person.ToString() + temp2 + " can't find");
                        }
                    }
                }
            }
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
        



        //save assets
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
