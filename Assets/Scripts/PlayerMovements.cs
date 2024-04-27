using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private CharacterController _controller;
    private float _playerSpeed = 4f;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        _controller.Move(move * Time.deltaTime * _playerSpeed);
    }
}
