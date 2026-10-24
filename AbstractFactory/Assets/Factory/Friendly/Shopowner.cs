using UnityEngine;

public class Shopowner : MonoBehaviour, INPC
{
    public void Spawn()
    {
        Debug.Log("Setting up shop");
        GameObject desk = GameObject.CreatePrimitive(PrimitiveType.Cube);
        desk.transform.parent = transform;
        desk.transform.localPosition = new Vector3(0,-0.5f,1);
        desk.transform.localScale = new Vector3(2,1,1);
        desk.transform.rotation = new Quaternion(0,0,0,0);
    }
    public void Speak()
    {
        Debug.Log("Do you want to buy something?");
    }
    public void Move()
    {

    }
}
