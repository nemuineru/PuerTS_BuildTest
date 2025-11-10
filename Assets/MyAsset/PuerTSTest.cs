using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Puerts.TSLoader;
using Puerts;
using System;

public class PuerTSTest : MonoBehaviour
{
    public TMP_Text text;
    public Action act;
    Puerts.JsEnv env;
    //1. Hello World
    void Start() {
        env = new Puerts.JsEnv();
    }

    // Update is called once per frame
    void Update()
    {
        env.Eval(@"
            //console.log('hello world');            
        ");
        
    }
}
