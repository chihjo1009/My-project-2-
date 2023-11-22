using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeaponManager : MonoBehaviour
{
    public enum EWeaponType
    {
        Sword,
        Bow,
        Staff
    }

    public GameObject swordModel;
    public GameObject bowModel;
    public GameObject staffModel;


    private EWeaponType currentWeapon = EWeaponType.Sword;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = EWeaponType.Sword;
            OnWeaponChange();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = EWeaponType.Bow;
            OnWeaponChange();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = EWeaponType.Staff;
            OnWeaponChange();
        }
    }

    void OnWeaponChange()
    {
        swordModel.SetActive(currentWeapon == EWeaponType.Sword);
        bowModel.SetActive(currentWeapon == EWeaponType.Bow);
        staffModel.SetActive(currentWeapon == EWeaponType.Staff);

        PerformWeaponAction();
    }

    void PerformWeaponAction()
    {
        switch(currentWeapon)
        {
            case EWeaponType.Sword:
                Debug.Log("sword");
                break;
            case EWeaponType.Bow:
                Debug.Log("bow");
                break;
            case EWeaponType.Staff:
                Debug.Log("staff");
                break;
        }
    }
}
