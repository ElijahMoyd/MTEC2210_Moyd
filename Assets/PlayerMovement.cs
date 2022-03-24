using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5.0f;









    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");

        float xMovement = xMove * speed * Time.deltaTime;


        transform.Translate(xMovement, 0, 0);
        //transform.position = new Vector3(transform.position.x + xMovement, 0, 0);




    }
}
