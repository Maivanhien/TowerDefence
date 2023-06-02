using UnityEngine;

public class Shop : MonoBehaviour {
    public GameObject shopTurretItem;

    private void Start() {
        foreach (var turretData in BuildManager.instance.turretDataCollection.turretDatas) {
            GameObject turretItemGO = Instantiate(shopTurretItem, transform);
            turretItemGO.GetComponent<ShopTurretItem>().Init(turretData.id, turretData.Sprite);
        }
    }
}
