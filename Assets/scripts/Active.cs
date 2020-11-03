using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* DownArrow for destroy the object
 * UpArrow for active the object
 * object=cat
 */

public class Active : MonoBehaviour
{
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            obj.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            obj.SetActive(true);
        }
    }
}
