using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvasScript : MonoBehaviour
{
	private PersistentData persistentData;
	private string playerName;
	public Text playerNameText;
	
    // Start is called before the first frame update
    void Start()
    {
        if (PersistentData.Instance != null)
		{
			playerName = PersistentData.Instance.playerName;
			playerNameText.text = "Name: " + playerName;
			
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
