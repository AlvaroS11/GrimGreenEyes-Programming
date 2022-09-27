using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    //Almacena las propiedades del objeto
    public string name;
    public Sprite sprite;
}
