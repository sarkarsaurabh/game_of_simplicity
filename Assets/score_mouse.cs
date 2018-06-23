using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_mouse : MonoBehaviour {

	public int score_total;
	public int bad_cogs;
	public Text score_disp;
	public Animator anim;
	public GameObject log;
	public Text win;
	// Use this for initialization
	void Start () {
		score_total = 9;
		bad_cogs = 0;
		//log = GameObject.Find("Vox_Dragon_Normal");
        anim = log.GetComponent<Animator>();
        win.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		score_disp.text = "Remove gears : "+ score_total.ToString()+ "/9";
		if ((score_total + bad_cogs) <= 0){
			
			anim.SetBool("Dead", true);
			// yield WaitForSeconds (anim["Dead_F"].length);
			win.enabled = true;
		}

	}

}
