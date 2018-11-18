﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticGameInfo {
	public static string userName;
	public static string userID;
	public static string performance;
	public static int currentTask;

	public const string TASK_1 = "Task 1";
	public const string TASK_2 = "Task 2";
	public const string TASK_3 = "Task 3";
	public const string TASK_4 = "Task 4";

	public const string DEFAULT_HINT = "Pickup the object visible!";
	public const string HINT_T1_AFTER_S1_PICKUP = "Instantiate into an object of type Cube!";
	public const string HINT_T2_AFTER_S1_PICKUP = "Choose the base class for human evolution!";
	public const string HINT_T3_AFTER_S1_PICKUP = "A car has a _____";
	public const string HINT_T1_AFTER_S2_PICKUP = "Set the object's color attribute to Green!";
	public const string HINT_T2_AFTER_S2_PICKUP = "Choose the derived class for given object!";
	public const string HINT_T3_AFTER_S2_PICKUP = "A car has a _____";
	public const string LEVEL_COMPLETE = "Congratulations! Task completed.";

	public static string hint = "Pickup the object visible!";

	public static int timeTaken = 0;
	public static bool complete = false;

}