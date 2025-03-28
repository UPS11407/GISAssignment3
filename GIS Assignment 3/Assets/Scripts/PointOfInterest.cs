using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class PointOfInterest : MonoBehaviour
{
    [SerializeField] TeleportationAnchor teleportPoint;

    public void TeleportNext()
    {
        teleportPoint.RequestTeleport();
    }
}
