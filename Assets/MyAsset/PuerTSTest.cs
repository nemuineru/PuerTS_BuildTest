using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Puerts.TSLoader;
using Puerts;

public class PuerTSTest : MonoBehaviour
{
    //1. Hello World
    void Start() {
        Puerts.JsEnv env = new Puerts.JsEnv();
        env.Eval(@"
            console.log('hello world');
        ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
