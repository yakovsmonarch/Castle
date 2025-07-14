using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    public Material PigMaterial;
    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 15)
        {
            Timer = 0;
        }

        if (Timer < 3)
        {
            PigMaterial.color = Color.green;
        }
        else if (Timer < 6)
        {
            PigMaterial.color = Color.yellow;
        }
        else
        {
            PigMaterial.color = Color.red;
        }
    }
}
