using UnityEngine;
//camerann mun fylgja spilarnum á sértsöku angle sama hvernig spilarinn er og snýr.
public class camera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
