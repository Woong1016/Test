using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Shop_UnitShopPanel;   // ������ ���� ���� �� �� �� �ִ� �г�
    public GameObject UnitShopPanel;        // ���� ���� �г�
    public GameObject ShopPanel;            // ���� �г�

    private bool isShopPanelActive = false; 

    void Start()
    {
        Shop_UnitShopPanel.SetActive(false);
        UnitShopPanel.SetActive(false);
        ShopPanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isShopPanelActive)
        {
            CloseShopPanelOnOutsideClick();
        }
    }

    public void ShopButton_Clicked()
    {
        Shop_UnitShopPanel.SetActive(true);         //������ ���� ���� ��ư�� �ִ� �г� Ȱ��ȭ
        isShopPanelActive = true; 
    }

    public void UnitShopButton_Clicked()
    {
        UnitShopPanel.SetActive(true);              //���� ���� ��ư�� �ִ� �г� Ȱ��ȭ
        isShopPanelActive = true; 
    }

    public void Shop_Button_Clicked()
    {
        ShopPanel.SetActive(true);                  //���� �г� Ȱ��ȭ
        isShopPanelActive = true; 
    }

    void CloseShopPanelOnOutsideClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject != ShopPanel)
            {
                // ���콺 Ŭ�� ��ġ�� ���� �г� �ٱ��̸� �г��� ����
                Shop_UnitShopPanel.SetActive(false);
                UnitShopPanel.SetActive(false);
                ShopPanel.SetActive(false);

                isShopPanelActive = false; // �г��� ���� �� ���� ������Ʈ
            }
        }
    }
}
