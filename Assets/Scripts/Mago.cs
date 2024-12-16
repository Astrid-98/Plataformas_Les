using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    //1. Referenciar la bola y el punto de spawn.
    //Instanciar una bola en el punto Spawn.

    private Animator anim;
    [SerializeField ]private GameObject bolaPrefab;
    [SerializeField ]private Transform puntoSpawn;

    private Transform objetivo; //

   
    void Start()
    {
       anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LanzarBolaFuego()
    {
        //2. Instanciar una copia de la bola en el punto de spawn.
        Vector3 direccionObjetivo = (objetivo.position - transform.position).normalized;

        // Saco una copia.
        GameObject bolaCopia = Instantiate(bolaPrefab, puntoSpawn.position, Quaternion.identity);

        //Encaro el fontal de la bola con la direccion calculada.
        bolaCopia.transform.right = direccionObjetivo;
    }
    private void OnTriggerEnter(Collider2D collision)
    {
        //Si lo que entra en mi trigger en player..
        if(collision.CompareTag("Player"))
        {
            //Entonces, mi obejtivo es aquel que entra en mi trigger.
            objetivo = collision.transform;

            anim.SetBool("atacando", true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            objetivo = null;

            anim.SetBool("atacando", false);
        }
    }
}
