using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour
{
    void Update(){ 
        if(Input.GetKeyDown(KeyCode.R)) { PlayButton(); }
        if(Input.GetKeyDown(KeyCode.Escape)){ ExitButton(); }
    }
    public void PlayButton(){ SceneManager.LoadScene("Game"); }
    public void ExitButton(){ SceneManager.LoadScene("Start"); }
}
