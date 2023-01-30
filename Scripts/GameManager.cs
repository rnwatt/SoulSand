using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public void MainMenu()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		
		Debug.Log("Main Menu");
	}
	public void GameOver()
	{
		Debug.Log("GAME OVER");
		UnityEngine.SceneManagement.SceneManager.LoadScene(2);
	}

	public void MainGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(1);
		Debug.Log("World");
	}

	public void DungeonMap()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(3);
		Debug.Log("Dungeon");
	}

	public void BossArena()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(4);
		Debug.Log("Boss Arena");
	}

	public void VictoryScreen()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(5);
		Debug.Log("Victory!");
	}

	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Quitting Game");
	}
}
