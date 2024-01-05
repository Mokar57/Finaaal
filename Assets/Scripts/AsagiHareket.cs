using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsagiHareket : MonoBehaviour
{
    
    public float hareketHizi = 5f;

    private void FixedUpdate()
    {
        HareketEt();
    }

    void HareketEt()
    {
        // Nesnenin aşağı yönde hareket etmesi için bir kuvvet uygula
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -hareketHizi);
    }
}
