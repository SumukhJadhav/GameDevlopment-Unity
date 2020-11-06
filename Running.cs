using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 25f;
    public float smoothTurn = 0.1f;
    public float smoothVel;
    public Transform cam;

    void start()
    {
        Vector3 direction = new Vector3 (-0.08499956f, 1.9f, 4.09f).normalized;
    }

    void Update()
    {
        //float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Run");
        Vector3 direction = new Vector3 (0f, 0f, vertical).normalized;
        
        if(Input.GetAxisRaw("Forw") == 1)
        {
            Debug.Log("H");
            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVel, smoothTurn);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                Vector3 movDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                controller.Move(movDir.normalized * speed * Time.deltaTime); 
            }
        }
 

    }
     void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "x")
        {
            Destroy(gameObject);
            Debug.Log("Hit");
        }
    }
}