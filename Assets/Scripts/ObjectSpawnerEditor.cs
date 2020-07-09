using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

[CustomEditor(typeof(ObjectSpawner))]
public class ObjectSpawnerEditor : Editor
{

    string[] _types = new[] { "Car", "Truck", "Bike" };
    float[] Mass = new[] { 1000f, 5000f, 200f };
    float[] Torque = new[] { 300f, 300f, 50f};
    float[] MaxDrop = new[] { 2f,3f,0.5f};
    float[] DamperValue = new[] { 5f,5.5f,0.2f};
    float[] StiffnessValue = new[] { 3.2f,9f,0.4f};

    int _choiceIndex = 0;

    public override void OnInspectorGUI()
    {
        ObjectSpawner myTarget = (ObjectSpawner)target;

        _choiceIndex = EditorGUILayout.Popup("Type", _choiceIndex, _types);
        myTarget.type = _choiceIndex;
        myTarget.Mass = Mass[_choiceIndex];
        myTarget.Torque = Torque[_choiceIndex];
        myTarget.MaxDrop = MaxDrop[_choiceIndex];
        myTarget.DamperValue = DamperValue[_choiceIndex];
        myTarget.StiffnessValue = StiffnessValue[_choiceIndex];

        DrawDefaultInspector();
    }

   
}