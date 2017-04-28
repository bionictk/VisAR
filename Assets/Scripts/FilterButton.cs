﻿using UnityEngine;
using System.Collections;

public class FilterButton : MonoBehaviour {

    GameObject parent;
    public string country;

	// Use this for initialization
	void Start () {
        parent = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnHit()
    {
        parent.BroadcastMessage("TogglePoints", country);
    }
}