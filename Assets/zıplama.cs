
using System;
using Unity.VisualScripting;
using UnityEngine;

public class Zıplama : MonoBehaviour
{

  public float castdistance;

  private bool yerdemi;

  public LayerMask groundLayer;

  public Vector2 boxSize;
  


  private Rigidbody2D rb;

  public float jumpForce;

  private void Start()
  {
    rb = gameObject.GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    
    if (Input.GetKeyDown(KeyCode.W) && yerdemi)
    {
      rb.AddForce(new Vector2(0, jumpForce));
    }
  }

  // public bool Yerde()
  // {
  //   if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castdistance, groundLayer))
  //   {
  //     Debug.Log("yerde");
  //     yerdemi = true;
  //     return true;
  //     
  //   }
  //   else
  //   {
  //     Debug.Log("yerde değil");
  //     yerdemi = false;
  //     return false;
  //   }
  // }

  private void OnDrawGizmos()
  {
    Gizmos.DrawWireCube(transform.position-transform.up * castdistance,boxSize);
  }

  private void OnCollisionStay2D(Collision2D other)
  {
    if (other.gameObject.CompareTag("tekyonplatform"))
    {
      Debug.Log("yerde");
      yerdemi = true;
    }
    
  }

  private void OnCollisionExit2D(Collision2D other)
  {
    if (other.gameObject.CompareTag("tekyonplatform"))
    {
      Debug.Log("yerde değil");
      yerdemi = false;
    }
  }
}


