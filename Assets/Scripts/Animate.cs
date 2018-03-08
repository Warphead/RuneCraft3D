using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {

    public Texture2D[] WizardWalk;  // 4 frames
    public Texture2D Portcullis;
    public int FramePointer = 0;
    public float FrameRate = 0.5F;
    public int PositionX = 1;
	// Use this for initialization
	void Start () {
        InvokeRepeating("CycleTextures", FrameRate, FrameRate);
        InvokeRepeating("MoveCharacter", 0.1F, 0.1F);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(1920 + PositionX, 200, 400, 400), WizardWalk[FramePointer]);
    }

    private void CycleTextures()
    {
        FramePointer++;
        if (FramePointer == 4)
        {
            FramePointer = 0;
        } 
        //renderer.material.mainTexture = WizardWalk[FramePointer];
    }

    private void MoveCharacter()
    {
        PositionX = PositionX - 30;
    }
}
