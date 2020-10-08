using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScrolling : MonoBehaviour
{
    public float speed; //adjust this in inspector to change scroll speed

    void Update()
    {
        transform.Translate(-speed, 0, 0);
    }

    
}
