using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

public class animtest : MonoBehaviour
{
    [MenuItem("Tools/test/testanim")]
    public static void CreateAnimator()
    {
        string animatorControllerPath = "Assets/Animator Controller/test.controller";
        string fbxpath = "Assets/Animation/main/01/KS_gratitude_2_H.fbx";
        AnimatorController controller = AssetDatabase.LoadAssetAtPath(animatorControllerPath, typeof(AnimatorController)) as AnimatorController;
        var animations = AssetDatabase.LoadAllAssetsAtPath(fbxpath);
        var originalClip = System.Array.Find<Object>(animations, item =>
            item is AnimationClip
        ) as AnimationClip;

        //add statemachine
        var stateMachine = controller.layers[0].stateMachine;

        // add states
        //"Assets/Animation/new/test.anim"
        
        // add neutral emotion
        
        var state_n1 = controller.AddMotion(originalClip);
        var exittransition1=state_n1.AddExitTransition();
        exittransition1.hasExitTime = true;
        


        //save assets
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    } 
}

