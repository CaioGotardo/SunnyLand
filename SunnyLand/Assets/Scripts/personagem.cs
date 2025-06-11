using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class personagem : MonoBehaviour
{

    private string name = "Robertino Divino";

    private int health = 100;

    private float velocity = 2.5f; // flaot necessita de f apos os numeros 

    private bool life = true;

    private Rigidbody2D rb;

    public float novaGravidade = 0;

    void Start()
    {
        Debug.Log("Su Nombre es " + name + " su vida es " + health + "su veloxita" + velocity );

        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = novaGravidade;

     


    }

    void Update()
    {
        
    }
}
