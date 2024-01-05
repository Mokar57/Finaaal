using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformdaninme2 : MonoBehaviour
{
    [SerializeField] private BoxCollider2D playerCollider;  //oyuncudan box collider çağırıyor
    [SerializeField] public float beklemesuresi=0.5f;
    

    private GameObject tekyonplatform;   //tek yön platformları belirtiyor tag ile belirticez

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (tekyonplatform != null)
            {
                StartCoroutine(DisableCollision());
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "tekyonplatform")
        {
            tekyonplatform = other.gameObject;   //üzerine çıktığın platformu tek yön platform yapıyorum?
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "tekyonplatform")
        {
            tekyonplatform = null;  //üzerinde olmadığım platformu tek yön platformdan çıkarıyorum?
        }
    }

    private IEnumerator DisableCollision()
    {
        BoxCollider2D platformCollider = tekyonplatform.GetComponent<BoxCollider2D>();

        Physics2D.IgnoreCollision(playerCollider, platformCollider);

        yield return new WaitForSeconds(beklemesuresi);
        
        Physics2D.IgnoreCollision(playerCollider, platformCollider,false);
        
        //oyuncu ile platformun çarpışmasını yok say bekleme süresini bekle çarpışma yok saymayı kaldır
    }
}
