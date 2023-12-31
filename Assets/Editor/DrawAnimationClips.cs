using UnityEngine;
using UnityEditor;
public class DrawAnimationClip
{
    [MenuItem("Tools/Animation/Copy")]
    static void AssetCopy ()
    {
        // AnimationClipを持つFBXのパス
        string fbxPath = "Assets/Animation/new/anger_H2.fbx";
        // AnimationClipのファイル名
        string clipName = "Armature|2022-03-12_CK_anger_1_H_remap";
        // AnimationClipの出力先
        string exportPath = "Assets/Animation/new/anger_H.anim";
        // string tempExportedClip = "Assets/Animation/new/tempClip.anim";

        // AnimationClipの取得
        var animations = AssetDatabase.LoadAllAssetsAtPath (fbxPath);
        var originalClip = System.Array.Find<Object> (animations, item =>
            item is AnimationClip && item.name == clipName
        );
	
        // AnimationClipをコピーして出力(ユニークなuuid)
        var copyClip = Object.Instantiate (originalClip);
        AssetDatabase.CreateAsset (copyClip, exportPath);

        // AnimationClipのコピー（固定化したuuid）
        //File.Copy (tempExportedClip, exportPath, true);
        //File.Delete (tempExportedClip);

        // AssetDatabaseリフレッシュ
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}