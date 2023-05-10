using UnityEngine;

public class CreatorsWheelColliders
{
    public static WheelCollider[] CreateWheelColliders(Transform[] wheelTransforms, float wheelRadius, float suspensionDistance, float suspensionSpring, float suspensionDamper)
    {
        WheelCollider[] wheelColliders = new WheelCollider[wheelTransforms.Length];

        for (int i = 0; i < wheelTransforms.Length; i++)
        {
            GameObject wheelColliderObject = new GameObject("WheelCollider_" + i);
            wheelColliderObject.transform.position = wheelTransforms[i].position;
            wheelColliderObject.transform.rotation = wheelTransforms[i].rotation;

            WheelCollider wheelCollider = wheelColliderObject.AddComponent<WheelCollider>();
            wheelCollider.radius = wheelRadius;
            wheelCollider.suspensionDistance = suspensionDistance;

            JointSpring jointSpring = wheelCollider.suspensionSpring;
            jointSpring.spring = suspensionSpring;
            jointSpring.damper = suspensionDamper;
            wheelCollider.suspensionSpring = jointSpring;

            wheelCollider.mass = 1000f;
            wheelCollider.wheelDampingRate = 0.25f;

            wheelColliders[i] = wheelCollider;
        }

        return wheelColliders;
    }
}
