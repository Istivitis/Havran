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
        //Animace vys�v�n� prachu Tom�i 
        Debug.Log("Ukl�z�me!");
        if (HP <=0)
        {
            vysato();
        }
    }


    void vysato()
    {

        Debug.Log("Je uklizeno");
        //Animace tot�ln�ho vys�t�
        //Zni�en� prachu
        gameObject.SetActive(false);
    }
  
}
