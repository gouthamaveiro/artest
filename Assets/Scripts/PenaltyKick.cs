using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PenaltyKick : MonoBehaviour {

	public Transform netArea,football,outArea,GoalArea,SlowArea,resetpos,footballpos;
	public Slider myslider;

	public int score;
	public Text scoretext;

	public float sliderval=1;
	bool isKicked;

	// Use this for initialization
	void Start () {

		Invoke ("slideMeter", 1f);
	}
	
	// Update is called once per frame
	void Update () {


	//	if (Input.GetKeyDown (KeyCode.Mouse0)) {

			//football.DOJump (netArea.position, 3, 1, 1, false);


	//	}

		if(Input.GetKeyDown(KeyCode.Mouse0)&& myslider.value > 0.7&&!isKicked) {
			isKicked = true;
			football.DOJump (outArea.position, 3, 1, 1, false).OnComplete (() => {


				rstPositon();

			});

		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && myslider.value > 0.4 && myslider.value<0.7&&!isKicked ) {
			isKicked = true;	
			football.DOJump (GoalArea.position+new Vector3(Random.Range(-0.27f,0.27f),0,0), 3, 1, 1, false).OnComplete (() => {


				rstPositon();
				scorecalc();


			});


			print ("its a goal");
		}

		if ((Input.GetKeyDown (KeyCode.Mouse0) && myslider.value <= 0.4)&&!isKicked) {
			isKicked = true;
			football.DOJump (SlowArea.position, 1, 1, 1, false).OnComplete (() => {



				rstPositon();


			});

			print ("Too slow");



		}
			

	}

	void rstPositon()
	{



		footballpos.position = resetpos.position;
		isKicked=false;
	


	}

	void scorecalc()
	{

		score++;

		scoretext.text = score.ToString ();

	}

	void slideMeter(){

		myslider.DOValue (sliderval, 1, false).OnComplete(()=>{

			slidercheck();
		});

		//slidercheck ();

	}



	void slidercheck(){

		if(sliderval==1)
			{
			myslider.DOValue (sliderval - 1, 1, false).OnComplete (() => {
				slideMeter ();
			});
		}
			
	}
}
