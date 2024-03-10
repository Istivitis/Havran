using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohybHlavni : MonoBehaviour
    
{
    private Animator anim;
    public float rychlost = 5f;
    private SpriteRenderer sprite; 
    
   
       
// Start is called before the first frame update
void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
           Pohyb();

       

    void Pohyb()
    {
            float horizontalniInput = Input.GetAxis("Horizontal");
            float vertikalniInput = Input.GetAxis("Vertical");



            Vector3 pohyb = new Vector3(horizontalniInput, vertikalniInput, 0f) * rychlost * Time.deltaTime;
            transform.Translate(pohyb);


            if (horizontalniInput > 0f)
            {

                anim.SetBool("Bìh", true);
                sprite.flipX = false;
            }
            else if (horizontalniInput < 0f)
            {
                anim.SetBool("Bìh", true);


                sprite.flipX = true; 

            }
            else
            {

                anim.SetBool("Bìh", false);

            }
           //////////////////
            if (vertikalniInput > 0f)
            {

                anim.SetBool("Nahoru", true);
            }
            
            else if (vertikalniInput < 0f)
            {
                anim.SetBool("Dolu", true);

            }
            else
            {

                anim.SetBool("Nahoru", false);

            }
            //////////////////////
            //////////////////////
            
        }
    }
}
