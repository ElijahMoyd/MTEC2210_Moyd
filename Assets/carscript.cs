using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class carscript : MonoBehaviour
    {
       

        public float speed = 5.0f;
        // Start is called before the first frame update

      
        // Update is called once per frame
        void Update()
        {

            transform.position += Vector3.right * speed * Time.deltaTime;
            //hint: In Unity you can get Vector (direction) shorthands like this: Vector3.up   
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            PlayerManager.isGameOver = true;
            Destroy(collision.gameObject);
        }
    }
}
