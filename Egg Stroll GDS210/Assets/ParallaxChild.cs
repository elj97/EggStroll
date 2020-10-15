using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxChild : MonoBehaviour
{
    [SerializeField] private bool isRight;

    void OnValidate()
    {
        var length = GetComponent<SpriteRenderer>().bounds.size.x;
        if (!isRight)
        {
            length *= -1;
        }
        transform.localPosition = new Vector3(length, 0, 0);
    }
}
