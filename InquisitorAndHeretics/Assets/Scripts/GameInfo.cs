using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameInfo
{
    public static int numberOfPeople = 6;   //������� ����� � ���
    public static int numberOfPlayer = 0;   //������� �������
    public static int localization = 1;     //���� ����������
    public static int numPlayer = 0;        //����� ������
    //Character parametrs
    public static int worldview = 0;
    public static int greed = 0;
    public static int forgiveness = 0;
    public static int revenge = 0;
}
public enum TypePeople
{
    None=0,
    Peasant = 1,
    BanditCaptain=2,
    Bandit=3,
    Inquisitor=4,
    Cleric=5,
    Cultist=6,
    Noble=7
}
public class People
{
    public TypePeople type = TypePeople.None;
}