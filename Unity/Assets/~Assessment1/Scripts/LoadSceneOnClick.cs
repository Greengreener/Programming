using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Assessment1{
public class LoadSceneOnClick : MonoBehaviour {

		public void LoadScene()
	{
		SceneManager.LoadScene (1);
	}
}
}