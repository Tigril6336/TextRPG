using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //подключение библеотеки для работы с пользовательским интерфейсом
using UnityEngine.SceneManagement; // библеотек для работы со сценами

public class GameMenuBtnController : MonoBehaviour
{
    [Header("Компоненты UI")]
    [SerializeField] private GameObject SettingsPan;


    private void Start() //код выполняемый перед запуском приложения
    {
        SettingsPan.SetActive(false); // сокрытие панели настроек

        if (SettingsPan == null) // проверка на нулевое значения панели настроек
        {
            SettingsPan = GameObject.FindGameObjectWithTag("SettingsPan"); // присвоение панели настроек через поиск по тегу
        }
    }


    // кнопка для начала игры
    public void StartGameBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //загрузка следующей сцены (по индексу)
    }

    public void SettingsPanOpenAndClose() // открытие и закрытие панели настроек
    {
        if(SettingsPan.activeSelf == true) // проверка на активность панели
        {
            SettingsPan.SetActive(false); // отключение панели
        }
        else // панель не активна
        {
            SettingsPan.SetActive(true); // активация панели
        }
    }

    public void ExitGame() // кнопка выхода из игры
    {
        Application.Quit(); // закрытие игры
    }
}
