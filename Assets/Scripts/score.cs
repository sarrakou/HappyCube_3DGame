using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + 43).ToString("0");
    }
}
