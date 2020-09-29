using UnityEngine;

public class mov : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, 2000 * Time.deltaTime);
        if(Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 2000 * Time.deltaTime);
        }
    }
}
