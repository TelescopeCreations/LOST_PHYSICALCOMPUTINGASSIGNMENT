using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class COLOURRANDOMIZER2 : MonoBehaviour
{
      public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColour2();
    }
    void ChangeColour2()
    {
        Thread.Sleep(10000);
        meshRenderer.material.color = Random.ColorHSV();
    }
}
