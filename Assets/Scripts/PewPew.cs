using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
    public GameObject bul;

    public Transform startPos;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // создаёт пулю при нажатии на левую кнопку мыши
        {
            Instantiate(bul, startPos.position, Quaternion.identity);
        }
    }
}
