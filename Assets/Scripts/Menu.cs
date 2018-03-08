using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public Main main;
    public Audio audio;

    public Texture2D Logo;
    public Texture2D Background;
    public Texture2D Button;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        Font DnDFont = (Font)Resources.Load("Fonts/DnDFont", typeof(Font));

        GUIStyle HugeText = new GUIStyle();

        HugeText.normal.textColor = Color.black;
        HugeText.fontSize = 86;
        HugeText.font = DnDFont;
        HugeText.alignment = TextAnchor.UpperCenter;

        if (main.ShowMenu == 1)
        { 
        GUI.backgroundColor = new Color(0, 0, 0, 0);
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Background.height), Background);
            GUI.DrawTexture(new Rect(Screen.width / 2 - 400, 50, 800, 200), Logo);


            GUI.DrawTexture(new Rect(Screen.width / 2 - 200, 350, 400, 100), Button);
                if (GUI.Button(new Rect(Screen.width / 2 - 100, 350, 200, 100), "Start game", HugeText))
        {
                audio.PlaySoundClick();
                main.ShowMenu = 0;
        main.ShowCity = 1;
        }

            GUI.DrawTexture(new Rect(Screen.width / 2 - 200, 450, 200, 100), Button);
            if (GUI.Button(new Rect(Screen.width / 2 - 100, 450, 200, 100), "Options", HugeText))
            {
                audio.PlaySoundClick();
                main.ShowMenu = 0;
                main.ShowOptions = 1;
            }
            GUI.DrawTexture(new Rect(Screen.width / 2 - 200, 550, 400, 100), Button);
            if (GUI.Button(new Rect(Screen.width / 2 - 100, 550, 200, 100), "Credits", HugeText))
        {
                audio.PlaySoundClick();
                main.ShowMenu = 0;
          main.ShowCredits = 1;
            }
            GUI.DrawTexture(new Rect(Screen.width / 2 - 200, 650, 400, 100), Button);
            if (GUI.Button(new Rect(Screen.width / 2 - 100, 650, 200, 100), "Quit", HugeText))
            {
                audio.PlaySoundClick();
                Application.Quit();
            }
        }
    }
}
