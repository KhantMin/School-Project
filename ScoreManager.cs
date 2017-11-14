using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
	private LevelManager levelManager;
	//public int WinScore = 100;


    Text text;

    void Awake ()
	{
		text = GetComponent <Text> ();
		score = 0;
		}

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}


    void Update ()
	{
		text.text = "Score: " + score;
		//if(score >= WinScore){
		//levelManager.LoadNextLevel();

   	//}
    }

   	

}
