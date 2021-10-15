using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEvents : MonoBehaviour
{
	int MAIN_LEVEL_SCENE = 1;
	int CREDITS_SCENE = 2;
	public void playEvent()
	{
		SceneManager.LoadScene(MAIN_LEVEL_SCENE);
	}

	public void creditsEvent()
	{
		SceneManager.LoadScene(CREDITS_SCENE);
	}

	public void quitEvent()
	{
		Application.Quit();
	}
}
