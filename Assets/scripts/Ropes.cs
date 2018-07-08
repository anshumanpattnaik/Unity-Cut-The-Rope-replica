using UnityEngine;

public class Ropes : MonoBehaviour {

	public Rigidbody2D hook;

	public GameObject linkPrefab;

	public Weights weigth;

	public int links = 7;

	// Use this for initialization
	void Start () {
		GenerateRopes ();
	}

	public void GenerateRopes(){

		Rigidbody2D previousRB = hook;

		for(int i = 0; i < links; i++){
			GameObject link = Instantiate (linkPrefab, transform);
			HingeJoint2D joint = link.GetComponent<HingeJoint2D> ();
			joint.connectedBody = previousRB;

			if (i < links - 1)
			{
				previousRB = link.GetComponent<Rigidbody2D>();
			} else
			{
				weigth.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
			}
		}
	}
}