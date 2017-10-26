using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class HurdleMove : MonoBehaviour {

	public Transform hero,childpos;
	public Transform[] target;
	public int i = 0;
	public float speed,time;
	public float jmpforce;





	// Use this for initialization
	void Start () {

		Moving ();

		
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.Mouse0)) {

			print ("mouse clicked");

		//	hero.transform.Translate (Vector3.up * Time.deltaTime * jmpforce);

			childpos.DOLocalJump (childpos.localPosition, .1f, 1, 1, false);
		}




	}


	void Moving()
	{
		time = Vector3.Distance (hero.position, target [i].position) / speed;

		print (time);

		hero.DOMove (target[i].position, time, false).SetEase(Ease.Linear);
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
