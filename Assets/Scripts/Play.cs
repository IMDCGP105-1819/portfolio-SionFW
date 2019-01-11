using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	public void PlayGame ()
	{
		//Once called, PlayGame will load the next scene
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void QuitGame ()
	{
		//Application will close if function is run
		Debug.Log ("Quit");
	}
}
