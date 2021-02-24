
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    public float Speed;

    void Update() {
       transform.position  =  Vector3.Lerp(transform.position , Target.position + Offset ,Speed * Time.deltaTime );
    }
}
