using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject actualNode;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveToNode(GameObject node)
    {
        Debug.Log("click");
        // if (actualNode)
      //  GameObject isInList = actualNode.GetComponent<PathOptions>().myArray
        //Debug.Log("");
        if(actualNode) // si el bot�n (nodo) est� en la lista del primero y est� activo, el nodo actual es el siguiente
                       //
            if(actualNode.GetComponent<PathOptions>().getGameobjects(node))
            {
                actualNode = node;
                Debug.Log("cambia correcto");

            }
    }
}
