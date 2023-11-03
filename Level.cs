using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{   int Levels = 5;
    int Health = 2;
    int Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Health += Levels;
        print("Çהמנמגüו " + Health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = transform.position;
        newpos.z +=Speed * Time.deltaTime;
        transform.position = newpos;

    }
}
