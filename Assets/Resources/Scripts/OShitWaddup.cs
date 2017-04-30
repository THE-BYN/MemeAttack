﻿using UnityEngine;

public class OShitWaddup : MonoBehaviour {
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            // Substract 2 health from Player if hit by oshitwaddup
            other.GetComponent<Player>().health -= 2;
            Destroy(gameObject);
        }
    }
}
