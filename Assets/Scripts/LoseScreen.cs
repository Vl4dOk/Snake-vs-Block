using UnityEngine;

public class LoseScreen : MonoBehaviour
{
    [SerializeField] Game game;
    public void RestartGame()
    {
        game.ReloadLevel();
    }
}
