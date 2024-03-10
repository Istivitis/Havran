using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utok : MonoBehaviour
{

    public Animator anim;
    public Transform UtokBod;
    public float dosah = 0.5f;
    public LayerMask Prach;

    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            �tok();
        }
        else
        {
            anim.SetBool("�tok", false);
        }

    }
    void �tok()
    {
        anim.SetBool("�tok", true);

        Collider2D[] Vysati = Physics2D.OverlapCircleAll(UtokBod.position, dosah, Prach);

       // Collider2D[] collidedObjects = Physics2D.OverlapPointAll(UtokBod.position, Prach);



        foreach (Collider2D nepritel in Vysati)
        {
            Debug.Log("Vys�v�m" + nepritel.name);

            nepritel.GetComponent<Prach>().Ratatatata(1);
        }

    }

    private void OnDrawGizmosSelected()
    {
        if (UtokBod == null)
            return;

        Gizmos.DrawWireSphere(UtokBod.position, dosah);
    }


}
