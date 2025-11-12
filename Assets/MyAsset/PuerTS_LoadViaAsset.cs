using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Puerts.TSLoader;
using Puerts;
using System;

public class PuerTS_LoadViaAsset : MonoBehaviour
{
    //xLuaのDoStringからPuerTSのevalに指定した際
    //どういう反応が発生しうるか検証..
    public TMP_Text text;
    public Action act;

    public TextAsset textAsset;
    Puerts.JsEnv env;
    TSLoader ld;
    //1. Hello World
    void Start()
    {
        env = new Puerts.JsEnv();
        ld = new TSLoader("");
    }

    // Update is called once per frame
    void Update()
    {
        float TrackX = 0f;

        text.text = env.Eval<string>("require('helloworld')");
    }
}
