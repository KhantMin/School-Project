using System.Collections;
using UnityEngine;

public class TrapsBehavior : MonoBehaviour {

	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	public int currentPoint = 0;

	void Start (){


	}

	void Update ()
	{
		Vector3 dir = path [currentPoint].position - transform.position;
		transform.position += (dir * Time.deltaTime * speed)/5;
		//float dist = Vector3.Distance(path[currentPoint].position, transform.position);

		//transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, Time.deltaTime*speed);

		if (dir.magnitude < reachDist) {
		//if(dist <= reachDist){
				currentPoint++;
		}

		if (currentPoint >= path.Length) {
			currentPoint = 0;
		}
	}


	void OnDrawGizmos ()
	{
		if(path.Length > 0)
		for (int i = 0; i < path.Length; i++) {

			if (path [i] != null) {
				Gizmos.DrawSphere(path[i].position, reachDist);
			}
		}
	}
}
