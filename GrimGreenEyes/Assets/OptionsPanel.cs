using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsPanel : MonoBehaviour
{
    [SerializeField] private GameObject parentPanel;

    private void Start()
    {
        HideOptionsPanel();
    }

    public void ShowOptionsPanel(Vector3 pos)
    {
        gameObject.SetActive(true);
        transform.position = pos;
        /*if(transform.localPosition.y >= parentPanel.GetComponent<RectTransform>().sizeDelta.y / 2)
        {

        }*/
    }

    public void HideOptionsPanel()
    {
        gameObject.SetActive(false);
    }
}
