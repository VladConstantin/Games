using UnityEngine;public class PowerUps : MonoBehaviour {    public int powerUpGunType;    public GameObject gc;    public bool gunLvlUp;    public bool dmgLvlUp;    public bool speedLvlUp;    void OnTriggerEnter2D(Collider2D other)    {        if (other.gameObject.tag == "Player")        {            if(powerUpGunType == 1)
            {
                if (gunLvlUp)
                {
                    other.gameObject.GetComponent<GunController>().upgrade(powerUpGunType, 1, 0, 0);
                    gc.gameObject.GetComponent<ShopUIManager>().foundBlzrLVL();
                }
                else if (dmgLvlUp)
                {
                    other.gameObject.GetComponent<GunController>().upgrade(powerUpGunType, 0, 1, 0);
                    gc.gameObject.GetComponent<ShopUIManager>().foundBlzrDMG();
                }
                else if (speedLvlUp)
                {
                    other.gameObject.GetComponent<GunController>().upgrade(powerUpGunType, 0, 0, 0.01f);
                    gc.gameObject.GetComponent<ShopUIManager>().foundBlzrSpeed();
                }
            }
            else
            {
                if (gunLvlUp)
                {
                    other.gameObject.GetComponent<GunController>().upgrade(powerUpGunType, 1, 0, 0);
                    gc.gameObject.GetComponent<ShopUIManager>().foundGlzrLVL();
                }
                else if (dmgLvlUp)
                {
                    other.gameObject.GetComponent<GunController>().upgrade(powerUpGunType, 0, 1, 0);
                    gc.gameObject.GetComponent<ShopUIManager>().foundGlzrDMG();
                }
                else if (speedLvlUp)
                {
                    other.gameObject.GetComponent<GunController>().upgrade(powerUpGunType, 0, 0, 0.01f);
                    gc.gameObject.GetComponent<ShopUIManager>().foundGlzrSpeed();
                }
            }                        Destroy(gameObject);        }    }}