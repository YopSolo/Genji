using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class GenjiActions : MonoBehaviour
{
    // D�claration d'une variable priv�e gameObject (equivalent d'une variable 'Graph' en visual scripting)
    private GameObject MyCamera;
    private float MyJumpHeight = .0f;

    private const int MAX_HP = 10;

    // Creer des m�thodes C# pour acceder et modifier les valeurs depuis le Visual Scripting
    // m�me principe que ce que l'on a vu avec les Scriptable Objects :)
    private int _HP = 8;
    public int HP
    {
        get { return _HP; }
        set
        {
            _HP = Mathf.Max(Mathf.Min(value, MAX_HP), 0);
        }
    }

    // dans la methode Start on va recup�rer la reference du game object Cam
    void Start()
    {
        // 
        MyCamera = GameObject.Find("Cam");

        // Documentation
        // https://docs.unity3d.com/Packages/com.unity.visualscripting@1.8/manual/vs-variables-reference.html

        // Recup�ration d'une variable d�finie dans le Visual Scripting (Application)
        //Variables.Application.Set("CharacterName", "GENJI !");
        Debug.Log("Hello " + Variables.Application.Get("CharacterName") + " !");

        // on peut aller chercher la valeur d'une variable definie dans le visual scripting ( Graph / Object ou Scene )
        MyJumpHeight = (float)Variables.Object(gameObject).Get("JumpHeight");
        // Debug.Log("MyJumpHeight: " + MyJumpHeight.ToString());

        // pour changer une valeur depuis le C# vers le Visual Scripting
        // Variables.Object(gameObject).Set("JumpHeight", 30.0f);
    }

    // on peut ensuite l'utiliser 
    void Update()
    {
        // Debug.Log(MyCamera.transform.rotation.ToString());
    }


    // Creation du node Triple shuriken en C# qui pourra �tre appell� en Visual Scripting
    public void GenjiTripleShuriken()
    {
        Debug.Log("Triple shuriken");
    }

    // Creation du node Dash en C# qui pourra �tre appell� en Visual Scripting
    public void GenjiDash()
    {
        Debug.Log("Dash !");
    }

}
