using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CustomEditor(typeof(TextController))]
public class TextControllerEditor : Editor
{
    private bool showLines = false;

    public override void OnInspectorGUI()
    {
        TextController myTarget = (TextController) target;

        DrawDefaultInspector();

        showLines = EditorGUILayout.Foldout(showLines, "Lines");

        if (showLines)
        {
            int lineCount = EditorGUILayout.IntField("Size", myTarget.Lines.Length);

            if (lineCount != myTarget.Lines.Length)
            {
                TextController.TextWithAudio[] newLines = new TextController.TextWithAudio[lineCount];

                for (int i = 0; i < myTarget.Lines.Length; ++i)
                {
                    newLines[i] = myTarget.Lines[i];
                }

                for (int i = myTarget.Lines.Length; i < lineCount; ++i)
                {
                    newLines[i] = new TextController.TextWithAudio();
                }
                myTarget.Lines = newLines;
            }

            for (int i = 0; i < myTarget.Lines.Length; ++i)
            {
                EditorGUILayout.LabelField("Text " + i);
                myTarget.Lines[i].Text = EditorGUILayout.TextArea(myTarget.Lines[i].Text);

                Object audioObject =
                    EditorGUILayout.ObjectField("Clip " + i, myTarget.Lines[i].Audio, typeof(AudioClip), true);
                Debug.Log(audioObject);
                myTarget.Lines[i].Audio = (AudioClip) audioObject;

                myTarget.Lines[i].DurationOverride = EditorGUILayout.FloatField("Duration Override " + i,
                    myTarget.Lines[i].DurationOverride);
            }
        }
    }
}