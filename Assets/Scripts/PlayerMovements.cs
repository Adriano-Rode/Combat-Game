using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private CharacterController _controller;
    private float _playerSpeed = 4f;
    public Transform cam;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0f;
        camRight.x = 0f;

        Vector3 forward = vertical * camForward;
        Vector3 right = horizontal * camRight;

        Vector3 move = forward + right;

        _controller.Move(move.normalized * Time.deltaTime * _playerSpeed);
    }
    
}
