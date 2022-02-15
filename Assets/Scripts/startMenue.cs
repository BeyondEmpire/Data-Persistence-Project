using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startMenue : MonoBehaviour
{
	public Text playerNameText;
	public string playerName;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void StartNew()
	{
		playerName = playerNameText.text;
		SceneManager.LoadScene(1);
	}
}
