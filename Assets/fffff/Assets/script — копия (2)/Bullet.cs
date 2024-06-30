using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
   void Update()
   {
     
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if(other.collider != null)
        {
            if (other.collider.CompareTag("Enemy"))
            {
                other.collider.GetComponent<Enemy>().TakeDamage(damage);
            }
            Destroy(gameObject);
            if(other.collider.CompareTag("ground"))
            {
                Destroy(gameObject);
            }
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
   }
    //{
          //RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
          //if(hitInfo != null)
         // {
          ///  if(hitInfo.collider.CompareTag("Enemy"))
           // {
//            hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);    
          //  }
          //Destroy(gameObject);
          //}
         // transform.Translate(Vector2.up * speed * Time.deltaTime);

    

     //void OnCollisionEnter2D(Collision2D other)
    //{
      //  if(!other.gameObject.CompareTag("Player")){
         //   if(other.gameObject.TryGetComponent<Enemy>(out Enemy target)){
             //   target.TakeDamage(damage);
          //  }
           // Destroy(gameObject);
        //}
        

  


