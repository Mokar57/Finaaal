
using UnityEngine;

public class hareket : MonoBehaviour
{
 private Rigidbody2D rb;
 private float horizontal;
 public float speed;
 //Horizontal belirleyip dönüşleri ona ayarlıyoruz(nasıl yorum yapıcam bilmiyom mq)
 public bool sagabak = true;
 
 void Start()
 {
  rb = gameObject.GetComponent<Rigidbody2D>();
 }

 void Update()
 {
  if (horizontal > 0 && sagabak == false)
  {
   dön();
  }
  if(horizontal < 0 && sagabak == true)
  {
   dön();
  }
 }

 void FixedUpdate()
 {
  horizontal = Input.GetAxis("Horizontal");
  rb.velocity = new Vector3(horizontal * Time.deltaTime * speed, rb.velocity.y, 0);
  //horizontal hareket için hızlanması için speed ile çarpıyoruz,rb.velocity yerçekimi devam etsin diye
 }

 void dön()
 {
  sagabak = !sagabak;
  Vector2 yeniscale = transform.localScale;
  yeniscale.x *= -1;
  transform.localScale = yeniscale;
  //scale'ini eksiyle çarpıp döndüren fonksiyon
 }
}
