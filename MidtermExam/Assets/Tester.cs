using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SingletonGameApplicationManager.Instance.Level = 99;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
