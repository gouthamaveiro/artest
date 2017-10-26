using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingLevels : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void game1()

	{
		SceneManager.LoadScene ("scene1");


	}

	public void game2()
	{

		SceneManager.LoadScene ("hurdle");

	}


	public void game3()
	{
		SceneManager.LoadScene ("penalty");



	}

	public void exitmenu()
	{

		SceneManager.LoadScene ("Mainmenu");

	}
}
