using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hut_flame : MonoBehaviour {

	public GameObject drag;
	public GameObject drag_flame;
	public GameObject house_expo;
	public GameObject house_fire;
	public GameObject house_smoke;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (drag.transform.position.x < -3f){
			drag_flame.SetActive(true);
			house_expo.SetActive(true);
			house_fire.SetActive(true);
			house_smoke.SetActive(true);
		}
		else{
			drag_flame.SetActive(false);
			house_expo.SetActive(false);
			house_fire.SetActive(false);
			house_smoke.SetActive(false);
		}
	}
}
