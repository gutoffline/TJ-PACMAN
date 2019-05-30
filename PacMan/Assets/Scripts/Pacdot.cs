using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    public Diretor diretor;
    
    void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();    
    }
    private void OnTriggerEnter2D(Collider2D colisor) {
        if(colisor.name == "pacman"){
            diretor.AdicionarPontos();
            Destroy(gameObject);
        }
    }
}
