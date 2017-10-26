using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {
	public Transform childpos;
	public Transform[] target;
	public int i = 0;
	public float speed,time;
	public float jmpforce;
	bool isjmped;
	public int score;
	public Text scoreTxt;



	// Use this for initialization
	void Start () {

		Moving ();


	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.Mouse0)&&!isjmped) {

			print ("mouse clicked");

			//	hero.transform.Translate (Vector3.up * Time.deltaTime * jmpforce);
		//	childpos.DOLocalJump(
			childpos.DOLocalJump (childpos.localPosition,3f,1,0.9f,false);
			Invoke ("enablejum", 1);
			score++;
			scoreTxt.text = score.ToString ();
			isjmped = true;
		}
	



	}

	void enablejum(){
		isjmped = false;
	}


	void Moving()
	{
		time = Vector3.Distance (transform.position, target [i].position) / speed;

		print (time);

		transform.DOMove (target[i].position, time, false).SetEase(Ease.Linear);
		i++;

		if (i > target.Length - 1) {

			i = 0;
		}

		Invoke ("Moving",time);

	}

	void jumping()
	{



	}
}
