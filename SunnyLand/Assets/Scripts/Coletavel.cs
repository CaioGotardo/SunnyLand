using JetBrains.Annotations;
using System.Collections; //using -> import classes 
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine; // sem ele n�o roda 

public class Coletavel : MonoBehaviour 
{
    private int pontos = 5; 

    void Start()
    {
        // concatena��o cs = concatena��o js 
        Debug.Log("O Jogo come�ou " + pontos  ); //debug.log = console.log | ; -> OBRIGATORIO
    }

    void Update()
    {
        //  Debug.Log("Rolando");
         
    }
}
