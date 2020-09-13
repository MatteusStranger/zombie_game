using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {
    public float Velocidade = 20;
    private Rigidbody rigidBodyBala;

    void Start()
    {
        rigidBodyBala = GetComponent<Rigidbody>();
}

    void FixedUpdate () {


        rigidBodyBala.MovePosition
           (rigidBodyBala.position +
           transform.forward * Velocidade * Time.deltaTime);
    }
    void OnTriggerEnter(Collider objetoDeColisao)
    {
        if(objetoDeColisao.tag == "Inimigo")
        {
            Destroy(objetoDeColisao.gameObject);
        }
        Destroy(gameObject);
    }
}
