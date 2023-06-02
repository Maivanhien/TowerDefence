using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TurretData", menuName = "GameData/TurretData")]
public class TurretData : ScriptableObject {
    public int id;
    public Sprite Sprite;
    public GameObject turretPrefab;
}
