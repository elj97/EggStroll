using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSortLayer : MonoBehaviour
{
    void Start()
    {
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Particles";
    }
}
