using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    private int count;
    //public GameObject[] bubers;
    //public static ArrayList bubers = new ArrayList();
    //BuberCon[] bubers = FindGameObjectsWithTag("BuberT");
    //private BuberCon[] bubers;

    public BuberCon[] bubers;

    //public List<BuberCon> bubers = new List<BuberCon>();
    public Text countText;

	// Use this for initialization
	void Start () {
        count = 0;
        SetCountText();
        
        bubers = FindObjectsOfType<BuberCon>();
        

      
        //bubers = (BuberCon)FindObjectOfType(typeof(BuberCon));



       // bubers = GameObject.FindGameObjectsWithTag("BuberT");


        //bubers = GameObject.FindObjectsOfType(typeof(BuberCon));
        //bubers = gameObject.FindObjectOfType<BuberCon>;

        //(bubers[0] as BuberCon).ative;
        //bubers[0].GetType(BuberCon).GetProperties()






    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("kk");
        /* for (int i = 0; i < bubers.Length; i++)
        {
            if(bubers[i].ative)
            {
                count++;
            }
        } */
        

        foreach (BuberCon ative in bubers)
        {
            if(ative)
            {
                count++;
            }

            Debug.Log("testing");
        }

        //Debug.Log(bubers.Length);
        Debug.Log(count);
        
    }
    
   

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();

    }
}
