using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour 
{

	void Start () 
	{



	}

	void Update () 
	{



	}

	public void SinglePlayerBTNClicked()
	{

		// SceneManager.LoadScene ("SinglePlayerMenu");

	}

	public void MultiPlayerBTNClicked()
	{

		// SceneManager.LoadScene ("MultiPlayerMenu");

	}

	public void SkirmishBTNClicked()
	{

		// SceneManager.LoadScene ("SkirmishMenu");

	}

	public void OptionsBTNClicked()
	{

		// SceneManager.LoadScene ("OptionsMenu");

	}

	public void ExitBTNClicked()
	{

		#if UNITY_EDITOR

			UnityEditor.EditorApplication.isPlaying = false;

		#else

			Application.Quit ();

		#endif

	}

}
