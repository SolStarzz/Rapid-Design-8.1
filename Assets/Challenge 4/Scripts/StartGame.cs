
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameStarter : MonoBehaviour
{
private Button button;
// Start is called before the first frame update
void Start()
{
button = GetComponent<Button>();
button.onClick.AddListener(StartTheGame);
}
// Update is called once per frame
void Update()
{
}
void StartTheGame()
{
SceneManager.LoadScene("Challenge 4");
}
}
