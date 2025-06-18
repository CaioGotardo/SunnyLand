using JetBrains.Annotations;
using System.Collections; //using -> import classes 
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine; // sem ele não roda 


public class Coletavel : MonoBehaviour 
{

public TMP_Text texto_pontos;
    int pontos = 0;
    

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            pontos++;
            texto_pontos.text = "Pontos:" + pontos.ToString();
            collision.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f); 
                
         
        }

        
       
    }
}
