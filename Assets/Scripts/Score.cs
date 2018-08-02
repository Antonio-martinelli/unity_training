using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public GameObject playerScript;
    public Text scoreText;
    public Text collectibleText;
    private string maxCollectable;

    void Start()
    {
        maxCollectable = GameObject.FindGameObjectsWithTag("Collectable").Length.ToString();
        collectibleText.text = playerScript.GetComponent<PlayerCollision>().collected.ToString() + "/" + GameObject.FindGameObjectsWithTag("Collectable").Length.ToString();
    }

	// Update is called once per frame
	void Update () {
        scoreText.text = player.position.z.ToString("0");
        collectibleText.text = playerScript.GetComponent<PlayerCollision>().collected.ToString() + "/" + maxCollectable;
    }

}
