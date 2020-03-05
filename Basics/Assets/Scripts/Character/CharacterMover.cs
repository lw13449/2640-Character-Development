using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 position;
    public float speed = 10f;
    public float jumpSpeed = 30f;
    public int jumpCount = 0;
    public float gravity = 3f;

    public void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Update()
    {
        if (controller.isGrounded)
        {
            position.y = 0; 
            jumpCount = 0;
        }

        position.x = Input.GetAxis("Horizontal") * speed;
        if (Input.GetButtonDown("Space"))
        {
            position.y = jumpSpeed;
            jumpCount++;
        }

        position.y -= gravity;
        //controller.Move(position * Time.deltaTime);
    }
}