using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 
    public float forwardForce = 400f;
    public float sidewaysForce = 400f;
    public bool moveRight=false;
    public bool moveLeft=false;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKey("d")){
            moveRight=true;
        }
        if (Input.GetKey("q")){
            moveLeft=true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight==true){
            rb.AddForce(sidewaysForce*Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
            moveRight=false;
        }
        if (moveLeft==true){
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
            moveLeft=false;
        }

        if (rb.position.y < -4f ){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
