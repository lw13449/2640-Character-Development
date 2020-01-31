using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterController : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    public float rotateSpeed = 2;
    private int jumpCount;
    public int jumpCountMax = 2;
    public bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Move(Input.GetAxis("Vertical"));
        Rotate(Input.GetAxis("Horizontal"));
    }
    

    public void Move(float myInput)
    {
        position.x = myInput;
        position = transform.TransformDirection(position * moveSpeed * Time.deltaTime);
    }
    void Rotate(float myInput)
    {
        transform.Rotate(0, myInput*rotateSpeed, 0);
    }

    void SearchInventory()
    {
        //the do work section of creating the Inventory List for objects, floats, and others you gather during the game.
        //Call the MatchID script to do work.
    }
}
