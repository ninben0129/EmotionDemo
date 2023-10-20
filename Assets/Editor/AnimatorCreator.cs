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
public static class AnimatorCreator
{
    [MenuItem("Tools/Animation/Create Animator")]
    public static void CreateAnimator()
    {
        List<string> levelList = new List<string>() { "L", "M", "H" };
        List<string> emotionList = new List<string>()
        {
            "neutral","anger","contempt","disgust","fear","gratitude","guilt",
            "jealousy","joy", "pride","sadness","shame","surprise"
        };
        string person = "CK";

        // creates the controller
        var controller =
            AnimatorController.CreateAnimatorControllerAtPath("Assets/Animator Controller/CK.controller");

        //add parameters
        controller.AddParameter("trans", AnimatorControllerParameterType.Int);
        controller.AddParameter("level", AnimatorControllerParameterType.Int);
        controller.AddParameter("scenario",AnimatorControllerParameterType.Int);

        //add statemachine
        var stateMachine = controller.layers[0].stateMachine;

        // add states
        //"Assets/Animation/new/test.anim"
        string animationClipFolderPath = "Assets/Animation/ChibaKaito/Anim/";
        
        // add neutral emotion
        AnimationClip clip1 = (AnimationClip)AssetDatabase.LoadAssetAtPath(animationClipFolderPath+"CK_neutral_1.anim", typeof(AnimationClip));
        var state_n1 = controller.AddMotion(clip1);
        var exittransition1=state_n1.AddExitTransition();
        exittransition1.hasExitTime = true;
        
        AnimationClip clip2 = (AnimationClip)AssetDatabase.LoadAssetAtPath(animationClipFolderPath+"CK_neutral_2.anim", typeof(AnimationClip));
        var state_n2 = controller.AddMotion(clip2);
        var exitTransition2 = state_n2.AddExitTransition();
        exitTransition2.hasExitTime = true;
        var anystatetransition1 = stateMachine.AddAnyStateTransition(state_n2);
        anystatetransition1.canTransitionToSelf = false;
        anystatetransition1.AddCondition(AnimatorConditionMode.Equals, 0, "trans");
        anystatetransition1.AddCondition(AnimatorConditionMode.Equals, 2, "scenario");
        
        AnimationClip clip3 = (AnimationClip)AssetDatabase.LoadAssetAtPath(animationClipFolderPath+"CK_neutral_3.anim", typeof(AnimationClip));
        var state_n3 = controller.AddMotion(clip3);
        var exittransition3=state_n3.AddExitTransition();
        exittransition3.hasExitTime = true;
        var anystatetransition2 = stateMachine.AddAnyStateTransition(state_n3);
        anystatetransition2.canTransitionToSelf = false;
        anystatetransition2.AddCondition(AnimatorConditionMode.Equals, 0, "trans");
        anystatetransition2.AddCondition(AnimatorConditionMode.Equals, 3, "scenario");

        for (int emo = 1; emo <= 12; emo++)
        {
            for (int sce = 1; sce <= 3; sce++)
            {
                for (int lev = 1; lev <= 3; lev++)
                {
                    string emotion = emotionList[emo];
                    int scenario = sce;
                    string level = levelList[lev-1];
                    
                    string animationClipPath =
                        animationClipFolderPath + person + "_" + emotion + "_" + scenario.ToString() + "_" + level+".anim";
                    
                    AnimationClip clip = (AnimationClip)AssetDatabase.LoadAssetAtPath(animationClipPath, typeof(AnimationClip));
                    
                    var state = controller.AddMotion(clip);
                    // state.name = "test1";
                    

                    // add transitions
                    var exitTransition = state.AddExitTransition();
                    exitTransition.hasExitTime = true;
                    var transition = stateMachine.AddAnyStateTransition(state);
                    transition.canTransitionToSelf = false;
                    transition.AddCondition(AnimatorConditionMode.Equals, emo, "trans");
                    transition.AddCondition(AnimatorConditionMode.Equals, sce, "scenario");
                    transition.AddCondition(AnimatorConditionMode.Equals, lev, "level");
                    
                }
            }
        }
        

        //save assets
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}