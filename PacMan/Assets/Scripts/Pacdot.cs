﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D colisor) {
    if(colisor.name == "pacman"){
        Destroy(gameObject);
    }
}
}