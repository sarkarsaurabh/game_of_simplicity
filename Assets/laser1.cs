using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser1 : MonoBehaviour {

    public Transform endPoint;
    private LineRenderer laserLine;

    // Use this for initialization
    void Start () {
        laserLine = GetComponent<LineRenderer>();
        laserLine.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
