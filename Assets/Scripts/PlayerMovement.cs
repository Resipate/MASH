using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform sprite;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;
    [SerializeField] private float accelCo;
    [SerializeField] public float dragIndex;
    [SerializeField] private float dragCo;
    [SerializeField] private float speedDecay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){ SceneManager.LoadScene("Game"); } 
        if(Input.GetKeyDown(KeyCode.Escape)){ SceneManager.LoadScene("Start"); }

        int x = 0, y = 0;
        if(Input.GetKey(KeyCode.LeftArrow)){
            x -= 1;
            sprite.localScale = new Vector3(-1, 1, 1);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            x += 1;
            sprite.localScale = new Vector3(1, 1, 1);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            y += 1;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            y -= 1;
        }
        
        if(x != 0){ xSpeed = Mathf.Clamp(xSpeed + x * (accelCo/Mathf.Sqrt(dragIndex * dragCo)), -maxSpeed, maxSpeed); }
        else if (x == 0 && Mathf.Abs(xSpeed) > 0.1f){ xSpeed = xSpeed - ((Mathf.Abs(xSpeed)/xSpeed)*(speedDecay/Mathf.Sqrt(dragIndex*dragCo))); }
        else{ xSpeed = 0; }

        if(y != 0){ ySpeed = Mathf.Clamp(ySpeed + y * (accelCo/Mathf.Sqrt(dragIndex * dragCo)), -maxSpeed, maxSpeed); }
        else if (y == 0 && Mathf.Abs(ySpeed) > 0.1f){ ySpeed = ySpeed - ((Mathf.Abs(ySpeed)/ySpeed)*(speedDecay/Mathf.Sqrt(dragIndex*dragCo))); }
        else{ ySpeed = 0; }

        this.transform.Translate(new Vector2(xSpeed, ySpeed) * Time.deltaTime);
        if(this.transform.position.x > 10.25f){ this.transform.position = new Vector3(10.25f, this.transform.position.y, this.transform.position.z); }
        if(this.transform.position.x < -10.4f){ this.transform.position = new Vector3(-10.4f, this.transform.position.y, this.transform.position.z); }
        if(this.transform.position.y > 4.5f){ this.transform.position = new Vector3(this.transform.position.x, 4.5f, this.transform.position.z); }
        if(this.transform.position.y < -4f){ this.transform.position = new Vector3(this.transform.position.x, -4f, this.transform.position.z); }
    }
}