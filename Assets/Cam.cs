using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float raycastDistance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.right, -vertical * 100f * Time.deltaTime);

        if (Input.GetKeyDown("e"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("Cheese"))
                    Debug.Log("interacted with " + hit.collider.gameObject.name);
            }
        }
    }
}
