using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JavaPlugin : MonoBehaviour {

	// Use this for initialization
	void Start () {

        AndroidJavaClass jc
            = new AndroidJavaClass (
                "com.javaplugin.test.MyPlugin"
        );

        jc.CallStatic ("ButtonPressed");
	}


}
