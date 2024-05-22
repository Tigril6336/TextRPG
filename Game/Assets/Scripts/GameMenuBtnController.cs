using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //����������� ���������� ��� ������ � ���������������� �����������
using UnityEngine.SceneManagement; // ��������� ��� ������ �� �������

public class GameMenuBtnController : MonoBehaviour
{
    [Header("���������� UI")]
    [SerializeField] private GameObject SettingsPan;


    private void Start() //��� ����������� ����� �������� ����������
    {
        SettingsPan.SetActive(false); // �������� ������ ��������

        if (SettingsPan == null) // �������� �� ������� �������� ������ ��������
        {
            SettingsPan = GameObject.FindGameObjectWithTag("SettingsPan"); // ���������� ������ �������� ����� ����� �� ����
        }
    }


    // ������ ��� ������ ����
    public void StartGameBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //�������� ��������� ����� (�� �������)
    }

    public void SettingsPanOpenAndClose() // �������� � �������� ������ ��������
    {
        if(SettingsPan.activeSelf == true) // �������� �� ���������� ������
        {
            SettingsPan.SetActive(false); // ���������� ������
        }
        else // ������ �� �������
        {
            SettingsPan.SetActive(true); // ��������� ������
        }
    }

    public void ExitGame() // ������ ������ �� ����
    {
        Application.Quit(); // �������� ����
    }
}
