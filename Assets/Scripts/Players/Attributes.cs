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

	public const int CLASS_C = 1;
	public const int CLASS_B = 2;
	public const int CLASS_A = 3;
	public const int CLASS_S = 4;
	public const int TOTAL_CLASS = 4;

	public static int[] MAX_LEVEL_CLASS 	= new int[TOTAL_CLASS]{40,   60,  80, 100}; // CLASS_C  max level 40, CLASS_B max level 80 ....
	public static int[] FRAGMENT_UP_CLASS 	= new int[TOTAL_CLASS]{80,  160, 240, 320}; // Fragment up from CLASS_C to CLASS_B is 80 ....
	public static int[] RUBY_UP_CLASS 		= new int[TOTAL_CLASS]{100, 200, 300, 400}; // Ruby up from CLASS_C to CLASS_B is 100 ...

	public const int TOTAL_PLANE 		= 17;
	public const int TOTAL_PLANE_ATT 	= 5;

	public const int CLASS_PLANE  		= 0;
	public const int HP_PLANE      		= 1;
	public const int DAMGE_PLANE  		= 2;
	public const int DAMGE_SPEC_PLANE 	= 3;
	public const int FIRE_RATE_PLANE 	= 4;

	public static int[,] PLANE_ATT = new int[TOTAL_PLANE, TOTAL_PLANE_ATT]
	{ 
		{ 1,  210,  63, 152, 5 }, // 0 *** CLASS_PLANE, HP_PLANE, DAMGE_PLANE, DAMGE_SPEC_PLANE, FIRE_RATE_PLANE ***
		{ 2,  293, 115, 146, 10},
		{ 2,  639,  55, 165, 10},
		{ 2,  403,  96, 165, 10},
		{ 2,  499,  83, 134, 10}, 
		{ 2,  162, 142, 134, 10}, // 5
		{ 3,  483, 248, 152, 10},
		{ 3,  408, 265, 142, 10},
		{ 3,  489, 254, 134, 10},
		{ 3,  885, 188, 128, 10}, 
		{ 3,  884, 187, 130, 10}, // 10
		{ 3,  408, 211, 418, 10},
		{ 4, 1058, 215, 137, 10},
		{ 4, 1064, 220, 121, 10},
		{ 4, 1064, 220, 121, 10},
		{ 4, 1052, 210, 153, 10}, // 15
		{ 4, 1052, 210, 153, 10}
	};

	// ************************ End Attribte Plane ************************


	//  ************************ Attribute Bot ************************

	public const int TOTAL_BOT 		= 19;
	public const int TOTAL_BOT_ATT 	= 6;

	public const int CLASS_BOT  			= 0;
	public const int DAMGE_BOT 				= 1;
	public const int FIRE_RATE_BOT 			= 2;
	public const int HP_BOT_PLUS   			= 3;
	public const int DAMGE_BOT_PLUS			= 4;
	public const int DAMGE_SPEC_BOT_PLUS 	= 5;


	public static int[,] BOT_ATT = new int[TOTAL_BOT, TOTAL_BOT_ATT]
	{
		{1, 10, 1, 18,  0, 16},	// 0 //  ** CLASS_BOT , DAMGE_BOT, FIRE_RATE_BOT v/s, HP_BOT_PLUS, DAMGE_BOT_PLUS, DAMGE_SPEC_BOT_PLUS
		{1, 10, 1, 18, 16,  0},
		{1, 10, 3,  0, 16, 18},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0}, //5
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0}, //10
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0}, //15
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0},
		{1, 10, 1, 18, 16,  0}
	};
	// ************************ End Attribute Bot ************************

	public const int TOTAL_LEVEL_BOM	= 2;
	public const int TOTAL_BOM_ATT 	= 2;
	public const int SPEED_BOM		= 0;
	public const int HP_BOM	= 1;

	public static int[,] BOM_ATT = new int[TOTAL_LEVEL_BOM, TOTAL_BOM_ATT] {
		{ 1, 5 },
		{ 1, 10 }
	};

	public const int TOTAL_LEVEL_BOM_BULLET	= 2;
	public const int TOTAL_BOM_BULLET_ATT 	= 2;
	public const int SPEED_BOM_BULLET		= 0;
	public const int HP_BOM_BULLET	= 1;

	public static int[,] BOM_BULLET_ATT = new int[TOTAL_LEVEL_BOM_BULLET, TOTAL_BOM_BULLET_ATT] {
		{ 1, 5 },
		{ 1, 10 }
	};

	public const int TOTAL_LEVEL_BOX	= 2;
	public const int TOTAL_BOX 	= 2;
	public const int SPEED_BOX		= 0;
	public const int HP_BOX	= 1;

	public static int[,] BOX_ATT = new int[TOTAL_LEVEL_BOX, TOTAL_BOX] {
		{ 1, 5 },
		{ 1, 10 }
	};

	public const int TOTAL_LEVEL_CANON	= 2;
	public const int TOTAL_CANON 	= 2;
	public const int SPEED_CANON		= 0;
	public const int HP_CANON	= 1;

	public static int[,] CANON_ATT = new int[TOTAL_LEVEL_CANON, TOTAL_CANON] {
		{ 1, 5 },
		{ 1, 10 }
	};

	public const int TOTAL_LEVEL_ROCKET	= 2;
	public const int TOTAL_ROCKET 	= 2;
	public const int SPEED_ROCKET		= 0;
	public const int HP_ROCKET	= 1;

	public static int[,] ROCKET_ATT = new int[TOTAL_LEVEL_ROCKET, TOTAL_ROCKET] {
		{ 1, 5 },
		{ 1, 10 }
	};

	public const int TOTAL_LEVEL_SPECIAL	= 2;
	public const int TOTAL_SPECIAL 	= 2;
	public const int SPEED_SPECIAL		= 0;
	public const int HP_SPECIAL	= 1;

	public static int[,] SPECIAL_ATT = new int[TOTAL_LEVEL_SPECIAL, TOTAL_SPECIAL] {
		{ 1, 5 },
		{ 1, 10 }
	};




	//  ************************ Attribute Enemy ************************
	public const int TOTAL_LEVEL_ENEMY 	= 2;
	public const int TOTAL_ENEMY_ATT 	= 7;

	public const int SPEED_ENEMY		= 0;
	public const int TYPE_SHOOT_ENEMY	= 1;
	public const int TYPE_BULLET_ENEMY 	= 2;
	public const int SPEED_BULLET_ENEMY = 3;
	public const int HP_ENEMY 			= 4;
	public const int BONUS_ENEMY 		= 5;
	public const int FIRE_RATE_BULLET_ENEMY = 6;


	public static int[,] E1_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   0,   0,   0,  12,   1, 0 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E2_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 7,   0,   0,   0,   10,   2, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E3_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   1,   1,   1,   12,   3, 1 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E4_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   0,   0,   0,   15,   4, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E5_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 5,   0,   0,   0,   11,   1, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E6_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 2,   0,   0,   0,   12,   1, 0 },
		{ 0,   0,   0,   0,   0,   0, 0 }
	};
	public static int[,] E7_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   1,   1,   18,   1, 1 },
		{ 0,   0,   0,   0,   0,   0, 0}
	};
	public static int[,] E8_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   1,   1,   18,   1, 2 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0}
	};
    public static int[,] E9_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   1,   1,   18,   1, 2 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0}
	};
	public static int[,] E10_ATT = new int[TOTAL_LEVEL_ENEMY, TOTAL_ENEMY_ATT]
	{ 
		{ 1,   1,   1,   1,  18,   1, 2 }, // SPEED_ENEMY, TYPE_SHOOT_ENEMY, TYPE_BULLET_ENEMY, SPEED_BULLET_ENEMY, HP_ENEMY, BONUS_ENEMY, FIRE_RATE_BULLET_ENEMY
		{ 0,   0,   0,   0,   0,   0, 0}
	};

	// ************************ End Attribute Enemy ************************
}
