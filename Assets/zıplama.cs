

using UnityEngine;

public class Zıplama : MonoBehaviour
{

  public float castdistance;

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
    if (Input.GetKeyDown(KeyCode.W) && Yerde())
    {
      rb.AddForce(new Vector2(0, jumpForce));
    }
  }

  public bool Yerde()
  {
    if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castdistance, groundLayer))
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  private void OnDrawGizmos()
  {
    Gizmos.DrawWireCube(transform.position-transform.up * castdistance,boxSize);
  }
}


