using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtons : MonoBehaviour
{
    void Start(){ Screen.SetResolution(879, 386, false); }
    public void PlayButton(){ SceneManager.LoadScene("Game"); }
    public void ExitButton(){ Application.Quit(); }

}
