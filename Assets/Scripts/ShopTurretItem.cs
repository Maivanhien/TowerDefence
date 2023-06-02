using UnityEngine;
using UnityEngine.UI;

public class ShopTurretItem : MonoBehaviour {
    public Image turretImage;
    public Button turretItemButton;
    private int turretId;
    private Sprite turretSprite;

    private void Start() {
        turretItemButton.onClick.AddListener(turretItemButtonOnClick);
    }

    private void OnDestroy() {
        turretItemButton.onClick.RemoveAllListeners();
    }

    public void Init(int _turretId, Sprite _turretSprite) {
        turretId = _turretId;
        turretSprite = _turretSprite;
        turretImage.sprite = turretSprite;
    }

    private void turretItemButtonOnClick() {
        BuildManager.instance.SetTurretToBuild(turretId);
    }
}
