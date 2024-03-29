﻿using UnityEngine;
using Supernova_Server;
public enum WPlayer : byte {Player1 , Player2};
public enum MovePlayerLeftAndRite : byte {BlokeLeft , BlokeRite};
public enum AIState : byte {ezay = 5 , normal = 3 , hard = 1}
public static class UnityCoustomMethod
{
	public static Color HexToRgb(string HexValue)
	{
		byte[] ColorRGB = new byte[3];
		int Index = 0;
		int IndexRGB = 0;
		string temp = "";
		
		for (int i = 0; i < HexValue.Length; i++) 
		{
			temp += HexValue[i];
			Index++;
			if(Index == 2)
			{
				ColorRGB[IndexRGB] = System.Convert.ToByte(temp , 16);
				IndexRGB ++;
				Index = 0;
				temp = "";
			}
		}
		Color32 tempC  = new Color32(ColorRGB[0] ,ColorRGB[1] , ColorRGB[2] ,255);
		return tempC;
	}
}

[System.Serializable]
public class anmtionControl
{
    public string Kay;
    public string stateName;
}

[System.Serializable]
public class AdvanceRamz
{
    public string stateNameZarbeh;
    public string stateNameDameage;
    public float damage;
    public bool Move;
    [Range(0, 10)]
    public float Destanse;
}

public static class MainPlayer
{
	public static WPlayer Mainplayer = WPlayer.Player2;
	public static CustomServerTCP Server = new CustomServerTCP();
	public static CustomClientTCP Client = new CustomClientTCP();
	//------------------------------------------------------------
	//public static Custom_Server ServerUDP = new Custom_Server();
	//public static Custom_Server ClientUDP = new Custom_Server();
}

public static class ControlGelobalVarebal
{
    public static bool EndGame = false;
    public static float HelsePlayer1 = 200;
    public static float HelsePlayer2 = 200;
	public static int TimeV = 60;
}
