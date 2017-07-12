using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define : MonoBehaviour {
	// BULLETS
	public const float TIMER_RED_BULLET = 1.5f;
	public const float TIMER_YELLOW_BULLET = 0.1f;
	public const float TIMER_CREATE_ENEMY = 3f;
	// Zero for Default
	public const int ZERO = 0;

	// Array properties enemies.
	public static Vector3 LEFT_BOT_POS = new Vector3(-1,0,0);
	public static Vector3 RIGHT_BOT_POS = new Vector3(1,0,0);

	// Move Direction
	public const float REACH_DISTANCE = 0.5f;
	public enum DIRECTION_ENEMIES {
		TOP_BOTTOM =1,
		RIGHT_LEFT,
		LEFT_RIGHT,
		DIAGONAL_LEFTTOP_RIGHTBOTTOM,
		DIAGONAL_RIGHTTOP_LEFTBOTTOM,
		DIAGONAL_LEFTBOTTOM_RIGHTTOP
	};
    // Move Direction
    public enum DIRECTION_CANON_SHOT
    {
        LEFT = 1,
        RIGHT,
        TOP,
        BOTTOM,
        LEFT_TOP,
        LEFT_BOTTOM,
        RIGHT_TOP,
        RIGHT_BOTTOM
    };
    // Angle Rotation circle;

    public const int ANGLE_ROTATE_45 = 45;
	public const int ANGLE_ROTATE_90 = 90;
	public const int ANGLE_ROTATE_135 = 135;
	public const int ANGLE_ROTATE_180 = 180;
	public const int ANGLE_ROTATE_225 = 225;
	public const int ANGLE_ROTATE_270 = 270;
	public const int ANGLE_ROTATE_325 = 325;
	public const int ANGLE_ROTATE_360 = 360;
	// Power Bullet


	// MainCharacter Begin
	public enum STATUS_PLANE
	{
		DISABLE = 0,
		ENABLE = 1,
		ACTIVE = 1000
	};

	public enum STATUS_BOT
	{
		DISABLE = 0,
		ENABLE = 1,
		ACTIVE_LEFT = 1000,
		ACTIVE_RIGHT = 2000
	}
	// MainCharacter End

	// Scenes
	public const string sceneMainMenu = "sceneMainMenu";
	public const string sceneProfile = "sceneProfile";
	public const string sceneSetting = "sceneSetting";
	public const string sceneDailyBonus = "sceneDailyBonus";
	public const string sceneAchievement = "sceneAchievement";
	public const string sceneContainer = "sceneContainer";
	public const string sceneDailyQuest = "sceneDailyQuest";
	public const string sceneGamePlay = "sceneGamePlay";
    public const string sceneLevel1 = "sceneLevel1";
    // Scenes End

    // Coins
    public const float DISTANCE_COIN_PLAYER = 6f;
	public const float SPEED_COIN_PLAYER = 2f;

	public const float DISTANCE_ITEMS_PLAYER = 6f;
	public const float SPEED_ITEMS_PLAYER = 2f;

	//Timer
	public const float GAMEPLAY_TIMER_DELAY = 2f;
	public const float GAMEPLAY_TIMER_START = 1f;
	public const float GAMEPLAY_TIMER_READY = 3f;
}
