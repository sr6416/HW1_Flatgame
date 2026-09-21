using UnityEngine;

public class BkgControllerScript : MonoBehaviour {
    //public makes it available to edit in Unity Editor
    float playerSpeed = 25.0f;

    //check hitGoalpost after rotation is done
    //start GoalPost checking after the input is taken
    //store last a/d key pressed
    //if you hit a goalpost if last key was a -= spriteIndex and if last key was d vice-versa
    //figure out what trigger is
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -playerSpeed * Time.deltaTime);
        }else if (Input.GetKey(KeyCode.D)){
            transform.Rotate(0, 0, playerSpeed * Time.deltaTime);
        }
    }// end Update
}// end class BkgControllerScript