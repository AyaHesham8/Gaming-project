using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surge : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Move", true);
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
   public void SetCollide()
    {
        anim.SetBool("Collide", true);
       
    }
}
