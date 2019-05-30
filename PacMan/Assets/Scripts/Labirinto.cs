using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirinto : MonoBehaviour
{
    public Diretor diretor;
    void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();   
        int total = GameObject.FindGameObjectsWithTag("ponto").Length;
        diretor.AdicionarPontosMaximo(total);
    }
}
