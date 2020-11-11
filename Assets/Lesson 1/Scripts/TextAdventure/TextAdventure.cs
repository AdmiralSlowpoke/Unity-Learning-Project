using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour
{
    // Start is called before the first frame update
    private InputField inputField;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Text mapText;
    private char[,] world =
    {
        {'F','F','F','F','F'},
        {'F','F','F','F','F'},
        {'F','F','H','F','F'},
        {'F','F','F','F','F'},
        {'F','F','F','F','F'}
    };
    private Vector2Int playerPos;
    void Start()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        Debug.Log(playerPos.y + "" + playerPos.x);
        RefreshMap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string Answer=inputField.text;
            switch (Answer)
            {
                case "Вперед":
                    if (playerPos.y > 0)
                        playerPos.y--;
                    LookAround();
                    break;
                case "Назад":
                    if (playerPos.y < 4)
                        playerPos.y++;
                    LookAround();
                    break;
                case "Налево":
                    if (playerPos.x > 0)
                        playerPos.x--;
                    LookAround();
                    break;
                case "Направо":
                    if (playerPos.x < 4)
                        playerPos.x++;
                    LookAround();
                    break;
                default:
                    text.text = "Введена неверная команда доступные команды: Вперед,Назад,Налево,Направо";
                    break;

            }
            Debug.Log(playerPos.y + " " + playerPos.x);
        }
    }
    private void LookAround()
    {
        switch (world[playerPos.y, playerPos.x])
        {
            case 'F':
                text.text = "Вы видете перед собой лес, куда вы пойдете дальше?";
                break;
            case 'H':
                text.text = "Вы видете перед собой дом, куда вы пойдете дальше?";
                break;
        }
        RefreshMap();
    }
    private void RefreshMap()
    {
        mapText.text = "";
        for(int i = 0; i < 5; i++)
        {
            for(int f = 0; f < 5; f++)
            {
                if (playerPos.y == i && playerPos.x == f)
                    mapText.text += "X";
                else
                mapText.text += world[i, f];
            }
            if (i < 4)
                mapText.text += "\n";
        }
    }
}
