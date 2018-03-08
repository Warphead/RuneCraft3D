using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public class Player : MonoBehaviour
    {

        private float waitTime = 0.5F;
        private Texture2D[] Idle;
        public Sprite[] Walk;
        public Sprite[] Jump;
        public Sprite[] Attack1;
        public Sprite[] Attack2;
        public Sprite[] Death;

        private int i = 0;

        private string spriteNames = "part_explosion";
        private Rect buttonPos;
        public int spriteVersion = 0;
        public SpriteRenderer spriteR;
        public Sprite[] sprites;

        public float moveSpeed = 1;
        public float jumpPower = 1;

        

        // Use this for initialization

        private void Start()
        {
            //buttonPos = new Rect(10.0f, 10.0f, 150.0f, 50.0f);
            //spriteR = gameObject.GetComponent<SpriteRenderer>();
            //sprites = Resources.LoadAll<Sprite>(spriteNames);
        }


        //   void LoopTexture()
        //{
        //Debug.Log(i);
        //GetComponent.< Renderer > ().material.mainTexture = textures[i];

        //if (int i < 3) { 
        //i++;
        //}
        //      else
        //i = 0;
        //CancelInvoke("LoopTexture");
        //}


        void Update()
        {
            //Invoke("LoopTexture", waitTime);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);


            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Verticalal");

            x = x * Time.deltaTime * moveSpeed;
            y = y * Time.deltaTime * jumpPower;

            transform.Translate(x, y, 0F);

            //Rigidbody2D rb = GetComponent<Rigidbody2D>();
            //if (Input.GetKey(KeyCode.UpArrow))
              //  rb.AddForce(Vector2.up * jumpPower);
        }
        void OnGUI()
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                spriteVersion++;
                if (spriteVersion > 3)
                    spriteVersion = 0;
                spriteR.sprite = Walk[spriteVersion];
            }
        }
    }
}