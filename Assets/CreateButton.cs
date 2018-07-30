using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour {

    public GameObject buttonPrefab;
    public bool workaround = false;

	void Start () {
		var button = Instantiate(buttonPrefab, transform);
        if (workaround)
        {
            button.SendMessage("OnCanvasGroupChanged");
        }
	}
}
