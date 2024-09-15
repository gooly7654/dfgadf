using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int currentLevel = 1; // Current level index (1-based)
    public int totalLevels = 3; // Total number of levels

    void Start()
    {
        // Optional: Initialize level-related data
    }

    public void LoadNextLevel()
    {
        currentLevel++;
        if (currentLevel > totalLevels)
        {
            // Optionally handle game completion or restart
            currentLevel = 1; // Restart from level 1 or handle game end
        }
        SceneManager.LoadScene($"Level{currentLevel}"); // Assumes scene names are Level1, Level2, etc.
    }
}
