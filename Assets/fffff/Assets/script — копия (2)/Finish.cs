using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{   
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private TMP_Text statusText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.CompareTag("Player")){
        Time.timeScale = 0.0f;
        menuPanel.SetActive(true);
       statusText.text = "You win. My congratulations!!!!";
        
   }
    }
}
