using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoundMover : MonoBehaviour {

    void Update () {
        Vector3 move = new Vector3(this.GetAxisMov(Input.GetAxis("Vertical"),transform.rotation.x), 0, this.GetAxisMov(-1 * Input.GetAxis("Horizontal"),transform.rotation.z));
        transform.Rotate(move * Time.deltaTime *15);
    }

     float GetAxisMov (float var, double transRot) // controals moves rot and keeps the table form over bending
    {
        double mtbend = .10; // max table bend rate
        if (transRot > mtbend & var > 0 || transRot < -mtbend & var < 0) //stops over table bend
        {
            return 0;
        }
        return var;
    }
    
}
