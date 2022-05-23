using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
    public Practice practice;
    // Start is called before the first frame update
    void Start()
    {
        practice.check += (int i) => {
            if (i < 6)
                Debug.Log("true");
            else
                Debug.Log("false");
            return (i < 6);
        };
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private bool Ischecking(int a)
    {        
        Debug.Log("Excellent");
        if (a < 6) 
            Debug.Log("true");
        else 
            Debug.Log("false");
        return (a<6);
        
    }
}
