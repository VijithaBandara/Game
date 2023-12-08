using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;
    //public GameObject newRecordPanel;

    public static int numberOfCoin;
    public Text coinsText;
    //public TextMeshProUGUI gemsText;
    //public TextMeshProUGUI newRecordText;

    //public static bool isGamePaused;
    //public GameObject[] characterPrefabs;

   /* private AdManager adManager;

    private void Awake()
    {
        int index = PlayerPrefs.GetInt("SelectedCharacter");
        GameObject go = Instantiate(characterPrefabs[index], transform.position, Quaternion.identity);
        adManager = FindObjectOfType<AdManager>();
    }*/

    void Start()
    {
        numberOfCoin = 0;
        Time.timeScale = 1;
        gameOver = /*isGameStarted = isGamePaused = */false;
        isGameStarted = false;
        /* adManager.RequestBanner();
          adManager.RequestInterstitial();
          adManager.RequestRewardBasedVideo();*/
    }

    void Update()
    {
        //Update UI
       /* gemsText.text = PlayerPrefs.GetInt("TotalGems", 0).ToString();
        scoreText.text = score.ToString();*/

        //Game Over
        if (gameOver)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        coinsText.text = "Coins:" + numberOfCoin;

        //Start Game
       if (SwipeManager.tap && !isGameStarted)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(20 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerManager.numberOfCoin += 1;
            Debug.Log("Coin:" + PlayerManager.numberOfCoin);
            Destroy(gameObject);
        }
    }
}*/