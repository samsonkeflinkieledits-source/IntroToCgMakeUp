using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;

    private float verticalRotation = 0f;
    private float verticalVelocity = 0f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        MovePlayer();
      
    }

    void MovePlayer()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;
        movement = movement.normalized * moveSpeed;

        movement.y = verticalVelocity;

        controller.Move(movement * Time.deltaTime);
    }

    

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

