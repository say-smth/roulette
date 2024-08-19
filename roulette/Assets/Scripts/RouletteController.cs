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
        //1. ȭ�� ������ ��� ��������?
        /*bool isDown=Input.GetMouseButtonDown(0);

        Debug.Log(isDown);

        if (isDown )
        {
            Debug.Log("�������ϴ�!");
        }*/
        //2. ȸ�� ��� ��Ű��?

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

        //�ӵ� ���̰� 
        rotationSpeed *= 0.96f;

        Debug.Log(rotationSpeed);
    }
}
