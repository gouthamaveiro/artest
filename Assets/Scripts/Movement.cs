using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
	public Transform cubeA,target;

	public Transform playercharacter;


	public int score;
	public Text scoreTxt;

	// Use this for initialization
	void Start () {

		Invoke ("Jump", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
//		if (Input.GetKeyDown (KeyCode.Mouse0)) {
//			print (" key was pressed");
//
//			cubeA.DOJump (playercharacter.position, 15, 1, 1, false);
//		}

		if (Input.GetKeyDown (KeyCode.Mouse0)) {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
//		


		if (Physics.Raycast (ray,out hit,4))
		{
				print ("Cast hit the ball");
				cubeA.DOJump (playercharacter.position, 3, 1, 1, false);

				score++;
				scoreTxt.text = score.ToString ();
			Invoke ("Jump", 1.2f);
				CancelInvoke ("GameOver");

		}
	}
	}
//		if (Input.GetKeyDown (KeyCode.Mouse0)) {
//
//
//			print ("left was pressed");
//
//			cubeA.DOJump (target.position, 15, 1, 1, false);
//
//		}





	void Jump()
	{
		cubeA.DOJump(target.position+new Vector3(Random.Range(-0.5f,0.5f),0,0),3,1, 1,false);

		Invoke ("GameOver", 1);
	}


	void GameOver(){

		Application.LoadLevel (Application.loadedLevel);
	}

			


}
	