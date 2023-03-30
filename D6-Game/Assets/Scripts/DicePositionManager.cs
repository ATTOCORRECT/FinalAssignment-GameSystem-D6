 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicePositionManager : MonoBehaviour
{
    public GameObject Die;

    GameObject[] DicePositionEmpties;
    Vector2[] dicePositionLUT = new Vector2[16];

    List<GameObject> Dice = new List<GameObject>(16);

    void Start()
    {
        
        DicePositionEmpties = GameObject.FindGameObjectsWithTag("DicePosition");
        for (int i = 0; i < DicePositionEmpties.Length; i++)
        {
            dicePositionLUT[i] = DicePositionEmpties[i].transform.position;
        }

        for (int i = 0; i < 15; i++)
        {
            Dice.Add(Instantiate(Die, dicePositionLUT[i], Quaternion.identity));
        }

        Dice.Add(null);
    }
    private void FixedUpdate()
    {
        for (int i = 0; i < 16; i++)
        {
            if (Dice[i] != null)
            {
                Dice[i].transform.position = Vector2.Lerp(Dice[i].transform.position, dicePositionLUT[i], 0.2f);
            }
        }
    }

    public void SelectDie(int column) {
        if (column == 6) {
            Object.Destroy(Dice[15], 0);
            Dice[15] = null;
        }
        else if (Dice[15] == null)
        {
            MoveColumnDown(column);
        }
        else if ((Dice[column + 10].GetComponent<DieManager>().colorIndex       == Dice[15].GetComponent<DieManager>().colorIndex) ||
                 (Dice[column + 10].GetComponent<DieManager>().numberIndex % 6  == (Dice[15].GetComponent<DieManager>().numberIndex + 1) % 6))
        {
            MoveColumnDown(column);
        }
        else
        {
            StartCoroutine(Dice[column + 10].GetComponent<DieManager>().ShakeDie());
        }
    }

    void MoveColumnDown(int column)
    {
        Object.Destroy(Dice[15], 0);
        Dice[15] = Dice[column + 10];
        Dice[column + 10] = Dice[column + 5];
        Dice[column + 5] = Dice[column];
        Dice[column] = Instantiate(Die, dicePositionLUT[column], Quaternion.identity);
    }


}
