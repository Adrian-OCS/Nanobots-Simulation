using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }
    
    //Ability to destroy tumors when close to them: press "j"
    private void OnTriggerStay(Collider other) {
    {
         if (Input.GetKeyDown(KeyCode.J))
        {
            Destroy(other.gameObject);  
        }
    }
}
}
