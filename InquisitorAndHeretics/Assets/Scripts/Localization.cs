using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization
{
    public string[,] localization = new string [20,2]    // [рядок, стовбець]
    { 
        { "Українська","English"},
        //Назви юнітів
        { "Селянин","Peasant" },
        { "Ватажок розбійників","Bandit captain"},
        { "Розбійник","Bandit" },
        { "Інквізитор","Inquisitor"},
        { "Жрець","Cleric"},
        { "Культист","Cultist"},
        { "Дворянин","Noble"},
        //Для інтерфейсу
        { "Кількість людей","Number of people" },
        { "Кількість гравців","Number of player" },
        { "Світогляд","Worldview" },
        { "Жадібність","Greed" },
        { "Прощення","Forgiveness" },
        { "Мстивість","Revenge" },

        { "Початок гри","Start Game" },
        { "Налаштування","Options" },
        { "Вихід","Exit" },
        { "Назад","Back" },
        { "Далі","Next" },
        { "Персонаж","Character" }
    };

}
