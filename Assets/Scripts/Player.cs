using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        //Moving Up
        if (verticalInput > 0)
        {
            if (transform.position.y < 3.9)
            {
                transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
            }
        }
        //Moving Down
        if (verticalInput < 0)
        {
            if (transform.position.y > -3.9)
            {
                transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
            }
        }
    }
}
