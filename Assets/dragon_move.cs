using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon_move : MonoBehaviour {
	public Animator anim;
	public GameObject log;
	public Rigidbody t1;
	public Rigidbody t2;
	public GameObject house;
	public Vector3 home_pos;
	public Vector3 target_pos;
	public GameObject tower_flame1;
	public GameObject tower_flame2;

	// Use this for initialization
	void Start () {
		log = GameObject.Find("Vox_Dragon_Normal");
        anim = log.GetComponent<Animator>();
        anim.Play ("Atk_TailSwing",0,0f);
        home_pos = new Vector3(15.85f,3.4f,-2.02f);
        target_pos = new Vector3(-4f,0.99f,1.8f);

        // anim.Play ("Breath_Fs",0,0f);
        // anim.Play ("Breath_Fw",0,0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			anim.Play ("Breath_Fw",0,0f);
		}

		if (t1.angularVelocity.magnitude <= 0.2f || t2.angularVelocity.magnitude <= 0.2f){
			// Debug.Log(t1.angularVelocity.magnitude);
			// Debug.Log(t2.angularVelocity.magnitude);
			float step = 2.0f * Time.deltaTime;
        	transform.position = Vector3.MoveTowards(transform.position, target_pos, step);
        	tower_flame1.SetActive(false);
        	tower_flame2.SetActive(false);
		}
		else{
			float step = 2.0f * Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, home_pos, step);
			tower_flame1.SetActive(true);
        	tower_flame2.SetActive(true);
		}

	}
}

