﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// Trung Hieu Nguyen
public class MainMenu : MonoBehaviour {

	public Slider sliderH;
	public Slider sliderV;
	public Slider sliderA;
	public Slider sliderX;

	public  GameObject _hero;
	public  GameObject _camera;
	public 	GameObject _ballDir;
	public 	GameObject _ball;



	bool isSelecting = false;
	Vector3 mousePosition1;


	void Start () {
		
	}
	public void PlayGame ()
	{
		SceneManager.LoadScene (1);
	}
	public void QuitGame()
	{
		Application.Quit ();
	}

	public void BtnX_Clicked()
	{
		Vector3 shoot = (_ball.transform.position - _ballDir.transform.position).normalized;
		_ball.GetComponent<Rigidbody>().AddForce(_ballDir.transform.up* 1000.0f);
		//_ball.GetComponent<Rigidbody>().velocity = _ball.transform.forward * 6;
	}

	public void silderV_Changed(float value)
	{
		Vector3 tempRotation = _camera.transform.eulerAngles;
		tempRotation.x = value;
		_camera.transform.rotation = Quaternion.Euler(tempRotation);

	}

	public void silderH_Changed(float value)
	{

		Vector3 tempRotation = _hero.transform.eulerAngles;
		tempRotation.y = value;
		_hero.transform.rotation = Quaternion.Euler(tempRotation);
	}

	public void silderBallV_Changed(float value)
	{
		Vector3 tempRotation = _ballDir.transform.eulerAngles;
		tempRotation.x = value;
		_ballDir.transform.rotation = Quaternion.Euler(tempRotation);

	}

	public void silderBallH_Changed(float value)
	{

		Vector3 tempRotation = _ballDir.transform.eulerAngles;
		tempRotation.y = value;
		_ballDir.transform.rotation = Quaternion.Euler(tempRotation);
	}


	void Update()
	{
		// If we press the left mouse button, save mouse location and begin selection
		if( Input.GetMouseButtonDown( 0 ) )
		{
			isSelecting = true;
			mousePosition1 = Input.mousePosition;
		}
		// If we let go of the left mouse button, end selection
		if( Input.GetMouseButtonUp( 0 ) )
			isSelecting = false;
	}
	void OnGUI()
	{
		if( isSelecting )
		{
			// Create a rect from both mouse positions
			//var rect = Utils.GetScreenRect( mousePosition1, Input.mousePosition );
			//Utils.DrawScreenRect( rect, new Color( 0.8f, 0.8f, 0.95f, 0.25f ) );
			//Utils.DrawScreenRectBorder( rect, 2, new Color( 0.8f, 0.8f, 0.95f ) );
		}
	}


}
