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


        // creates the controller
        var controller =
            AnimatorController.CreateAnimatorControllerAtPath("Assets/Animator Controller/test.controller");

        //add parameters
        controller.AddParameter("trans", AnimatorControllerParameterType.Int);
        controller.AddParameter("level", AnimatorControllerParameterType.Int);

        //add statemachine
        var stateMachine = controller.layers[0].stateMachine;

        // add states
        //"Assets/Animation/new/test.anim"
        string animationClipPath = "Assets/Animation/new/test.anim";
        AnimationClip clip = (AnimationClip)AssetDatabase.LoadAssetAtPath(animationClipPath, typeof(AnimationClip));
        var state = controller.AddMotion(clip);
        state.name = "test1";
        var state1 = controller.AddMotion(clip);

        // add transitions
        var exitTransition = state.AddExitTransition();

        var transition1 = stateMachine.AddAnyStateTransition(state1);
        transition1.canTransitionToSelf = false;
        transition1.AddCondition(AnimatorConditionMode.Equals, 2, "trans");
        transition1.AddCondition(AnimatorConditionMode.Equals, 2, "level");
        var transition2 = state1.AddExitTransition();

        //save assets
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}