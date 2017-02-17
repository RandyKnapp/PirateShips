using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	[SerializeField]
	private Button playButton;

	private void Start()
	{
		playButton.onClick.AddListener(OnPlayButtonClicked);
	}

	private void OnDestroy()
	{
		playButton.onClick.RemoveAllListeners();
	}

	private void OnPlayButtonClicked()
	{
		SceneManager.LoadScene("Game");
	}
}
