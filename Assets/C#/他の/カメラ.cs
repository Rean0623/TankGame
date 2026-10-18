using UnityEngine;

public class カメラ : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -10);

    void LateUpdate()
    {
        if (target == null) return;

        transform.position = target.position + target.rotation* offset;
        transform.LookAt(target.position,Vector3.up);
        
    }
}
