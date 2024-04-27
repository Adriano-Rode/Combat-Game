using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector3 _localRot;
    public Transform player;

    void Start()
    {
        
    }

    void Update()
    {  
        transform.position = player.position;
        
        _localRot.x += Input.GetAxis("Mouse X") * 3;
        _localRot.y -= Input.GetAxis("Mouse Y") * 3;

        _localRot.y = Mathf.Clamp(_localRot.y, -20f, 80f);

        Quaternion quaternion = Quaternion.Euler(_localRot.y, _localRot.x, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, quaternion, Time.deltaTime * 10f);
    }
}
