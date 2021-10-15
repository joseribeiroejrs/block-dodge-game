using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public float slowDownFactor = 10f;
    // Start is called before the first frame update
    public void EndGame()
	{
		Debug.Log("End game!");

		StartCoroutine(RestartLevel());
	}

	IEnumerator RestartLevel()
	{
		Time.timeScale = 1f / slowDownFactor;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slowDownFactor;
		yield return new WaitForSeconds(1.5f / slowDownFactor);

		Time.timeScale = Time.timeScale * slowDownFactor;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownFactor;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
