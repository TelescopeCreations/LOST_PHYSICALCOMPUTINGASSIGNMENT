using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class COLOURRANDOMIZE : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Thread.Sleep(1000);
        ChangeColour();
    }
    void ChangeColour()
    {
        Thread.Sleep(5000);
        meshRenderer.material.color = Random.ColorHSV();
    }
}
