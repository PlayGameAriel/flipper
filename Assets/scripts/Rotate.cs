using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
/* The object increases and decreases slowly  */
public class Rotate : MonoBehaviour
{
    public bool updateOn = true;
 
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(updateOff()); 
    }
  IEnumerator updateOff()
    {
        yield return new WaitForSeconds(4f);
        updateOn = false;
    }
    
    // Update is called once per frame
    void Update()
    {

        if (updateOn == true)
        {
            transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime;
        }

        else
        {

            transform.localScale -= new Vector3(transform.localScale.x , transform.localScale.y , transform.localScale.z) * Time.deltaTime;

        }
       
       
       

    }
    
}
