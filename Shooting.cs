using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 10f;
    public Camera fpsCam;
    public float range = 100f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            fire();
        }
    }
    void fire()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
