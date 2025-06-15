using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;    // 회전 속도 변수

    bool rotateFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (!rotateFlag)
            {
                rotSpeed = Random.Range(5f, 15f);
                rotateFlag = true;
            }
            
        }

        rotSpeed *= 0.994f;

        if (rotSpeed < 0.2f)
        {
            Debug.Log("check spped : " + rotSpeed);
            rotSpeed = 0f;
            rotateFlag = false;
        }
        else
        {
            Debug.Log("check spped : " + rotSpeed);
            transform.Rotate(0, 0, rotSpeed);
        }
    }
}
