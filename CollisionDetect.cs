using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided with" + collision.gameObject.name);


    }

}
