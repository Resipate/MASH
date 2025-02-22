using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HospitalBehav : MonoBehaviour
{
    [SerializeField] private Sprite[] states;
    [SerializeField] private SpriteRenderer sR;
    [SerializeField] private IntUpdater iU;
    [SerializeField] private int score;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player"){
            if(other.GetComponent<PlayerMovement>().dragIndex > 1){
                int result = 0;
                while(result != -1){
                    result = iU.removeSoldier();
                    if(result != -1){ score += 1; }
                    sR.sprite = states[score];
                    if(score >= 9){ SceneManager.LoadScene("End"); }
                }
            }
        }
    }
}
