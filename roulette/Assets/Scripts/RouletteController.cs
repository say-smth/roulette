using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    private float rotationSpeed=0;

    void Start()
    {
        
    }

    void Update()
    {
        //1. 화면 누르면 어떻게 감지하지?
        /*bool isDown=Input.GetMouseButtonDown(0);

        Debug.Log(isDown);

        if (isDown )
        {
            Debug.Log("눌렀습니다!");
        }*/
        //2. 회전 어떻게 시키지?

        bool isDownLeft=Input.GetMouseButton(0);
        bool isDownRight=Input.GetMouseButton(1);

        if(isDownLeft)
        {
            rotationSpeed = -10;
        }
        else if(isDownRight)
        {
            rotationSpeed = 10;
        }

        this.transform.Rotate(0, 0, rotationSpeed);

        //속도 줄이고 
        rotationSpeed *= 0.96f;

        Debug.Log(rotationSpeed);
    }
}
