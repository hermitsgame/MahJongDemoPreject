﻿using UnityEngine;
using System.Collections;

public class HuPaiEventMange : MonoBehaviour {

    public PlayMakerFSM fsm;

	// Use this for initialization
	void Start () {
        fsm = GameObject.Find("ButtonManager").transform.GetComponent<PlayMakerFSM>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void HuPaiEvent()
    {
        fsm.SendEvent("tuipai");        
    }
}
