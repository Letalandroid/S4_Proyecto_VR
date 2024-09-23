using UnityEngine;

public class Quit : MonoBehaviour {

    public void onClick()
    {
        Destroy(GameObject.FindGameObjectWithTag("EditorOnly"));
    }
}
