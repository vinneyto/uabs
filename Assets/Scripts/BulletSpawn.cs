using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletSpawn : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    
    public GameObject bulletSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();

        if (triggerValue > 0)
        {
            
        }
    }
}
