using UnityEngine;
using System.Collections;

public class Environment : MonoBehaviour
{
    public Color Desert = Color.white;
    public Color Sea = Color.white;
    public Color Forest = Color.white;
    //set these colors in Unity Editor, replace with backdrop sprites later on

    public void changebg(string bgcolor)
    {
        switch (bgcolor)
        {
            case "Desert": GetComponent<Camera>().backgroundColor = Desert; break;
            case "Sea": GetComponent<Camera>().backgroundColor = Sea; break;
            case "Forest": GetComponent<Camera>().backgroundColor = Forest; break;
            default: GetComponent<Camera>().backgroundColor = Color.black; break;
        }
    }
}