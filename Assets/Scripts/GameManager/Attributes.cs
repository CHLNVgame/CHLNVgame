using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour {

	// ************************ Attribute Plane ************************

	public const int HP_PLUS 				= 0;
	public const int DAMGE_PLUS 			= 1;
	public const int DAME_SPEC_PLUS 		= 2;
	public const int TOTAL_LEVEL_UP_PLANE 	= 3;
	public static int[] LEVEL_UP_PLANE = new int[TOTAL_LEVEL_UP_PLANE]{12, 2, 11};

	public const int CLASS_C = 0;
	public const int CLASS_B = 1;
	public const int CLASS_A = 2;
	public const int CLASS_S = 3;
	public const int TOTAL_CLASS = 4;

	public static int[] MAX_LEVEL_CLASS 	= new int[TOTAL_CLASS]{40,   60,  80, 100}; // CLASS_C  max level 40, CLASS_B max level 80 ....
	public static int[] FRAGMENT_UP_CLASS 	= new int[TOTAL_CLASS]{80,  160, 240, 320}; // Fragment up from CLASS_C to CLASS_B is 80 ....
	public static int[] RUBY_UP_CLASS 		= new int[TOTAL_CLASS]{100, 200, 300, 400}; // Ruby up from CLASS_C to CLASS_B is 100 ...




	public const int CLASS_PLANE  		= 0;
	public const int HP_PLANE      		= 1;
	public const int DAMGE_PLANE  		= 2;
	public const int DAMGE_SPEC_PLANE 	= 3;
	public const int FIRE_RATE_PLANE 	= 4;
	public const int SPEED_BULLET_PLANE = 5;

	public const int TOTAL_PLANE_ATT 	= 6;
	public const int TOTAL_PLANE 		= 17;

	public static int[,] PLANE_ATT = new int[TOTAL_PLANE, TOTAL_PLANE_ATT]
	{ 
		{ 0,  210,  63, 152, 5 , 20}, // 0 *** CLASS_PLANE, HP_PLANE, DAMGE_PLANE, DAMGE_SPEC_PLANE, FIRE_RATE_PLANE, SPEED_BULLET_PLANE ***
		{ 1,  293, 115, 146, 10, 15},
		{ 1,  639,  55, 165, 10, 15},
		{ 1,  403,  96, 165, 10, 15},
		{ 1,  499,  83, 134, 10, 15}, 
		{ 1,  162, 142, 134, 10, 15}, // 5
		{ 2,  483, 248, 152, 10, 15},
		{ 2,  408, 265, 142, 10, 15},
		{ 2,  489, 254, 134, 10, 15},
		{ 2,  885, 188, 128, 10, 15}, 
		{ 2,  884, 187, 130, 10, 15}, // 10
		{ 2,  408, 211, 418, 10, 15},
		{ 3, 1058, 215, 137, 10, 15},
		{ 3, 1064, 220, 121, 10, 15},
		{ 3, 1064, 220, 121, 10, 15},
		{ 3, 1052, 210, 153, 10, 15}, // 15
		{ 3, 1052, 210, 153, 10, 15}
	};

	// ************************ End Attribte Plane ************************


	//  ************************ Attribute Bot ************************



	public const int CLASS_BOT  			= 0;
	public const int DAMGE_BOT 				= 1;
	public const int FIRE_RATE_BOT 			= 2;
	public const int HP_BOT_PLUS   			= 3;
	public const int DAMGE_BOT_PLUS			= 4;
	public const int DAMGE_SPEC_BOT_PLUS 	= 5;
	public const int SPEED_BULLET_BOT 	= 6;

	public const int TOTAL_BOT_ATT 	= 7;
	public const int TOTAL_BOT 		= 19;



	public static int[,] BOT_ATT = new int[TOTAL_BOT, TOTAL_BOT_ATT]
	{
		{1, 10, 1, 18,  0, 16, 10},	// 0 //  ** CLASS_BOT , DAMGE_BOT, FIRE_RATE_BOT v/s, HP_BOT_PLUS, DAMGE_BOT_PLUS, DAMGE_SPEC_BOT_PLUS, SPEED_BULLET_BOT
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 3,  0, 16, 18, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10}, //5
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10}, //10
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10}, //15
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10},
		{1, 10, 1, 18, 16,  0, 10}
	};
	// ************************ End Attribute Bot ************************

	public const int TOTAL_LEVEL_BOM	= 2;


	public const int SPEED_BOM		= 0;
	public const int HP_BOM	= 1;
	public const int DAMGE_BOM	= 2;
    public const int BONUS_BOM = 3;
    public const int TOTAL_BOM_ATT 	= 4;

	public static int[,] BOM_ATT = new int[TOTAL_LEVEL_BOM, TOTAL_BOM_ATT] {
        { 1, 3 , 10, 1},
        { 1, 10, 10, 1 }
    };

	public const int TOTAL_LEVEL_BOM_BULLET	= 2;


	public const int SPEED_BOM_BULLET		= 0;
	public const int HP_BOM_BULLET	= 1;
	public const int DAMGE_BOM_BULLET	= 2;
    public const int BONUS_BOM_BULLET = 3;
	public const int TOTAL_BOM_BULLET_ATT 	= 4;

	public static int[,] BOM_BULLET_ATT = new int[TOTAL_LEVEL_BOM_BULLET, TOTAL_BOM_BULLET_ATT] {
		{ 1, 3 , 10, 1},
		{ 1, 10, 10, 1 }
	};

	public const int TOTAL_LEVEL_BOX	= 2;


	public const int SPEED_BOX		= 0;
	public const int HP_BOX	= 1;
	public const int DAMGE_BOX	= 2;
    public const int BONUS_BOX = 3;
    public const int TOTAL_BOX 	= 4;

	public static int[,] BOX_ATT = new int[TOTAL_LEVEL_BOX, TOTAL_BOX] {
        { 1, 3 , 10, 1},
        { 1, 10, 10, 1 }
    };

	public const int TOTAL_LEVEL_CANON	= 2;

	public const int SPEED_CANON		= 0;
	public const int HP_CANON	= 1;
	public const int DAMGE_CANON	= 2;
    public const int BONUS_CANON = 3;
    public const int TOTAL_CANON 	= 4;

	public static int[,] CANON_ATT = new int[TOTAL_LEVEL_CANON, TOTAL_CANON] {
        { 1, 3 , 10, 1},
        { 1, 10, 10, 1 }
    };

	public const int TOTAL_LEVEL_ROCKET	= 2;


	public const int SPEED_ROCKET		= 0;
	public const int HP_ROCKET	= 1;
	public const int DAMGE_ROCKET	= 2;
    public const int BONUS_ROCKET = 3;
    public const int TOTAL_ROCKET 	= 4;


	public static int[,] ROCKET_ATT = new int[TOTAL_LEVEL_ROCKET, TOTAL_ROCKET] {
        { 1, 3 , 10, 1},
        { 1, 10, 10, 1 }
    };

	public const int TOTAL_LEVEL_SPECIAL	= 2;


	public const int SPEED_SPECIAL		= 0;
	public const int HP_SPECIAL	= 1;
	public const int DAMGE_SPECIAL	= 2;
    public const int BONUS_SPECIAL = 3;
    public const int TOTAL_SPECIAL 	= 4;

	public static int[,] SPECIAL_ATT = new int[TOTAL_LEVEL_SPECIAL, TOTAL_SPECIAL] {
         { 1, 3 , 10, 1},
        { 1, 10, 10, 1 }
    };




	//  ************************ Attribute Enemy ************************
	public const int TOTAL_LEVEL_ENEMY 	= 2;
	public const int TOTAL_ENEMY_ATT 	= 7;

	public const int SPEED_ENEMY		= 0;
	public const int TYPE_SHOOT_ENEMY	= 1;
	public const int DAMGE_ENEMY	 	= 2;
	public const int SPEED_BULLET_ENEMY = 3;
	public const int HP_ENEMY 			= 4;
	public const int BONUS_ENEMY 		= 5;
	public const int FIRE_RATE_BULLET_ENEMY = 6;    


	public static int[,] E1_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 2,   0,   25,   0,  60,   1, 0 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, DAMGE_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E2_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 3,   0,   25,   0,   60,   2, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E3_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 2,   1,   25,   10,   60,   3, 2 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E4_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 2,   0,   25,   0,   450,   4, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E5_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 2,   0,   25,   0,   30,   1, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E6_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 3,   0,   25,   0,   60,   1, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E7_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   25,   10,   1000,   1, 2 },
		{ 0,   0,   0,   0,   0,   0, 0}
	};
	public static int[,] E8_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   25,   1,   4,   1, 2 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0}
	};
    public static int[,] E9_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   25,   1,   4,   1, 2 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0}
	};
	public static int[,] E10_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   25,   1,  4,   1, 2 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0}
	};

	// ************************ End Attribute Enemy ************************
}
