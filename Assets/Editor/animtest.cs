using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

public class animtest : MonoBehaviour
{
    [MenuItem("Tools/test/testanim")]
    public static void CreateAnimator()
    {
        
        string animatorControllerPath = "Assets/Animator Controller/test.controller";
        string fbxpath = "Assets/Animation/main/08/CK_neutral_1.fbx";
        AnimatorController controller = AssetDatabase.LoadAssetAtPath(animatorControllerPath, typeof(AnimatorController)) as AnimatorController;
        var animations = AssetDatabase.LoadAllAssetsAtPath(fbxpath);
        var animationClip = System.Array.Find<Object>(animations, item =>
            item is AnimationClip && item.name.Contains("preview")==false
        ) as AnimationClip;

        //add statemachine
        var stateMachine = controller.layers[0].stateMachine;


        // add clip
        var state_n1 = controller.AddMotion(animationClip);
        var exittransition1=state_n1.AddExitTransition();
        exittransition1.hasExitTime = true;
        //save assets
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    } 
}

