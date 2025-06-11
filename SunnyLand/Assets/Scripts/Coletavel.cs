using JetBrains.Annotations;
using System.Collections; //using -> import classes 
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine; // sem ele não roda 

public class Coletavel : MonoBehaviour 
{
    private int pontos = 5; 

    void Start()
    {
        // concatenação cs = concatenação js 
        Debug.Log("O Jogo começou " + pontos  ); //debug.log = console.log | ; -> OBRIGATORIO
    }

    void Update()
    {
        //  Debug.Log("Rolando");
         
    }
}
