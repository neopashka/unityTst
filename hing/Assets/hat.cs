using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision hit){
		if(hit.collider.name=="hat"){
			GameObject.Find ("hat").GetComponent<Collider> ().enabled = false;
			GameObject.Find ("hat").transform.parent = GameObject.Find ("EthanHead").transform;
			GameObject.Find ("hat").transform.localPosition = new Vector3 (0.0f,0.0f,0.0f);
			GameObject.Find ("hat").transform.localRotation = new Quaternion (0.0f,0.0f,0.0f,0.0f);
<<<<<<< .merge_file_a00820
			Debug.Log ("big");
=======
			Debug.Log ("book");
>>>>>>> .merge_file_a02412
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
