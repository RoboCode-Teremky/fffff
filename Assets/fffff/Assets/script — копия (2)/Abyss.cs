using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Abyss : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.TryGetComponent<playercontrol>(out playercontrol Wj2D)){
       
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
