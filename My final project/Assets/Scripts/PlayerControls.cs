using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class PlayerControls : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultipier;
    bool readyToJump;



    [Header("Ground Check ")]

    // How to make a C# ----> Accesor datatype varName

    Rigidbody rb;

    public CharacterController controller; // A var to hold the players char controller component


  

    private Vector3 moveDirections = Vector3.zero;


    public int health;


    private EnemyFollow enemy;


    public float rotateSpeed = 5f; // speed the player rotate


    public Animator animController; // A var to hold the players anime controller component


// Start is called before the first frame update
void Start()
{

controller = GetComponent<CharacterController>();

enemy = FindObjectOfType<EnemyFollow>();

animController = GetComponent<Animator>();
}


// Update is called once per frame
void Update()
{
// gather input from the player
float horizontalInput = Input.GetAxis("Horizontal");
float verticalInput = Input.GetAxis("Vertical");


// calculate direction the player should based on our collected input
Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);


// move the player based on input
controller.Move(movement * moveSpeed * Time.deltaTime);


// vector.3 = (0, 0, 0) --> Player is not moving

if (movement != Vector3.zero) // if the player is moving...
{
    animController.SetBool("IsMoving", true); // tell the anim controller to transition to the run

    //rotate the player in direction they are moving over time
    Quaternion targetRotation = Quaternion.LookRotation(movement); // storing the rotation needed

    // rotate the player based on its current Rotation values and the target rotation value
    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
}
else
{
    animController.SetBool("IsMoving", false);
}
}


void OnTriggerEnter(Collider other)
{
if(other.CompareTag("Enemy"))
{

//GameManager.Instance.GameOver();


Destroy(gameObject);
}

}
private void Jump()
{
    // reset y velocity
    rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
}
}


