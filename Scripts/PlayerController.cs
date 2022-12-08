using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    public CharacterDatabase characterDB;
    //public SpriteRenderer artworkSprite;
    private int selectedOption = 0;
    private Rigidbody2D rb;

    //Player
    float walkSpeed = 10f;
    float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    //Animation Changer / States
    Animator animator;
    string currentState;
    const string PLAYER_IDLE_UP = "grant_idel";
    const string PLAYER_IDLE_DOWN = "up_idel";
    const string PLAYER_IDLE_RIGHT = "right_idel";
    const string PLAYER_IDLE_LEFT = "left_idel";
    const string PLAYER_RIGHT = "grant_right";
    const string PLAYER_LEFT = "grant_left";
    const string PLAYER_DOWN = "grant_up";
    const string PLAYER_UP = "grant_down";

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

        /*if(!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);*/
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            if (inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;
            }
            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);

            //Right
            if (inputHorizontal > 0)
            {
                ChangeAnimationState(PLAYER_RIGHT);
            }
            //Left
            else if (inputHorizontal < 0)
            {
                ChangeAnimationState(PLAYER_LEFT);
            }
            //Play up animation if not going right or left
            else if (inputVertical < 0)
            {
                ChangeAnimationState(PLAYER_UP);
            }
            //Same for down
            else if (inputVertical > 0)
            {
                ChangeAnimationState(PLAYER_DOWN);
            }

        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
            if (getAnimationState() == PLAYER_DOWN)
            {
                ChangeAnimationState(PLAYER_IDLE_DOWN);
            }
            else if (getAnimationState() == PLAYER_UP)
            {
                ChangeAnimationState(PLAYER_IDLE_UP);
            }
            else if (getAnimationState() == PLAYER_RIGHT)
            {
                ChangeAnimationState(PLAYER_IDLE_RIGHT);
            }
            else if (getAnimationState() == PLAYER_LEFT)
            {
                ChangeAnimationState(PLAYER_IDLE_LEFT);
            }

        }


    }

    void ChangeAnimationState(string newState)
    {
        //stop animatinon from interupting itself
        if (currentState == newState) return;

        //Play new animation
        animator.Play(newState);

        //update currentState
        currentState = newState;

    }

    string getAnimationState()
    {
        return currentState;
    }

  /*  private void UpdateCharacter(int selectedOption)
   {
    Character character = characterDB.GetCharacter(selectedOption);
    artworkSprite.sprite = character.characterSprite;
    nameText.text = character.characterName;
   }
   private void Load()
   {
    selectedOption = PlayerPrefs.GetInt("selectedOption");
   }*/


}
