using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour

{
    public GameObject arrowPrefab;

    
    private void Start()
    {
       GameObject arrowGo =  GameObject.Instantiate(arrowPrefab);
        arrowGo.transform.position = new Vector3(0, 6f, 0);
    }

}
