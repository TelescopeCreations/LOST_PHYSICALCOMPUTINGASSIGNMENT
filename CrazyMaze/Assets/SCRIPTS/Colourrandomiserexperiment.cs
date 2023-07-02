using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Colourrandomiserexperiment : MonoBehaviour
{  public MeshRenderer meshRenderer1;
   public MeshRenderer meshRenderer2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColourA();
        Thread.Sleep(10000);
        ChangeColourB();
    }
    void ChangeColourA()
    {
        meshRenderer1.material.color = Random.ColorHSV();
    }
    void ChangeColourB()
    {
        meshRenderer2.material.color = Random.ColorHSV();
    }
}
