using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (ObjectGenerator))]
public class ObjectGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ObjectGenerator objGen = (ObjectGenerator)target;

        if (DrawDefaultInspector ())
        {
            if (objGen.autoUpdate)
            {
                objGen.Generate ();
            }
        }
    }
}
