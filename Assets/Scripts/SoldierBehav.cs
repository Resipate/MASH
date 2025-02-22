using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierBehav : MonoBehaviour
{
    [SerializeField] private IntUpdater iU;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("1");
        if(other.tag == "Player"){
            if(iU.addSoldier() != -1){ Destroy(this.gameObject); }
        }
    }

}
