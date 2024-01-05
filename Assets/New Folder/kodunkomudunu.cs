using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kodunkomudunu : MonoBehaviour
{
    public bool firePlatform;
    void Start()
    {
        firePlatform = false;
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            firePlatform = true;
            
            // Çarpışan nesneyi kullan veya işlemlerinizi yap
            GameObject carpisanNesne = other.gameObject;
            Debug.Log("Çarpışan nesne: " + carpisanNesne.name);

            // Sahnedeki tüm nesneleri al
            GameObject[] tumNesneler = GameObject.FindGameObjectsWithTag("tekyonplatform");

            // Oyuncu hariç, rastgele bir nesneyi seç
            GameObject secilenNesne = null;

            do
            {
                secilenNesne = tumNesneler[UnityEngine.Random.Range(0, tumNesneler.Length)];
            } while (secilenNesne == gameObject); // Oyuncuyu hariç tut

            RenkDegistir(secilenNesne);
           
            
            Destroy(gameObject);
            
        }
    }
    
    private void RenkDegistir(GameObject obje)
    {
        // Rastgele bir renk seç
        Color yeniRenk = new Color(250f, 0f, 0f);
    
        // Nesnenin rengini değiştir
        obje.GetComponent<Renderer>().material.color = yeniRenk;
    }
   
}
