using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class coin : MonoBehaviour
{
   static public UnityEvent pikcoin = new UnityEvent();
private void OnCollisionEnter2D(Collision2D other)
{
    if(other.collider.CompareTag("Player")){
    pikcoin.Invoke();
    Destroy(gameObject);
    }
}
}

