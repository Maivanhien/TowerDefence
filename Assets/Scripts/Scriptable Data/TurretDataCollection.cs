using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TurretDataCollection", menuName = "GameData/TurretDataCollection")]
public class TurretDataCollection : ScriptableObject {
    public List<TurretData> turretDatas;

    public TurretData GetTurretDataById(int id) {
        return turretDatas.Find(x => x.id == id);
    }

    public Sprite GetTurretSpriteById(int id) {
        return GetTurretDataById(id).Sprite;
    }

    public GameObject GetTurretPrefabById(int id) {
        return GetTurretDataById(id).turretPrefab;
    }
}
