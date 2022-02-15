using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistentData : MonoBehaviour
{
	public int oldHighScore;
	private MainManager mainManager;
	
	 public static PersistentData Instance;
	 public string playerName;
	 private startMenue startMenue;
	 
    private void Awake()
    {
        // start of new code
		if (Instance != null)
		{
			Destroy(gameObject);
			return;
		}
		
		Instance = this;
		DontDestroyOnLoad(gameObject);
    }
	[System.Serializable]
	class SaveData
	{
    public string playerName;
	public int oldHighScore;
	}
	
	public void SaveGameData(int kacke)
	{
		GetInGameData();
		playerName = startMenue.playerName;
		
		SaveData data = new SaveData();
		
		data.playerName = playerName;
		data.oldHighScore = kacke;
		
		string json = JsonUtility.ToJson(data);
		File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
	}
	public void LoadGameData()
	{
		string path = Application.persistentDataPath + "/savefile.json";
		if (File.Exists(path))
		{
			GetInGameData();
			
			string json = File.ReadAllText(path);
			SaveData data = JsonUtility.FromJson<SaveData>(json);

			oldHighScore = data.oldHighScore;
			mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
			mainManager.oldHighScore = oldHighScore;
			
			playerName = data.playerName;
			startMenue.playerName = playerName;
		}
	}
	
	private void GetInGameData()
	{
		startMenue = GameObject.Find("Canvas").GetComponent<startMenue>();
	}
}
