using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntUpdater : MonoBehaviour
{
    private int currState;
    private int maxCap = 3;
    [SerializeField] private Sprite[] states;
    [SerializeField] private SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        sR.sprite = states[0];
    }

    public int addSoldier(){
        if(currState + 1 > maxCap){ return -1; }
        sR.sprite = states[++currState];
        return currState;
    }

    public int removeSoldier(){
        if(currState == 0){ return -1; }
        sR.sprite = states[--currState];
        return currState;
    }
}
