using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prach : MonoBehaviour
{
    public int maxHP = 1000;
    public int HP;






    void Start()
    {
        HP = maxHP;
    }


    public void Ratatatata(int damage)
    {
        HP = HP - damage;
        //Animace vysávání prachu Tomáši 
        Debug.Log("Uklízíme!");
        if (HP <=0)
        {
            vysato();
        }
    }


    void vysato()
    {

        Debug.Log("Je uklizeno");
        //Animace totálního vysátí
        //Znièení prachu
        gameObject.SetActive(false);
    }
  
}
