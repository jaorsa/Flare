using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : MonoBehaviour
{

    public Transform player;
    public Vector3 distancia;
    public float retardo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 posicionDeseada = player.position + distancia;
        Vector3 posicionRetardo = Vector3.Lerp(transform.position, posicionDeseada, retardo);
        transform.position = posicionRetardo;

        transform.LookAt(player);
    }
}
