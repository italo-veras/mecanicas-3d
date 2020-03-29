using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentFirstPerson : MonoBehaviour
{

    [SerializeField]
    protected CharacterController characterController;
    [SerializeField]
    private Transform groundCheck;

    protected Vector3 inputMoviment;
    Vector3 gravityVector;

    public float movementSpeed;
    public float jumpSpeed;
    float gravitySpeed = -29.43f;
    public float groundCheckRadius;

    public LayerMask groundMask;

    public bool isGrounded;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        groundCheck = GameObject.Find("Ground Check Player").GetComponent<Transform>();
    }
   
    void Update()
    {
        Inputs();
        
    }
    protected void FixedUpdate()
    {
        Moviment();
        Gravity();
    }
    void Inputs()
    {
        inputMoviment = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")).normalized;
       
    }
    protected virtual void Moviment()
    {

        characterController.Move(inputMoviment * movementSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gravityVector.y = Mathf.Sqrt(jumpSpeed * -2f * gravitySpeed);
        }
    } 
    void Gravity()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundMask);

        if (isGrounded == true && gravityVector.y < 0)
        {
            gravityVector.y = -1f;
        }
        else
        {
            gravityVector.y += gravitySpeed * Time.deltaTime;
        }
        characterController.Move(gravityVector * Time.deltaTime);
    }
    
    
}
