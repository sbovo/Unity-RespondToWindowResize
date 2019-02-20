using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeHelper : MonoBehaviour
{

    // Members
    private Vector2 WindowSize;

    // Singleton
    public static ResizeHelper instance;

    void Awake()
    {
        if (instance != null)
            GameObject.Destroy(instance);
        else
        {
            instance = this;
            instance.WindowSize = new Vector2(Screen.width, Screen.height);
        }

        DontDestroyOnLoad(this);
    }
          

    void Update()
    {
        Vector2 NewSize = new Vector2(Screen.width, Screen.height);
        if (this.WindowSize != NewSize)
        {
            this.WindowSize = NewSize;
            // If the size of the windows is too small display an elegant message saying that
            // "There is not enough space to play here :-)

            System.Diagnostics.Debug.WriteLine("{" + NewSize.x.ToString() + ":" + NewSize.y.ToString() + "}");
        }
    }
}
