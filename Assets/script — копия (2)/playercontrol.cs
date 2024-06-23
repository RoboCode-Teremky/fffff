using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playercontrol : MonoBehaviour
{
    [SerializeField] private float speed= 1.0f;
    [SerializeField] private float jumpForce = 1.0f;
    private float direction = 0f;
    private Rigidbody2D rb2d;
    [SerializeField] private int maxHP = 6;
    public int currentHP;
    static public UnityEvent<int> hpChange = new UnityEvent<int>(); 
    [SerializeField] private Transform spawnPoint;
        void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
         transform.position = spawnPoint.position;
        currentHP = maxHP;
        hpChange.Invoke(currentHP);
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
       if(direction > 0f)
       {
        rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
        transform.localScale = new Vector3(1, 1);
       }
       else if(direction < 0f) 
       {
        rb2d.velocity = new Vector2(direction * speed, rb2d.velocity.y);
        transform.localScale = new Vector3(-1, 1);
       }
        foreach(RaycastHit2D rh2d in Physics2D.RaycastAll(transform.position, Vector2.down,1.5f)){
            if(rh2d.collider.CompareTag("ground")&& Input.GetButtonDown("Jump")){
                rb2d.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("spike") || other.gameObject.CompareTag("abyss")){
         transform.position = spawnPoint.position;  
         currentHP--;
         hpChange.Invoke(currentHP);
        }
    }
}
