using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {

    public float speed = 1.0f;
    public int x = 0;
    private void Update()
    {
        for (int i = 0; i < 10; ++i)
        {
            transform.position += transform.up;
        }
    }

}
