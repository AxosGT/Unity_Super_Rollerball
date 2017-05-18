using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuberCon : MonoBehaviour {

    public bool ative;
    public Material ativemat;
    public Material unativemat;
    
   

	// Use this for initialization
	void Start () {
        filp(this.ative);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (this.ative == false)
            {
                this.ative = true;                
            }
            else
            {
                this.ative = false;
            }
            filp(this.ative);
        }
    }
    
    private void filp(bool ative) // changes the color
    {

        if (ative)
        {
            this.gameObject.GetComponentInChildren<Renderer>().sharedMaterial = ativemat;
        }
        else
        {
            this.gameObject.GetComponentInChildren<Renderer>().sharedMaterial = unativemat;
        }
    } 

    public bool getative()
    {
        return ative;
    }
}
