using UnityEngine;

public class BuildManager : MonoBehaviour {
    public static BuildManager instance;
    public TurretDataCollection turretDataCollection;
    private GameObject turretToBuild;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if(instance != this) {
            Destroy(this.gameObject);
        }
    }

    public GameObject GetTurretToBuild() {
        return turretToBuild;
    }

    public void SetTurretToBuild(int id) {
        turretToBuild = turretDataCollection.GetTurretPrefabById(id);
    }
}
