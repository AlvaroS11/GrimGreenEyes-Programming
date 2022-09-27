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
        if(actualNode) // si el botón (nodo) está en la lista del primero y está activo, el nodo actual es el siguiente
                       //
            if(actualNode.GetComponent<PathOptions>().getGameobjects(node))
            {
                actualNode = node;
                Debug.Log("cambia correcto");

            }
    }
}
