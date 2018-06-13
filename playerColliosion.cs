
using UnityEngine;
using System.collection;

public class playerCollision : MonoBehaviour {
	public AudioSource tickSource;
 public playermovement movement;
 void start(){
	 tickSource = GetComponant<AudioSource>();
 }
 
void OnCollisionEnter (Collision collisionInfo)
{
	if(collisionInfo.collider.tag =="obstacle")
	{
		tickSource.Play ();
		movement.enabled = false;
		FindObjectOfType<GameManager>().EndGame();
	}
}
}
