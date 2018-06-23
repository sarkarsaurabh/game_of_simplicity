using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	public GameObject ground;

	// Use this for initialization
	void Start () {
		ground = GameObject.Find("Plane");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
         // this object was clicked - do something
     // Destroy (this.gameObject);
	score_mouse remote = ground.GetComponent<score_mouse>();
	remote.score_total -= 1;
    this.gameObject.SetActive(false);
    if( this.gameObject.tag == "bad_cog"){
    	remote.bad_cogs += 1;
    }
  } 
}

 