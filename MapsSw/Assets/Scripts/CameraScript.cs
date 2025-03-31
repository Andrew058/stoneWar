using UnityEngine;

public class CameraScript : MonoBehaviour
{
   public GameObject Albert;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Albert.transform.position.x;
        transform.position = position;
    }
}
