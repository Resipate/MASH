using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtons : MonoBehaviour
{
    public void PlayButton(){ SceneManager.LoadScene("Game"); }
    public void ExitButton(){ Application.Quit(); }

}
