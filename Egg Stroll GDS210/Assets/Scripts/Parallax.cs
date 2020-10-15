using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos, ypos;
    public GameObject cam;
    public float parallaxEffectx;
    public float parallaxEffecty;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        ypos = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffectx));
        float dist = (cam.transform.position.x * parallaxEffectx);
        float ydist = (cam.transform.position.y * parallaxEffecty);

        transform.position = new Vector3(startpos + dist, ypos + ydist, transform.position.z);
        if (temp > startpos + (length - offset))
        {
            startpos += length;
        }
        else if (temp < startpos - (length - offset))
        {
            startpos -= length;
        }
    }
}
