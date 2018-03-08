using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CharacterSheet : MonoBehaviour
{
    public Main main;
    public Inventory inventory;
    public Audio audio;

    private int CharacterPointer;        // points to character, 1. Warrior, 2 Ninja, 3. Wizard, 4. Tinkerer

    public Texture2D Warrior;
    public Texture2D Ninja;
    public Texture2D Wizard;
    public Texture2D Tinkerer;

    public Texture2D ButtonLeft;
    public Texture2D ButtonRight;
    public Texture2D ButtonDown;
    public Texture2D ButtonUp;
    public Texture2D ButtonExit;

    

    public string[] Attributes;
    public string[] AttributesDescribtion;
    public string[] CharacterNames;
    private int[] Agility = new int[4];
    private int[] Charisma = new int[4];
    private int[] Intelligence = new int[4];
    private int[] Mana = new int[4];
    private int[] Speed = new int[4];
    private int[] Stamina = new int[4];
    private int[] Strength = new int[4];
    private int[] Toughness = new int[4];
    private int[] Total = new int[4];

    private Rect Fullscreen = new Rect(0, 0, 1920, Screen.height);
    private Rect LogoCenter = new Rect(Screen.width / 2, 20, 100, 100);
    private Rect AttributesAlignment = new Rect(40, 180, 100, 40);
    private Rect PopUp = new Rect(Screen.width / 2 - 300, 300, 600, 600);
    private Rect ToolTipRect = new Rect(100, 100, 100, 100);

    public int i;
    //private int ShowCharacterSheet = 1;

    public Texture2D Paper;
    public Texture2D[] CharacterPortrait;
    public Texture2D[] CharacterWeapon1;
    public Texture2D[] CharacterWeapon2;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start()
    {

        CharacterPointer = 0;
        string[] Attributes = new string[8];
        string[] AttributesDescribtion = new string[8];
        string[] CharacterNames = new string[4];
        Texture2D[] Portraits = new Texture2D[4];
        Attributes[0] = "Agility: ";
        Attributes[1] = "Charisma: ";
        Attributes[2] = "Intelligence: ";
        Attributes[3] = "Mana: ";
        Attributes[4] = "Speed: ";
        Attributes[5] = "Stamina: ";
        Attributes[6] = "Strength: ";
        Attributes[7] = "Toughness: ";
        //Attributes[8] = "Total: ";

        AttributesDescribtion[0] = "Agility affects ranged attack damage and jump height.";
        AttributesDescribtion[1] = "Charisma affects shop prrices.";
        AttributesDescribtion[2] = "How much experience is needed for next level.";
        AttributesDescribtion[3] = "Magimum magic points, recharcges over time.";
        AttributesDescribtion[4] = "Speed determines characters move speed.";
        AttributesDescribtion[5] = "Stamina affects how fast the charater get tired, recharges over time.";
        AttributesDescribtion[6] = "Strength affects melee attack damage, jump height and carry load.";
        AttributesDescribtion[7] = "Toughness affects damage resistance and hitpoints.";

        CharacterNames[0] = "The Mighty Warrior";
        CharacterNames[1] = "Shadow Ninja";
        CharacterNames[2] = "High Wizard";
        CharacterNames[3] = "Gnome Tinkerer";

        //AttributesDescribtion[8] = "Amount of total points: ";


        //Character attributes: 0. Warrior, 1. Ninja, 2. Wizard, 3. Tinkerer

        // 0. Warrior
        Agility[0] = 70;
        Charisma[0] = 65;
        Intelligence[0] = 40;
        Mana[0] = 10;
        Speed[0] = 50;
        Stamina[0] = 80;
        Strength[0] = 80;
        Toughness[0] = 75;
        //Total[0] = Agility[0] + Charisma[0] + Intelligence[0] + Speed[0] + Stamina[0] + Strength[0] + Toughness[0];
        CharacterPointer = 0;

        // 1. Ninja
        Agility[1] = 90;
        Charisma[1] = 45;
        Intelligence[1] = 65;
        Mana[1] = 30;
        Speed[1] = 90;
        Stamina[1] = 80;
        Strength[1] = 60;
        Toughness[1] = 50;
        //Total[1] = Agility[1] + Charisma[1] + Intelligence[1] + Speed[1] + Stamina[1] + Strength[1] + Toughness[1];

        // 2 .Wizard

        Agility[2] = 60;
        Charisma[2] = 30;
        Intelligence[2] = 90;
        Mana[2] = 80;
        Speed[2] = 60;
        Stamina[2] = 60;
        Strength[2] = 40;
        Toughness[2] = 40;
        //Total[2] = Agility[2] + Charisma[2] + Intelligence[2] + Speed[2] + Stamina[2] + Strength[2] + Toughness[2];

        // 3.  Tinkerer 

        Agility[3] = 60;
        Charisma[3] = 30;
        Intelligence[3] = 90;
        Mana[3] = 35;
        Speed[3] = 55;
        Stamina[3] = 65;
        Strength[3] = 35;
        Toughness[3] = 35;
        //Total[3] = Agility[3] + Charisma[3] + Intelligence[3] + Speed[3] + Stamina[3] + Strength[3] + Toughness[3];

    }

    // Update is called once per frame
    void Update()
    {
        if (CharacterPointer == -1)
        {
            CharacterPointer = 3;
        }
        if (CharacterPointer == 4)
        {
            CharacterPointer = 0;
        }
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
        GUI.backgroundColor = new Color(0, 0, 0, 0);

        if (main.ShowCharacterSheet == 1)
        {

            GUI.DrawTexture(Fullscreen, Paper);

            GUI.Label(LogoCenter, "RuneCraft Character Sheet", HeaderText);

            // Buttons

            GUI.Button(new Rect(50, 250, 300, 50), new GUIContent("", "Agility affects ranged damage and jumo height"));
            GUI.Button(new Rect(50, 300, 300, 50), new GUIContent("", "Charisma affects shop prices"));
            GUI.Button(new Rect(50, 350, 300, 50), new GUIContent("", "Intelligence determines XP needed for the next level"));
            GUI.Button(new Rect(50, 400, 300, 50), new GUIContent("", "Manapoints"));
            GUI.Button(new Rect(50, 450, 300, 50), new GUIContent("", "Stamina determines how fast you character gets tired, recharges over time"));
            GUI.Button(new Rect(50, 500, 300, 50), new GUIContent("", "Strength affects melee damage, jump height and carry load"));
            GUI.Button(new Rect(50, 550, 300, 50), new GUIContent("", "Speed of the character"));
            GUI.Button(new Rect(50, 600, 300, 50), new GUIContent("", "Toughness affects hitpoints and damage reduction"));

            GUI.Label(new Rect(Screen.width / 2, Screen.height - 40, 200, 40), GUI.tooltip);

            //GUI.Label(AttributesAlignment, "<b>Attributes</b>", HeaderText);
            //GUI.Label(AttributesAlignment, "<b>Attributes</b>\nAgility\nCharisma\nMana\nIntelligence\nSpeed\nStamina\nStrength\nToughness", LargeText);

            // Buttons

            if (GUI.Button(new Rect(Screen.width / 2, Screen.height - 100, 50, 50), ButtonExit))
            {

                main.ShowCharacterSheet = 0;
                main.ShowCity = 1;
            }

            if (GUI.Button(new Rect(50, Screen.height - 100, 50, 50), ButtonLeft))
            {
                CharacterPointer--;
            }
            if (GUI.Button(new Rect(Screen.width - 100, Screen.height - 100, 50, 50), ButtonRight))
            {
                CharacterPointer++;
            }

            if (CharacterPointer < 4)
            {

                // Skills
                GUI.Label(new Rect(Screen.width - 350, 150, 100, 20), "Skills", LargeText);

                GUI.Label(new Rect(Screen.width - 350, 250, 300, 50), "Blacksmith", MediumText);
                //GUI.Label(new Rect(350, 250, 300, 50), "" + Agility[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 300, 300, 50), "Runecraft", MediumText);
                //GUI.Label(new Rect(350, 300, 300, 50), "" + Charisma[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 350, 300, 50), "Tailoring", MediumText);
                //GUI.Label(new Rect(350, 350, 300, 50), "" + Intelligence[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 400, 300, 50), "Herbalism", MediumText);
                //GUI.Label(new Rect(350, 400, 300, 50), "" + Mana[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 450, 300, 50), "Tinkering", MediumText);
                //GUI.Label(new Rect(350, 450, 300, 50), "" + Stamina[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 500, 300, 50), "Steal", MediumText);
                //GUI.Label(new Rect(350, 500, 300, 50), "" + Strength[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 550, 300, 50), "Pick lock", MediumText);
                //GUI.Label(new Rect(350, 550, 300, 50), "" + Speed[CharacterPointer], LargeText);

                GUI.Label(new Rect(Screen.width - 350, 600, 300, 50), "Lore", MediumText);
                //GUI.Label(new Rect(350, 600, 300, 50), "" + Toughness[CharacterPointer], LargeText);

                // Attributes
                //GUI.Label(new Rect(10, 60, 100, 20), "sound volume ");



                GUI.Label(new Rect(50, 150, 300, 50), "Attributes", LargeText);

                GUI.Label(new Rect(50, 250, 300, 50), "Agility", MediumText);
                GUI.Label(new Rect(350, 250, 300, 50), "" + Agility[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 300, 300, 50), "Charisma", MediumText);
                GUI.Label(new Rect(350, 300, 300, 50), "" + Charisma[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 350, 300, 50), "Intelligence", MediumText);
                GUI.Label(new Rect(350, 350, 300, 50), "" + Intelligence[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 400, 300, 50), "Mana", MediumText);
                GUI.Label(new Rect(350, 400, 300, 50), "" + Mana[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 450, 300, 50), "Stamina", MediumText);
                GUI.Label(new Rect(350, 450, 300, 50), "" + Stamina[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 500, 300, 50), "Strength", MediumText);
                GUI.Label(new Rect(350, 500, 300, 50), "" + Strength[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 550, 300, 50), "Speed", MediumText);
                GUI.Label(new Rect(350, 550, 300, 50), "" + Speed[CharacterPointer], LargeText);

                GUI.Label(new Rect(50, 600, 300, 50), "Toughness", MediumText);
                GUI.Label(new Rect(350, 600, 300, 50), "" + Toughness[CharacterPointer], LargeText);


            }
            GUI.DrawTexture(new Rect(800, 200, 400, 400), CharacterPortrait[CharacterPointer]);
            GUI.DrawTexture(new Rect(800, 600, 200, 200), CharacterWeapon1[0]);
            GUI.DrawTexture(new Rect(1000, 600, 200, 200), CharacterWeapon2[0]);

            GUI.Label(new Rect(800, 100, 200, 200), "" + CharacterNames[CharacterPointer], LargeText);




        }
    }
}