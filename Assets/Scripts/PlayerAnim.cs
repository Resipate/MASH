using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private float currState = 0.5f;
    [SerializeField] private float timeSinceChange;
    [SerializeField] private float changeRate;
    [SerializeField] private Sprite[] states;
    [SerializeField] private SpriteRenderer sR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeSinceChange < changeRate){ timeSinceChange += Time.deltaTime; }
        else{
            currState *= -1;
            sR.sprite = states[(int)(currState + 0.5f)];
            timeSinceChange = 0;
        }
    }
}
