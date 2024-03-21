using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GatherUsername : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    string userName;
    public string UserName
    {
        get {return userName??= "Player2";}
        set {userName = value;}
    }
}
