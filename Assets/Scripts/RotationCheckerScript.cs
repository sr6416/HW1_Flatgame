using System;
using UnityEngine;

public class RotationCheckerScript : MonoBehaviour
{
    public Sprite[] mapSprites;
    public SpriteRenderer map;

    public SpriteRenderer background;
    public Color[] backgroundColors;
    public AudioSource mapSound;
    public AudioClip snowShoveling;
    int lastKeyWasA = -1;
    int spriteIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        map.sprite = mapSprites[0];
        background.color = backgroundColors[0];
        mapSound = GetComponent<AudioSource>();

    }// end Start

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.A))
        {
            lastKeyWasA = 1;
            //print("last key was A");
        }if (Input.GetKey(KeyCode.D))
        {
            lastKeyWasA = 0;
            //print("last key was D");
        }
    }// end Update

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Something collided with RotationChecker!");
        //if (other.CompareTag("GoalPost"))
        if(other.gameObject.name == "GoalPost")
        {
            Debug.Log("ABOUT TO CALL CHANGE SPRITE");

            changeSprite();

            Debug.Log("CHANGE SPRITE FINISHED");
            print("rotationchecker has collided with goalpost");
        }
    }// end OnTriggerEnter2D

    public void changeSprite()
    {
        print("hi im changeSprite");
        if (!(lastKeyWasA == -1))
        {
            if (lastKeyWasA == 0)//last key pressed was D: Right, move forward
            {
                if (spriteIndex == 3){
                    spriteIndex = 0;
                }
                else
                {
                    spriteIndex++;
                }
            }else if (lastKeyWasA == 1)//last key pressed was A: Left, move backward
            {
                if (spriteIndex == 0){
                    spriteIndex = 3;
                }
                else
                {
                    spriteIndex--;
                }
            }
            else
            {
                lastKeyWasA = -1;
            }
            

            map.sprite = mapSprites[spriteIndex];
            background.color = backgroundColors[spriteIndex];
            print(spriteIndex);
            print("hi!");
            Debug.Log("Changing map to index: " + spriteIndex + " / " + mapSprites[spriteIndex].name);
        }

       
        
    }// end changeSprite()
    public void playSounds()
    {
        if (spriteIndex == 0)// summer sounds
        {
            
        }else if (spriteIndex == 1)// fall sounds
        {
            
        }else if (spriteIndex == 2)//winter sounds
        {
            mapSound.PlayOneShot(snowShoveling);
            
        }else if (spriteIndex == 3)//spring sounds
        {
            
        }
    }
}// end class RotationCheckerScript
