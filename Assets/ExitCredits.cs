using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitCredits : MonoBehaviour
{
	public void exitCredits()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
	}
}

