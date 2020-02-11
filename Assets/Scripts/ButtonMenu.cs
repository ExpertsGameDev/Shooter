using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject settigsMenu;

	public void ButtonStart()
	{
        SceneManager.LoadScene(1);
	}

    public void ButtonSetting()
    {
        startMenu.SetActive(false);
        settigsMenu.SetActive(true);
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
