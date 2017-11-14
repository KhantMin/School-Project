using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 	public float speed = 6f;

    Vector3	movement;
    Rigidbody playerRigidbody;
    int floorMask;
    float CamRayLength = 100f;
    //private Transform playerTransform;
    private int count;

    void Awake(){

    	floorMask = LayerMask.GetMask("Floor");
    	playerRigidbody = GetComponent<Rigidbody>();


    }

    void Start(){

    	count = 0;
    	//SetCountText();
    }
  
    void FixedUpdate(){//run with phyisics

		float h = Input.GetAxisRaw("Horizontal");//Return value of virtual axis with no smoothing
    	float v = Input.GetAxisRaw("Vertical");

    	Move(h, v);
    	Turning();


    }

    void Move(float h, float v){

    	movement.Set(h, 0f, v);
    	movement = movement.normalized * speed * Time.deltaTime;

    	playerRigidbody.MovePosition(transform.position + movement);
    	//Debug.Log(playerRigidbody.position);


    }

    void Turning ()
	{

		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);//Changing the camera to mouse position
		RaycastHit floorHit;

		if (Physics.Raycast (camRay, out floorHit, CamRayLength, floorMask)) { //Raycast(Origin, direction, hit info, max distance, layer mask, query Trigger interaction)

			Vector3 playerToMouse = floorHit.point - transform.position;
			playerToMouse.y = 0f;

			Quaternion newRotation = Quaternion.LookRotation(playerToMouse);
			playerRigidbody.MoveRotation(newRotation);

		}
    }

    //void OnTriggerEnter (Collider other)
	//{
	//	if (other.gameObject.CompareTag ("Pick Up")) {
	//		other.gameObject.SetActive(false);
	//		count = count + 1;
	//		SetCountText();
	//	}
    //}

    //void SetCountText ()
	//{
	//	if (count >= 9) {
	//		Debug.Log("All Collected");
	//	}
    //}

    }


  