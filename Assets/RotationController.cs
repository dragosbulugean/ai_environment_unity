using UnityEngine;
using System.Collections;

public class RotationController : MonoBehaviour {

    public float RotationSpeed = 10.0f;
    public bool Clockwise = false;
  

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float amount = Time.deltaTime * RotationSpeed;
        amount = Clockwise ? amount : -amount;
        this.transform.Rotate(0, Time.deltaTime * RotationSpeed, 0, Space.World);
	}
}
