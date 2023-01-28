using TMPro;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.TextCore;


public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.SetText(player.position.z.ToString("0"));
    }
}
