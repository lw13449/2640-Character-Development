using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterController : MonoBehaviour
{
    private Vector3 position;
    private CharacterController controller;

    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    private int jumpCount;
    public int jumpCountMax = 2;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        
    }
}
