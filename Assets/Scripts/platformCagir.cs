using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformCagir : MonoBehaviour
{
    public GameObject prefab; // Unity editöründen sürükleyip bıraktığınız prefab'ın referansı
    public float minSuresi = 2f; // Minimum süre (saniye)
    public float maxSuresi = 5f; // Maximum süre (saniye)

    private void Start()
    {
        // Belirli aralıklarla random süreler içinde Coroutine'i başlat
        StartCoroutine(CagirPrefabRandom());
    }

    IEnumerator CagirPrefabRandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSuresi, maxSuresi));

            // Prefab'ı çağır ve kendi üstünde oluştur
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
