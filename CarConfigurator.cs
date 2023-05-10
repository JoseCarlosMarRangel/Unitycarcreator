using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CarConfigurator))]

public class CarConfiguratorEditor : Editor
{

    public override void OnInspectorGUI()
    {
        //mostrar decripción en el inspector
        EditorGUILayout.HelpBox("Este script sera utilizadopara la creación de vehículos", MessageType.Info);

        //mostrar los campos predeterminados del inspector
        DrawDefaultInspector();

        if (GUILayout.Button("Crear WheelColliders"))
        {
            Transform[] wheelTransforms = new Transform[4];
            // Aquí deberías asignar los transform de las llantas que quieres convertir en WheelColliders

            float wheelRadius = 0.3f;
            float suspensionDistance = 0.2f;
            float suspensionSpring = 20000f;
            float suspensionDamper = 2000f;

            WheelCollider[] wheelColliders = CreatorsWheelColliders.CreateWheelColliders(wheelTransforms, wheelRadius, suspensionDistance, suspensionSpring, suspensionDamper);
        }

        //Muestra cualquier otro campo personalizado 
        serializedOject.ApplyModifiedProperties();
    }
}
