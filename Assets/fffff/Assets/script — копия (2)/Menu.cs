using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private TMP_Text statusText;
    // Start is called before the first frame update
    void Start()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    void OnEnable(){
        playercontrol.hpChange.AddListener(Lose);
    }

      void OnDisable(){
        playercontrol.hpChange.RemoveListener(Lose);
    }

    // Update is called once per frame
    void Update()
    { }
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        Time.timeScale = 1.0f;
        int level = SceneManager.GetActiveScene().buildIndex;
        if (level < SceneManager.sceneCount - 1)
        {
            SceneManager.LoadScene(level + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
   // public void Victory()
    //{
       // Time.timeScale = 0.0f;
        //menuPanel.SetActive(true);
       // statusText.text = "You win. My congratulations!!!!";
   // }
    public void Lose(int hp)
    {
        if (hp > 0) { menuPanel.SetActive(false); }
        else
        {
            Time.timeScale = 0.0f;
            menuPanel.SetActive(true);
            statusText.text = "You lost. Try again.";
        }

    }
    public void GoToMenu(){
        SceneManager.LoadScene(0);
    }
   // public void ExitGame(){
        //Application.Quit();
  //  }
    //public void StartGameButton(){
      //  SceneManager.LoadScene(1);
    //}
}

