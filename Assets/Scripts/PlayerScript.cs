using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //public makes it available to edit in Unity Editor
    float playerSpeed = 2.0f;
    float nextWposition = 0;
    float nextAposition = 0;
    float nextSposition = 0;
    float nextDposition = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        /*
        if (Input.GetKey(KeyCode.W)){
            nextWposition = newPosition.y + playerSpeed * Time.deltaTime;
            if (nextWposition >= 2){

            }else{
                newPosition.y += playerSpeed * Time.deltaTime;
            }

        }if (Input.GetKey(KeyCode.A)){
            nextAposition = newPosition.x - playerSpeed * Time.deltaTime;
            if (nextAposition <= -2){

            }else{
                newPosition.x -= playerSpeed * Time.deltaTime;
            }
        }/*if (Input.GetKey(KeyCode.S)){
            nextSposition = newPosition.y - playerSpeed * Time.deltaTime;
            if (nextSposition <= -2){

            }else{
                newPosition.y -= playerSpeed * Time.deltaTime;
            }
        }if (Input.GetKey(KeyCode.D)){
            nextDposition = newPosition.x + playerSpeed * Time.deltaTime;
            if (nextDposition >= 2){

            }else{
                newPosition.x += playerSpeed * Time.deltaTime;
            }
        }
        transform.position = newPosition;
    }
*/
    }
}
