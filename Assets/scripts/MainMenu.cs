using System.Collections;
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
		_ball.GetComponent<Rigidbody>().AddForce(_ballDir.transform.up* 100.0f);
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

}
