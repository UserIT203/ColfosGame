using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Gun))]
public class GunEditor : Editor
{
    private Gun gun;

    private void OnEnable()
    {
        gun = (Gun)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (gun.kindGun == KindGun.Ranged)
        {
            GUILayout.Label("Ranged Guns");

            EditorGUILayout.BeginVertical("box");

            gun.allBullets = EditorGUILayout.IntField("Count Bullets: ", gun.allBullets);
            gun.bulletsInGun = EditorGUILayout.IntField("Count Bullets In Gun: ", gun.bulletsInGun);

            EditorGUILayout.EndVertical();
        }else if (gun.kindGun == KindGun.Melee)
        {
            GUILayout.Label("Melle Guns");

            EditorGUILayout.BeginVertical("box");

            GUILayout.Label("None");

            EditorGUILayout.EndVertical();
        }
    }
}
