using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    private PlayerData playerData = null;

    public void Lambo()
    {
        playerData.Atk_Speed += (playerData.Atk_Speed * 0.3f); 
    }

}
