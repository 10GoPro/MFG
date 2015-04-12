using UnityEngine;
using System.Collections;

public class MoverDelante : MonoBehaviour {
	public float Vel;
	private Animator animator;
	// Use this for initialization
	void Awake ()
	{
		animator = GetComponent <Animator>();
	}
	void Start () {
		animator.SetFloat("VAdelante" , 0.02f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
