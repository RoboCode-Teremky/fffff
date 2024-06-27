using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    private int levelNumber = 0;
    private TMP_Text buttonText;
    private Button button;
    // Start is called before the first frame update
     void Awake()
    {
        button = GetComponent<Button>();
        buttonText = gameObject.GetComponentInChildren<TMP_Text>();
        
    }

    public void SetLevelNumber(int levelNumber){
        this.levelNumber = levelNumber;
        buttonText.text = levelNumber.ToString("D2");
        button.onClick.AddListener(()=>SceneManager.LoadScene(this.levelNumber));
    }
    
}


