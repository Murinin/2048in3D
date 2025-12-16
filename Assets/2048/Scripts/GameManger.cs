using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
public class GameManger : MonoBehaviour
{
   public static UnityEvent OnGameOver = new UnityEvent();
    public static UnityEvent OnNewRecordAchived = new UnityEvent();
    public static UnityEvent OnNumberOnDiceIncresses = new UnityEvent();
    public static UnityEvent OnMakingChangesToGameScore = new UnityEvent();

    public static int CurrentGameScore;
    public static int ReckorGameScore;
    public static int HighesNumberOnDice;

    public static void CheckHighestNumberOnDice (CubeControler dice)
    {
        if (dice.cubeNumber > HighesNumberOnDice)
        {
            HighesNumberOnDice = dice.cubeNumber;
            OnNumberOnDiceIncresses.Invoke();
        }
    }

    public static void MakeChangesToGameScore(CubeControler dice)
    {

    }

}
