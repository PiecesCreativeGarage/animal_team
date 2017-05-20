using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class moveMap : MonoBehaviour {	
	public void MainMap () {
		SceneManager.LoadScene("main_map");
	}

	public void LoadHouse () {
		SceneManager.LoadScene("house");
	}

	public void LoadDakko () {
		SceneManager.LoadScene("dakko");
	}

	public void LoadTakeOut () {
		SceneManager.LoadScene("take out");
	}
		
	public void LoadPark () {
		SceneManager.LoadScene("park");
	}

	public void LoadHospital () {
		SceneManager.LoadScene("hospital");
	}

	public void LoadPetShop () {
		SceneManager.LoadScene("petShop");
	}

	public void LoadFrendsHouse () {
		SceneManager.LoadScene("frendsHouse");
	}
}
