using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Murcielago : MonoBehaviour
{
    [SerializeField] private Transform ruta;

    private List<Transform> puntosRuta = new List<Transform>();

    
    void Start()
    {
        
        foreach (Transform punto in ruta.transform) 
        {
            puntosRuta.Add(punto);
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
