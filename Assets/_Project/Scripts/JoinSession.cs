using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class JoinSession : MonoBehaviour
{
    const string MATCH_SCENE_NAME = "Match";
    Button joinMatchButton;
    void Start()
    {
        joinMatchButton = GetComponent<Button>();
        joinMatchButton.onClick.AddListener(JoinMatch);
    }

    void JoinMatch()
    {
        SceneManager.LoadScene(MATCH_SCENE_NAME);
    }
}
