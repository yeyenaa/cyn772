using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRd; //Rigidbody 컴포넌트 저장
    public float speed = 10f; //속도
    // Start is called before the first frame update
    void Start()
    {
        playerRd = GetComponent<Rigidbody> (); //Rigidbody 컴포넌트를 찾아서 지정
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //transform.Translate (Vector3.left * speed * Time.deltaTime);
            playerRd.AddForce (-speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
            //transform.Translate (Vector3.right * speed * Time.deltaTime);
            playerRd.AddForce (speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            //transform.Translate (Vector3.forward * speed * Time.deltaTime);
            playerRd.AddForce (0f, 0f, speed);
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
            //transform.Translate (Vector3.back * speed * Time.deltaTime);
            playerRd.AddForce (0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.Space) == true)
        {
            //transform.Translate (Vector3.jump * speed * Time.deltaTime);
            //if(바닥 근처)
            //{

            //playerRd.AddForce (0f, speed, 0f);
            //}
        }
    }
}
