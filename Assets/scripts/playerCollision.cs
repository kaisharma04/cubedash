
using UnityEngine;

public class playerCollision : MonoBehaviour {
 public playermovement movement;
 
void OnCollisionEnter (Collision collisionInfo)
{
	if(collisionInfo.collider.tag =="obstacle")
	{
		movement.enabled = false;
		FindObjectOfType<GameManager>().EndGame();
	}
}
}
