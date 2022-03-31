using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour

 
{
    public SpriteRenderer spriterender;
    // Start is called before the first frame update
    private void Awake ()
    {
        spriterender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (spriterender != null) 
        {
            Color newColor = new Color(
                Random.value,
                Random.value,
                Random.value

                );


            spriterender.color = newColor;
        }
    }
}
