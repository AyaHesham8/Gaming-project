using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitButton(){
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame(){
        SceneManager.LoadScene("Level1Scene1");
    }
}
