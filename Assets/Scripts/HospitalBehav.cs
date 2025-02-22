using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalBehav : MonoBehaviour
{
    [SerializeField] private IntUpdater iU;
    [SerializeField] private int score;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.transform.tag == "Player"){
            if(other.GetComponent<PlayerMovement>().dragIndex > 1){
                int result = 0;
                while(result != -1){
                    result = iU.removeSoldier();
                    if(result != -1){ score += 1; }
                }
            }
        }
    }
}
