using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurdleCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag == "hero") {

			print ("colliding with hero");

			SceneManager.LoadScene ("hurdle");
		

		}



	}


}
