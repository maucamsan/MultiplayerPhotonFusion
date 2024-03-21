using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class JoinSession : MonoBehaviour
{

    public static int numberOfPlayers = 1;
    const string MATCH_SCENE_NAME = "Match";
    [SerializeField] TMP_InputField inputField;
    public StringVariable StringVariable;
    Button joinMatchButton;

    string userName;
    public string UserName
    {
        get {return string.IsNullOrEmpty(inputField.text) ?  $"Player{numberOfPlayers++}" : inputField.text;}
        set {userName = inputField.text;}
    }
    void Start()
    {
        joinMatchButton = GetComponent<Button>();
        joinMatchButton.onClick.AddListener(JoinMatch);
    }

    void JoinMatch()
    {
        StringVariable.UserName = UserName;
        SceneManager.LoadScene(MATCH_SCENE_NAME);
    }
}
