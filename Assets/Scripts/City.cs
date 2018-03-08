using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class City : MonoBehaviour
{

    private int CharacterPointer;        // points to character, 1. Warrior, 2 Ninja, 3. Wizard, 4. Tinkerer

    public Texture2D Warrior;
    public Texture2D CityBackground;


    public Texture2D ButtonUp;

    public Main main;
    public Audio audio;

    private Rect Fullscreen = new Rect(0, 0, Screen.width, Screen.height);
    private Rect LogoCenter = new Rect(Screen.width / 2, 20, 100, 100);
    private Rect AttributesAlignment = new Rect(40, 180, 100, 40);
    private Rect PopUp = new Rect(Screen.width / 2 - 300, 300, 600, 600);
    private Rect ToolTipRect = new Rect(100, 100, 100, 100);

    public int i;
    

    public Texture2D Paper;
    private int CityPointer = 0;


    private void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        Font DnDFont = (Font)Resources.Load("Fonts/DnDFont", typeof(Font));

        GUIStyle HeaderText = new GUIStyle();

        HeaderText.normal.textColor = Color.black;
        HeaderText.fontSize = 128;
        HeaderText.font = DnDFont;

        HeaderText.alignment = TextAnchor.MiddleCenter;

        GUIStyle HugeText = new GUIStyle();

        HugeText.normal.textColor = Color.black;
        HugeText.fontSize = 86;
        HugeText.font = DnDFont;
        HugeText.alignment = TextAnchor.UpperLeft;

        GUIStyle LargeText = new GUIStyle();

        LargeText.normal.textColor = Color.black;
        LargeText.fontSize = 64;
        LargeText.font = DnDFont;
        LargeText.alignment = TextAnchor.UpperLeft;

        GUIStyle MediumText = new GUIStyle();

        MediumText.normal.textColor = Color.black;
        MediumText.fontSize = 48;
        MediumText.font = DnDFont;
        MediumText.alignment = TextAnchor.UpperLeft;

        GUIStyle SmallText = new GUIStyle();

        SmallText.normal.textColor = Color.black;
        SmallText.fontSize = 32;
        SmallText.font = DnDFont;
        SmallText.alignment = TextAnchor.UpperLeft;

        //GUI.backgroundColor = new Color(0, 0, 0, 0);


        

        if (main.ShowCity == 1)
        {

            GUI.DrawTexture(Fullscreen, CityBackground);
            GUI.DrawTexture(new Rect(Screen.width / 2, Screen.height - 300, 200, 200), Warrior);
            GUI.Label(LogoCenter, "You are at RuneCity", HeaderText);

            

            

            GUI.Button(new Rect(Screen.width - 400, Screen.height - 300, 200, 200), new GUIContent("", "Visit blacksmith"));
            if (GUI.Button(new Rect(Screen.width - 400, Screen.height - 300, 200, 200), "Blacksmith")) ;

            GUI.Button(new Rect(Screen.width - 600, Screen.height - 400, 200, 200), new GUIContent("", "Visit the Laughing Goblin tavern"));
            if (GUI.Button(new Rect(Screen.width - 600, Screen.height - 400, 200, 200), "Tavern")) ;

            GUI.Button(new Rect(Screen.width - 800, Screen.height - 500, 200, 200), new GUIContent("", "Visit store"));
            if (GUI.Button(new Rect(Screen.width - 800, Screen.height - 500, 200, 200), "Store")) ;

            GUI.Label(new Rect(Screen.width / 2, Screen.height - 40, 200, 40), GUI.tooltip);

            // Buttons

            //GUI.Button(new Rect(Screen.width - 200, Screen.height - 200, 200, 200), new GUIContent("", "Visit Hall of Heroes"));
            if (GUI.Button(new Rect(Screen.width - 200, Screen.height - 200, 200, 200), "Hall of Heroes"))
            {
                main.ShowCity = 0;

                main.ShowCharacterSheet = 1;

            }
            //GUI.Label(AttributesAlignment, "<b>Attributes</b>", HeaderText);
            //GUI.Label(AttributesAlignment, "<b>Attributes</b>\nAgility\nCharisma\nMana\nIntelligence\nSpeed\nStamina\nStrength\nToughness", LargeText);



        }
        
    }
}