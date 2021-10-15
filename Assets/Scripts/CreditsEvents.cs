using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsEvents : MonoBehaviour
{
	int MENU_SCENE = 0;

	public void backEvent()
	{
		Debug.Log("Vamos para o menu");
		SceneManager.LoadScene(MENU_SCENE);
	}
}
