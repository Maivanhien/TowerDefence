using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {
    public Color hoverColor;
    private GameObject turret;
    private Renderer renderer;
    private Color startColor;

    private void Start() {
        renderer = GetComponent<Renderer>();
        startColor = renderer.material.color;
    }

    private void OnMouseDown() {
        if (turret != null) {
            Debug.Log("Can't build there");
            return;
        }
        // Build a turret
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (BuildManager.instance.GetTurretToBuild() == null)
            return;
        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = Instantiate(turretToBuild, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
    }

    private void OnMouseEnter() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (BuildManager.instance.GetTurretToBuild() == null)
            return;
        renderer.material.color = hoverColor;
    }

    private void OnMouseExit() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (BuildManager.instance.GetTurretToBuild() == null)
            return;
        renderer.material.color = startColor;
    }
}
