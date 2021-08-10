using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    bool alive = true;
    public float speed = 5;
    public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    public float jumpForce = 5;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
    if (!alive) return;

     Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
     Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
     rb.MovePosition(rb.position + forwardMove + horizontalMove);  
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space)){
          Jump();
        }

        if (transform.position.y < -5) {
            Die();
        }
    }
    public void Die ()
    {
        alive = false;
        Invoke("Restart", 2);
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Jump(){

        rb.AddForce(Vector3.up * jumpForce);
    }

}
