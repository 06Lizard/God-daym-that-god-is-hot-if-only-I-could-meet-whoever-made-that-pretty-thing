using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleSystem3 : MonoBehaviour
{
    private Player player;
    public EnemyGeneral enemy;
    public int Range1;
    public int Range2;

    //Keeps track of how many rounds have passed for effects.
    public int RoundNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = FindAnyObjectByType<Player>();
        player.healthBar = FindAnyObjectByType<HealthBar>();
    }

    int RollD6()
    {
        return Mathf.FloorToInt(Random.Range(1f, 7f));
    }

    public void Battle()
    {
        PlayerTurn();
        EnemyTurn();
        RoundNumber++;

        if (enemy.isAlive == false)
        {
            int index = Random.Range(Range1, Range2);
            SceneManager.LoadScene(index);
            DontDestroyOnLoad(player);
            Debug.Log("Scene Loaded");
        }
    }

    public void Block()
    {
        RoundNumber++;
    }

    public void UsePotion()
    {
        player.Heal();
        EnemyTurn();
        RoundNumber++;
    }

    public void PlayerTurn()
    {
        enemy.takeDamage(player.PlayerWeapon.damage);
    }

    public void EnemyTurn()
    {
        if (RollD6() == 6)
        {
            enemy.DealCritDamage();
        }
        else
        {
            enemy.DealDamage();
        }

    }

}