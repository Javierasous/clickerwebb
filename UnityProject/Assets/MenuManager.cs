using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public int scorePoints;
    public TextMeshProUGUI scoreText;
    public int scoreAdd;

    public Animator anim;
    public GameObject menuCanvas;

    public void ClickObject()
    {
        scorePoints += scoreAdd;
        scoreText.text = "Score: " + scorePoints.ToString();
        anim.SetTrigger("Click");
        Debug.Log(scoreText);
    }
    public void PowerUp()
    {
        scoreAdd += 1;
    }
}